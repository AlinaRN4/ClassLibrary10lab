using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10lab
{
    public class Piano : MusicalInstrument
    {
        private int numberOfKeys;
        public string KeyboardLayout { get; set; }
        public int NumberOfKeys
        {
            get { return numberOfKeys; }
            set
            {
                if (value > 75 || value < 89)
                    numberOfKeys = value;
                else
                    throw new Exception("Кол-во клавиш должно быть 76-88.");
            }
        }
        public Piano() : base()
        {
            Name = "No name";
            KeyboardLayout = "NoStyle";
            NumberOfKeys = 0;
        }
        public Piano(string name, string keyboardLayout, int numberOfKeys) : base(name)
        {
            KeyboardLayout = keyboardLayout;
            NumberOfKeys = numberOfKeys;
        }
        public override void Show()
        {
            Console.WriteLine($"Музыкальный инструмент: {Name}, Раскладка клавиш: {KeyboardLayout}, Кол-во клавиш: {NumberOfKeys}");
        }
        public override string ToString()
        {
            return Name + ", " + KeyboardLayout + ", " + NumberOfKeys;
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите раскладку клавиш для фортепиано (октавная, шкальная, дигитальная):");
            KeyboardLayout = Console.ReadLine();

            Console.WriteLine("Введите количество клавиш на фортепиано:");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("Некорректное значение. Введите целое положительное число.");
            }
            NumberOfKeys = num;
        }
        public override void RandomInit()
        {
            base.RandomInit();
            string[] layouts = { "октавная", "шкальная", "дигитальная" };
            KeyboardLayout = layouts[new Random().Next(0, layouts.Length)];

            NumberOfKeys = new Random().Next(76, 89); // случайное число клавиш от 76 до 88
        }
        
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Piano other = (Piano)obj;
            return KeyboardLayout == other.KeyboardLayout && NumberOfKeys == other.NumberOfKeys;
        }
    }

}
