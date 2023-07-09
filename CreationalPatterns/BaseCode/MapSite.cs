using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.BaseCode;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a MapSite (product object) to be created by the corresponding factory.
/// <para>Implements the IMapSite (AbstractProduct) interface.</para>
/// </summary>
public class MapSite : IMapSite
{
    public void Enter() { }
}