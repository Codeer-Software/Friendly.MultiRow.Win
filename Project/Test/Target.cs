namespace Test
{
    static class Target
    {
        internal static string Path
        {
            get { return System.IO.Path.GetFullPath("../../../Target/bin/Release/Target.exe"); }
        }
    }
}
