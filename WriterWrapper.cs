namespace RandoTest
{
    internal class WriterWrapper
    {
        public bool _isOnCooldown;

        private string _writerExePath;
        private string _workingDirectory;

        public WriterWrapper(string exePath, string workingDirectory)
        {
            _writerExePath = exePath;
            _workingDirectory = workingDirectory;
        }

        public double GetRandomCmRev(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        public void ExecuteWriter()
        {
            if (_isOnCooldown) return;
            var p = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = _writerExePath,
                    WorkingDirectory = _workingDirectory,
                    Arguments = "settings.json"
                }
            };
            p.Start();
            _isOnCooldown = true;
            Console.WriteLine("Sensitivity updating in 1000ms...");
            Thread.Sleep(1000);
            Console.WriteLine("Sensitivity updated!");
        }

        public string FormatSens(double sens, int decimals)
        {
            return sens.ToString($"F{decimals}");
        }
    }
}
