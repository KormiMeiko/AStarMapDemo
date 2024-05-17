using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AStarMapDemo
{
    public partial class MainWindow : Form
    {
        const string BuildDateTime = "2024年5月18日 01:15";
        string AppDir = AppDomain.CurrentDomain.BaseDirectory;
        bool drawObstacleMode = false;
        bool drawCongestedRoadMode = false;
        bool itHasMap = false;
        bool isDrawX = false;
        string lastOpenedMapDataPath = "";

        int MapStart_X = 0;
        int MapStart_Y = 0;
        int MapEnd_X = 0;
        int MapEnd_Y = 0;
        public MainWindow()
        {
            InitializeComponent();
            mapControl.OnGridInfo += mapControl_OnGridInfo;
            mapControl.PathFindingCompleted += mapControl_PathFindingCompleted;
            stopwatch = new Stopwatch();
        }
        private void mapControl_OnGridInfo(string info)
        {
            toolStripStatusLabel1.Text = info;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            drawObstacleMode = false;
            drawCongestedRoadMode = false;

            ResetTimer();

            ModeLVD.Checked = true;
            mapControl.SetNeighborNodeMode("LVD");
            ModeM.Checked = true;
            mapControl.SetCalculateHCostMode("Manhattan");
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开方案";
            openFileDialog.Filter = "方案文件 (*.amap)|*.amap|所有文件 (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                lastOpenedMapDataPath = selectedFilePath;
                mapControl.SetMapDataFilePath(selectedFilePath);
                mapControl.LoadMapData();
                MapStart_X = mapControl.GetStartPoint().X;
                MapStart_Y = mapControl.GetStartPoint().Y;
                MapEnd_X = mapControl.GetEndPoint().X;
                MapEnd_Y = mapControl.GetEndPoint().Y;
                itHasMap = true;
                itHadMap();
                ResetTimer();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否将搜索路径一同保存？\n(如果没有选“是”即可。)", "提示", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                SaveMapData();
            }
            else if (dr == DialogResult.No)
            {
                mapControl.ClearPath();
                SaveMapData();
            }
            else if (dr == DialogResult.Cancel)
            {
                //
            }
        }
        private void SaveMapData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存方案";
            saveFileDialog.FileName = ".amap";
            saveFileDialog.Filter = "打开方案 (*.amap)|*.amap|所有文件 (*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog.FileName;
                lastOpenedMapDataPath = selectedFilePath;
                mapControl.SetMapDataFilePath(selectedFilePath);
                mapControl.SaveMapData();
                MessageBox.Show("保存成功。", "提示");
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MapNew_Click(object sender, EventArgs e)
        {
            if (itHasMap == true)
            {
                DialogResult dr = MessageBox.Show("创建地图会覆盖当前地图，是否继续？\n(地图上设置和绘制的内容会同时被清除。)", "提示", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    NewMap();
                }
                else if (dr == DialogResult.No)
                {

                }
            }
            else if (itHasMap == false)
            {
                NewMap();
            }
        }
        private void NewMap()
        {
            int width, height;
            if (int.TryParse(MapW.Text, out width) && int.TryParse(MapH.Text, out height))
            {
                lastOpenedMapDataPath = "";
                mapControl.SetMapSize(width, height);
                itHasMap = true;
                itHadMap();
                ResetTimer();
            }
            else
            {
                MessageBox.Show("请输入有效的地图尺寸。", "提示");
            }
        }

        private void btn_MapStart_Click(object sender, EventArgs e)
        {
            SetMapStartPoint();
        }
        private void SetMapStartPoint()
        {
            int x, y;
            if (int.TryParse(MapStartX.Text, out x) && int.TryParse(MapStartY.Text, out y))
            {
                MapStart_X = x;
                MapStart_Y = y;
                mapControl.SetStartPoint(x, y);
            }
            else
            {
                MessageBox.Show("请输入有效的起点坐标。", "提示");
            }
        }

        private void btn_MapEnd_Click(object sender, EventArgs e)
        {
            SetMapEndPoint();
        }
        private void SetMapEndPoint()
        {
            int x, y;
            if (int.TryParse(MapEndX.Text, out x) && int.TryParse(MapEndY.Text, out y))
            {
                MapEnd_X = x;
                MapEnd_Y = y;
                mapControl.SetEndPoint(x, y);
            }
            else
            {
                MessageBox.Show("请输入有效的终点坐标。", "提示");
            }
        }

        private void btn_DrawObstacle_Click(object sender, EventArgs e)
        {
            if (itHasMap == true)
            {
                drawObstacleMode = !drawObstacleMode;
                drawCongestedRoadMode = false;
                UpdateDrawModeShow();

                isDrawX = false;
                SwitchDrawObstacleX.Checked = false;
                mapControl.SwitchDrawX(false);
            }
            else if (itHasMap == false)
            {
                MessageBox.Show("请先创建地图，或从方案读取地图再绘制。", "提示");
            }
        }

        private void btn_DrawCongested_Click(object sender, EventArgs e)
        {
            if (itHasMap == true)
            {
                drawCongestedRoadMode = !drawCongestedRoadMode;
                drawObstacleMode = false;
                UpdateDrawModeShow();

                isDrawX = false;
                SwitchDrawObstacleX.Checked = false;
                mapControl.SwitchDrawX(false);
            }
            else if (itHasMap == false)
            {
                MessageBox.Show("请先创建地图，或从方案读取地图再绘制。", "提示");
            }
        }

        private void UpdateDrawModeShow()
        {
            if (drawObstacleMode == true)
            {
                DrawObstacleSwitch_Show.Text = "启用";
            }
            else if (drawObstacleMode == false)
            {
                DrawObstacleSwitch_Show.Text = "关闭";
            }

            if (drawCongestedRoadMode == true)
            {
                DrawCongestedSwitch_Show.Text = "启用";
            }
            else if (drawCongestedRoadMode == false)
            {
                DrawCongestedSwitch_Show.Text = "关闭";
            }
        }
        private void mapControl_PathFindingCompleted(object sender, PathFindingCompletedEventArgs e)
        {
            blinkingDot.DotColor = Color.FromArgb(140, 140, 174);
            blinkingDot.BlinkInterval = 800;
            blinkingDot.IsBlinking = true;

            tabControl.Enabled = true;

            stopwatch.Stop();
            timer1.Stop();

            ForceRestartPanel.Visible = false;
        }
        private void mapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isDrawX)
            {
                int x = e.X / MapControl.GridSize;
                int y = e.Y / MapControl.GridSize;

                if (drawObstacleMode)
                {
                    mapControl.SetObstacle(x, y);
                }
                else if (drawCongestedRoadMode)
                {
                    int congestionLevel;
                    if (int.TryParse(DrawCongestedLevelNum.Text, out congestionLevel))
                    {
                        mapControl.SetCongestedRoad(x, y, congestionLevel);
                    }
                    else
                    {
                        MessageBox.Show("请输入有效的拥堵级别。", "提示");
                    }
                }
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (itHasMap == true)
            {
                tabControl.Enabled = false;

                drawObstacleMode = false;
                drawCongestedRoadMode = false;
                UpdateDrawModeShow();

                isDrawX = false;
                SwitchDrawObstacleX.Checked = false;
                mapControl.SwitchDrawX(false);

                mapControl.ClearPath();

                int runLevel = int.Parse(RunSpeed.Value.ToString());
                int runSpeed = 1001 - runLevel * 100;


                ResetTimer();
                stopwatch.Start();
                timer1.Start();

                blinkingDot.DotColor = Color.FromArgb(97, 97, 137);
                blinkingDot.BlinkInterval = 200;
                blinkingDot.IsBlinking = true;

                mapControl.StartPathFinding(MapStart_X, MapStart_Y, MapEnd_X, MapEnd_Y, runSpeed);

                ForceRestartPanel.Visible = true;
            }
            else if (itHasMap == false)
            {
                MessageBox.Show("请先创建地图，或从方案读取地图再运行。", "提示");
            }
        }
        private void itHadMap()
        {
            if (itHasMap == true)
            {
                panel3.Visible = true;
                panel4.Visible = true;
                btn_MapStart.Visible = true;
                btn_MapEnd.Visible = true;
                MapStart.Visible = true;
                MapEnd.Visible = true;
                panel2.Visible = true;
                btn_MapReset.Visible = true;
            }
            else if (itHasMap == false)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                btn_MapStart.Visible = false;
                btn_MapEnd.Visible = false;
                MapStart.Visible = false;
                MapEnd.Visible = false;
                panel2.Visible = false;
                btn_MapReset.Visible = false;
            }
        }

        private void btn_MapReset_Click(object sender, EventArgs e)
        {
            ResetTimer();
            mapControl.ClearPath();
        }

        private void ModeLV_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetNeighborNodeMode("LV");
        }

        private void ModeLVD_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetNeighborNodeMode("LVD");
        }
        string AboutInfo = "AStarMapDemo\r\n>由于程序制作过于匆忙，可能存在小瑕疵，请谅解。\r\n\r\n版本: " + Application.ProductVersion + "\r\n构建日期: " + BuildDateTime + "\r\n\r\n作者:\r\n        kormimeiko@gmail.com\r\n图标: GNOME3";
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            MessageBox.Show(AboutInfo, "关于");
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AboutInfo, "关于");
        }

        private void btn_Github_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/KormiMeiko/AStarMapDemo",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void reloadCurrentMapData_Click(object sender, EventArgs e)
        {
            mapControl.SetMapDataFilePath(lastOpenedMapDataPath);
            mapControl.LoadMapData();
            MapStart_X = mapControl.GetStartPoint().X;
            MapStart_Y = mapControl.GetStartPoint().Y;
            MapEnd_X = mapControl.GetEndPoint().X;
            MapEnd_Y = mapControl.GetEndPoint().Y;
            itHasMap = true;
            itHadMap();
            ResetTimer();
        }

        private void restartProgram_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ModeM_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetCalculateHCostMode("Manhattan");
        }

        private void ModeE_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetCalculateHCostMode("Euclidean");
        }

        private void ModeC_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetCalculateHCostMode("Chebyshev");
        }

        private void ModeImprovement1_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetCalculateHCostMode("Improvement1");
        }

        private void ModeAdaptive_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.SetCalculateHCostMode("Adaptive");
        }
        private Stopwatch stopwatch;
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimerDisplay();
        }
        private void ResetTimer()
        {
            blinkingDot.DotColor = Color.FromArgb(140, 140, 174);
            blinkingDot.BlinkInterval = 800;
            blinkingDot.IsBlinking = true;

            stopwatch.Reset();
            labelTimer.Text = "00:000s";
        }
        private void UpdateTimerDisplay()
        {
            labelTimer.ForeColor = Color.Black;
            // 获取当前经过的时间
            TimeSpan elapsedTime = stopwatch.Elapsed;
            // 计算总毫秒数
            long totalMilliseconds = (long)elapsedTime.TotalMilliseconds;
            // 计算秒数
            int seconds = (int)(totalMilliseconds / 1000);
            // 计算剩余的毫秒数
            int remainingMilliseconds = (int)(totalMilliseconds % 1000);
            // 将时间格式化为显示字符串
            string displayTime = $"{seconds:D2}:{remainingMilliseconds:D3}";
            labelTimer.Text = displayTime + "s";
        }

        private void mapControl_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "就绪。";
        }

        private void btnForceRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SwitchDrawObstacleX_CheckedChanged(object sender, EventArgs e)
        {
            if (drawObstacleMode == true)
            {
                if(isDrawX == true)
                {
                    isDrawX = false;
                    mapControl.SwitchDrawX(false);
                }
                else if(isDrawX == false)
                {
                    isDrawX = true;
                    mapControl.SwitchDrawX(true);
                }
            }
            else
            {
                isDrawX = false;
                mapControl.SwitchDrawX(false);
                SwitchDrawObstacleX.Checked = false;
            }
        }
    }
}
