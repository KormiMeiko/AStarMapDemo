using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static AStarMapDemo.MapControl;
using static System.Windows.Forms.AxHost;

namespace AStarMapDemo
{
    public partial class MainForm : Form
    {
        private bool drawObstacleMode = false;
        private bool drawCongestedRoadMode = false;

        public MainForm()
        {
            InitializeComponent();
            mapControl1.OnGridInfo += mapControl1_OnGridInfo;


        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void mapControl1_OnGridInfo(string info)
        {
            label1.Text = info;
        }
        private void mapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / MapControl.GridSize;
            int y = e.Y / MapControl.GridSize;

            if (drawObstacleMode)
            {
                mapControl1.SetObstacle(x, y);
            }
            else if (drawCongestedRoadMode)
            {
                int congestionLevel;
                if (int.TryParse(textBoxCongestionLevel.Text, out congestionLevel))
                {
                    mapControl1.SetCongestedRoad(x, y, congestionLevel);
                }
                else
                {
                    MessageBox.Show("Please enter a valid congestion level.");
                }
            }
        }

        private void buttonDrawObstacle_Click(object sender, EventArgs e)
        {
            drawObstacleMode = true;
            drawCongestedRoadMode = false;
        }

        private void buttonDrawCongestedRoad_Click(object sender, EventArgs e)
        {
            drawObstacleMode = false;
            drawCongestedRoadMode = true;
        }

        private void buttonSetMapSize_Click(object sender, EventArgs e)
        {
            int width, height;
            if (int.TryParse(textBoxMapWidth.Text, out width) && int.TryParse(textBoxMapHeight.Text, out height))
            {
                mapControl1.SetMapSize(width, height);
            }
            else
            {
                MessageBox.Show("Please enter valid map dimensions.");
            }
        }

        private void buttonSetStartPoint_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(textBoxStartX.Text, out x) && int.TryParse(textBoxStartY.Text, out y))
            {
                mapControl1.SetStartPoint(x, y);
            }
            else
            {
                MessageBox.Show("Please enter valid start point coordinates.");
            }
        }

        private void buttonSetEndPoint_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(textBoxEndX.Text, out x) && int.TryParse(textBoxEndY.Text, out y))
            {
                mapControl1.SetEndPoint(x, y);
            }
            else
            {
                MessageBox.Show("Please enter valid end point coordinates.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mapControl1.SaveMapData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            mapControl1.LoadMapData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //mapControl1.StartPathFinding(6, 9, 27, 9);
            //try
            //{
            //List<Node> path = mapControl1.FindPath(6, 9, 27, 9);
            //mapControl1.DisplayPath(path);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("不可能");
            //}
        }
    }
}
