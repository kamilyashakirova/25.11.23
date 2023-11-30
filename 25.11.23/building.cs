using System;
public class Building
{
    private static int LastNumber = 0;
    private int number;
    private int height;
    private int floors;
    private int apartments;
    private int ent;
    public Building(int height, int floors, int apartments, int ent)
    {
        number = GenerateBNumber();
        this.height = height;
        this.floors = floors;
        this.apartments = apartments;
        this.ent = ent;
    }
    public int BuildingNumber
    {
        get { return number;}
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public int Floors
    {
        get { return floors; }
        set { floors = value; }
    }

    public int Apartments
    {
        get { return apartments; }
        set { apartments = value; }
    }

    public int Entrances
    {
        get { return ent; }
        set { ent = value; }
    }
    /// <summary>
    ///чтобы узнать высоту одного этажа
    /// </summary>
    /// <returns></returns>
    public int CalcHeight()
    {
        return height / floors;
    }
    /// <summary>
    /// сколько квартир в каждом подъезде
    /// </summary>
    /// <returns></returns>
    public int CalcEntrance()
    {
        return apartments / ent;
    }
    /// <summary>
    /// сколько квартир на каждом этаже
    /// </summary>
    /// <returns></returns>
    public int CalcFloor()
    {
        return apartments / floors;
    }
    /// <summary>
    /// для генерации уникального номера здания
    /// </summary>
    /// <returns></returns>
    private int GenerateBNumber()
    {
        LastNumber++;
        return LastNumber;
    }
}
