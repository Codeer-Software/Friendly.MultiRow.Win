using Codeer.Friendly;

namespace Friendly.MultiRow.Win
{
    public class GcMultiRowDriver : ControlDriverBase
    {
        public GcMultiRowDriver(AppVar src) : base(src) { }

        public RowCollectionDriver Rows { get { return new RowCollectionDriver(this, AppVar["Rows"]()); } }
    }
}
