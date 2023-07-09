﻿using CreationalPatterns.BaseCode;
using CreationalPatterns.Common.Interfaces;

namespace CreationalPatterns.AbstractFactory;

/// <summary>
/// <para>Abstract Factory.</para>
/// Declares an interface for operations that create abstract mazes (product objects).
/// </summary>
public class MazeFactory
{
    public MazeFactory() { }
    
    public virtual IMaze MakeMaze() 
        => new Maze();
    
    public virtual IWall MakeWall() 
        => new Wall();
    
    public virtual IRoom MakeRoom(int roomNumber) 
        => new Room(roomNumber);
    
    public virtual IDoor MakeDoor(IRoom room1, IRoom room2)
        => new Door(room1, room2);
}