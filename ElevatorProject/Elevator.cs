
using System;
using System.Collections.Generic;

namespace ElevatorProject
{
    internal class Elevator
    {
        public int CurrentFloor { get; set; }

        public HashSet<int> ListOfFloorPressed { get; set; }

        public Elevator() 
        {
            ListOfFloorPressed = new HashSet<int>();
            CurrentFloor = 4;
        }

        public void ManageElevatorDoor(IList<int> newList)
        {
            foreach (int item in newList) 
            {
                ElevatorDoorOpen(item);
                ElevatorDoorClosed(item);               
            }

        }

        public void ElevatorDoorOpen(int floor)
        {
            CurrentFloor = floor;
            Console.WriteLine("Elevator reached the {0} Floor", CurrentFloor);
            
        }

        public void ElevatorDoorClosed(int floor)
        {
            ListOfFloorPressed.Remove(floor);
            Console.WriteLine("Door are closed");
          
        }

    }
}
