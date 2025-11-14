using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Suporte
{
    public partial class MessageBubble : UserControl
    {
        private Label lblText;
        private bool isUser;

        public MessageBubble(string text, bool isUserMessage, DateTime? time = null)
        {
            this.isUser = isUserMessage;
            InitializeComponents();
            SetMessage(text, time);
        }

        private void InitializeComponents()
        {
            this.lblText = new Label();
            this.SuspendLayout();

            // Configuração da Label do texto
            lblText.AutoSize = true;
            lblText.MaximumSize = new Size(400, 0); // largura máxima do texto antes de quebrar linha
            lblText.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblText.Padding = new Padding(10);
            lblText.Margin = new Padding(0);
            lblText.BackColor = Color.Transparent;

            this.Controls.Add(lblText);

            // Configurações do balão
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Padding = new Padding(8);
            this.Margin = new Padding(0);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void SetMessage(string text, DateTime? time = null)
        {
            string withTime = text;
            if (time.HasValue)
                withTime += $"\n\n{time.Value:HH:mm}";

            lblText.Text = withTime;
            lblText.TextAlign = isUser ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
            lblText.ForeColor = Color.Black;

            Invalidate(); // força redesenho
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            int radius = 12;

            using (GraphicsPath path = RoundedRect(rect, radius))
            {
                Color fill = isUser ? Color.FromArgb(220, 248, 198) : Color.FromArgb(240, 240, 240);
                using (SolidBrush brush = new SolidBrush(fill))
                    g.FillPath(brush, path);

                using (Pen pen = new Pen(Color.FromArgb(200, 200, 200)))
                    g.DrawPath(pen, path);
            }
        }

        private GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(r.Left, r.Top, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Top, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.Left, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}