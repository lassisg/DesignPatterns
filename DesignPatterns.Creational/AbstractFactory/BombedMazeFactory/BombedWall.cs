using DesignPatterns.Creational.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.BombedMazeFactory;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a BombedWall (product object) to be created by the corresponding factory.
/// <para>Implements the IWall (AbstractProduct) interface.</para>
/// </summary>
public class BombedWall : IWall
{
    public void Enter() { }
}