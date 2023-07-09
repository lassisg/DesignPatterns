using CreationalPatterns.AbstractFactory;
using CreationalPatterns.AbstractFactory.BombedMazeFactory;
using CreationalPatterns.AbstractFactory.EnchantedMazeFactory;
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
        
        var mazeFactory = new MazeFactory();
        var regularGame = new MazeGame();
        regularGame.Maze = regularGame.CreateMaze(mazeFactory);

        var bombedMazeFactory = new BombedMazeFactory();
        var bombedMazeGame = new MazeGame();
        bombedMazeGame.Maze = bombedMazeGame.CreateMaze(bombedMazeFactory);

        var enchantedMazeFactory = new EnchantedMazeFactory();
        var enchantedMazeGame = new MazeGame();
        enchantedMazeGame.Maze = enchantedMazeGame.CreateMaze(enchantedMazeFactory);
        
        #endregion
        
        Console.ReadLine();
    }
}