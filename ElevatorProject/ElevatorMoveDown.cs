using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject
{
    internal class ElevatorMoveDown : IElevatorMove
    {
        public IList<int> Move(HashSet<int> listOfFloor, int floor)
        {
            List<int> sortedList = listOfFloor.ToList();

            ((List<int>)sortedList).Sort((x, y) => y.CompareTo(x));
            List<int> newList = new List<int>();
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (floor < sortedList[i])
                {
                    newList.Add(sortedList[i]);
                    sortedList.Remove(sortedList[i]);
                    i--;
                }
            }
            newList.Sort();
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
