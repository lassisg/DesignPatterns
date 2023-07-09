using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.AbstractFactory.EnchantedMazeFactory;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a DoorNeedingSpell (product object) to be created by the corresponding factory.
/// <para>Implements the IDoor (AbstractProduct) interface.</para>
/// </summary>
public class DoorNeedingSpell : IDoor
{
    public IRoom Room1 { get; set; }
    public IRoom Room2 { get; set; }
    public bool IsOpen { get; set; }
    
    public DoorNeedingSpell(IRoom room1, IRoom room2)
        => (Room1, Room2 ) = (room1, room2 );

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