

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ElevatorProject
{
    internal class ElevatorMoveUp : IElevatorMove
    {

        public IList<int> Move(HashSet<int> listOfFloor, int floor)
        {
            List<int> sortedList = listOfFloor.ToList();
            sortedList.Sort();
           
            List<int> newList = new List<int>();

            for(int i=0;i<sortedList.Count;i++)
            {
                if(floor > sortedList[i])
                {
                    newList.Add(sortedList[i]);
                    sortedList.Remove(sortedList[i]);
                    i--;
                }
            }
           ((List<int>)newList).Sort((x, y) => y.CompareTo(x));
            foreach (var item in newList)
            {
                sortedList.Add(item);

            }
            Console.WriteLine("Floor Move Sequence");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);

            }

            return sortedList;



        }
    }
}
