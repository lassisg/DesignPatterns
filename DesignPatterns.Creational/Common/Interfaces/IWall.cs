namespace DesignPatterns.Creational.Common.Interfaces;

/// <summary>
/// Abstract product. An interface for type of walls (product object).
/// </summary>
public interface IWall : IMapSite
{
    public void Enter();
}