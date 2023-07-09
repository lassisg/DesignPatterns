using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.BaseCode;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a Wall (product object) to be created by the corresponding factory.
/// <para>Implements the IWall (AbstractProduct) interface.</para>
/// </summary>
public class Wall : IWall
{
    public string? Material { get; set; }

    public Wall() { }
    public void Enter() { }
}
