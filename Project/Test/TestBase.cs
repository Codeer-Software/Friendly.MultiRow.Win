using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;
using System.Diagnostics;
using Codeer.Friendly.Windows.NativeStandardControls;
using System.Windows.Forms;
using Friendly.MultiRow.Win;
using Ong.Friendly.FormsStandardControls;

namespace Test
{
    [TestClass]
    public class TestBase
    {
        WindowsAppFriend _app;
        GcMultiRowDriver _grid;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start(Target.Path));
            var main = _app.Type<Application>().OpenForms[0];
            new FormsButton(main._buttonNormal).EmulateClick(new Async());
            var dlg = new WindowControl(main).WaitForNextModal();
            _grid = new GcMultiRowDriver(dlg.Dynamic()._grid);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).Kill();
        }

        [TestMethod]
        public void TestCellActivate()
        {
            _grid.Rows[0].Cells[1].EmulateActivate();
            _grid.Rows[0].Cells[1].IsActive.IsTrue();
        }
    }
}
