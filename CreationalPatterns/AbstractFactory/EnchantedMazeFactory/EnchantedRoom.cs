﻿using CreationalPatterns.Common;
using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.AbstractFactory.EnchantedMazeFactory;

/// <summary>
/// <para>Concrete product.</para>
/// Defines a EnchantedRoom (product object) to be created by the corresponding factory.
/// <para>Implements the IRoom (AbstractProduct) interface.</para>
/// </summary>
public class EnchantedRoom : IRoom
{
    public int RoomNumber { get; set; }
    public ISpell Spell { get; set; }
    public Dictionary<DirectionEnum, IMapSite> Sides { get; set; } = new();

    public EnchantedRoom(int roomNumber, ISpell spell) 
        => (RoomNumber, Spell) = (roomNumber, spell);

    public IMapSite GetSide(DirectionEnum direction)
    {
        if (!Sides.ContainsKey(direction))
            throw new InvalidDataException($"The side { direction.ToString() } is not set.");

        IMapSite side = Sides.First(x => x.Key == direction).Value;
        
        return side;
    }

    public void SetSide(DirectionEnum direction, IMapSite mapSite)
    {
        if (Sides.Count is 4) 
            throw new InvalidDataException("There are no more sides available.");

        if (Sides.ContainsKey(direction))
            throw new InvalidDataException($"The side { direction.ToString() } is already set.");
        
        Sides.Add(direction, mapSite);
    }

    public void Enter() { }
    
}