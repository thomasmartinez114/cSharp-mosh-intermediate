namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger _logger)
        {
            _logger = Logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
}
