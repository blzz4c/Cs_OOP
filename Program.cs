using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main()
        {
            List<Production> productions = new();
            productions = Menu(productions);
            
        }
        static List<Production> Menu(List<Production> productions)
        {
            Console.WriteLine("-----1 Часть-----");
            Console.WriteLine("1. Сгенерировать случайные объекты");
            Console.WriteLine("2. Вывести случайные объекты");
            int answ = int.Parse(Console.ReadLine()!);
            

            switch (answ)
            {
                case 1:
                    Console.Clear();
                    productions = CreateRandomInitObjects();
                    Menu(productions);
                    break;
                case 2:
                    Console.Clear();
                    ShowObjects(productions);
                    break;
            }
            return productions;
        }
        static List<Production> CreateRandomInitObjects()
        {
            Console.WriteLine("-----Генерация объектов------");
            Console.WriteLine("0. Сгенерировать объект класса Production");
            Console.WriteLine("1. Сгенерировать объект класса Factory");
            Console.WriteLine("2. Сгенерировать объект класса Workshop");
            Console.WriteLine("3. Сгенерировать объект класса CraftShop");
            Console.WriteLine("4. Сгенерировать объекты всех классов");

            int answ = int.Parse(Console.ReadLine()!);
            List<Production> productions = new();

            switch (answ)
            {
                case 0:
                    productions.Add(new Production());
                    productions.Last().RandomInit();
                    break;
                case 1:
                    productions.Add(new Factory());
                    productions.Last().RandomInit();
                    break;
                case 2:
                    productions.Add(new Workshop());
                    productions.Last().RandomInit();
                    break;
                case 3:
                    productions.Add(new CraftShop());
                    productions.Last().RandomInit();
                    break;
                case 4:
                    productions.Add(new Production());
                    productions.Last().RandomInit();
                    productions.Add(new Factory());
                    productions.Last().RandomInit();
                    productions.Add(new Workshop());
                    productions.Last().RandomInit();
                    productions.Add(new CraftShop());
                    productions.Last().RandomInit();
                    break;
            }
            Console.Clear();
            return productions;
        }
        static void ShowObjects(List<Production> productions)
        {
            foreach(var x in productions)
            {
                if (x is CraftShop)
                {
                    Console.WriteLine("Объект craftShop");
                }
                else if (x is Workshop)
                {
                    Console.WriteLine("Объект workshop");
                }
                else if (x is Factory)
                {
                    Console.WriteLine("Объект factory");
                }
                else if (x is Production)
                {
                    Console.WriteLine("Объект production");
                }
                
                x.Show();
                Console.WriteLine();
            }
        }
    }
}
