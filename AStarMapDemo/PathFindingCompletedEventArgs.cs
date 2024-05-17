using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarMapDemo
{
    public class PathFindingCompletedEventArgs : EventArgs
    {
        public List<Node> Path { get; }

        public PathFindingCompletedEventArgs(List<Node> path)
        {
            Path = path;
        }
    }

}
