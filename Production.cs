using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab10
{
    public class Production : IInit, IComparable<Production>, ICloneable
    {
        public string ProductType 
        {
            get
            {
                return ProductType!;
            }

            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException($"Ошибка! {nameof(ProductType)} не может являться пустой строкой!");
                }
                else
                {
                    ProductType = value;
                }
            }
        }
        public int Capacity
        {
            get
            {
                return Capacity!;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Ошибка! {nameof(Capacity)} не может быть меньше нуля!");
                }
                else
                {
                    Capacity = value;
                }
            }
        }
        public Production()
        {
            ProductType = "Unknown";
            Capacity = 0;
        }
        public Production(string productType, int capacity)
        {
            ProductType = productType;
            Capacity = capacity;
        }
        public Production(Production p) : this(p.ProductType, p.Capacity) { }
        public virtual void Show()
        {
            Console.WriteLine($"Тип продукта: {ProductType}\n" +
                $"Мощность пр-ва: {Capacity}\n");
        }
        public virtual void Init()
        {
            Console.WriteLine("Введите тип продукта: ");
            ProductType = Console.ReadLine()!;

            Console.WriteLine("Введите мощность производства: ");
            Capacity = int.Parse( Console.ReadLine()! );

        }
        public virtual void RandomInit()
        {
            Random rnd = new();
            string[] productType = { "Автомобили", "Грузовики", "Светодиодные лампы", "Мебель", "Обувь", "Одежда", "Молоко" };

            ProductType = productType[rnd.Next(productType.Length)];
            Capacity = rnd.Next(500);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Production)) return false;
            else return this.ProductType == ((Production)obj).ProductType &&
                    this.Capacity == ((Production)obj).Capacity;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ProductType, Capacity);
        }
        public virtual int CompareTo(Production? other)
        {
            return string.Compare(ProductType, other!.ProductType);
        }
        public override string ToString()
        {
            return $"Product type: {ProductType}\nCapacity: {Capacity}";
        }
        public virtual object Clone()
        {
            return new Production(this);
        }
    }
}
