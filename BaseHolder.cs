using System.Collections.Generic;
using Model;

namespace NastyLab46
{
    public class BaseHolder
    {
        public List<Product> CPUs { get; } = new()
        {
            new CPU()
            {
                Title = "Intel Core i3-10100F",
                SKU = "ITL-TG-WHT-02",
                Price = 250,
                Frequency = 3.6f,
                CoresCount = 4,
                TDP = 65,
                MaxTemperature = 95.0f
            },
            new CPU()
            {
                Title = "Intel Core i5-10400F",
                SKU = "ITL-TG-WHT-02",
                Price = 400,
                Frequency = 4.3f,
                CoresCount = 6,
                TDP = 65,
                MaxTemperature = 100.0f,
            },
            new CPU()
            {
                Title = "AMD Ryzen 5 3600",
                SKU = "AMD-TG-BLK-01",
                Price = 380,
                Frequency = 3.6f,
                CoresCount = 6,
                TDP = 65,
                MaxTemperature = 115.0f
            },
            new CPU()
            {
                Title = "AMD Ryzen 5 5600G",
                SKU = "",
                Price = 410,
                Frequency = 4.3f,
                CoresCount = 6,
                TDP = 60,
                MaxTemperature = 115
            }
        };

        public List<Product> GPUs { get; } = new()
        {
            new GPU()
            {
                Title = "Nvidia GeForce GTX 1080",
                SKU = "ASM-TG-WHT-01",
                Price = 800,
                MemoryType = MemoryType.GDDR5x,
                MemoryAmount = 12000,
                CudaFrequency = 1500,
                TDP = 150
            },
            new GPU()
            {
                Title = "Nvidia GeForce RTX 3050",
                SKU = "ASM-TG-SMT-02",
                Price = 800,
                MemoryType = MemoryType.GDDR6,
                MemoryAmount = 8000,
                CudaFrequency = 1300,
                TDP = 130
            },
            new GPU()
            {
                Title = "Nvidia GeForce RTX 3060",
                SKU = "ASM-AS-SMT-03",
                Price = 1100,
                MemoryType = MemoryType.GDDR6,
                MemoryAmount = 12000,
                CudaFrequency = 190,
                TDP = 165
            },
            new GPU()
            {
                Title = "Nvidia GeForce RTX 3090Ti",
                SKU = "ASM-TG-SMT-10",
                Price = 3000,
                MemoryType = MemoryType.GDDR6x,
                MemoryAmount = 24000,
                CudaFrequency = 200,
                TDP = 180
            }
        };

        public List<Product> Coolers { get; } = new()
        {
            new Cooler()
            {
                Title = "Be Quiet! Dark Rock Pro 4",
                SKU = "SRT-TG-BLK-02",
                Price = 115,
                Material = CoolerMaterial.Метал,
                Type = CoolerType.Звичайний,
                Speed = 1500
            },
            new Cooler()
            {
                Title = "Corsair LL120 RGB",
                SKU = "SRT-RD-WHT-03",
                Price = 199,
                Material = CoolerMaterial.Алюміній,
                Type = CoolerType.Звичайний,
                Speed = 1200
            },
            new Cooler()
            {
                Title = "NZXT Kraken Z73",
                SKU = "SRT-RD-WHT-02",
                Price = 400,
                Material = CoolerMaterial.Пласмас,
                Type = CoolerType.Водний,
                Speed = 2300
            }
        };

        public List<Product> HardDrives { get; } = new()
        {
            new HardDrive()
            {
                Title = "Kingston 2121",
                SKU = "CLR-TG-SMT-02",
                Price = 100,
                Speed = 3000,
                Capasity = 512,
                Type = HardDriveType.SSD
            }
        };

        public List<Product> RAMs { get; } = new()
        {
            new RAM()
            {
                Title = "HyperX Beast 350x",
                SKU = "ASM-TG-SMT-02",
                Price = 200,
                MemoryAmount = 15900,
                MemoryType = MemoryType.DDR4_DIMM,
                PinsCount = 2
            }
        };

        public List<Product> Monitors { get; } = new()
        {
            new Monitor()
            {
                Title = "Asus ZenMon 2x",
                SKU = "MNT-SG-SMT-02",
                Matrix = MatrixType.IPS,
                ReactionTime = 0.4f,
                Resolution = (1920, 1080)
            }
        };
    }
}
