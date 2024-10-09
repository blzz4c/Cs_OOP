using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Factory : Production
    {
        public string Location
        {
            get
            {
                return Location!;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException($"Ошибка! {nameof(Location)} не может являться пустой строкой!");
                }
                else
                {
                    Location = value;
                }
            }
        }
        public Factory()
        {
            Location = "Unknown";
        }
        public Factory(string productType, int capacity, string location) : base(productType, capacity)
        {
            Location = location;
        }
        public Factory(Factory f) : base(f)
        {
            Location = f.Location;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Местоположение завода: {Location}");
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите местоположение завода: ");
            Location = Console.ReadLine()!;
        }
        public override void RandomInit()
        {
            Random rnd = new();
            base.RandomInit();
            string[] location = { "г. Москва", "г. Пермь", "г. Кудымкар", "д. Ваничи", "г. Екатеринбург" };

            Location = location[rnd.Next(location.Length)];
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj) &&
                obj is Factory factory &&
                factory.Location == Location;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Location);
        }
        public override object Clone()
        {
            return new Factory(this);
        }
    }
}
