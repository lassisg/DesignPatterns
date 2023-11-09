namespace DesignPatterns.Creational.Common.Interfaces;

/// <summary>
/// Abstract product. An interface for type of doors (product object).
/// </summary>
public interface IDoor : IMapSite
{
    public IRoom Room1 { get; set; }
    public IRoom Room2 { get; set; }
    public bool IsOpen { get; set; }
    
    public void Enter() { }

    public IRoom OtherSideFrom(IRoom room)
    {
        if (room == Room1)
            return Room2;

        if (room == Room2)
            return Room1;

        throw new ArgumentException($"Room '{room}' not found.");
    }
}