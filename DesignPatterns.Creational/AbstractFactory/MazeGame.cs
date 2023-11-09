using DesignPatterns.Creational.Common;
using DesignPatterns.Creational.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory;

public class MazeGame
{
    public IMaze? Maze { get; set; }
    
    public IMaze CreateMaze(MazeFactory mazeFactory)
    {
        IMaze maze = mazeFactory.MakeMaze();
        IRoom room1 = mazeFactory.MakeRoom(1);
        IRoom room2 = mazeFactory.MakeRoom(2);
        IDoor door = mazeFactory.MakeDoor(room1, room2);
        
        maze.AddRoom(room1);
        maze.AddRoom(room2);
        
        room1.SetSide(DirectionEnum.North, mazeFactory.MakeWall());
        room1.SetSide(DirectionEnum.East, door);
        room1.SetSide(DirectionEnum.South, mazeFactory.MakeWall());
        room1.SetSide(DirectionEnum.West, mazeFactory.MakeWall());
        
        room2.SetSide(DirectionEnum.North, mazeFactory.MakeWall());
        room2.SetSide(DirectionEnum.East, mazeFactory.MakeWall());
        room2.SetSide(DirectionEnum.South, mazeFactory.MakeWall());
        room2.SetSide(DirectionEnum.West, door);
        
        return maze;
    }
}