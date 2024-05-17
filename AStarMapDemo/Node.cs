using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarMapDemo
{
    //该类用于表示A*算法中的节点
    public class Node
    {
        //X 和 Y 属性：
        //X 和 Y 属性用于表示节点在网格地图中的位置坐标。
        //在二维网格地图中，节点的位置由其横坐标（X）和纵坐标（Y）确定。
        public int X { get; set; }
        public int Y { get; set; }

        //GCost 和 HCost 属性：
        //GCost 属性表示从起点到当前节点的实际代价，即已经花费的代价。
        //HCost 属性表示从当前节点到终点的估计代价，即启发式函数的值。
        //这两个属性合起来确定了节点的总代价 FCost，即 FCost = GCost + HCost。
        //在A*算法中，选择下一个要探索的节点时，会优先考虑总代价最小的节点。
        public int GCost { get; set; }
        public int HCost { get; set; }

        //FCost 只读属性：
        //FCost 属性是只读的，它通过 GCost 和 HCost 的和来计算。
        //这种设计确保了 FCost 始终反映了当前节点的总代价。
        public int FCost => GCost + HCost;

        //Parent 属性：
        //Parent 属性表示当前节点在搜索过程中的父节点，即从哪个节点到达当前节点的。
        //这个属性在重构路径时非常有用，可以从终点节点一直回溯到起点节点，构建完整的路径。
        public Node Parent { get; set; }

        //构造函数：
        //构造函数接受横纵坐标、实际代价、估计代价和父节点作为参数，并将它们分别赋值给对应的属性。
        //这样，创建节点对象时就可以初始化它们的属性值。
        public Node(int x, int y, int gCost, int hCost, Node parent)
        {
            X = x;
            Y = y;
            GCost = gCost;
            HCost = hCost;
            Parent = parent;
        }
    }
}
