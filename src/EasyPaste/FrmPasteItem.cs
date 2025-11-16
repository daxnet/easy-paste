using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyPaste
{
    public partial class FrmPasteItem : Form
    {
        private FrmPasteItem()
        {
            InitializeComponent();
        }

        internal FrmPasteItem(EditBehavior mode) : this()
        {
            Text = mode == EditBehavior.Add ? "Add New Item" : "Edit Item";
        }
    }
}
