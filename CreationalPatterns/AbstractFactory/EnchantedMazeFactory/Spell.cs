using CreationalPatterns.Common;
using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.AbstractFactory.EnchantedMazeFactory;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a Spell (product object) to be created by the corresponding factory.
/// <para>Implements the ISpell (AbstractProduct) interface.</para>
/// </summary>
public class Spell : ISpell
{
    public string? Name { get; set; }
    public Spell() { }
}