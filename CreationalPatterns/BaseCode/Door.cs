namespace CreationalPatterns.BaseCode;

public class Door : MapSite
{
    public Room Room1 { get; set; }
    public Room Room2 { get; set; }
    public bool IsOpen { get; set; }
    
    public Door(Room room1, Room room2)
        => (Room1, Room2 ) = (room1, room2 );

    public virtual void Enter() { }

    public Room OtherSideFrom(Room room)
    {
        if (room == Room1)
            return Room2;

        if (room == Room2)
            return Room1;

        throw new ArgumentException($"Room '{room}' not found.");
    }
}