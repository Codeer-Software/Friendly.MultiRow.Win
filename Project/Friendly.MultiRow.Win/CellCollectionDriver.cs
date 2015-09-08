using Codeer.Friendly;

namespace Friendly.MultiRow.Win
{
    public class CellCollectionDriver : ControlDriverBase
    {
        GcMultiRowDriver _multiRow;

        public int Count { get { return (int)AppVar["Count"]().Core; } }
        public CellDriver this[int index] { get { return new CellDriver(_multiRow, AppVar["[]"](index)); } }
        public CellCollectionDriver(GcMultiRowDriver multiRow, AppVar src)
            : base(src)
        {
            _multiRow = multiRow;
        }
    }
}
