using DesignPatterns.Creational.Common.Interfaces;

namespace DesignPatterns.Creational.BaseCode;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a Maze (product object) to be created by the corresponding factory.
/// <para>Implements the IMaze (AbstractProduct) interface.</para>
/// </summary>
public class Maze : IMaze
{
    public List<IRoom> Rooms { get; set; } = new();

    public void AddRoom(IRoom room) 
        => Rooms.Add(room);
    
    public IRoom RoomNb(int roomNumber) 
        => Rooms.FirstOrDefault(x => x.RoomNumber == roomNumber)!;
    
}