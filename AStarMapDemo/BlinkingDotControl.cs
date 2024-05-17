using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AStarMapDemo
{
    public class BlinkingDotControl : Control
    {
        private Color dotColor = Color.Red;
        private int blinkInterval = 500; // 默认闪烁频率为500毫秒
        private bool isBlinking = false;
        private System.Timers.Timer blinkTimer;

        public Color DotColor
        {
            get { return dotColor; }
            set
            {
                dotColor = value;
                Invalidate(); // 重新绘制控件
            }
        }

        public int BlinkInterval
        {
            get { return blinkInterval; }
            set
            {
                blinkInterval = value;
                if (isBlinking)
                {
                    blinkTimer.Interval = blinkInterval;
                }
            }
        }

        public bool IsBlinking
        {
            get { return isBlinking; }
            set
            {
                isBlinking = value;
                if (isBlinking)
                {
                    StartBlink();
                }
                else
                {
                    StopBlink();
                }
            }
        }

        public BlinkingDotControl()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();

            blinkTimer = new System.Timers.Timer(blinkInterval);
            blinkTimer.Elapsed += BlinkTimer_Elapsed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 绘制圆点
            using (SolidBrush brush = new SolidBrush(dotColor))
            {
                int diameter = Math.Min(ClientSize.Width, ClientSize.Height);
                e.Graphics.FillEllipse(brush, 0, 0, diameter, diameter);
            }
        }

        private void BlinkTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 切换显示状态
            this.Invoke((Action)delegate
            {
                this.Visible = !this.Visible;
            });
        }

        private void StartBlink()
        {
            blinkTimer.Interval = blinkInterval;
            blinkTimer.Start();
            this.Visible = true;
        }

        private void StopBlink()
        {
            blinkTimer.Stop();
            this.Visible = true; // Ensure the dot is visible when blinking stops
        }
    }
}
