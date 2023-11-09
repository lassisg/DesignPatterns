namespace DesignPatterns.Creational.Common.Interfaces;

/// <summary>
/// Abstract product. An interface for type of mazes (product object).
/// </summary>
public interface IMaze
{
    public List<IRoom> Rooms { get; set; }

    public void AddRoom(IRoom room);
    public IRoom RoomNb(int roomNumber);
}