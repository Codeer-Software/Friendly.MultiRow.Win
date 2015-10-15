using Codeer.Friendly;
using System;
using System.Windows.Forms;

namespace Friendly.MultiRow.Win
{
	public class ComboBoxCellDriver : CellDriver
	{
		//public string Text
		//{
		//	get
		//	{
		//		return AppVar[ "Value" ]().ToString();
		//	}
		//}
		public ComboBoxCellDriver( CellDriver src )
			: base( src )
		{
		}

		public void EmulateEdit( string text )
		{
			App[ GetType(), "EmulateEdit" ]( MultiRow, this, text );
		}

		public void EmulateEdit( string text, Async async )
		{
			App[ GetType(), "EmulateEdit", async ]( MultiRow, this, text );
		}

		static void EmulateEdit( Control grid, object cell, string text )
		{
			EmulateActivate( grid , cell);
			grid.GetType().GetMethod( "BeginEdit" ).
				   Invoke( grid, new object[] { false } );
			var control = (Control)grid.GetType().GetMethod( "get_EditingControl" ).Invoke( grid, new object[0] );
			control.Text = text;
			grid.GetType().GetMethod( "EndEdit", new Type[0] ).
				   Invoke( grid, new object[0] );
		}
	}

	public static class ComboBoxCellDriverExtensions
	{
		public static ComboBoxCellDriver AsComboBoxCell( this CellDriver src )
		{
			return new ComboBoxCellDriver( src );
		}
	}
}
