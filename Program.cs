using Microsoft.Extensions.Logging;

namespace ProjectOrganization
{
    internal static class Program
    {
        private static Logger<Application> logger = new(LoggerFactory.Create(builder => { }));

        [STAThread]
        private static void Main()
        {
            Environment.Instance.SetUp();
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(StartMenuForm.Instance);
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex.Message);
            }

            Environment.Instance.TearDown();
        }
    }
}