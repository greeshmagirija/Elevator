using System;


namespace ElevatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ManageElevator = new ManageElevator( new Elevator(), new ElevatorMoveUp(),new ElevatorMoveDown());
            ManageElevator.ElevatorButtonPressed(); // To Initiate the logic
            
            
        }
    }
}
