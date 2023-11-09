using DesignPatterns.Creational.BaseCode;
using DesignPatterns.Creational.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory;

/// <summary>
/// <para>Abstract Factory.</para>
/// Declares an interface for operations that create abstract mazes (product objects).
/// </summary>
public class MazeFactory : IMazeFactory
{
    public MazeFactory() { }
    
    public virtual IMaze MakeMaze() 
        => new Maze();
    
    public virtual IWall MakeWall() 
        => new Wall();
    
    public virtual IRoom MakeRoom(int roomNumber) 
        => new Room(roomNumber);
    
    public virtual IDoor MakeDoor(IRoom room1, IRoom room2)
        => new Door(room1, room2);
}