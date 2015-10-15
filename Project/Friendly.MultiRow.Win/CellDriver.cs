using Codeer.Friendly;
using Codeer.Friendly.Windows;
using Friendly.MultiRow.Win.Inside;
using System.Windows.Forms;

namespace Friendly.MultiRow.Win
{
	public class CellDriver : IAppVarOwner
	{
#if ENG
		/// <summary>
		/// Application manipulation object.
		/// </summary>
#else
		/// <summary>
		/// アプリケーション操作クラスです。
		/// </summary>
#endif
		public WindowsAppFriend App
		{
			get
			{
				return (WindowsAppFriend)AppVar.App;
			}
		}

#if ENG
		/// <summary>
		/// Returns an AppVar for a .NET object for the corresponding window.
		/// </summary>
#else
		/// <summary>
		/// 対応するウィンドウの.Netのオブジェクトが格納されたAppVarを取得します。
		/// </summary>
#endif
		public AppVar AppVar
		{
			get;
			set;
		}

		protected GcMultiRowDriver MultiRow {get;private set;}

		public bool IsActive { get { return (bool)App[GetType(), "IsActiveCore"](MultiRow, this).Core; } }
		
		public CellDriver(GcMultiRowDriver multiRow, AppVar src)
		{
			MultiRow = multiRow;
			AppVar = src;
			Initializer.Initialize(App);
		}

		public CellDriver( CellDriver src )
			: this( src.MultiRow , src.AppVar)
		{
		}

		public string Text
		{
			get
			{
				return AppVar[ "Value" ]().ToString();
			}
		}

		public void EmulateActivate()
		{
			App[GetType(), "EmulateActivate"](MultiRow, this);
		}
		public void EmulateActivate(Async async)
		{
			App[ GetType(), "EmulateActivate" , async]( MultiRow, this );
		}

		protected static void EmulateActivate(Control grid, object cell)
		{
			grid.Focus();
			grid.GetType().GetMethod("set_CurrentCell").
				   Invoke(grid, new object[] { cell });
		}

		static bool IsActiveCore(object grid, object cell)
		{
			return ReferenceEquals(cell, Invoker.Call(grid, "get_CurrentCell"));
		}
	}
}
