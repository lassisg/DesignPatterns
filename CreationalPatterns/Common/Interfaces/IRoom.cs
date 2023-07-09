namespace CreationalPatterns.Common.Interfaces;

/// <summary>
/// Abstract product. An interface for type of rooms (product object).
/// </summary>
public interface IRoom : IMapSite
{
    public int RoomNumber { get; set; }
    public Dictionary<DirectionEnum, IMapSite> Sides { get; set; }

    public IMapSite GetSide(DirectionEnum direction);
    public void SetSide(DirectionEnum direction, IMapSite mapSite);
    public void Enter();
}