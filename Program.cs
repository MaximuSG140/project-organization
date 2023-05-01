namespace ProjectOrganization
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Environment.Instance.SetUp();
            ApplicationConfiguration.Initialize();
            Application.Run(StartMenuForm.Instance);
            Environment.Instance.TearDown();
        }
    }
}