using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class CraftShop : Workshop
    {
        public int NumberOfPeople
        {
            get
            {
                return NumberOfPeople;
            }
            set
            {
                if (NumberOfPeople < 0)
                {
                    throw new ArgumentException($"Ошибка! {nameof(NumberOfPeople)} не может быть меньше нуля!");
                }
                else
                {
                    NumberOfPeople = value;
                }
            }
        }
        public CraftShop()
        {
            NumberOfPeople = 0;
        }
        public CraftShop(
            string productType, int capacity, string location, string workshopGoal, int numberOfPeople) :
            base(productType, capacity, location, workshopGoal)
        {
            NumberOfPeople = numberOfPeople;
        }
        public CraftShop(CraftShop c) : base(c) 
        {
            NumberOfPeople= c.NumberOfPeople;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Количество людей в мастерской: {NumberOfPeople}");
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите количество людей в мастерской: ");
            NumberOfPeople = int.Parse(Console.ReadLine()!);
        }
        public override void RandomInit()
        {
            Random rnd = new Random();
            base.RandomInit();
            NumberOfPeople = rnd.Next(20);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj) &&
                obj is CraftShop craftShop &&
                craftShop.NumberOfPeople == NumberOfPeople;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), NumberOfPeople);
        }

        public override object Clone()
        {
            return new CraftShop(this);
        }
    }
}
