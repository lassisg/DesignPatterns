using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.AbstractFactory.EnchantedMazeFactory;

/// <summary>
/// <para>Concrete Factory.</para>
/// Implements operations that create concrete mazes, Enchanted Mazes (product objects).
/// </summary>
public class EnchantedMazeFactory : MazeFactory
{
    public EnchantedMazeFactory() { }
    
    public IRoom MakeRoom(int roomNumber) 
        => new EnchantedRoom(roomNumber, CastSpell());
    
    public override IDoor MakeDoor(IRoom room1, IRoom room2)
        => new DoorNeedingSpell(room1, room2);

    public ISpell CastSpell() => new Spell();
}