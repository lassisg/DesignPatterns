namespace CreationalPatterns.BaseCode;

public class Maze
{
    public List<Room> Rooms { get; set; } = new();

    public void AddRoom(Room room) 
        => Rooms.Add(room);
    
    public Room RoomNb(int roomNumber) 
        => Rooms.FirstOrDefault(x => x.RoomNumber == roomNumber);
    
}