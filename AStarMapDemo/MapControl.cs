namespace AStarMapDemo
{
    public class MapControl : UserControl
    {
        //GridSize 是一个常量，定义了每个网格的大小为15像素。这意味着地图中的每个方格都是15x15像素的区域。
        public const int GridSize = 15;

        //gridTypes 是一个二维整型数组，用于存储每个网格的类型。
        //注释解释了不同类型的网格
        //0 表示道路。1 表示障碍。2 表示起点。3 表示终点。4 表示拥堵的道路。5 表示找到的道路。6 表示已探索的道路。
        private int[,] gridTypes;

        //congestionLevels 是一个二维整型数组，用于存储每个网格的拥堵程度。
        //这个数组只有在网格类型为拥堵道路 (4) 时才有意义。
        private int[,] congestionLevels;

        //MapWidth 和 MapHeight 是地图的宽度和高度。
        //这两个属性只有 get 访问器和 private 的 set 访问器，这意味着它们只能在类的内部进行设置，而在类的外部只能读取。
        public int MapWidth { get; private set; }
        public int MapHeight { get; private set; }

        //这行代码定义了一个委托（delegate）类型 GridInfoDelegate。
        //委托是一个类型安全的函数指针，它可以封装一个方法，该方法具有与委托定义相同的参数列表和返回类型。
        //在这个例子中，GridInfoDelegate 是一个参数为 string 类型且没有返回值的方法。
        public delegate void GridInfoDelegate(string info);

        //OnGridInfo 是一个事件（event），其类型是 GridInfoDelegate。
        //事件是委托的封装，提供了一种发布-订阅模式，允许类或对象提供一个通知机制，当某个动作发生时通知其他类或对象。
        //OnGridInfo 事件会在 MapControl 类中某些情况发生时触发，并传递一个 string 类型的信息。
        public event GridInfoDelegate OnGridInfo;

        public MapControl()
        {
            //启用双缓冲以减少闪烁现象，提高绘图性能。
            //双缓冲是通过在后台缓冲区中绘制图像，然后将其复制到屏幕上来实现的。
            this.DoubleBuffered = true;

            //调用 InitializeMap 方法，初始化地图的默认大小为 0 x 0。
            InitializeMap(0, 0);

            //为 MouseMove 事件添加处理程序 MapControl_MouseMove，当鼠标在控件上移动时，将调用该处理程序。
            this.MouseMove += new MouseEventHandler(MapControl_MouseMove);

            //绘制优化
            this.MouseDown += MapControl_MouseDown;
            this.MouseUp += MapControl_MouseUp;
        }
        bool isDrawing = false;
        string MouseStatus = "up";
        public void SwitchDrawX(bool isDrawX)
        {
            isDrawing = isDrawX;
        }
        private void MapControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MouseStatus = "down";
            }
            else if(e.Button == MouseButtons.Right)
            {
                MouseStatus = "down2";
            }
        }
        private void MapControl_MouseUp(object sender, MouseEventArgs e)
        {
            MouseStatus = "up";
        }
        private void InitializeMap(int width, int height)
        {
            MapWidth = width; //设置地图的宽度。
            MapHeight = height; //设置地图的高度。

            //初始化一个二维数组 gridTypes，用于存储每个网格的类型。
            gridTypes = new int[width, height];
            //初始化一个二维数组 congestionLevels，用于存储每个网格的拥堵级别。
            congestionLevels = new int[width, height];

            //将地图上的所有网格初始化为默认值。
            ClearMap();

            //更新控件的尺寸以适应地图大小。
            UpdateControlSize();
        }

        private void UpdateControlSize()
        {
            //更新控件的宽度和高度，使其与地图大小相适应。
            //每个网格的尺寸为 GridSize 像素

            this.Width = MapWidth * GridSize;
            this.Height = MapHeight * GridSize;
        }

        private void ClearMap()
        {
            //遍历地图的所有网格，将 gridTypes 和 congestionLevels 数组中的每个元素初始化为 0。
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    //将网格类型设置为 0，表示道路。
                    gridTypes[x, y] = 0;
                    //将拥堵级别设置为 0，表示无拥堵。
                    congestionLevels[x, y] = 0;
                }
            }
        }

        //重写 OnPaint 方法以处理控件的绘制。
        protected override void OnPaint(PaintEventArgs e)
        {
            //调用 base.OnPaint(e) 以确保基础类的绘制逻辑被执行。
            base.OnPaint(e);
            //获取 Graphics 对象 g，用于绘制图形。
            Graphics g = e.Graphics;
            //遍历网格并绘制每个网格的内容
            //遍历地图的所有网格，按列（x）和行（y）顺序进行。
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    //创建一个 Rectangle 对象 rect，定义每个网格的位置和尺寸。
                    //x * GridSize 和 y * GridSize 确定网格的左上角坐标，GridSize 确定网格的宽度和高度。
                    Rectangle rect = new Rectangle(x * GridSize, y * GridSize, GridSize, GridSize);

                    //根据网格类型填充颜色
                    //使用 switch 语句检查 gridTypes[x, y] 的值，以确定网格的类型。
                    switch (gridTypes[x, y])
                    {
                        //根据网格类型使用不同的颜色填充网格
                        case 0: // 白色（道路）
                            g.FillRectangle(Brushes.White, rect);
                            //g.FillRectangle 方法使用此画笔填充 rect 矩形，表示当前网格的颜色。
                            break;
                        case 1: // 黑色（障碍物）
                            g.FillRectangle(Brushes.Black, rect);
                            break;
                        case 2: // 酸橙绿（起点）
                            g.FillRectangle(Brushes.LimeGreen, rect);
                            break;
                        case 3: // 红色（终点）
                            g.FillRectangle(Brushes.Red, rect);
                            break;
                        case 4: // 动态计算的颜色（拥堵的道路），拥堵级别越高，颜色越深黄。
                            //congestionLevel 从 congestionLevels 数组中获取当前网格的拥堵级别。
                            //congestionLevels 是一个二维数组，存储每个网格的拥堵信息。
                            //x 和 y 分别表示当前网格的列和行索引。
                            int congestionLevel = congestionLevels[x, y];
                            //255 - congestionLevel * 10 用于计算红色和绿色分量的值。
                            Color congestionColor = Color.FromArgb(255, 255 - congestionLevel * 10, 255 - congestionLevel * 10, 0);
                            //使用 congestionColor 创建一个新的 SolidBrush 对象，用于填充当前网格。
                            g.FillRectangle(new SolidBrush(congestionColor), rect);
                            break;
                        case 5: // 深天蓝色（路径）
                            g.FillRectangle(Brushes.DeepSkyBlue, rect);
                            break;
                        case 6: // 银色（已探索）
                            g.FillRectangle(Brushes.Silver, rect);
                            break;
                    }
                    //使用黑色画笔绘制网格的边框。
                    g.DrawRectangle(Pens.Black, rect);
                }
            }
        }

        //设置地图尺寸
        public void SetMapSize(int width, int height)
        {
            //调用 InitializeMap 方法重新初始化地图，并调用 Invalidate 方法触发重绘
            InitializeMap(width, height);
            //重绘地图：调用 Invalidate() 方法触发控件重绘，更新显示。
            Invalidate();
        }

        //设置障碍物
        public void SetObstacle(int x, int y)
        {
            if (IsValidCoordinate(x, y))
            {
                //如果指定的坐标在起点、终点或拥堵道路上，则不进行任何操作。
                if (gridTypes[x, y] == 2 || gridTypes[x, y] == 3 || gridTypes[x, y] == 4)
                {
                    return;
                }
                //如果不是障碍物，且是道路的前提先，点击创建为障碍物，反之还原为道路。
                if (gridTypes[x, y] == 1)
                {
                    if (!isDrawing)
                    {
                        if(MouseStatus == "down")
                        {
                            gridTypes[x, y] = 0; //移除障碍物
                        }
                    }
                }
                else
                {
                    gridTypes[x, y] = 1; //设置障碍物
                }
                //重绘地图：调用 Invalidate() 方法触发控件重绘，更新显示。
                Invalidate();
            }
        }

        //获取起点
        public Point GetStartPoint()
        {
            //这个方法遍历整个地图，查找标记为起点（2）的网格并返回其坐标。如果未找到，则返回 Point.Empty。
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    if (gridTypes[x, y] == 2)
                    {
                        return new Point(x, y); //返回起点的坐标
                    }
                }
            }
            return Point.Empty; //如果没有找到起点，返回 Point.Empty
        }

        //获取终点
        public Point GetEndPoint()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    if (gridTypes[x, y] == 3)
                    {
                        return new Point(x, y); //返回终点的坐标
                    }
                }
            }
            return Point.Empty; //如果没有找到终点，返回 Point.Empty
        }

        //设置起点
        public void SetStartPoint(int x, int y)
        {
            //检查坐标合法性：调用 IsValidCoordinate(x, y) 检查传入的坐标是否在地图范围内。
            if (IsValidCoordinate(x, y))
            {
                //清除当前起点：调用 ClearStartPoint() 方法清除当前已经设置的起点（如果有）。
                ClearStartPoint();
                //检查新位置的合法性：确保新位置不在障碍物（1）或拥堵道路（4）上。
                if (gridTypes[x, y] != 1 && gridTypes[x, y] != 4)
                {
                    //设置新起点：将 gridTypes[x, y] 设置为 2（起点）。
                    gridTypes[x, y] = 2;
                    //重绘地图：调用 Invalidate() 方法触发控件重绘，更新显示。
                    Invalidate();
                }
            }
        }

        //设置终点
        public void SetEndPoint(int x, int y)
        {
            //检查坐标合法性：调用 IsValidCoordinate(x, y) 检查传入的坐标是否在地图范围内。
            if (IsValidCoordinate(x, y))
            {
                //清除当前终点：调用 ClearEndPoint() 方法清除当前已经设置的终点（如果有）。
                ClearEndPoint();
                //检查新位置的合法性：确保新位置不在障碍物（1）或拥堵道路（4）上。
                if (gridTypes[x, y] != 1 && gridTypes[x, y] != 4)
                {
                    //设置新终点：将 gridTypes[x, y] 设置为 3（终点）。
                    gridTypes[x, y] = 3;
                    //重绘地图：调用 Invalidate() 方法触发控件重绘，更新显示。
                    Invalidate();
                }
            }
        }

        //清除当前起点
        private void ClearStartPoint()
        {
            //遍历整个地图：使用嵌套的 for 循环遍历地图的每个网格。
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    //查找当前起点：如果找到标记为 2 的网格，将其重置为 0（普通道路）。
                    if (gridTypes[x, y] == 2)
                    {
                        //结束方法：一旦找到并清除起点，立即返回，避免不必要的继续遍历。
                        gridTypes[x, y] = 0;
                        return;
                    }
                }
            }
        }

        //清除当前终点
        private void ClearEndPoint()
        {
            //遍历整个地图：使用嵌套的 for 循环遍历地图的每个网格。
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    //查找当前终点：如果找到标记为 3 的网格，将其重置为 0（普通道路）。
                    if (gridTypes[x, y] == 3)
                    {
                        //结束方法：一旦找到并清除终点，立即返回，避免不必要的继续遍历。
                        gridTypes[x, y] = 0;
                        return;
                    }
                }
            }
        }

        //设置拥堵道路
        public void SetCongestedRoad(int x, int y, int congestionLevel)
        {
            //检查坐标合法性：调用 IsValidCoordinate(x, y) 检查传入的坐标是否在地图范围内。
            if (IsValidCoordinate(x, y))
            {
                //确保合法位置：确保不能在起点（2）、终点（3）或障碍物（1）上设置拥堵道路。
                //如果当前位置是这些类型之一，方法直接返回。
                if (gridTypes[x, y] == 1 || gridTypes[x, y] == 2 || gridTypes[x, y] == 3)
                {
                    return;
                }
                //设置或移除拥堵道路
                if (gridTypes[x, y] == 4)
                {
                    //如果当前位置已经是拥堵道路（4），则将其重置为普通道路（0），并将拥堵级别重置为 0。
                    gridTypes[x, y] = 0;
                    congestionLevels[x, y] = 0;
                }
                else
                {
                    //否则，将当前位置设置为拥堵道路（4），并指定其拥堵级别。
                    gridTypes[x, y] = 4; // Set congested road
                    congestionLevels[x, y] = congestionLevel;
                }
                //重绘地图：调用 Invalidate() 方法触发控件重绘，更新显示。
                Invalidate();
            }
        }

        //判断坐标是否有效
        //这个方法用于检查给定的坐标是否在地图的有效范围内。
        private bool IsValidCoordinate(int x, int y)
        {
            //检查横坐标：确保 x 在 0 到 MapWidth 之间。
            //检查纵坐标：确保 y 在 0 到 MapHeight 之间。
            return x >= 0 && x < MapWidth && y >= 0 && y < MapHeight;
            //返回结果：如果 x 和 y 都在有效范围内，返回 true，否则返回 false。
        }

        //鼠标移动事件处理器
        //这个方法用于在鼠标移动到地图上时提供当前鼠标所在网格的信息。
        private void MapControl_MouseMove(object sender, MouseEventArgs e)
        {
            //计算网格坐标：通过 e.X / GridSize 和 e.Y / GridSize 计算鼠标当前所在的网格坐标 x 和 y。
            int x = e.X / GridSize;
            int y = e.Y / GridSize;

            // 检查是否正在绘制
            if (isDrawing)
            {
                if(e.Button == MouseButtons.Left)
                {
                    if (MouseStatus == "down")
                    {
                        SetObstacle(x, y);
                    }
                }
                else if(e.Button == MouseButtons.Right)
                {
                    if (MouseStatus == "down2")
                    {
                        if (IsValidCoordinate(x, y))
                        {
                            if (gridTypes[x, y] == 1)
                            {
                                gridTypes[x, y] = 0;
                                Invalidate();
                            }
                        }
                    }
                }
            }

            //检查坐标合法性：调用 IsValidCoordinate(x, y) 检查计算出的网格坐标是否在地图范围内。
            if (IsValidCoordinate(x, y))
            {
                //使用 switch 表达式根据 gridTypes[x, y] 的值生成网格类型的信息字符串。
                string gridType = gridTypes[x, y] switch
                {
                    0 => "道路",
                    1 => "障碍",
                    2 => "起点",
                    3 => "终点",
                    //特别地，对于拥堵道路（4），包含其拥堵级别。
                    4 => $"拥堵道路 (拥堵级别: {congestionLevels[x, y]})",
                    5 => $"找到的道路",
                    6 => $"已探索的道路",
                    _ => "未知"
                };
                //触发事件：如果 OnGridInfo 事件有订阅者，调用该事件并传递生成的网格信息字符串。
                OnGridInfo?.Invoke($"坐标 ({x}, {y}) 的类型是 {gridType}。");
            }
            else
            {
                //无效坐标处理：如果坐标不合法，触发事件并传递 "就绪。" 信息。
                OnGridInfo?.Invoke("就绪。");
            }
        }

        //设置地图数据文件路径
        public string mapDataFilePath = "";
        public void SetMapDataFilePath(string mapDataPath)
        {
            mapDataFilePath = mapDataPath;
        }

        //保存地图数据到文件
        public void SaveMapData()
        {
            try
            {
                //文件写入：使用 StreamWriter 创建或覆盖文件，并写入地图数据。
                using (StreamWriter writer = new StreamWriter(mapDataFilePath))
                {
                    //写入尺寸：首先写入地图的宽度和高度。
                    writer.WriteLine($"{MapWidth},{MapHeight}");
                    //写入每个网格的数据：遍历整个地图，写入每个网格的坐标、类型和拥堵级别。
                    for (int x = 0; x < MapWidth; x++)
                    {
                        for (int y = 0; y < MapHeight; y++)
                        {
                            writer.WriteLine($"{x},{y},{gridTypes[x, y]},{congestionLevels[x, y]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //错误处理：如果在保存过程中发生错误，捕获异常并显示错误消息。
                MessageBox.Show($"保存地图方案时出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //从文件中读取地图数据并显示在地图上
        public void LoadMapData()
        {
            try
            {
                //检查文件存在性：检查 mapDataFilePath 指定的文件是否存在。
                if (File.Exists(mapDataFilePath))
                {
                    //清除现有地图数据：调用 ClearMap() 方法清除当前地图数据。
                    ClearMap();
                    //文件读取：使用 StreamReader 读取文件内容。
                    using (StreamReader reader = new StreamReader(mapDataFilePath))
                    {
                        //读取尺寸：首先读取并解析地图的宽度和高度。
                        string[] size = reader.ReadLine().Split(',');
                        int width = int.Parse(size[0]);
                        int height = int.Parse(size[1]);
                        //初始化地图：调用 InitializeMap(width, height) 方法以新尺寸初始化地图。
                        InitializeMap(width, height);
                        //读取每个网格的数据：逐行读取文件内容，解析每个网格的坐标、类型和拥堵级别，并更新地图数据。
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            int x = int.Parse(parts[0]);
                            int y = int.Parse(parts[1]);
                            int type = int.Parse(parts[2]);
                            int congestion = int.Parse(parts[3]);

                            gridTypes[x, y] = type;
                            congestionLevels[x, y] = congestion;
                        }
                    }
                    //刷新地图显示：调用 Invalidate() 方法触发控件重绘，更新显示。
                    Invalidate();
                }
                else
                {
                    MessageBox.Show("地图方案文件没找到。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //错误处理：如果在读取过程中发生错误，捕获异常并显示错误消息。
                MessageBox.Show($"加载地图方案数据时错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //清除地图上显示的路径和已探索的节点
        public void ClearPath()
        {
            //遍历整个地图的所有网格点。
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    //检查每个网格点的类型，如果是路径（假设类型5）或者已探索节点（假设类型6），将其重置为道路（类型0）。
                    if (gridTypes[x, y] == 5 || gridTypes[x, y] == 6)
                    {
                        gridTypes[x, y] = 0;
                    }
                }
            }
            //调用 Invalidate() 方法刷新地图显示。
            Invalidate();
        }

        //在地图上显示已找到的路径
        public void DisplayPath(List<Node> path)
        {
            //遍历路径列表中的每个节点。
            foreach (var node in path)
            {
                //对于每个路径节点，检查其类型，跳过起点（类型2）和终点（类型3）。
                if (gridTypes[node.X, node.Y] != 2 && gridTypes[node.X, node.Y] != 3)
                {
                    //将路径节点的类型设置为路径（类型 5）。
                    gridTypes[node.X, node.Y] = 5;
                }
            }
            //调用 Invalidate() 方法刷新地图显示。
            Invalidate();
        }

        string CalculateHCostMode = "";
        public void SetCalculateHCostMode(string mode)
        {
            CalculateHCostMode = mode;
        }

        //事件声明
        public event EventHandler<PathFindingCompletedEventArgs> PathFindingCompleted;
        protected virtual void OnPathFindingCompleted(PathFindingCompletedEventArgs e)
        {
            PathFindingCompleted?.Invoke(this, e);
        }

        //A* 算法的路径寻找
        public async Task<List<Node>> FindPath(int startX, int startY, int endX, int endY, int speed)
        {
            //初始化
            //创建 openList 用于存放待探索的节点，使用 List<Node> 类型。
            var openList = new List<Node>();
            //创建 closedList 用于存放已探索的节点，使用 HashSet<(int, int)> 类型。
            var closedList = new HashSet<(int, int)>();
            //创建起始节点 startNode，并将其添加到 openList 中。
            var startNode = new Node(startX, startY, 0, CalculateHCost(startX, startY, endX, endY, CalculateHCostMode), null);
            openList.Add(startNode);

            //路径搜索循环
            while (openList.Count > 0)
            {
                //在 openList 还有节点时，不断执行以下步骤
                //从 openList 中找出 F 代价最小的节点 currentNode。
                var currentNode = openList.OrderBy(n => n.FCost).First();
                //将 currentNode 从 openList 移除。
                openList.Remove(currentNode);

                // 如果 currentNode 是终点节点，则构建并返回路径。
                //currentNode.X 和 currentNode.Y 分别是当前节点的 x 坐标和 y 坐标。
                //endX 和 endY 分别是终点节点的 x 坐标和 y 坐标。
                //如果当前节点的坐标与终点坐标相同，则说明已经找到了从起点到终点的路径。
                if (currentNode.X == endX && currentNode.Y == endY)
                {
                    //构建路径
                    var path = ReconstructPath(currentNode);
                    DisplayPath(path);
                    OnPathFindingCompleted(new PathFindingCompletedEventArgs(path));
                    return path;
                }
                //将 currentNode 添加到 closedList 中。
                closedList.Add((currentNode.X, currentNode.Y));

                //将 currentNode 标记为已探索（除非是起点或终点）。
                if (gridTypes[currentNode.X, currentNode.Y] != 2 && gridTypes[currentNode.X, currentNode.Y] != 3)
                {
                    gridTypes[currentNode.X, currentNode.Y] = 6;
                }

                //邻居节点处理
                //遍历 currentNode 的邻居节点。
                foreach (var neighbor in GetNeighbors(currentNode.X, currentNode.Y))
                {
                    //跳过已在 closedList 中的邻居或是障碍物。
                    if (closedList.Contains((neighbor.X, neighbor.Y)) || gridTypes[neighbor.X, neighbor.Y] == 1) continue;
                    //计算新 G 代价 newGCost，并考虑拥挤度。
                    int newGCost = currentNode.GCost + 1 + congestionLevels[neighbor.X, neighbor.Y];
                    //如果邻居节点不在 openList 中，或者找到更优路径，更新邻居节点信息，并将其添加到 openList 中。
                    if (!openList.Any(n => n.X == neighbor.X && n.Y == neighbor.Y) || newGCost < neighbor.GCost)
                    {
                        //发现更优路径，更新节点信息
                        //创建新节点
                        //neighbor.X 和 neighbor.Y: 邻居节点的坐标。
                        //newGCost: 从起始节点到这个邻居节点的实际代价，包含了路径的长度和拥堵度。
                        //CalculateHCost(neighbor.X, neighbor.Y, endX, endY, CalculateHCostMode): 从邻居节点到目标节点的启发式估价，用于估计从当前节点到目标节点的成本。
                        //GCost 是从起点到当前节点的实际移动代价。
                        //HCost 是从当前节点到终点的启发式估价。
                        //Parent 是当前节点的父节点，用于路径重构。

                        //currentNode: 当前节点，是邻居节点的父节点，记录了路径信息。
                        var newNode = new Node(neighbor.X, neighbor.Y, newGCost, CalculateHCost(neighbor.X, neighbor.Y, endX, endY, CalculateHCostMode), currentNode);
                        //检查 openList 中是否已经存在该节点
                        //openList.Any(n => n.X == newNode.X && n.Y == newNode.Y): 检查 openList 中是否已经存在坐标与 newNode 相同的节点。
                        //Any 方法返回一个布尔值，表示是否存在满足条件的节点。

                        if (openList.Any(n => n.X == newNode.X && n.Y == newNode.Y))
                        {
                            //First 方法返回第一个满足条件的节点。
                            //如果存在这样的节点，就把第一个满足条件的节点移除。
                            openList.Remove(openList.First(n => n.X == newNode.X && n.Y == newNode.Y));
                        }
                        //将新节点添加到 openList
                        openList.Add(newNode);
                    }
                }

                //界面更新和延迟
                //每次循环后调用 Invalidate() 方法刷新地图显示。
                Invalidate();
                //使用 Task.Delay(speed) 添加延迟，以便可视化路径搜索过程。
                await Task.Delay(speed);
            }
            //如果 openList 为空且未找到路径，返回 null。
            return null;
        }

        public async void StartPathFinding(int startX, int startY, int endX, int endY, int speed)
        {
            var path = await FindPath(startX, startY, endX, endY, speed);
            if (path == null)
            {
                MessageBox.Show("没有道路路径被找到。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string NeighborNodeMode = "";
        public void SetNeighborNodeMode(string mode)
        {
            NeighborNodeMode = mode;
        }

        //获取给定坐标 (x, y) 的相邻节点列表
        private List<Node> GetNeighbors(int x, int y)
        {
            //初始化 neighbors 列表
            //neighbors 是一个用于存储相邻节点的列表。
            var neighbors = new List<Node>();

            //根据 NeighborNodeMode 的值选择相邻节点模式
            //选择水平、垂直和对角线方向的相邻节点模式
            if (NeighborNodeMode == "LVD")
            {
                //dx 和 dy 数组分别表示相邻节点的水平和垂直方向的偏移量。
                int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 }; // 对应左、上、右、左上、右上、左下、右下、下
                int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };
                //使用 for 循环遍历这些偏移量，计算新的相邻节点的坐标 (newX, newY)。
                for (int i = 0; i < 8; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];
                    //检查新坐标是否有效且不是障碍物，然后将其添加到 neighbors 列表中。
                    if (IsValidCoordinate(newX, newY) && gridTypes[newX, newY] != 1)
                    {
                        neighbors.Add(new Node(newX, newY, 0, 0, null));
                    }
                }
            }
            else if (NeighborNodeMode == "LV") //选择水平和垂直方向的相邻节点模式
            {
                //只使用水平和垂直方向的偏移量，即左、上、右、下。
                int[] dx = { -1, 0, 1, 0 }; // 对应左、上、右、下
                int[] dy = { 0, -1, 0, 1 };
                //使用 for 循环遍历这些偏移量，计算新的相邻节点的坐标 (newX, newY)。
                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];
                    //检查新坐标是否有效且不是障碍物，然后将其添加到 neighbors 列表中。
                    if (IsValidCoordinate(newX, newY) && gridTypes[newX, newY] != 1)
                    {
                        neighbors.Add(new Node(newX, newY, 0, 0, null));
                    }
                }
            }
            //返回相邻节点列表
            return neighbors;
        }

        //路径重构
        //用于从终点节点开始重构路径，一直回溯到起点节点，并返回完整的路径。
        private List<Node> ReconstructPath(Node endNode)
        {
            //从终点节点 endNode 开始，将该节点加入路径列表 path。
            var path = new List<Node> { endNode };
            //通过不断访问每个节点的父节点，沿着路径回溯直到起点节点。
            while (endNode.Parent != null)
            {
                //每次回溯时，将父节点插入到路径列表的开头，以确保路径的顺序是从起点到终点。
                path.Insert(0, endNode.Parent);
                endNode = endNode.Parent;
            }
            //最后返回完整的路径列表。
            return path;
        }

        //启发式函数的计算
        private int CalculateHCost(int startX, int startY, int endX, int endY, string mode)
        {
            int distance = 0;
            switch (mode)
            {
                //曼哈顿距离（Manhattan Distance）：从当前节点到终点的水平和垂直方向上的距离之和。
                case "Manhattan":
                    distance = Math.Abs(endX - startX) + Math.Abs(endY - startY);
                    break;
                //欧几里得距离（Euclidean Distance）：从当前节点到终点的直线距离的平方。
                case "Euclidean":
                    //优化：使用平方的欧几里得距离
                    distance = (int)(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2));
                    break;
                //切比雪夫距离（Chebyshev Distance）：从当前节点到终点的水平和垂直方向上的最大距离。
                case "Chebyshev":
                    distance = Math.Max(Math.Abs(endX - startX), Math.Abs(endY - startY));
                    break;
                //改进1
                //对对角线方向的移动成本采用了固定的14作为倍数，水平或垂直方向的移动成本为10倍。
                //考虑了对角线方向上的移动成本，以提供更准确的路径估计。
                //通过最小和最大差值的方式计算了对角线和水平垂直方向上的移动成本。
                //在对角线和水平垂直方向上的移动成本之间取了最大值，以确保对角线移动成本不低于水平或垂直移动成本。
                //这样做可以更好地反映对角线移动的实际代价，避免了在某些情况下低估对角线移动的成本。
                //or
                //通过分别计算对角线方向和水平垂直方向上的移动成本，然后取最大值，确保了对角线移动成本不低于水平或垂直移动成本。
                case "Improvement1":
                    // 计算水平和垂直方向上的距离
                    int dx = Math.Abs(endX - startX);
                    int dy = Math.Abs(endY - startY);
                    // 计算对角线方向上的距离
                    int min = Math.Min(dx, dy);
                    int max = Math.Max(dx, dy);
                    // 对角线方向上的移动成本为min，垂直或水平方向上的移动成本为max-min
                    int diagonalCost = min * 14;
                    int straightCost = (max - min) * 10;
                    distance = diagonalCost + straightCost;
                    break;
                //一种自适应方案
                //根据当前地图的实际情况，动态调整移动成本，使得算法在考虑障碍物和拥堵情况下能够更准确地评估路径的代价，提高了搜索的准确性和效率。
                //可以根据具体需求灵活调整启发式函数的权重和参数，以适应不同的应用场景和地图结构，从而更好地应对复杂的搜索问题。
                //通过综合考虑多种因素，可以提高路径搜索的效率和性能，减少不必要的搜索开销，同时保证找到的路径质量较高。
                case "Adaptive":
                    // 计算基础距离
                    int dx2 = Math.Abs(endX - startX);
                    int dy2 = Math.Abs(endY - startY);
                    // 对角线距离加上水平/垂直距离
                    distance = Math.Max(dx2, dy2) * 10 + Math.Min(dx2, dy2) * 6;
                    // 根据实际情况动态调整移动成本
                    switch (gridTypes[endX, endY])
                    {
                        // 如果是障碍物
                        case 1:
                            // 增加障碍物的移动成本
                            distance += 100;
                            break;
                        // 如果是拥堵道路
                        case 4:
                            // 获取拥堵级别
                            int congestionLevel = congestionLevels[endX, endY];
                            // 根据拥堵级别增加移动成本
                            distance += congestionLevel * 10;
                            break;
                    }
                    break;
                // 可以添加更多的启发式函数模式
                default:
                    //如果未指定任何有效的启发式函数模式，则默认使用曼哈顿距离。
                    distance = Math.Abs(endX - startX) + Math.Abs(endY - startY);
                    break;
            }
            return distance;
        }
    }
}