using Codeer.Friendly;


namespace Friendly.MultiRow.Win
{
    public class RowDriver : ControlDriverBase
    {
        GcMultiRowDriver _multiRow;
        public CellCollectionDriver Cells { get { return new CellCollectionDriver(_multiRow, AppVar["Cells"]()); } }
        public RowDriver(GcMultiRowDriver multiRow, AppVar src) : base(src) 
        {
            _multiRow = multiRow;
        }
    }
}
