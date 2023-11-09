using DesignPatterns.Creational.Common;
using DesignPatterns.Creational.Common.Interfaces;

namespace DesignPatterns.Creational.BaseCode;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a Room (product object) to be created by the corresponding factory.
/// <para>Implements the IRoom (AbstractProduct) interface.</para>
/// </summary>
public class Room : IRoom
{
    public int RoomNumber { get; set; }
    public Dictionary<DirectionEnum, IMapSite> Sides { get; set; } = new();

    public Room(int roomNumber) 
        => RoomNumber = roomNumber;

    public IMapSite GetSide(DirectionEnum direction)
    {
        if (!Sides.ContainsKey(direction))
            throw new InvalidDataException($"The side { direction.ToString() } is not set.");

        IMapSite side = Sides.First(x => x.Key == direction).Value;
        
        return side;
    }

    public void SetSide(DirectionEnum direction, IMapSite mapSite)
    {
        if (Sides.Count is 4) 
            throw new InvalidDataException("There are no more sides available.");

        if (Sides.ContainsKey(direction))
            throw new InvalidDataException($"The side { direction.ToString() } is already set.");
        
        Sides.Add(direction, mapSite);
    }

    public void Enter() { }
    
}