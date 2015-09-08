using Codeer.Friendly;
using Friendly.MultiRow.Win.Inside;
using System.Windows.Forms;

namespace Friendly.MultiRow.Win
{
    public class CellDriver : ControlDriverBase
    {
        GcMultiRowDriver _multiRow;

        public bool IsActive { get { return (bool)App[GetType(), "IsActiveCore"](_multiRow, this).Core; } }
        
        public CellDriver(GcMultiRowDriver multiRow, AppVar src)
            : base(src)
        {
            _multiRow = multiRow;
        }

        public void EmulateActivate()
        {
            App[GetType(), "EmulateActivate"](_multiRow, this);
        }

        static void EmulateActivate(object grid, object cell)
        {
            grid.GetType().GetMethod("set_CurrentCell").
                   Invoke(grid, new object[] { cell });
        }

        static bool IsActiveCore(object grid, object cell)
        {
            return ReferenceEquals(cell, Invoker.Call(grid, "get_CurrentCell"));
        }
    }
}
