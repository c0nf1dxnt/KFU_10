using Part1;
using System;
using System.Collections;

namespace BuildingFactory
{
    public class Creator
    {
        static private Hashtable buildings = new Hashtable();

        public static int CreateBuilding(double height, byte floors, ushort apartments, int entrances)
        {
            Building building = new Building(height, floors, apartments, entrances);
            buildings.Add(building.GetBuildingNumber(), building);
            return building.GetBuildingNumber();
        }
        public static int CreateBuilding(double height)
        {
            Building building = new Building(height);
            buildings.Add(building.GetBuildingNumber(), building);
            return building.GetBuildingNumber();
        }
        public static int CreateBuilding(ushort apartments)
        {
            Building building = new Building(apartments);
            buildings.Add(building.GetBuildingNumber(), building);
            return building.GetBuildingNumber();
        }
        public static int CreateBuilding(byte floors, ushort apartments)
        {
            Building building = new Building(floors, apartments);
            buildings.Add(building.GetBuildingNumber(), building);
            return building.GetBuildingNumber();
        }
        public static int CreateBuilding()
        {
            Building building = new Building();
            buildings.Add(building.GetBuildingNumber(), building);
            return building.GetBuildingNumber();
        }
        public static void DeleteBuilding(int buildingNumber)
        {
            if (buildings.ContainsKey(buildingNumber))
            {
                buildings.Remove(buildingNumber);
                Console.WriteLine($"Здание с номером {buildingNumber} успешно удалено из хеш-таблицы!");
            }
            else
            {
                Console.WriteLine($"Здание с номером {buildingNumber} отсутствует в хеш-таблице!");
            }
        }
    }
}
