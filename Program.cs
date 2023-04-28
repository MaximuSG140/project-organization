namespace ProjectOrganization
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Environment.Instance.SetUp();
            ApplicationConfiguration.Initialize();
            Application.Run(new StartMenuForm());
            Environment.Instance.TearDown();
        }
    }
}