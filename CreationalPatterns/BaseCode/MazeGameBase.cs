using CreationalPatterns.Common;

namespace CreationalPatterns.BaseCode;

public class MazeGameBase
{
    public Maze? Maze { get; set; }
    
    public Maze CreateMaze()
    {
        var maze = new Maze();
        var room1 = new Room(1);
        var room2 = new Room(2);
        var door = new Door(room1, room2);
        
        maze.AddRoom(room1);
        maze.AddRoom(room2);
        
        room1.SetSide(DirectionEnum.North, new Wall());
        room1.SetSide(DirectionEnum.East, door);
        room1.SetSide(DirectionEnum.South, new Wall());
        room1.SetSide(DirectionEnum.West, new Wall());
        
        room2.SetSide(DirectionEnum.North, new Wall());
        room2.SetSide(DirectionEnum.East, new Wall());
        room2.SetSide(DirectionEnum.South, new Wall());
        room2.SetSide(DirectionEnum.West, door);
        
        return maze;
    }
}