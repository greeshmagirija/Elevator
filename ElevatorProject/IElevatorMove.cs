using System.Collections.Generic;

namespace ElevatorProject
{
    internal interface IElevatorMove
    {
        IList<int> Move(HashSet<int> hashSet, int floor);
    }
}
