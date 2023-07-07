using CreationalPatterns.AbstractFactory;

namespace DesignPatterns.App;

public static class Creational
{
    /// <summary>
    /// Client using only interfaces
    /// </summary>
    public static void RunAbstractFactoryExample()
    {
        Console.WriteLine("Abstract Factory pattern tests");

        var game = new MazeGame();
        game.CreateMaze();
        Console.ReadLine();
    } 
}