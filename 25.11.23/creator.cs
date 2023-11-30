
using System.Collections.Generic;


public class Creator
{
    private static Dictionary<int, Building> buildings = new Dictionary<int, Building>();

    private Creator() { }

    public static Building CreateBuild(int height, int floors, int apartments, int entrances)
    {
        Building building = new Building(height, floors, apartments, entrances);
        buildings.Add(building.BuildingNumber, building);
        return building;
    }

    public static Building CreateBuild()
    {
        return CreateBuild(0, 0, 0, 0);
    }

    public static bool RemoveBuilding(int buildingNumber)
    {
        return buildings.Remove(buildingNumber);
    }
}
