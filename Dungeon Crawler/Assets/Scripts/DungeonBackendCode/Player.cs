using System;
using Unity.VisualScripting;

public class Player : Inhabitant
{
    private Room currentRoom;

    public Player(string name) : base(name)
    {
        
    }
    /*public Player(int hp) : base.setHP(hp)
    {

    }*/
    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }

    public void setCurrentRoom(Room r)
    {
        if (r != null)
        {
            this.currentRoom = r;
        }
    }

    //getter (accessor) for read only access to the private field name
    

}