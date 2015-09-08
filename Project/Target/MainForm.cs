using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Target
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _buttonNormal_Click(object sender, EventArgs e)
        {
            using (var form = new NormalForm())
            {
                form.ShowDialog();
            }
        }

        private void _buttonTemplate_Click(object sender, EventArgs e)
        {
            using (var form = new CommonCellForm())
            {
                form.ShowDialog();
            }
        }
    }
}
