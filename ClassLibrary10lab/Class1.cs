using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10lab
{
    public class MusicalInstrument:IInit, IComparable<MusicalInstrument>
    {
        public string Name { get; set; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }
        public MusicalInstrument()
        {
            Name = "Неизвестный";
        }
        public virtual void Show()
        {
            Console.WriteLine($"Инструмент: {Name}");
        }
        public override string ToString()
        {
            return Name;
        }
        public virtual void Init()
        {
            Console.WriteLine("Введите название музыкального инструмента:");
            Name = Console.ReadLine();
        }
        public virtual void RandomInit()
        {
            Random random = new Random();
            Name = "Инструмент" + random.Next(1, 100);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            MusicalInstrument other = (MusicalInstrument)obj;
            return Name == other.Name;
        }
        public int CompareTo(MusicalInstrument other)
        {
            return Name.CompareTo(other.Name);
        }
        public override int GetHashCode()
{
    return Name.GetHashCode();
}
    }

}
