using EasyPaste.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyPaste
{
    internal partial class FrmPasteItemGroup : Form
    {
        private readonly EditBehavior _behavior;
        private readonly EditContext<PasteItemGroup>? _editContext;

        private FrmPasteItemGroup()
        {
            InitializeComponent();
        }

        public FrmPasteItemGroup(EditBehavior behavior, EditContext<PasteItemGroup>? editContext = null)
            : this()
        {
            _behavior = behavior;
            _editContext = editContext;

            if (behavior == EditBehavior.Edit && editContext is not null)
            {
                if (editContext.Value is null)
                {
                    throw new InvalidOperationException("Value not set.");
                }

                Text = $"Edit Group - {editContext.Value.Name}";

                txtGroupName.Text = editContext.Value.Name;
                colorSelector.SelectedItem = Color.FromName(editContext.Value.ColorName);
            }
            else
            {
                Text = "Add Group";
                colorSelector.SelectedItem = Color.AliceBlue;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PasteItemGroup? SelectedGroup { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Get the group name from the input (assuming a TextBox named txtGroupName exists)
            var groupName = txtGroupName.Text.Trim();
            var selectedColor = colorSelector.SelectedItem as Color?;

            // Check if the group name is empty
            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Group name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            // Check if the group name already exists in the editContext's ExistingValues
            if (_editContext != null && _editContext.ExistingValues.Any(g => g.Name.Equals(groupName, StringComparison.OrdinalIgnoreCase)))
            {
                if (_behavior == EditBehavior.Add)
                {
                    MessageBox.Show("Group name already exists.", "Validation Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            // If validation passes, set the SelectedGroup and close the dialog
            SelectedGroup = _behavior == EditBehavior.Add
                ? new PasteItemGroup(Guid.NewGuid(), groupName, selectedColor?.Name ?? Color.Black.Name)
                : new PasteItemGroup(_editContext.Value.Id, groupName, selectedColor?.Name ?? Color.Black.Name);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
