using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyPaste
{
    public partial class FrmAddOrEdit : Form
    {
        private FrmAddOrEdit()
        {
            InitializeComponent();
        }

        internal FrmAddOrEdit(AddOrEdit mode) : this()
        {
            Text = mode == AddOrEdit.Add ? "Add New Item" : "Edit Item";
        }
    }
}
