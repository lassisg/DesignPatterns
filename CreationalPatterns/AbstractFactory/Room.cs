namespace CreationalPatterns.AbstractFactory;

public class Room : MapSite
{
    public int RoomNumber { get; set; }
    public Dictionary<DirectionEnum, MapSite> Sides { get; set; } = new();

    public Room(int roomNumber) 
        => RoomNumber = roomNumber;

    public MapSite GetSide(DirectionEnum direction)
    {
        if (!Sides.ContainsKey(direction))
            throw new InvalidDataException($"The side { direction.ToString() } is not set.");

        MapSite side = Sides.First(x => x.Key == direction).Value;
        
        return side;
    }

    public void SetSide(DirectionEnum direction, MapSite mapSite)
    {
        if (Sides.Count is 4) 
            throw new InvalidDataException("There are no more sides available.");

        if (Sides.ContainsKey(direction))
            throw new InvalidDataException($"The side { direction.ToString() } is already set.");
        
        Sides.Add(direction, mapSite);
    }

    public virtual void Enter() { }
    
}