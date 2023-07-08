using CreationalPatterns.BaseCode;

namespace DesignPatterns.App;

public static class Creational
{
    public static void RunAbstractFactoryExample()
    {
        Console.WriteLine("Abstract Factory pattern tests");

        var game = new MazeGame();
        Maze maze = game.CreateMaze();
        Console.ReadLine();
    } 
}