using ClassLibrary10lab;
using System.Diagnostics.Metrics;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MusicalInstrument[] instruments = new MusicalInstrument[20];

            for (int i = 0; i < 20; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0:
                        instruments[i] = new Guitar();
                        instruments[i].Name = "Guitar";
                        (instruments[i] as Guitar).NumberOfStrings = rnd.Next(4, 12);
                        break;
                    case 1:
                        instruments[i] = new ElectricGuitar();
                        instruments[i].Name = "Electric Guitar";
                        (instruments[i] as ElectricGuitar).NumberOfStrings = rnd.Next(4, 12);
                        (instruments[i] as ElectricGuitar).PowerSource = GetRandomPowerSource(rnd);
                        break;
                    case 2:
                        instruments[i] = new Piano();
                        instruments[i].Name = "Piano";
                        (instruments[i] as Piano).KeyboardLayout = GetRandomKeyLayout(rnd);
                        (instruments[i] as Piano).NumberOfKeys = rnd.Next(61, 88);
                        break;
                    case 3:
                        instruments[i] = new Piano();
                        instruments[i].Name = "Piano";
                        (instruments[i] as Piano).KeyboardLayout = "Digital";
                        (instruments[i] as Piano).NumberOfKeys = rnd.Next(61, 88);
                        break;
                }
            }

            foreach (MusicalInstrument instrument in instruments)
            {
                instrument.ToString();
            }
        }

        static string GetRandomPowerSource(Random rnd)
        {
            string[] powerSources = { "Battery", "Battery", "Fixed power source", "USB" };
            return powerSources[rnd.Next(powerSources.Length)];
        }

        static string GetRandomKeyLayout(Random rnd)
        {
            string[] keyLayouts = { "Octave", "Scale", "Digital" };
            return keyLayouts[rnd.Next(keyLayouts.Length)];
        }
    }
    
}
