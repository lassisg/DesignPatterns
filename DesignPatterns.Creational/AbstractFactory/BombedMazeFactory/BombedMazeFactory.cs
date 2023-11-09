using DesignPatterns.Creational.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.BombedMazeFactory;

/// <summary>
/// <para>Concrete Factory.</para>
/// Implements operations that create concrete mazes, Bombed Mazes (product objects).
/// </summary>
public class BombedMazeFactory : MazeFactory
{
    // public BombedMazeFactory() { }

    public override IWall MakeWall()
        => new BombedWall();

    public override IRoom MakeRoom(int roomNumber)
        => new BombedRoom(roomNumber);
}