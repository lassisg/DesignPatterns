namespace CreationalPatterns.AbstractFactory;

public class MazeFactory
{
    public virtual AbstractFactory.Maze MakeMaze() 
        => new AbstractFactory.Maze();
}