using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject
{
    internal class ManageElevator
    {
        private Elevator elevator;
        private IElevatorMove elevatorMoveUp;
        private IElevatorMove elevatorMoveDown;

        public ManageElevator(Elevator elevator, IElevatorMove elevatorMoveUp, IElevatorMove elevatorMoveDown)
        {
            this.elevator = elevator;
            this.elevatorMoveUp = elevatorMoveUp;
            this.elevatorMoveDown = elevatorMoveDown;
            
        }
        
        public void ElevatorButtonPressed() 
        {
            Console.WriteLine(" Is Person Enter the Elevator: If Yes Enter : Y else Enter : N");
            var input = Console.ReadLine();
            if (input[0] == 'Y')
            {
                PopulateListofFloorPressed();

            }
            else
            {
                Console.WriteLine("No one Enter the lift");
            }
            //If first pressed floor is above the current floor then move Up else move down
            if(elevator.CurrentFloor < elevator.ListOfFloorPressed.First()) 
            {
                var newList = elevatorMoveUp.Move(elevator.ListOfFloorPressed,elevator.CurrentFloor);
                elevator.ManageElevatorDoor(newList);

            }
            else
            {
                var newList = elevatorMoveDown.Move(elevator.ListOfFloorPressed, elevator.CurrentFloor);
                elevator.ManageElevatorDoor(newList);
            }
            

            Console.ReadLine();
        }

        private void PopulateListofFloorPressed()
        {
            Console.WriteLine("Number of person Entered the Lift");
            var numberOfPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the floor between 1 to 10");
            for (int i = 1; i <= numberOfPerson; i++)
            {
                var floorValue = Console.ReadLine();
                int.TryParse(floorValue, out int floorPressed);
                if (floorPressed >= 1 && floorPressed <= 10)
                {
                    elevator.ListOfFloorPressed.Add(floorPressed);
                }
                else
                {
                    Console.WriteLine(" Enter the floor detail again");
                    i--;
                }
            }
        }
    }
}
