using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Target
{
	public partial class NormalForm : Form
	{
		public NormalForm()
		{
			InitializeComponent();
		}

		protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
		{
			if( keyData == Keys.F5 )
			{
				_grid.Focus();	
				_grid.BeginEdit(false);
				_grid.EditingControl.Text = "abc";
				_grid.EndEdit();
				return true;
			}
			return base.ProcessCmdKey( ref msg, keyData );
		}
	}
}
