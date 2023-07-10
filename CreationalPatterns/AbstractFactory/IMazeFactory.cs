using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.AbstractFactory;

/// <summary>
/// <para>Abstract Factory.</para>
/// Declares an interface for operations that create abstract mazes (product objects).
/// </summary>
public interface IMazeFactory
{
    public IMaze MakeMaze();
    public IWall MakeWall();
    public IRoom MakeRoom(int roomNumber);
    public IDoor MakeDoor(IRoom room1, IRoom room2);
}