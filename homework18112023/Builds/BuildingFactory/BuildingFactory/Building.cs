using System;

namespace Part1
{
    public class Building
    {
        private int buildingNumber;
        private double height;
        private byte floors;
        private ushort apartments;
        private int entrances;
        private static int lastBuildingNumber = 0;
        internal Building(double height, byte floors, ushort apartments, int entrances)
        {
            buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }
        internal Building(double height)
        {
            buildingNumber = GenerateBuildingNumber();
            this.height = height;
            floors = 0;
            apartments = 0;
            entrances = 0;
        }
        internal Building(ushort apartments)
        {
            buildingNumber = GenerateBuildingNumber();
            height = 0;
            floors = 0;
            this.apartments = apartments;
            entrances = 0;
        }
        internal Building(byte floors, ushort apartments)
        {
            buildingNumber = GenerateBuildingNumber();
            height = 0;
            this.floors = floors;
            this.apartments = apartments;
            entrances = 0;
        }
        internal Building()
        {
            buildingNumber = GenerateBuildingNumber();
            height = 0;
            floors = 0;
            apartments = 0;
            entrances = 0;
        }
        public int GetBuildingNumber()
        {
            return buildingNumber;
        }

        public double GetHeight()
        {
            return height;
        }

        public int GetFloors()
        {
            return floors;
        }

        public int GetApartments()
        {
            return apartments;
        }

        public int GetEntrances()
        {
            return entrances;
        }

        private static int GenerateBuildingNumber()
        {
            return ++lastBuildingNumber;
        }

        public double CalculateFloorHeight()
        {
            return (double)height / floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return apartments / floors;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер здания: {buildingNumber}");
            Console.WriteLine($"Высота здания: {height}");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: около {CalculateFloorHeight()} м");
            Console.WriteLine($"Количество квартир в подъезде: около {CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Количество квартир на этаже: около {CalculateApartmentsPerFloor()}");
        }
    }
}
