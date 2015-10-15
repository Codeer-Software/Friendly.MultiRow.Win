namespace Test
{
    static class Target
    {
        internal static string Path
        {
            get { return System.IO.Path.GetFullPath("../../../Target2/bin/Release/Target.exe"); }
        }
    }
}
