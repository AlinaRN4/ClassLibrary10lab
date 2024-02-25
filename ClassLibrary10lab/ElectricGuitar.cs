using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10lab
{
    public class ElectricGuitar : Guitar
    {
        public string PowerSource { get; set; }

        public ElectricGuitar() : base()
        {
            PowerSource = "No style";
            Name = "No name";
        }
        public ElectricGuitar(string name, int numberOfStrings, string powerSource) : base(name, numberOfStrings)
        {
            PowerSource = powerSource;
        }
        public override void Show()
        {
            Console.WriteLine($"Музыкальный инструмент: {Name}, Кол-во струн: {NumberOfStrings}, Источник питания: {PowerSource}");
        }
        public override string ToString()
        {
            return Name + ", " + NumberOfStrings + ", " + PowerSource;
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите источник питания для электрогитары (батарейки, аккумуляторы, фиксированный источник питания, USB):");
            PowerSource = Console.ReadLine();
        }

        public override void RandomInit()
        {
            base.RandomInit();
            string[] powerSources = { "батарейки", "аккумуляторы", "фиксированный источник питания", "USB" };
            PowerSource = powerSources[new Random().Next(0, powerSources.Length)];
        }
        
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            ElectricGuitar other = (ElectricGuitar)obj;
            return PowerSource == other.PowerSource;
        }
    }

}
