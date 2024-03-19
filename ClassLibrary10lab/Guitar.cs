using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10lab
{
    public class Guitar : MusicalInstrument
    {
        private int numberOfStrings;
        public int NumberOfStrings
        {
            get { return numberOfStrings; }
            set
            {
                if (value > 3 || value < 13)
                    numberOfStrings = value;
                else
                    throw new Exception("Количество струн должно быть 4-12.");
            }
        }
        public Guitar() : base()
        {
            NumberOfStrings = 0;
        }
        public Guitar(string name, int numberOfStrings) : base(name)
        {
            NumberOfStrings = numberOfStrings;
        }
        public override void Show()
        {
            Console.WriteLine($"Музыкальный инструмент: {Name}, Кол-во струн: {NumberOfStrings}");
        }
        public override string ToString()
        {
            return Name + ", " + NumberOfStrings;
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите количество струн на гитаре:");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("Некорректное значение. Введите целое положительное число.");
            }
            NumberOfStrings = num;
        }
        public override void RandomInit()
        {
            base.RandomInit();
            NumberOfStrings = new Random().Next(4, 13); // случайное число струн от 4 до 12
        }
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Guitar other = (Guitar)obj;
            return NumberOfStrings == other.NumberOfStrings;
        }
         public MusicalInstrument GetBase(Guitar g)
 {
     return new MusicalInstrument(g.Name);
 }
 public object Clone()
 {
     return new Guitar(Name, NumberOfStrings);
 }
 public override int GetHashCode()
 {
     return base.GetHashCode();
 }
    }

}
