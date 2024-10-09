using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Workshop : Factory
    {
        public string WorkshopGoal;
        public Workshop()
        {
            WorkshopGoal = "Unknown";
        }
        public Workshop(
            string productType, int capacity, string location, string workshopGoal) :
            base(productType, capacity, location)
        {
            WorkshopGoal = workshopGoal;
        }
        public Workshop(Workshop w) : base(w)
        {
            WorkshopGoal = w.WorkshopGoal;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Задача цеха: {WorkshopGoal}");
        }
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите задачу цеха: ");
            WorkshopGoal = Console.ReadLine()!;
        }
        public override void RandomInit()
        {
            Random rnd = new();
            base.RandomInit();
            string[] workshopGoal = { "Сборка", "Упаковка", "Проверка", "Отправка", "Сортировка" };
            WorkshopGoal = workshopGoal[rnd.Next(workshopGoal.Length)];
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj) &&
                obj is Workshop workshop &&
                workshop.WorkshopGoal == WorkshopGoal;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), WorkshopGoal);
        }

        public override object Clone()
        {
            return new Workshop(this);
        }
    }
}
