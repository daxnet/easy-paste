using EasyPaste.Components;
using EasyPaste.Models;

namespace EasyPaste
{
    public partial class FrmMain : Form
    {
        private PasteProfile? _profile;
        private Dictionary<string, ActionButton> _actionButtons = [];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void InitializeColorImageList()
        {
            foreach (var (name, image) in Utils.EnumerateKnownColorImages())
            {
                imgListColors.Images.Add(name, image);
            }

        }

        private void InitializeActionButtons()
        {
            var addGroupActionButton = new ActionButton([ctxMnuAddGroup, mnuAddGroup, tbtnAddGroup], OnAddGroupClicked);
            _actionButtons.Add("add_group", addGroupActionButton);

            var editGroupActionButton = new ActionButton([ctxMnuEditGroup, mnuEditGroup, tbtnEditGroup], OnEditGroupClicked);
            _actionButtons.Add("edit_group", editGroupActionButton);

            foreach (var actionButton in _actionButtons.Values)
            {
                components.Add(actionButton);
            }
        }

        private async Task LoadProfileAsync()
        {
            _profile = await PasteProfile.LoadAsync();
            var groups = _profile.Groups;

            foreach (var group in groups)
            {
                var lvi = new ListViewItem
                {
                    Text = group.ToString(),
                    Tag = group,
                    ImageKey = string.IsNullOrEmpty(group.ColorName) ? PasteItemGroup.DefaultGroupName : group.ColorName
                };
                lvGroups.Items.Add(lvi);
            }
        }

        private void OnAddGroupClicked(object? sender, EventArgs e)
        {
            using var addGroupDialog = new FrmPasteItemGroup(EditBehavior.Add, new(_profile?.Groups ?? []));
            if (addGroupDialog.ShowDialog(this) == DialogResult.OK)
            {
                var addedGroup = addGroupDialog.SelectedGroup;
                if (addedGroup is not null)
                {
                    _profile?.Groups.Add(addedGroup);
                    var lvi = new ListViewItem
                    {
                        Text = addedGroup.Name,
                        ImageKey = addedGroup.ColorName,
                        Tag = addedGroup
                    };

                    lvGroups.Items.Add(lvi);

                    lvi.Selected = true;
                }
            }
        }

        private void OnEditGroupClicked(object? sender, EventArgs e)
        {
            if (lvGroups.SelectedItems.Count == 0)
                return;

            var selectedListViewItem = lvGroups.SelectedItems[0];
            if (selectedListViewItem.Tag is not PasteItemGroup selectedGroup)
                return;

            using var editGroupDialog =
                new FrmPasteItemGroup(EditBehavior.Edit, new(_profile?.Groups ?? [], selectedGroup));
            if (editGroupDialog.ShowDialog(this) == DialogResult.OK)
            {
                var editedGroup = editGroupDialog.SelectedGroup;
                if (editedGroup is not null)
                {
                    // Update model
                    _profile?.UpdateGroup(editedGroup);

                    // Update UI
                    selectedListViewItem.Tag = editedGroup;
                    selectedListViewItem.ImageKey = editedGroup.ColorName;
                    selectedListViewItem.Text = editedGroup.Name;
                }
            }
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeColorImageList();
            InitializeActionButtons();
            await LoadProfileAsync();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FrmPasteItemGroup(EditBehavior.Add).ShowDialog(this);
        }

        private void lvGroups_MouseDown(object sender, MouseEventArgs e)
        {
            var editGroupActionButton = _actionButtons["edit_group"];
            var lvi = lvGroups.GetItemAt(e.X, e.Y);
            
            editGroupActionButton.Enabled = lvi?.Tag is PasteItemGroup { IsDefaultGroup: false };

            if (e.Button == MouseButtons.Right)
            {
                if (lvGroups.GetItemAt(e.X, e.Y) is { Tag: PasteItemGroup group })
                {
                    ctxMnuStripSingleGroup.Show(lvGroups, e.Location);
                }
                else
                {
                    ctxMnuStripGroups.Show(lvGroups, e.Location);
                }
            }
        }
    }
}
