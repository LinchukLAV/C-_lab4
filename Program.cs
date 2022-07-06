using System;
using System.Linq;
using Model;

namespace NastyLab46
{
    static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            BaseHolder holder = new();

            Product order = new AssemblyProduct()
            {
                Title = "Загальне замовлення",
                SKU = "TLE-EM-WE-01",
            };
            order.Add(holder.GPUs.First());
            order.Add(holder.CPUs.First());

            Product PC = new AssemblyProduct()
            {
                Title = "PC-1",
                SKU = "ASM-TG-WHT-01",
                DiscountPersentage = 15,
            };
            PC.Add(holder.Coolers.First());
            PC.Add(holder.CPUs.Last());
            PC.Add(holder.GPUs.Last());
            PC.Add(holder.RAMs.First());
            PC.Add(holder.HardDrives.Last());

            Product PCMonitor = new AssemblyProduct()
            {
                Title = "Універсальна сбірка Монітор та ПК",
                DiscountPersentage = 5

            };
            PCMonitor.Add(PC);
            PCMonitor.Add(holder.Monitors.First());

            order.Add(PCMonitor);

            Console.WriteLine(order);
        }
    }
}
