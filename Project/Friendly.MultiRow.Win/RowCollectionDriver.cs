using Codeer.Friendly;

namespace Friendly.MultiRow.Win
{
    public class RowCollectionDriver : ControlDriverBase
    {
        GcMultiRowDriver _multiRow;
        public int Count { get { return (int)AppVar["Count"]().Core; } }
        public RowDriver this[int index] { get { return new RowDriver(_multiRow, AppVar["[]"](index)); } }
        public RowCollectionDriver(GcMultiRowDriver multiRow, AppVar src)
            : base(src)
        {
            _multiRow = multiRow;
        }
    }
}
