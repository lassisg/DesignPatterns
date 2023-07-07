namespace CreationalPatterns.AbstractFactory;

public class MazeGame
{
    public Maze Maze { get; set; }
    
    public void CreateMaze()
    {
        var aMaze = new Maze();
        var r1 = new Room(1);
        var r2 = new Room(2);
        var theDoor = new Door(r1, r2);
        
        aMaze.AddRoom(r1);
        aMaze.AddRoom(r2);
        
        r1.SetSide(DirectionEnum.North, new Wall());
        r1.SetSide(DirectionEnum.East, theDoor);
        r1.SetSide(DirectionEnum.South, new Wall());
        r1.SetSide(DirectionEnum.West, new Wall());
        
        r2.SetSide(DirectionEnum.North, new Wall());
        r2.SetSide(DirectionEnum.East, new Wall());
        r2.SetSide(DirectionEnum.South, new Wall());
        r2.SetSide(DirectionEnum.West, theDoor);
        
        Maze = aMaze;
    }
}