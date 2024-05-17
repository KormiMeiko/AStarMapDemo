namespace AStarMapDemo
{
    partial class MainForm
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
            buttonDrawObstacle = new Button();
            buttonDrawCongestedRoad = new Button();
            buttonSetMapSize = new Button();
            mapControl1 = new MapControl();
            textBoxCongestionLevel = new TextBox();
            buttonSetStartPoint = new Button();
            buttonSetEndPoint = new Button();
            textBoxMapWidth = new TextBox();
            textBoxMapHeight = new TextBox();
            textBoxStartX = new TextBox();
            textBoxStartY = new TextBox();
            textBoxEndX = new TextBox();
            textBoxEndY = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // buttonDrawObstacle
            // 
            buttonDrawObstacle.Location = new Point(12, 677);
            buttonDrawObstacle.Name = "buttonDrawObstacle";
            buttonDrawObstacle.Size = new Size(169, 23);
            buttonDrawObstacle.TabIndex = 0;
            buttonDrawObstacle.Text = "buttonDrawObstacle";
            buttonDrawObstacle.UseVisualStyleBackColor = true;
            buttonDrawObstacle.Click += buttonDrawObstacle_Click;
            // 
            // buttonDrawCongestedRoad
            // 
            buttonDrawCongestedRoad.Location = new Point(187, 677);
            buttonDrawCongestedRoad.Name = "buttonDrawCongestedRoad";
            buttonDrawCongestedRoad.Size = new Size(169, 23);
            buttonDrawCongestedRoad.TabIndex = 1;
            buttonDrawCongestedRoad.Text = "buttonDrawCongestedRoad";
            buttonDrawCongestedRoad.UseVisualStyleBackColor = true;
            buttonDrawCongestedRoad.Click += buttonDrawCongestedRoad_Click;
            // 
            // buttonSetMapSize
            // 
            buttonSetMapSize.Location = new Point(362, 677);
            buttonSetMapSize.Name = "buttonSetMapSize";
            buttonSetMapSize.Size = new Size(169, 23);
            buttonSetMapSize.TabIndex = 3;
            buttonSetMapSize.Text = "buttonSetMapSize";
            buttonSetMapSize.UseVisualStyleBackColor = true;
            buttonSetMapSize.Click += buttonSetMapSize_Click;
            // 
            // mapControl1
            // 
            mapControl1.Location = new Point(12, 12);
            mapControl1.Name = "mapControl1";
            mapControl1.Size = new Size(1176, 630);
            mapControl1.TabIndex = 4;
            mapControl1.MouseClick += mapControl1_MouseClick;
            // 
            // textBoxCongestionLevel
            // 
            textBoxCongestionLevel.Location = new Point(187, 648);
            textBoxCongestionLevel.Name = "textBoxCongestionLevel";
            textBoxCongestionLevel.Size = new Size(100, 23);
            textBoxCongestionLevel.TabIndex = 5;
            // 
            // buttonSetStartPoint
            // 
            buttonSetStartPoint.Location = new Point(537, 677);
            buttonSetStartPoint.Name = "buttonSetStartPoint";
            buttonSetStartPoint.Size = new Size(169, 23);
            buttonSetStartPoint.TabIndex = 6;
            buttonSetStartPoint.Text = "buttonSetStartPoint";
            buttonSetStartPoint.UseVisualStyleBackColor = true;
            buttonSetStartPoint.Click += buttonSetStartPoint_Click;
            // 
            // buttonSetEndPoint
            // 
            buttonSetEndPoint.Location = new Point(712, 677);
            buttonSetEndPoint.Name = "buttonSetEndPoint";
            buttonSetEndPoint.Size = new Size(169, 23);
            buttonSetEndPoint.TabIndex = 7;
            buttonSetEndPoint.Text = "buttonSetEndPoint";
            buttonSetEndPoint.UseVisualStyleBackColor = true;
            buttonSetEndPoint.Click += buttonSetEndPoint_Click;
            // 
            // textBoxMapWidth
            // 
            textBoxMapWidth.Location = new Point(362, 648);
            textBoxMapWidth.Name = "textBoxMapWidth";
            textBoxMapWidth.Size = new Size(48, 23);
            textBoxMapWidth.TabIndex = 8;
            // 
            // textBoxMapHeight
            // 
            textBoxMapHeight.Location = new Point(416, 648);
            textBoxMapHeight.Name = "textBoxMapHeight";
            textBoxMapHeight.Size = new Size(48, 23);
            textBoxMapHeight.TabIndex = 9;
            // 
            // textBoxStartX
            // 
            textBoxStartX.Location = new Point(537, 648);
            textBoxStartX.Name = "textBoxStartX";
            textBoxStartX.Size = new Size(48, 23);
            textBoxStartX.TabIndex = 11;
            // 
            // textBoxStartY
            // 
            textBoxStartY.Location = new Point(591, 648);
            textBoxStartY.Name = "textBoxStartY";
            textBoxStartY.Size = new Size(48, 23);
            textBoxStartY.TabIndex = 10;
            // 
            // textBoxEndX
            // 
            textBoxEndX.Location = new Point(712, 648);
            textBoxEndX.Name = "textBoxEndX";
            textBoxEndX.Size = new Size(48, 23);
            textBoxEndX.TabIndex = 13;
            // 
            // textBoxEndY
            // 
            textBoxEndY.Location = new Point(766, 648);
            textBoxEndY.Name = "textBoxEndY";
            textBoxEndY.Size = new Size(48, 23);
            textBoxEndY.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(906, 645);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(887, 677);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(977, 677);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(84, 23);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1104, 677);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(84, 23);
            btnFind.TabIndex = 17;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 712);
            Controls.Add(btnFind);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(textBoxEndX);
            Controls.Add(textBoxEndY);
            Controls.Add(textBoxStartX);
            Controls.Add(textBoxStartY);
            Controls.Add(textBoxMapHeight);
            Controls.Add(textBoxMapWidth);
            Controls.Add(buttonSetEndPoint);
            Controls.Add(buttonSetStartPoint);
            Controls.Add(textBoxCongestionLevel);
            Controls.Add(mapControl1);
            Controls.Add(buttonSetMapSize);
            Controls.Add(buttonDrawCongestedRoad);
            Controls.Add(buttonDrawObstacle);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDrawObstacle;
        private Button buttonDrawCongestedRoad;
        private Button buttonSetMapSize;
        private MapControl mapControl1;
        private TextBox textBoxCongestionLevel;
        private Button buttonSetStartPoint;
        private Button buttonSetEndPoint;
        private TextBox textBoxMapWidth;
        private TextBox textBoxMapHeight;
        private TextBox textBoxStartX;
        private TextBox textBoxStartY;
        private TextBox textBoxEndX;
        private TextBox textBoxEndY;
        private Label label1;
        private Button btnSave;
        private Button btnLoad;
        private Button btnFind;
    }
}