namespace RandoTest
{
    internal static class SensCalculator
    {
        public static double GetQuakeSource(int cpi, double sens)
        {
            return (360 / (0.022 * cpi * sens)) * 2.54;
        }

        public static double GetOverwatch(int cpi, double sens)
        {
            return (360 / (0.0066 * cpi * sens)) * 2.54;
        }
        
        public static double GetValorant(int cpi, double sens)
        {
            return (360 / (0.06996 * cpi * sens)) * 2.54;
        }
    }
}
