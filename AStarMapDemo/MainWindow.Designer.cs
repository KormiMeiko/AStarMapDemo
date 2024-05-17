namespace AStarMapDemo
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mapControl = new MapControl();
            tabControl = new TabControl();
            tab_Start = new TabPage();
            panel1 = new Panel();
            btn_Exit = new Button();
            btn_Restart = new Button();
            contextMenuStrip_re = new ContextMenuStrip(components);
            reloadCurrentMapData = new ToolStripMenuItem();
            restartProgram = new ToolStripMenuItem();
            btn_Save = new Button();
            btn_Open = new Button();
            tab_Map = new TabPage();
            btn_MapReset = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            MapEnd = new Panel();
            label6 = new Label();
            MapEndY = new NumericUpDown();
            label7 = new Label();
            MapEnd_Title = new Panel();
            MapEnd_Title_Text = new Label();
            MapEndX = new NumericUpDown();
            btn_MapEnd = new Button();
            MapStart = new Panel();
            label3 = new Label();
            MapStartY = new NumericUpDown();
            label4 = new Label();
            MapStart_Title = new Panel();
            MapStart_Title_Text = new Label();
            MapStartX = new NumericUpDown();
            btn_MapStart = new Button();
            MapSetting = new Panel();
            label2 = new Label();
            MapH = new NumericUpDown();
            label1 = new Label();
            MapSetting_Title = new Panel();
            MapSetting_Title_Text = new Label();
            MapW = new NumericUpDown();
            btn_MapNew = new Button();
            page_Draw = new TabPage();
            DrawObstacleX = new Panel();
            SwitchDrawObstacleX = new CheckBox();
            DrawObstacleX_Title = new Panel();
            DrawObstacleX_Title_Text = new Label();
            DrawCongestedLevel = new Panel();
            label12 = new Label();
            DrawCongestedLevel_Title = new Panel();
            DrawCongestedLevel_Title_Text = new Label();
            DrawCongestedLevelNum = new NumericUpDown();
            DrawCongestedSwitch = new Panel();
            DrawCongestedSwitch_Show = new Label();
            DrawCongestedSwitch_TItle = new Panel();
            DrawCongestedSwitch_TItle_Text = new Label();
            panel5 = new Panel();
            btn_DrawCongested = new Button();
            DrawObstacleSwitch = new Panel();
            DrawObstacleSwitch_Show = new Label();
            DrawObstacleSwitch_Title = new Panel();
            DrawObstacleSwitch_Title_Text = new Label();
            btn_DrawObstacle = new Button();
            page_Run = new TabPage();
            RuningTimer = new Panel();
            labelTimer = new Label();
            RuningTimer_Title = new Panel();
            blinkingDot = new BlinkingDotControl();
            RuningTimer_Title_Text = new Label();
            CalculateHCostMode = new Panel();
            ModeAdaptive = new RadioButton();
            ModeImprovement1 = new RadioButton();
            ModeC = new RadioButton();
            ModeE = new RadioButton();
            ModeM = new RadioButton();
            CalculateHCostMode_Title = new Panel();
            CalculateHCostMode_Title_Text = new Label();
            NeighborNode = new Panel();
            ModeLVD = new RadioButton();
            ModeLV = new RadioButton();
            NeighborNode_Title = new Panel();
            NeighborNode_Title_Text = new Label();
            RunSetting = new Panel();
            label11 = new Label();
            RunSetting_Title = new Panel();
            RunSetting_Title_Text = new Label();
            RunSpeed = new NumericUpDown();
            btn_Run = new Button();
            tabPage1 = new TabPage();
            btn_Github = new Button();
            btn_About = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ContentPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ForceRestartPanel = new Panel();
            btnForceRestart = new Button();
            tabControl.SuspendLayout();
            tab_Start.SuspendLayout();
            contextMenuStrip_re.SuspendLayout();
            tab_Map.SuspendLayout();
            MapEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapEndY).BeginInit();
            MapEnd_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapEndX).BeginInit();
            MapStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapStartY).BeginInit();
            MapStart_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapStartX).BeginInit();
            MapSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapH).BeginInit();
            MapSetting_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MapW).BeginInit();
            page_Draw.SuspendLayout();
            DrawObstacleX.SuspendLayout();
            DrawObstacleX_Title.SuspendLayout();
            DrawCongestedLevel.SuspendLayout();
            DrawCongestedLevel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrawCongestedLevelNum).BeginInit();
            DrawCongestedSwitch.SuspendLayout();
            DrawCongestedSwitch_TItle.SuspendLayout();
            DrawObstacleSwitch.SuspendLayout();
            DrawObstacleSwitch_Title.SuspendLayout();
            page_Run.SuspendLayout();
            RuningTimer.SuspendLayout();
            RuningTimer_Title.SuspendLayout();
            CalculateHCostMode.SuspendLayout();
            CalculateHCostMode_Title.SuspendLayout();
            NeighborNode.SuspendLayout();
            NeighborNode_Title.SuspendLayout();
            RunSetting.SuspendLayout();
            RunSetting_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RunSpeed).BeginInit();
            tabPage1.SuspendLayout();
            statusStrip.SuspendLayout();
            ContentPanel.SuspendLayout();
            ForceRestartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mapControl
            // 
            mapControl.Dock = DockStyle.Fill;
            mapControl.Location = new Point(0, 0);
            mapControl.Name = "mapControl";
            mapControl.Size = new Size(1204, 601);
            mapControl.TabIndex = 0;
            mapControl.MouseClick += mapControl_MouseClick;
            mapControl.MouseLeave += mapControl_MouseLeave;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tab_Start);
            tabControl.Controls.Add(tab_Map);
            tabControl.Controls.Add(page_Draw);
            tabControl.Controls.Add(page_Run);
            tabControl.Controls.Add(tabPage1);
            tabControl.ItemSize = new Size(60, 30);
            tabControl.Location = new Point(8, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1214, 103);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 1;
            // 
            // tab_Start
            // 
            tab_Start.BackColor = Color.WhiteSmoke;
            tab_Start.BorderStyle = BorderStyle.FixedSingle;
            tab_Start.Controls.Add(panel1);
            tab_Start.Controls.Add(btn_Exit);
            tab_Start.Controls.Add(btn_Restart);
            tab_Start.Controls.Add(btn_Save);
            tab_Start.Controls.Add(btn_Open);
            tab_Start.Location = new Point(4, 34);
            tab_Start.Name = "tab_Start";
            tab_Start.Padding = new Padding(3);
            tab_Start.Size = new Size(1206, 65);
            tab_Start.TabIndex = 0;
            tab_Start.Text = "开始";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(153, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 50);
            panel1.TabIndex = 8;
            // 
            // btn_Exit
            // 
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Exit.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Image = Properties.Resources.exit;
            btn_Exit.ImageAlign = ContentAlignment.TopCenter;
            btn_Exit.Location = new Point(234, 2);
            btn_Exit.Margin = new Padding(2);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(71, 59);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "退出程序";
            btn_Exit.TextAlign = ContentAlignment.BottomCenter;
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restart
            // 
            btn_Restart.ContextMenuStrip = contextMenuStrip_re;
            btn_Restart.FlatAppearance.BorderSize = 0;
            btn_Restart.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Restart.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_Restart.FlatStyle = FlatStyle.Flat;
            btn_Restart.Image = Properties.Resources.restart;
            btn_Restart.ImageAlign = ContentAlignment.TopCenter;
            btn_Restart.Location = new Point(159, 2);
            btn_Restart.Margin = new Padding(2);
            btn_Restart.Name = "btn_Restart";
            btn_Restart.Size = new Size(71, 59);
            btn_Restart.TabIndex = 2;
            btn_Restart.Text = "重启程序";
            btn_Restart.TextAlign = ContentAlignment.BottomCenter;
            btn_Restart.UseVisualStyleBackColor = true;
            btn_Restart.Click += btn_Restart_Click;
            // 
            // contextMenuStrip_re
            // 
            contextMenuStrip_re.Items.AddRange(new ToolStripItem[] { reloadCurrentMapData, restartProgram });
            contextMenuStrip_re.Name = "contextMenuStrip1";
            contextMenuStrip_re.Size = new Size(149, 48);
            // 
            // reloadCurrentMapData
            // 
            reloadCurrentMapData.Name = "reloadCurrentMapData";
            reloadCurrentMapData.Size = new Size(148, 22);
            reloadCurrentMapData.Text = "重载当前方案";
            reloadCurrentMapData.Click += reloadCurrentMapData_Click;
            // 
            // restartProgram
            // 
            restartProgram.Name = "restartProgram";
            restartProgram.Size = new Size(148, 22);
            restartProgram.Text = "重启程序";
            restartProgram.Click += restartProgram_Click;
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Save.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Image = Properties.Resources.save;
            btn_Save.ImageAlign = ContentAlignment.TopCenter;
            btn_Save.Location = new Point(77, 2);
            btn_Save.Margin = new Padding(2);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(71, 59);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "保存方案";
            btn_Save.TextAlign = ContentAlignment.BottomCenter;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Open
            // 
            btn_Open.FlatAppearance.BorderSize = 0;
            btn_Open.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Open.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_Open.FlatStyle = FlatStyle.Flat;
            btn_Open.Image = Properties.Resources.open;
            btn_Open.ImageAlign = ContentAlignment.TopCenter;
            btn_Open.Location = new Point(2, 2);
            btn_Open.Margin = new Padding(2);
            btn_Open.Name = "btn_Open";
            btn_Open.Size = new Size(71, 59);
            btn_Open.TabIndex = 0;
            btn_Open.Text = "打开方案";
            btn_Open.TextAlign = ContentAlignment.BottomCenter;
            btn_Open.UseVisualStyleBackColor = true;
            btn_Open.Click += btn_Open_Click;
            // 
            // tab_Map
            // 
            tab_Map.BackColor = Color.WhiteSmoke;
            tab_Map.BorderStyle = BorderStyle.FixedSingle;
            tab_Map.Controls.Add(btn_MapReset);
            tab_Map.Controls.Add(panel2);
            tab_Map.Controls.Add(panel4);
            tab_Map.Controls.Add(panel3);
            tab_Map.Controls.Add(MapEnd);
            tab_Map.Controls.Add(btn_MapEnd);
            tab_Map.Controls.Add(MapStart);
            tab_Map.Controls.Add(btn_MapStart);
            tab_Map.Controls.Add(MapSetting);
            tab_Map.Controls.Add(btn_MapNew);
            tab_Map.Location = new Point(4, 34);
            tab_Map.Name = "tab_Map";
            tab_Map.Padding = new Padding(3);
            tab_Map.Size = new Size(1206, 65);
            tab_Map.TabIndex = 1;
            tab_Map.Text = "地图";
            // 
            // btn_MapReset
            // 
            btn_MapReset.FlatAppearance.BorderSize = 0;
            btn_MapReset.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_MapReset.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_MapReset.FlatStyle = FlatStyle.Flat;
            btn_MapReset.Image = Properties.Resources.map_clear;
            btn_MapReset.ImageAlign = ContentAlignment.TopCenter;
            btn_MapReset.Location = new Point(782, 2);
            btn_MapReset.Margin = new Padding(2);
            btn_MapReset.Name = "btn_MapReset";
            btn_MapReset.Size = new Size(71, 59);
            btn_MapReset.TabIndex = 10;
            btn_MapReset.Text = "重置状态";
            btn_MapReset.TextAlign = ContentAlignment.BottomCenter;
            btn_MapReset.UseVisualStyleBackColor = true;
            btn_MapReset.Visible = false;
            btn_MapReset.Click += btn_MapReset_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(776, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 50);
            panel2.TabIndex = 9;
            panel2.Visible = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(516, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 50);
            panel4.TabIndex = 8;
            panel4.Visible = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(256, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 50);
            panel3.TabIndex = 7;
            panel3.Visible = false;
            // 
            // MapEnd
            // 
            MapEnd.BorderStyle = BorderStyle.FixedSingle;
            MapEnd.Controls.Add(label6);
            MapEnd.Controls.Add(MapEndY);
            MapEnd.Controls.Add(label7);
            MapEnd.Controls.Add(MapEnd_Title);
            MapEnd.Controls.Add(MapEndX);
            MapEnd.Location = new Point(598, 2);
            MapEnd.Name = "MapEnd";
            MapEnd.Size = new Size(172, 59);
            MapEnd.TabIndex = 6;
            MapEnd.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 32);
            label6.Name = "label6";
            label6.Size = new Size(18, 17);
            label6.TabIndex = 4;
            label6.Text = "Y:";
            // 
            // MapEndY
            // 
            MapEndY.Location = new Point(115, 30);
            MapEndY.Maximum = new decimal(new int[] { 39, 0, 0, 0 });
            MapEndY.Name = "MapEndY";
            MapEndY.Size = new Size(48, 23);
            MapEndY.TabIndex = 2;
            MapEndY.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 32);
            label7.Name = "label7";
            label7.Size = new Size(19, 17);
            label7.TabIndex = 3;
            label7.Text = "X:";
            // 
            // MapEnd_Title
            // 
            MapEnd_Title.BackColor = Color.FromArgb(209, 209, 223);
            MapEnd_Title.Controls.Add(MapEnd_Title_Text);
            MapEnd_Title.Dock = DockStyle.Top;
            MapEnd_Title.Location = new Point(0, 0);
            MapEnd_Title.Name = "MapEnd_Title";
            MapEnd_Title.Size = new Size(170, 23);
            MapEnd_Title.TabIndex = 0;
            // 
            // MapEnd_Title_Text
            // 
            MapEnd_Title_Text.AutoSize = true;
            MapEnd_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            MapEnd_Title_Text.Location = new Point(3, 3);
            MapEnd_Title_Text.Name = "MapEnd_Title_Text";
            MapEnd_Title_Text.Size = new Size(56, 17);
            MapEnd_Title_Text.TabIndex = 0;
            MapEnd_Title_Text.Text = "终点坐标";
            // 
            // MapEndX
            // 
            MapEndX.Location = new Point(32, 30);
            MapEndX.Maximum = new decimal(new int[] { 79, 0, 0, 0 });
            MapEndX.Name = "MapEndX";
            MapEndX.Size = new Size(48, 23);
            MapEndX.TabIndex = 1;
            MapEndX.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // btn_MapEnd
            // 
            btn_MapEnd.FlatAppearance.BorderSize = 0;
            btn_MapEnd.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_MapEnd.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_MapEnd.FlatStyle = FlatStyle.Flat;
            btn_MapEnd.Image = Properties.Resources.map_end;
            btn_MapEnd.ImageAlign = ContentAlignment.TopCenter;
            btn_MapEnd.Location = new Point(522, 2);
            btn_MapEnd.Margin = new Padding(2);
            btn_MapEnd.Name = "btn_MapEnd";
            btn_MapEnd.Size = new Size(71, 59);
            btn_MapEnd.TabIndex = 5;
            btn_MapEnd.Text = "设置终点";
            btn_MapEnd.TextAlign = ContentAlignment.BottomCenter;
            btn_MapEnd.UseVisualStyleBackColor = true;
            btn_MapEnd.Visible = false;
            btn_MapEnd.Click += btn_MapEnd_Click;
            // 
            // MapStart
            // 
            MapStart.BorderStyle = BorderStyle.FixedSingle;
            MapStart.Controls.Add(label3);
            MapStart.Controls.Add(MapStartY);
            MapStart.Controls.Add(label4);
            MapStart.Controls.Add(MapStart_Title);
            MapStart.Controls.Add(MapStartX);
            MapStart.Location = new Point(338, 2);
            MapStart.Name = "MapStart";
            MapStart.Size = new Size(172, 59);
            MapStart.TabIndex = 4;
            MapStart.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 32);
            label3.Name = "label3";
            label3.Size = new Size(18, 17);
            label3.TabIndex = 4;
            label3.Text = "Y:";
            // 
            // MapStartY
            // 
            MapStartY.Location = new Point(115, 30);
            MapStartY.Maximum = new decimal(new int[] { 39, 0, 0, 0 });
            MapStartY.Name = "MapStartY";
            MapStartY.Size = new Size(48, 23);
            MapStartY.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 32);
            label4.Name = "label4";
            label4.Size = new Size(19, 17);
            label4.TabIndex = 3;
            label4.Text = "X:";
            // 
            // MapStart_Title
            // 
            MapStart_Title.BackColor = Color.FromArgb(209, 209, 223);
            MapStart_Title.Controls.Add(MapStart_Title_Text);
            MapStart_Title.Dock = DockStyle.Top;
            MapStart_Title.Location = new Point(0, 0);
            MapStart_Title.Name = "MapStart_Title";
            MapStart_Title.Size = new Size(170, 23);
            MapStart_Title.TabIndex = 0;
            // 
            // MapStart_Title_Text
            // 
            MapStart_Title_Text.AutoSize = true;
            MapStart_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            MapStart_Title_Text.Location = new Point(3, 3);
            MapStart_Title_Text.Name = "MapStart_Title_Text";
            MapStart_Title_Text.Size = new Size(56, 17);
            MapStart_Title_Text.TabIndex = 0;
            MapStart_Title_Text.Text = "起点坐标";
            // 
            // MapStartX
            // 
            MapStartX.Location = new Point(32, 30);
            MapStartX.Maximum = new decimal(new int[] { 79, 0, 0, 0 });
            MapStartX.Name = "MapStartX";
            MapStartX.Size = new Size(48, 23);
            MapStartX.TabIndex = 1;
            // 
            // btn_MapStart
            // 
            btn_MapStart.FlatAppearance.BorderSize = 0;
            btn_MapStart.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_MapStart.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_MapStart.FlatStyle = FlatStyle.Flat;
            btn_MapStart.Image = Properties.Resources.map_start;
            btn_MapStart.ImageAlign = ContentAlignment.TopCenter;
            btn_MapStart.Location = new Point(262, 2);
            btn_MapStart.Margin = new Padding(2);
            btn_MapStart.Name = "btn_MapStart";
            btn_MapStart.Size = new Size(71, 59);
            btn_MapStart.TabIndex = 3;
            btn_MapStart.Text = "设置起点";
            btn_MapStart.TextAlign = ContentAlignment.BottomCenter;
            btn_MapStart.UseVisualStyleBackColor = true;
            btn_MapStart.Visible = false;
            btn_MapStart.Click += btn_MapStart_Click;
            // 
            // MapSetting
            // 
            MapSetting.BorderStyle = BorderStyle.FixedSingle;
            MapSetting.Controls.Add(label2);
            MapSetting.Controls.Add(MapH);
            MapSetting.Controls.Add(label1);
            MapSetting.Controls.Add(MapSetting_Title);
            MapSetting.Controls.Add(MapW);
            MapSetting.Location = new Point(78, 2);
            MapSetting.Name = "MapSetting";
            MapSetting.Size = new Size(172, 59);
            MapSetting.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 32);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 4;
            label2.Text = "高:";
            // 
            // MapH
            // 
            MapH.Location = new Point(115, 30);
            MapH.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            MapH.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MapH.Name = "MapH";
            MapH.Size = new Size(48, 23);
            MapH.TabIndex = 2;
            MapH.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 3;
            label1.Text = "宽:";
            // 
            // MapSetting_Title
            // 
            MapSetting_Title.BackColor = Color.FromArgb(209, 209, 223);
            MapSetting_Title.Controls.Add(MapSetting_Title_Text);
            MapSetting_Title.Dock = DockStyle.Top;
            MapSetting_Title.Location = new Point(0, 0);
            MapSetting_Title.Name = "MapSetting_Title";
            MapSetting_Title.Size = new Size(170, 23);
            MapSetting_Title.TabIndex = 0;
            // 
            // MapSetting_Title_Text
            // 
            MapSetting_Title_Text.AutoSize = true;
            MapSetting_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            MapSetting_Title_Text.Location = new Point(3, 3);
            MapSetting_Title_Text.Name = "MapSetting_Title_Text";
            MapSetting_Title_Text.Size = new Size(56, 17);
            MapSetting_Title_Text.TabIndex = 0;
            MapSetting_Title_Text.Text = "地图设置";
            // 
            // MapW
            // 
            MapW.Location = new Point(32, 30);
            MapW.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            MapW.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MapW.Name = "MapW";
            MapW.Size = new Size(48, 23);
            MapW.TabIndex = 1;
            MapW.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // btn_MapNew
            // 
            btn_MapNew.FlatAppearance.BorderSize = 0;
            btn_MapNew.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_MapNew.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_MapNew.FlatStyle = FlatStyle.Flat;
            btn_MapNew.Image = Properties.Resources.map_new;
            btn_MapNew.ImageAlign = ContentAlignment.TopCenter;
            btn_MapNew.Location = new Point(2, 2);
            btn_MapNew.Margin = new Padding(2);
            btn_MapNew.Name = "btn_MapNew";
            btn_MapNew.Size = new Size(71, 59);
            btn_MapNew.TabIndex = 1;
            btn_MapNew.Text = "创建地图";
            btn_MapNew.TextAlign = ContentAlignment.BottomCenter;
            btn_MapNew.UseVisualStyleBackColor = true;
            btn_MapNew.Click += btn_MapNew_Click;
            // 
            // page_Draw
            // 
            page_Draw.BackColor = Color.WhiteSmoke;
            page_Draw.BorderStyle = BorderStyle.FixedSingle;
            page_Draw.Controls.Add(DrawObstacleX);
            page_Draw.Controls.Add(DrawCongestedLevel);
            page_Draw.Controls.Add(DrawCongestedSwitch);
            page_Draw.Controls.Add(panel5);
            page_Draw.Controls.Add(btn_DrawCongested);
            page_Draw.Controls.Add(DrawObstacleSwitch);
            page_Draw.Controls.Add(btn_DrawObstacle);
            page_Draw.Location = new Point(4, 34);
            page_Draw.Name = "page_Draw";
            page_Draw.Padding = new Padding(3);
            page_Draw.Size = new Size(1206, 65);
            page_Draw.TabIndex = 2;
            page_Draw.Text = "绘制";
            // 
            // DrawObstacleX
            // 
            DrawObstacleX.BorderStyle = BorderStyle.FixedSingle;
            DrawObstacleX.Controls.Add(SwitchDrawObstacleX);
            DrawObstacleX.Controls.Add(DrawObstacleX_Title);
            DrawObstacleX.Location = new Point(123, 2);
            DrawObstacleX.Name = "DrawObstacleX";
            DrawObstacleX.Size = new Size(67, 59);
            DrawObstacleX.TabIndex = 11;
            // 
            // SwitchDrawObstacleX
            // 
            SwitchDrawObstacleX.AutoSize = true;
            SwitchDrawObstacleX.Location = new Point(7, 30);
            SwitchDrawObstacleX.Name = "SwitchDrawObstacleX";
            SwitchDrawObstacleX.Size = new Size(51, 21);
            SwitchDrawObstacleX.TabIndex = 1;
            SwitchDrawObstacleX.Text = "启用";
            SwitchDrawObstacleX.UseVisualStyleBackColor = true;
            SwitchDrawObstacleX.CheckedChanged += SwitchDrawObstacleX_CheckedChanged;
            // 
            // DrawObstacleX_Title
            // 
            DrawObstacleX_Title.BackColor = Color.FromArgb(209, 209, 223);
            DrawObstacleX_Title.Controls.Add(DrawObstacleX_Title_Text);
            DrawObstacleX_Title.Dock = DockStyle.Top;
            DrawObstacleX_Title.Location = new Point(0, 0);
            DrawObstacleX_Title.Name = "DrawObstacleX_Title";
            DrawObstacleX_Title.Size = new Size(65, 23);
            DrawObstacleX_Title.TabIndex = 0;
            // 
            // DrawObstacleX_Title_Text
            // 
            DrawObstacleX_Title_Text.AutoSize = true;
            DrawObstacleX_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            DrawObstacleX_Title_Text.Location = new Point(3, 3);
            DrawObstacleX_Title_Text.Name = "DrawObstacleX_Title_Text";
            DrawObstacleX_Title_Text.Size = new Size(56, 17);
            DrawObstacleX_Title_Text.TabIndex = 0;
            DrawObstacleX_Title_Text.Text = "连续绘制";
            // 
            // DrawCongestedLevel
            // 
            DrawCongestedLevel.BorderStyle = BorderStyle.FixedSingle;
            DrawCongestedLevel.Controls.Add(label12);
            DrawCongestedLevel.Controls.Add(DrawCongestedLevel_Title);
            DrawCongestedLevel.Controls.Add(DrawCongestedLevelNum);
            DrawCongestedLevel.Location = new Point(323, 2);
            DrawCongestedLevel.Name = "DrawCongestedLevel";
            DrawCongestedLevel.Size = new Size(122, 59);
            DrawCongestedLevel.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 32);
            label12.Name = "label12";
            label12.Size = new Size(59, 17);
            label12.TabIndex = 3;
            label12.Text = "拥堵级别:";
            // 
            // DrawCongestedLevel_Title
            // 
            DrawCongestedLevel_Title.BackColor = Color.FromArgb(209, 209, 223);
            DrawCongestedLevel_Title.Controls.Add(DrawCongestedLevel_Title_Text);
            DrawCongestedLevel_Title.Dock = DockStyle.Top;
            DrawCongestedLevel_Title.Location = new Point(0, 0);
            DrawCongestedLevel_Title.Name = "DrawCongestedLevel_Title";
            DrawCongestedLevel_Title.Size = new Size(120, 23);
            DrawCongestedLevel_Title.TabIndex = 0;
            // 
            // DrawCongestedLevel_Title_Text
            // 
            DrawCongestedLevel_Title_Text.AutoSize = true;
            DrawCongestedLevel_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            DrawCongestedLevel_Title_Text.Location = new Point(3, 3);
            DrawCongestedLevel_Title_Text.Name = "DrawCongestedLevel_Title_Text";
            DrawCongestedLevel_Title_Text.Size = new Size(56, 17);
            DrawCongestedLevel_Title_Text.TabIndex = 0;
            DrawCongestedLevel_Title_Text.Text = "拥堵级别";
            // 
            // DrawCongestedLevelNum
            // 
            DrawCongestedLevelNum.Location = new Point(68, 30);
            DrawCongestedLevelNum.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            DrawCongestedLevelNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DrawCongestedLevelNum.Name = "DrawCongestedLevelNum";
            DrawCongestedLevelNum.Size = new Size(48, 23);
            DrawCongestedLevelNum.TabIndex = 1;
            DrawCongestedLevelNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DrawCongestedSwitch
            // 
            DrawCongestedSwitch.BorderStyle = BorderStyle.FixedSingle;
            DrawCongestedSwitch.Controls.Add(DrawCongestedSwitch_Show);
            DrawCongestedSwitch.Controls.Add(DrawCongestedSwitch_TItle);
            DrawCongestedSwitch.Location = new Point(278, 2);
            DrawCongestedSwitch.Name = "DrawCongestedSwitch";
            DrawCongestedSwitch.Size = new Size(39, 59);
            DrawCongestedSwitch.TabIndex = 9;
            // 
            // DrawCongestedSwitch_Show
            // 
            DrawCongestedSwitch_Show.AutoSize = true;
            DrawCongestedSwitch_Show.Location = new Point(3, 32);
            DrawCongestedSwitch_Show.Name = "DrawCongestedSwitch_Show";
            DrawCongestedSwitch_Show.Size = new Size(32, 17);
            DrawCongestedSwitch_Show.TabIndex = 3;
            DrawCongestedSwitch_Show.Text = "关闭";
            // 
            // DrawCongestedSwitch_TItle
            // 
            DrawCongestedSwitch_TItle.BackColor = Color.FromArgb(209, 209, 223);
            DrawCongestedSwitch_TItle.Controls.Add(DrawCongestedSwitch_TItle_Text);
            DrawCongestedSwitch_TItle.Dock = DockStyle.Top;
            DrawCongestedSwitch_TItle.Location = new Point(0, 0);
            DrawCongestedSwitch_TItle.Name = "DrawCongestedSwitch_TItle";
            DrawCongestedSwitch_TItle.Size = new Size(37, 23);
            DrawCongestedSwitch_TItle.TabIndex = 0;
            // 
            // DrawCongestedSwitch_TItle_Text
            // 
            DrawCongestedSwitch_TItle_Text.AutoSize = true;
            DrawCongestedSwitch_TItle_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            DrawCongestedSwitch_TItle_Text.Location = new Point(3, 3);
            DrawCongestedSwitch_TItle_Text.Name = "DrawCongestedSwitch_TItle_Text";
            DrawCongestedSwitch_TItle_Text.Size = new Size(32, 17);
            DrawCongestedSwitch_TItle_Text.TabIndex = 0;
            DrawCongestedSwitch_TItle_Text.Text = "状态";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(196, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 50);
            panel5.TabIndex = 8;
            // 
            // btn_DrawCongested
            // 
            btn_DrawCongested.FlatAppearance.BorderSize = 0;
            btn_DrawCongested.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_DrawCongested.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_DrawCongested.FlatStyle = FlatStyle.Flat;
            btn_DrawCongested.Image = Properties.Resources.draw;
            btn_DrawCongested.ImageAlign = ContentAlignment.TopCenter;
            btn_DrawCongested.Location = new Point(202, 2);
            btn_DrawCongested.Margin = new Padding(2);
            btn_DrawCongested.Name = "btn_DrawCongested";
            btn_DrawCongested.Size = new Size(71, 59);
            btn_DrawCongested.TabIndex = 4;
            btn_DrawCongested.Text = "绘制拥堵";
            btn_DrawCongested.TextAlign = ContentAlignment.BottomCenter;
            btn_DrawCongested.UseVisualStyleBackColor = true;
            btn_DrawCongested.Click += btn_DrawCongested_Click;
            // 
            // DrawObstacleSwitch
            // 
            DrawObstacleSwitch.BorderStyle = BorderStyle.FixedSingle;
            DrawObstacleSwitch.Controls.Add(DrawObstacleSwitch_Show);
            DrawObstacleSwitch.Controls.Add(DrawObstacleSwitch_Title);
            DrawObstacleSwitch.Location = new Point(78, 2);
            DrawObstacleSwitch.Name = "DrawObstacleSwitch";
            DrawObstacleSwitch.Size = new Size(39, 59);
            DrawObstacleSwitch.TabIndex = 3;
            // 
            // DrawObstacleSwitch_Show
            // 
            DrawObstacleSwitch_Show.AutoSize = true;
            DrawObstacleSwitch_Show.Location = new Point(3, 32);
            DrawObstacleSwitch_Show.Name = "DrawObstacleSwitch_Show";
            DrawObstacleSwitch_Show.Size = new Size(32, 17);
            DrawObstacleSwitch_Show.TabIndex = 3;
            DrawObstacleSwitch_Show.Text = "关闭";
            // 
            // DrawObstacleSwitch_Title
            // 
            DrawObstacleSwitch_Title.BackColor = Color.FromArgb(209, 209, 223);
            DrawObstacleSwitch_Title.Controls.Add(DrawObstacleSwitch_Title_Text);
            DrawObstacleSwitch_Title.Dock = DockStyle.Top;
            DrawObstacleSwitch_Title.Location = new Point(0, 0);
            DrawObstacleSwitch_Title.Name = "DrawObstacleSwitch_Title";
            DrawObstacleSwitch_Title.Size = new Size(37, 23);
            DrawObstacleSwitch_Title.TabIndex = 0;
            // 
            // DrawObstacleSwitch_Title_Text
            // 
            DrawObstacleSwitch_Title_Text.AutoSize = true;
            DrawObstacleSwitch_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            DrawObstacleSwitch_Title_Text.Location = new Point(3, 3);
            DrawObstacleSwitch_Title_Text.Name = "DrawObstacleSwitch_Title_Text";
            DrawObstacleSwitch_Title_Text.Size = new Size(32, 17);
            DrawObstacleSwitch_Title_Text.TabIndex = 0;
            DrawObstacleSwitch_Title_Text.Text = "状态";
            // 
            // btn_DrawObstacle
            // 
            btn_DrawObstacle.FlatAppearance.BorderSize = 0;
            btn_DrawObstacle.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_DrawObstacle.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_DrawObstacle.FlatStyle = FlatStyle.Flat;
            btn_DrawObstacle.Image = Properties.Resources.draw;
            btn_DrawObstacle.ImageAlign = ContentAlignment.TopCenter;
            btn_DrawObstacle.Location = new Point(2, 2);
            btn_DrawObstacle.Margin = new Padding(2);
            btn_DrawObstacle.Name = "btn_DrawObstacle";
            btn_DrawObstacle.Size = new Size(71, 59);
            btn_DrawObstacle.TabIndex = 2;
            btn_DrawObstacle.Text = "绘制障碍";
            btn_DrawObstacle.TextAlign = ContentAlignment.BottomCenter;
            btn_DrawObstacle.UseVisualStyleBackColor = true;
            btn_DrawObstacle.Click += btn_DrawObstacle_Click;
            // 
            // page_Run
            // 
            page_Run.BackColor = Color.WhiteSmoke;
            page_Run.BorderStyle = BorderStyle.FixedSingle;
            page_Run.Controls.Add(RuningTimer);
            page_Run.Controls.Add(CalculateHCostMode);
            page_Run.Controls.Add(NeighborNode);
            page_Run.Controls.Add(RunSetting);
            page_Run.Controls.Add(btn_Run);
            page_Run.Location = new Point(4, 34);
            page_Run.Name = "page_Run";
            page_Run.Padding = new Padding(3);
            page_Run.Size = new Size(1206, 65);
            page_Run.TabIndex = 3;
            page_Run.Text = "运行";
            // 
            // RuningTimer
            // 
            RuningTimer.BorderStyle = BorderStyle.FixedSingle;
            RuningTimer.Controls.Add(labelTimer);
            RuningTimer.Controls.Add(RuningTimer_Title);
            RuningTimer.Location = new Point(877, 2);
            RuningTimer.Name = "RuningTimer";
            RuningTimer.Size = new Size(180, 59);
            RuningTimer.TabIndex = 14;
            // 
            // labelTimer
            // 
            labelTimer.Dock = DockStyle.Fill;
            labelTimer.Font = new Font("Courier New", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimer.Location = new Point(0, 23);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(178, 34);
            labelTimer.TabIndex = 1;
            labelTimer.Text = "00:000s";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RuningTimer_Title
            // 
            RuningTimer_Title.BackColor = Color.FromArgb(209, 209, 223);
            RuningTimer_Title.Controls.Add(blinkingDot);
            RuningTimer_Title.Controls.Add(RuningTimer_Title_Text);
            RuningTimer_Title.Dock = DockStyle.Top;
            RuningTimer_Title.Location = new Point(0, 0);
            RuningTimer_Title.Name = "RuningTimer_Title";
            RuningTimer_Title.Size = new Size(178, 23);
            RuningTimer_Title.TabIndex = 0;
            // 
            // blinkingDot
            // 
            blinkingDot.BlinkInterval = 800;
            blinkingDot.DotColor = Color.FromArgb(140, 140, 174);
            blinkingDot.IsBlinking = false;
            blinkingDot.Location = new Point(158, 3);
            blinkingDot.Name = "blinkingDot";
            blinkingDot.Size = new Size(15, 15);
            blinkingDot.TabIndex = 5;
            // 
            // RuningTimer_Title_Text
            // 
            RuningTimer_Title_Text.AutoSize = true;
            RuningTimer_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RuningTimer_Title_Text.Location = new Point(3, 3);
            RuningTimer_Title_Text.Name = "RuningTimer_Title_Text";
            RuningTimer_Title_Text.Size = new Size(44, 17);
            RuningTimer_Title_Text.TabIndex = 0;
            RuningTimer_Title_Text.Text = "计时器";
            // 
            // CalculateHCostMode
            // 
            CalculateHCostMode.BorderStyle = BorderStyle.FixedSingle;
            CalculateHCostMode.Controls.Add(ModeAdaptive);
            CalculateHCostMode.Controls.Add(ModeImprovement1);
            CalculateHCostMode.Controls.Add(ModeC);
            CalculateHCostMode.Controls.Add(ModeE);
            CalculateHCostMode.Controls.Add(ModeM);
            CalculateHCostMode.Controls.Add(CalculateHCostMode_Title);
            CalculateHCostMode.Location = new Point(437, 2);
            CalculateHCostMode.Name = "CalculateHCostMode";
            CalculateHCostMode.Size = new Size(434, 59);
            CalculateHCostMode.TabIndex = 13;
            // 
            // ModeAdaptive
            // 
            ModeAdaptive.AutoSize = true;
            ModeAdaptive.Location = new Point(366, 30);
            ModeAdaptive.Name = "ModeAdaptive";
            ModeAdaptive.Size = new Size(62, 21);
            ModeAdaptive.TabIndex = 5;
            ModeAdaptive.TabStop = true;
            ModeAdaptive.Text = "自适应";
            ModeAdaptive.UseVisualStyleBackColor = true;
            ModeAdaptive.CheckedChanged += ModeAdaptive_CheckedChanged;
            // 
            // ModeImprovement1
            // 
            ModeImprovement1.AutoSize = true;
            ModeImprovement1.Location = new Point(303, 30);
            ModeImprovement1.Name = "ModeImprovement1";
            ModeImprovement1.Size = new Size(57, 21);
            ModeImprovement1.TabIndex = 4;
            ModeImprovement1.TabStop = true;
            ModeImprovement1.Text = "改进1";
            ModeImprovement1.UseVisualStyleBackColor = true;
            ModeImprovement1.CheckedChanged += ModeImprovement1_CheckedChanged;
            // 
            // ModeC
            // 
            ModeC.AutoSize = true;
            ModeC.Location = new Point(199, 30);
            ModeC.Name = "ModeC";
            ModeC.Size = new Size(98, 21);
            ModeC.TabIndex = 3;
            ModeC.TabStop = true;
            ModeC.Text = "切比雪夫距离";
            ModeC.UseVisualStyleBackColor = true;
            ModeC.CheckedChanged += ModeC_CheckedChanged;
            // 
            // ModeE
            // 
            ModeE.AutoSize = true;
            ModeE.Location = new Point(95, 30);
            ModeE.Name = "ModeE";
            ModeE.Size = new Size(98, 21);
            ModeE.TabIndex = 2;
            ModeE.TabStop = true;
            ModeE.Text = "欧几里得距离";
            ModeE.UseVisualStyleBackColor = true;
            ModeE.CheckedChanged += ModeE_CheckedChanged;
            // 
            // ModeM
            // 
            ModeM.AutoSize = true;
            ModeM.Location = new Point(3, 30);
            ModeM.Name = "ModeM";
            ModeM.Size = new Size(86, 21);
            ModeM.TabIndex = 1;
            ModeM.TabStop = true;
            ModeM.Text = "曼哈顿距离";
            ModeM.UseVisualStyleBackColor = true;
            ModeM.CheckedChanged += ModeM_CheckedChanged;
            // 
            // CalculateHCostMode_Title
            // 
            CalculateHCostMode_Title.BackColor = Color.FromArgb(209, 209, 223);
            CalculateHCostMode_Title.Controls.Add(CalculateHCostMode_Title_Text);
            CalculateHCostMode_Title.Dock = DockStyle.Top;
            CalculateHCostMode_Title.Location = new Point(0, 0);
            CalculateHCostMode_Title.Name = "CalculateHCostMode_Title";
            CalculateHCostMode_Title.Size = new Size(432, 23);
            CalculateHCostMode_Title.TabIndex = 0;
            // 
            // CalculateHCostMode_Title_Text
            // 
            CalculateHCostMode_Title_Text.AutoSize = true;
            CalculateHCostMode_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CalculateHCostMode_Title_Text.Location = new Point(3, 3);
            CalculateHCostMode_Title_Text.Name = "CalculateHCostMode_Title_Text";
            CalculateHCostMode_Title_Text.Size = new Size(92, 17);
            CalculateHCostMode_Title_Text.TabIndex = 0;
            CalculateHCostMode_Title_Text.Text = "启发式函数类型";
            // 
            // NeighborNode
            // 
            NeighborNode.BorderStyle = BorderStyle.FixedSingle;
            NeighborNode.Controls.Add(ModeLVD);
            NeighborNode.Controls.Add(ModeLV);
            NeighborNode.Controls.Add(NeighborNode_Title);
            NeighborNode.Location = new Point(206, 2);
            NeighborNode.Name = "NeighborNode";
            NeighborNode.Size = new Size(225, 59);
            NeighborNode.TabIndex = 12;
            // 
            // ModeLVD
            // 
            ModeLVD.AutoSize = true;
            ModeLVD.Location = new Point(92, 30);
            ModeLVD.Name = "ModeLVD";
            ModeLVD.Size = new Size(128, 21);
            ModeLVD.TabIndex = 2;
            ModeLVD.TabStop = true;
            ModeLVD.Text = "水平+垂直+对角线";
            ModeLVD.UseVisualStyleBackColor = true;
            ModeLVD.CheckedChanged += ModeLVD_CheckedChanged;
            // 
            // ModeLV
            // 
            ModeLV.AutoSize = true;
            ModeLV.Location = new Point(3, 30);
            ModeLV.Name = "ModeLV";
            ModeLV.Size = new Size(83, 21);
            ModeLV.TabIndex = 1;
            ModeLV.TabStop = true;
            ModeLV.Text = "水平+垂直";
            ModeLV.UseVisualStyleBackColor = true;
            ModeLV.CheckedChanged += ModeLV_CheckedChanged;
            // 
            // NeighborNode_Title
            // 
            NeighborNode_Title.BackColor = Color.FromArgb(209, 209, 223);
            NeighborNode_Title.Controls.Add(NeighborNode_Title_Text);
            NeighborNode_Title.Dock = DockStyle.Top;
            NeighborNode_Title.Location = new Point(0, 0);
            NeighborNode_Title.Name = "NeighborNode_Title";
            NeighborNode_Title.Size = new Size(223, 23);
            NeighborNode_Title.TabIndex = 0;
            // 
            // NeighborNode_Title_Text
            // 
            NeighborNode_Title_Text.AutoSize = true;
            NeighborNode_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            NeighborNode_Title_Text.Location = new Point(3, 3);
            NeighborNode_Title_Text.Name = "NeighborNode_Title_Text";
            NeighborNode_Title_Text.Size = new Size(114, 17);
            NeighborNode_Title_Text.TabIndex = 0;
            NeighborNode_Title_Text.Text = "相邻(候选)节点判定";
            // 
            // RunSetting
            // 
            RunSetting.BorderStyle = BorderStyle.FixedSingle;
            RunSetting.Controls.Add(label11);
            RunSetting.Controls.Add(RunSetting_Title);
            RunSetting.Controls.Add(RunSpeed);
            RunSetting.Location = new Point(78, 2);
            RunSetting.Name = "RunSetting";
            RunSetting.Size = new Size(122, 59);
            RunSetting.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 32);
            label11.Name = "label11";
            label11.Size = new Size(59, 17);
            label11.TabIndex = 3;
            label11.Text = "运行速度:";
            // 
            // RunSetting_Title
            // 
            RunSetting_Title.BackColor = Color.FromArgb(209, 209, 223);
            RunSetting_Title.Controls.Add(RunSetting_Title_Text);
            RunSetting_Title.Dock = DockStyle.Top;
            RunSetting_Title.Location = new Point(0, 0);
            RunSetting_Title.Name = "RunSetting_Title";
            RunSetting_Title.Size = new Size(120, 23);
            RunSetting_Title.TabIndex = 0;
            // 
            // RunSetting_Title_Text
            // 
            RunSetting_Title_Text.AutoSize = true;
            RunSetting_Title_Text.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunSetting_Title_Text.Location = new Point(3, 3);
            RunSetting_Title_Text.Name = "RunSetting_Title_Text";
            RunSetting_Title_Text.Size = new Size(56, 17);
            RunSetting_Title_Text.TabIndex = 0;
            RunSetting_Title_Text.Text = "运行速度";
            // 
            // RunSpeed
            // 
            RunSpeed.Location = new Point(68, 30);
            RunSpeed.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            RunSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RunSpeed.Name = "RunSpeed";
            RunSpeed.Size = new Size(48, 23);
            RunSpeed.TabIndex = 1;
            RunSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btn_Run
            // 
            btn_Run.FlatAppearance.BorderSize = 0;
            btn_Run.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Run.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_Run.FlatStyle = FlatStyle.Flat;
            btn_Run.Image = Properties.Resources.run;
            btn_Run.ImageAlign = ContentAlignment.TopCenter;
            btn_Run.Location = new Point(2, 2);
            btn_Run.Margin = new Padding(2);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(71, 59);
            btn_Run.TabIndex = 3;
            btn_Run.Text = "运行";
            btn_Run.TextAlign = ContentAlignment.BottomCenter;
            btn_Run.UseVisualStyleBackColor = true;
            btn_Run.Click += btn_Run_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(btn_Github);
            tabPage1.Controls.Add(btn_About);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1206, 65);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "帮助";
            // 
            // btn_Github
            // 
            btn_Github.FlatAppearance.BorderSize = 0;
            btn_Github.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_Github.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_Github.FlatStyle = FlatStyle.Flat;
            btn_Github.Image = Properties.Resources.website;
            btn_Github.ImageAlign = ContentAlignment.TopCenter;
            btn_Github.Location = new Point(77, 2);
            btn_Github.Margin = new Padding(2);
            btn_Github.Name = "btn_Github";
            btn_Github.Size = new Size(71, 59);
            btn_Github.TabIndex = 5;
            btn_Github.Text = "Github";
            btn_Github.TextAlign = ContentAlignment.BottomCenter;
            btn_Github.UseVisualStyleBackColor = true;
            btn_Github.Click += btn_Github_Click;
            // 
            // btn_About
            // 
            btn_About.FlatAppearance.BorderSize = 0;
            btn_About.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_About.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btn_About.FlatStyle = FlatStyle.Flat;
            btn_About.Image = Properties.Resources.info;
            btn_About.ImageAlign = ContentAlignment.TopCenter;
            btn_About.Location = new Point(2, 2);
            btn_About.Margin = new Padding(2);
            btn_About.Name = "btn_About";
            btn_About.Size = new Size(71, 59);
            btn_About.TabIndex = 4;
            btn_About.Text = "关于";
            btn_About.TextAlign = ContentAlignment.BottomCenter;
            btn_About.UseVisualStyleBackColor = true;
            btn_About.Click += btn_About_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 714);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1230, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(44, 17);
            toolStripStatusLabel1.Text = "就绪。";
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.BorderStyle = BorderStyle.FixedSingle;
            ContentPanel.Controls.Add(mapControl);
            ContentPanel.Location = new Point(12, 107);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1206, 603);
            ContentPanel.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // ForceRestartPanel
            // 
            ForceRestartPanel.BackColor = Color.Blue;
            ForceRestartPanel.Controls.Add(btnForceRestart);
            ForceRestartPanel.Location = new Point(1144, 4);
            ForceRestartPanel.Name = "ForceRestartPanel";
            ForceRestartPanel.Size = new Size(74, 32);
            ForceRestartPanel.TabIndex = 5;
            ForceRestartPanel.Visible = false;
            // 
            // btnForceRestart
            // 
            btnForceRestart.BackColor = SystemColors.Control;
            btnForceRestart.FlatStyle = FlatStyle.Popup;
            btnForceRestart.Location = new Point(3, 3);
            btnForceRestart.Name = "btnForceRestart";
            btnForceRestart.Size = new Size(68, 26);
            btnForceRestart.TabIndex = 0;
            btnForceRestart.Text = "重启程序";
            btnForceRestart.UseVisualStyleBackColor = false;
            btnForceRestart.Click += btnForceRestart_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 736);
            Controls.Add(ForceRestartPanel);
            Controls.Add(ContentPanel);
            Controls.Add(statusStrip);
            Controls.Add(tabControl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AStarMapDemo";
            Load += MainWindow_Load;
            Shown += MainWindow_Shown;
            tabControl.ResumeLayout(false);
            tab_Start.ResumeLayout(false);
            contextMenuStrip_re.ResumeLayout(false);
            tab_Map.ResumeLayout(false);
            MapEnd.ResumeLayout(false);
            MapEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapEndY).EndInit();
            MapEnd_Title.ResumeLayout(false);
            MapEnd_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapEndX).EndInit();
            MapStart.ResumeLayout(false);
            MapStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapStartY).EndInit();
            MapStart_Title.ResumeLayout(false);
            MapStart_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapStartX).EndInit();
            MapSetting.ResumeLayout(false);
            MapSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapH).EndInit();
            MapSetting_Title.ResumeLayout(false);
            MapSetting_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MapW).EndInit();
            page_Draw.ResumeLayout(false);
            DrawObstacleX.ResumeLayout(false);
            DrawObstacleX.PerformLayout();
            DrawObstacleX_Title.ResumeLayout(false);
            DrawObstacleX_Title.PerformLayout();
            DrawCongestedLevel.ResumeLayout(false);
            DrawCongestedLevel.PerformLayout();
            DrawCongestedLevel_Title.ResumeLayout(false);
            DrawCongestedLevel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrawCongestedLevelNum).EndInit();
            DrawCongestedSwitch.ResumeLayout(false);
            DrawCongestedSwitch.PerformLayout();
            DrawCongestedSwitch_TItle.ResumeLayout(false);
            DrawCongestedSwitch_TItle.PerformLayout();
            DrawObstacleSwitch.ResumeLayout(false);
            DrawObstacleSwitch.PerformLayout();
            DrawObstacleSwitch_Title.ResumeLayout(false);
            DrawObstacleSwitch_Title.PerformLayout();
            page_Run.ResumeLayout(false);
            RuningTimer.ResumeLayout(false);
            RuningTimer_Title.ResumeLayout(false);
            RuningTimer_Title.PerformLayout();
            CalculateHCostMode.ResumeLayout(false);
            CalculateHCostMode.PerformLayout();
            CalculateHCostMode_Title.ResumeLayout(false);
            CalculateHCostMode_Title.PerformLayout();
            NeighborNode.ResumeLayout(false);
            NeighborNode.PerformLayout();
            NeighborNode_Title.ResumeLayout(false);
            NeighborNode_Title.PerformLayout();
            RunSetting.ResumeLayout(false);
            RunSetting.PerformLayout();
            RunSetting_Title.ResumeLayout(false);
            RunSetting_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RunSpeed).EndInit();
            tabPage1.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ContentPanel.ResumeLayout(false);
            ForceRestartPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MapControl mapControl;
        private TabControl tabControl;
        private TabPage tab_Start;
        private TabPage tab_Map;
        private TabPage page_Draw;
        private TabPage page_Run;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btn_Open;
        private Button btn_Save;
        private Button btn_MapNew;
        private Panel MapSetting;
        private Panel MapSetting_Title;
        private Label MapSetting_Title_Text;
        private NumericUpDown MapW;
        private Panel ContentPanel;
        private NumericUpDown MapH;
        private Label label1;
        private Label label2;
        private Button btn_MapStart;
        private Panel MapStart;
        private Label label3;
        private NumericUpDown MapStartY;
        private Label label4;
        private Panel MapStart_Title;
        private Label MapStart_Title_Text;
        private NumericUpDown MapStartX;
        private Button btn_MapEnd;
        private Panel MapEnd;
        private Label label6;
        private NumericUpDown MapEndY;
        private Label label7;
        private Panel MapEnd_Title;
        private Label MapEnd_Title_Text;
        private NumericUpDown MapEndX;
        private Button btn_Restart;
        private Button btn_Exit;
        private TabPage tabPage1;
        private Button btn_DrawObstacle;
        private Panel DrawObstacleSwitch;
        private Label DrawObstacleSwitch_Show;
        private Panel DrawObstacleSwitch_Title;
        private Label DrawObstacleSwitch_Title_Text;
        private Button btn_DrawCongested;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel DrawCongestedLevel;
        private Label label12;
        private Panel DrawCongestedLevel_Title;
        private Label DrawCongestedLevel_Title_Text;
        private NumericUpDown DrawCongestedLevelNum;
        private Panel DrawCongestedSwitch;
        private Label DrawCongestedSwitch_Show;
        private Panel DrawCongestedSwitch_TItle;
        private Label DrawCongestedSwitch_TItle_Text;
        private Button btn_Run;
        private Panel RunSetting;
        private Label label11;
        private Panel RunSetting_Title;
        private Label RunSetting_Title_Text;
        private NumericUpDown RunSpeed;
        private Button btn_About;
        private Button btn_Github;
        private Panel panel1;
        private Panel panel2;
        private Button btn_MapReset;
        private Panel NeighborNode;
        private Panel NeighborNode_Title;
        private Label NeighborNode_Title_Text;
        private RadioButton ModeLV;
        private RadioButton ModeLVD;
        private ContextMenuStrip contextMenuStrip_re;
        private ToolStripMenuItem reloadCurrentMapData;
        private ToolStripMenuItem restartProgram;
        private Panel CalculateHCostMode;
        private RadioButton ModeE;
        private RadioButton ModeM;
        private Panel CalculateHCostMode_Title;
        private Label CalculateHCostMode_Title_Text;
        private RadioButton ModeC;
        private RadioButton ModeImprovement1;
        private RadioButton ModeAdaptive;
        private Panel RuningTimer;
        private Panel RuningTimer_Title;
        private Label RuningTimer_Title_Text;
        private Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private BlinkingDotControl blinkingDot;
        private Panel ForceRestartPanel;
        private Button btnForceRestart;
        private Panel DrawObstacleX;
        private Panel DrawObstacleX_Title;
        private Label DrawObstacleX_Title_Text;
        private CheckBox SwitchDrawObstacleX;
    }
}