﻿namespace RandoTest
{
    internal static class JSONTemplate
    {
        const string defaultJSON = @"{
  ""### Accel modes ###"": ""classic | jump | natural | motivity | power | lut | noaccel"",
  ""### Cap modes ###"": ""in_out | input | output"",
  ""version"": ""1.6.1"",
  ""defaultDeviceConfig"": {
    ""disable"": false,
    ""DPI (normalizes sens to 1000dpi and converts input speed unit: counts/ms -> in/s)"": 0,
    ""Polling rate Hz (keep at 0 for automatic adjustment)"": 0
  },
  ""profiles"": [
    {
      ""name"": ""default"",
      ""Whole/combined accel (set false for 'by component' mode)"": true,
      ""lpNorm"": 2.0,
      ""Stretches domain for horizontal vs vertical inputs"": {
        ""x"": 1.0,
        ""y"": 1.0
      },
      ""Stretches accel range for horizontal vs vertical inputs"": {
        ""x"": 1.0,
        ""y"": 1.0
      },
      ""Whole or horizontal accel parameters"": {
        ""mode"": ""noaccel"",
        ""Gain / Velocity"": true,
        ""inputOffset"": 0.0,
        ""outputOffset"": 0.0,
        ""acceleration"": 0.005,
        ""decayRate"": 0.1,
        ""growthRate"": 1.0,
        ""motivity"": 1.5,
        ""exponentClassic"": 2.0,
        ""scale"": 1.0,
        ""exponentPower"": 0.05,
        ""limit"": 1.5,
        ""midpoint"": 5.0,
        ""smooth"": 0.5,
        ""Cap / Jump"": {
          ""x"": 15.0,
          ""y"": 1.5
        },
        ""Cap mode"": ""output"",
        ""data"": []
      },
      ""Vertical accel parameters"": {
        ""mode"": ""noaccel"",
        ""Gain / Velocity"": true,
        ""inputOffset"": 0.0,
        ""outputOffset"": 0.0,
        ""acceleration"": 0.005,
        ""decayRate"": 0.1,
        ""growthRate"": 1.0,
        ""motivity"": 1.5,
        ""exponentClassic"": 2.0,
        ""scale"": 1.0,
        ""exponentPower"": 0.05,
        ""limit"": 1.5,
        ""midpoint"": 5.0,
        ""smooth"": 0.5,
        ""Cap / Jump"": {
          ""x"": 15.0,
          ""y"": 1.5
        },
        ""Cap mode"": ""output"",
        ""data"": []
      },
      ""Sensitivity multiplier"": 1.0,
      ""Y/X sensitivity ratio (vertical sens multiplier)"": 1.0,
      ""L/R sensitivity ratio (left sens multiplier)"": 1.0,
      ""U/D sensitivity ratio (up sens multiplier)"": 1.0,
      ""Degrees of rotation"": 0.0,
      ""Degrees of angle snapping"": 0.0,
      ""Input Speed Cap"": 0.0
    }
  ],
  ""devices"": []
}";
        public static void CreateNewSettingsJSON(string path)
        {
            try
            {
                File.WriteAllText(path + "settings.json", defaultJSON);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }
        }

        public static void WriteSettingsJSON(string path, string sens)
        {

        }
    }
}
