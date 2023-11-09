namespace DesignPatterns.Creational.Common.Interfaces;

/// <summary>
/// Abstract product. An interface for type of spells (product object).
/// </summary>
public interface ISpell
{
    public string Name { get; set; }
}