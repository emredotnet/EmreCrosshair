using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CrosshairCsharp
{
    public partial class EmreCrosshair : Form
    {
        int crosshairSize, gap, crosshair_kalinlik, border_kalinlik; // Crosshair parameters
        bool top,bottom,left,right;
        Color renk; // Crosshair color

        public EmreCrosshair(int size, int gap1, int kalinlik, Color renk, int border, double opaklik, bool t , bool b , bool l , bool r)
        {
            InitializeComponent();
            crosshairSize = size;
            gap = gap1;
            crosshair_kalinlik = kalinlik;
            border_kalinlik = border;
            top = t; bottom=b; left = l; right = r;
            this.Opacity = opaklik;
            this.renk = renk;
            InitializeOverlay();
        }

        /// <summary>
        /// Initializes the overlay properties of the form.
        /// </summary>
        private void InitializeOverlay()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = false;
            TransparencyKey = BackColor;

            MakeFormClickThrough();
        }

        /// <summary>
        /// Overrides the CreateParams property to set the form as a tool window.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80; // WS_EX_TOOLWINDOW
                return cp;
            }
        }

        /// <summary>
        /// Handles the paint event to draw the crosshair.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Create a black pen for the crosshair border
            Pen borderPen = new Pen(Color.Black, crosshair_kalinlik + border_kalinlik)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Center
            };

            // Create the pen for the crosshair
            Pen pen = new Pen(renk, crosshair_kalinlik)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Center
            };

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            if (border_kalinlik != 0)
            {
                // Draw horizontal lines (border)
                if (left) g.DrawLine(borderPen, centerX - crosshairSize - gap - border_kalinlik / 2, centerY, centerX - gap + border_kalinlik / 2, centerY); // Left horizontal line (border)
                if (right) g.DrawLine(borderPen, centerX + gap - border_kalinlik / 2, centerY, centerX + crosshairSize + gap + border_kalinlik / 2, centerY); // Right horizontal line (border)

                // Draw vertical lines (border)
                if (top) g.DrawLine(borderPen, centerX, centerY - crosshairSize - gap - border_kalinlik / 2, centerX, centerY - gap + border_kalinlik / 2); // Top vertical line (border)
                if (bottom) g.DrawLine(borderPen, centerX, centerY + gap - border_kalinlik / 2, centerX, centerY + crosshairSize + gap + border_kalinlik / 2); // Bottom vertical line (border)
            }

            // Draw crosshair
            if (left) g.DrawLine(pen, centerX - crosshairSize - gap, centerY, centerX - gap, centerY); // Left horizontal line
            if (right) g.DrawLine(pen, centerX + gap, centerY, centerX + crosshairSize + gap, centerY); // Right horizontal line

            if (top) g.DrawLine(pen, centerX, centerY - crosshairSize - gap, centerX, centerY - gap); // Top vertical line
            if (bottom) g.DrawLine(pen, centerX, centerY + gap, centerX, centerY + crosshairSize + gap); // Bottom vertical line
        }

        /// <summary>
        /// Makes the form click-through by setting appropriate window styles.
        /// </summary>
        private void MakeFormClickThrough()
        {
            int initialStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, initialStyle | WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x00000020;
        private const int WS_EX_LAYERED = 0x00080000;
    }
}
