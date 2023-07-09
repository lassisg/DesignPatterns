using CreationalPatterns.AbstractFactory;
using CreationalPatterns.BaseCode;
using CreationalPatterns.Common.Interfaces;

namespace DesignPatterns.App;

public static class Creational
{
    /// <summary>
    /// <para>Client.</para>
    /// Uses only interfaces declared by AbstractFactory and AbstractProduct
    /// </summary>
    public static void RunAbstractFactoryExample()
    {
        Console.WriteLine("Abstract Factory (Kit)");

        #region Base

        Console.WriteLine("Running base sample");
        var baseGame = new MazeGameBase();
        Maze baseMaze = baseGame.CreateMaze();

        #endregion

        #region Abstract Factory

        Console.WriteLine("Running AbstractFactory sample");
        var factory = new MazeFactory();
        
        var game = new MazeGame();
        IMaze maze = game.CreateMaze(factory);

        #endregion
        
        Console.ReadLine();
    }
}