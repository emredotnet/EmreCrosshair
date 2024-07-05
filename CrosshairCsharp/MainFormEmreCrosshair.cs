using System;
using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;

namespace CrosshairCsharp
{
    public partial class MainFormEmreCrosshair : Form
    {
        private Color renk = Color.Red; // Default crosshair color
        int border, size, gap, kalinlik; // Crosshair parameters
        double opaklik; // Crosshair opacity
        byte R, G, B; // RGB values for custom color
        bool top = true, bottom = true, right = true, left = true;
        public MainFormEmreCrosshair()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Determines the color of the crosshair based on the selected radio button.
        /// </summary>
        /// <returns>True if a color is selected.</returns>
        private bool radiocheck()
        {
            if (radioButton1.Checked) { renk = Color.Red; }
            else if (radioButton2.Checked) { renk = Color.Lime; }
            else if (radioButton3.Checked) { renk = Color.Black; }
            else if (radioButton4.Checked) { renk = Color.SpringGreen; }
            else if (radioButton5.Checked)
            {
                R = Convert.ToByte(rgbtrackR.Value);
                G = Convert.ToByte(rgbtrackG.Value);
                B = Convert.ToByte(rgbtrackB.Value);
                renk = Color.FromArgb(255, R, G, B);
            }

            return true;
        }

        /// <summary>
        /// Handles the start button click event to create and display the crosshair form.
        /// </summary>
        private void startbutton_Click(object sender, EventArgs e)
        {
            if (radiocheck())
            {
                size = uzunluktrack.Value;
                gap = gaptrack.Value;
                kalinlik = kalinliktrack.Value;
                opaklik = opaktrack.Value / 100.0;
                if (bordercheck.Checked) { border = bordertrack.Value; }
                else border = 0;

                EmreCrosshair crosshairform = new EmreCrosshair(size, gap, kalinlik, renk, border, opaklik,top,bottom,left,right);
                crosshairform.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Updates the crosshair preview in the panel based on the current settings.
        /// </summary>
        private void crossguncelle()
        {
            if (radiocheck())
            {
                size = uzunluktrack.Value;
                gap = gaptrack.Value;
                kalinlik = kalinliktrack.Value;
                opaklik = opaktrack.Value / 100.0;
                if (bordercheck.Checked) { border = bordertrack.Value; }
                else border = 0;

                // Clear and redraw the panel
                crosshairpanel1.Paint -= CrosshairPanel_Paint;
                crosshairpanel1.Paint += (s, pe) => DrawCrosshair(pe.Graphics, size, gap, kalinlik, renk, border);
                crosshairpanel1.Invalidate(); // Invalidate panel to redraw
            }
        }

        /// <summary>
        /// Shows the main menu form and hides any open crosshair forms.
        /// </summary>
        private void menu()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is EmreCrosshair)
                {
                    form.Hide();
                }
            }
            this.Show();
        }

        bool crosslineselect(Control p2)
        {
            if (p2.BackColor == Color.Lime)
            {
                p2.BackColor = Color.Red;
                return false;
            }
            else p2.BackColor = Color.Lime; return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            menu();
            ShowInTaskbar = true;
        }

        private void crosshairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu();
            ShowInTaskbar = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            rgbtrackR.Enabled = radioButton5.Checked;
            rgbtrackG.Enabled = radioButton5.Checked;
            rgbtrackB.Enabled = radioButton5.Checked;
            crossguncelle();
        }

        private void bordercheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bordercheck.Checked)
            {
                bordertrack.Enabled = true;
            }
            else bordertrack.Enabled = false;
            crossguncelle();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sizelabel.Text = uzunluktrack.Value.ToString();
            crossguncelle();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            gaplabel.Text = gaptrack.Value.ToString();
            crossguncelle();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            kalinliklabel.Text = kalinliktrack.Value.ToString();
            crossguncelle();
        }

        private void rgbtrackR_Scroll(object sender, EventArgs e)
        {
            labelRed.Text = rgbtrackR.Value.ToString();
            crossguncelle();
        }

        private void bordertrack_Scroll(object sender, EventArgs e)
        {
            borderlabel.Text = bordertrack.Value.ToString();
            crossguncelle();
        }

        private void opaktrack_Scroll(object sender, EventArgs e)
        {
            opaklabel.Text = opaktrack.Value.ToString();
        }

        private void rgbtrackG_Scroll(object sender, EventArgs e)
        {
            labelGreen.Text = rgbtrackG.Value.ToString();
            crossguncelle();
        }

        private void rgbtrackB_Scroll(object sender, EventArgs e)
        {
            labelBlue.Text = rgbtrackB.Value.ToString();
            crossguncelle();
        }

        private void MainFormEmreCrosshair_Load(object sender, EventArgs e)
        {
            sizelabel.Text = uzunluktrack.Value.ToString();
            gaplabel.Text = gaptrack.Value.ToString();
            kalinliklabel.Text = kalinliktrack.Value.ToString();
            borderlabel.Text = bordertrack.Value.ToString();
            opaklabel.Text = opaktrack.Value.ToString();
            crossguncelle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            crossguncelle();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            crossguncelle();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            crossguncelle();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            crossguncelle();
        }

        private void CrosshairPanel_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder for custom paint logic (currently not used)
        }

        /// <summary>
        /// Draws the crosshair on the specified graphics object.
        /// </summary>
        /// <param name="g">The graphics object to draw on.</param>
        /// <param name="size">The length of each crosshair line.</param>
        /// <param name="gap">The gap between the center and the start of the lines.</param>
        /// <param name="kalinlik">The thickness of the lines.</param>
        /// <param name="renk">The color of the crosshair.</param>
        /// <param name="border">The thickness of the border around the crosshair.</param>
        private void DrawCrosshair(Graphics g, int size, int gap, int kalinlik, Color renk, int border)
        {
            g.Clear(crosshairpanel1.BackColor); // Clear previous drawings

            Pen pen = new Pen(renk, kalinlik)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Center
            };

            // Create a black pen for the crosshair border
            Pen borderPen = new Pen(Color.Black, kalinlik + border)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Center
            };

            int centerX = crosshairpanel1.Width / 2;
            int centerY = crosshairpanel1.Height / 2;

            if (border != 0)
            {
                // Draw horizontal lines (border)
                if (lbutton.BackColor == Color.Lime) g.DrawLine(borderPen, centerX - size - gap - border / 2, centerY, centerX - gap + border / 2, centerY); // Left horizontal line (border)
                if (rbutton.BackColor == Color.Lime) g.DrawLine(borderPen, centerX + gap - border / 2, centerY, centerX + size + gap + border / 2, centerY); // Right horizontal line (border)

                // Draw vertical lines (border)
                if (topbutton.BackColor == Color.Lime) g.DrawLine(borderPen, centerX, centerY - size - gap - border / 2, centerX, centerY - gap + border / 2); // Top vertical line (border)
                if (bottombutton.BackColor == Color.Lime) g.DrawLine(borderPen, centerX, centerY + gap - border / 2, centerX, centerY + size + gap + border / 2); // Bottom vertical line (border)
            }

            // Draw crosshair
            if (lbutton.BackColor == Color.Lime) g.DrawLine(pen, centerX - size - gap, centerY, centerX - gap, centerY); // Left horizontal line
            if (rbutton.BackColor == Color.Lime) g.DrawLine(pen, centerX + gap, centerY, centerX + size + gap, centerY); // Right horizontal line
            if (topbutton.BackColor == Color.Lime) g.DrawLine(pen, centerX, centerY - size - gap, centerX, centerY - gap); // Top vertical line
            if (bottombutton.BackColor == Color.Lime) g.DrawLine(pen, centerX, centerY + gap, centerX, centerY + size + gap); // Bottom vertical line
        }

        private void lgbutton_Click(object sender, EventArgs e)
        {
            if (lgbutton.Text == "Türkçe")
            {
                lgbutton.Text = "English";
                ColorGB.Text = "Renk";
                startbutton.Text = "Baþlat";
                radioButton1.Text = "Kýrmýzý";
                radioButton2.Text = "Yeþil";
                radioButton3.Text = "Siyah";
                radioButton4.Text = "Spring Yeþil";
                bordercheck.Text = "Dýþ Çizgi Kalýnlýðý (4 Önerilir)";
                label1.Text = "Uzunluk";
                label2.Text = "Boþluk";
                label3.Text = "Kalýnlýk";
                label4.Text = "Opaklýk";
                label5.Text = "Kýrmýzý";
                label6.Text = "Yeþil";
                label7.Text = "Mavi";
            }
            else
            {
                lgbutton.Text = "Türkçe";
                ColorGB.Text = "Color";
                startbutton.Text = "Start";
                radioButton1.Text = "Red";
                radioButton2.Text = "Green";
                radioButton3.Text = "Black";
                radioButton4.Text = "Spring Green";
                bordercheck.Text = "Border Scale (4 Recommended)";
                label1.Text = "Length";
                label2.Text = "Offset";
                label3.Text = "Thickness";
                label4.Text = "Opacity";
                label5.Text = "Red";
                label6.Text = "Green";
                label7.Text = "Blue";
            }
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            top = crosslineselect(topbutton);
            crossguncelle();
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            bottom = crosslineselect(bottombutton);
            crossguncelle();
        }

        private void lbutton_Click(object sender, EventArgs e)
        {
            left = crosslineselect(lbutton);
            crossguncelle();
        }

        private void rbutton_Click(object sender, EventArgs e)
        {
            right = crosslineselect(rbutton);
            crossguncelle();
        }
    }
}
