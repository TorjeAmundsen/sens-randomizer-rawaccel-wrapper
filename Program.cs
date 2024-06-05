using RandoTest;

namespace randoWrapper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string writerexePath = "G:\\RawAccel\\writer.exe";
            string working = "G:\\RawAccel";

            WriterWrapper writerWrapper = new WriterWrapper(writerexePath, working);
            writerWrapper.ExecuteWriter();

            /*TestLoop(20, 55.5, 30);*/
            double testQS = SensCalculator.GetQuakeSource(1600, 0.7);
            double testOW = SensCalculator.GetOverwatch(1600, 3);
            double testVal = SensCalculator.GetValorant(1600, 0.28302);
            Console.WriteLine($"QS 1600 0.7: {testQS}");
            Console.WriteLine($"OW 1600 3.00: {testOW}");
            Console.WriteLine($"Val 1600 3.00: {testVal}");
        }

        public void MenuLoop()
        {
            //
            return;
        }

        public static void TestLoop(double min, double max, double currentCmRev)
        {
            WriterWrapper writerWrapper = new WriterWrapper("G:\\RawAccel\\writer.exe", "G:\\RawAccel");

            bool maxHit = false;
            bool minHit = false;
            string maxString = String.Format("{0:0.00}", max);
            string minString = String.Format("{0:0.00}", min);

            for (int i = 0; i < 1_000_000; i++)
            {
                double val = writerWrapper.GetRandomCmRev(min, max);
                double multiplier = currentCmRev / val;
                if (i % 10000 == 0) Console.WriteLine($"Current: {String.Format("{0:0.00}", currentCmRev)} cm/360, target: {String.Format("{0:0.00}", val)}, multiplier: {multiplier}");
            }
            Console.WriteLine($"Max value: {maxString}, hit: {maxHit}");
            Console.WriteLine($"Min value: {minString}, hit: {minHit}");
        }
    }
}