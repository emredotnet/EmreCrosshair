using System;
using System.IO;
using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;
using System.Configuration;

namespace CrosshairCsharp
{
    public partial class MainFormEmreCrosshair : Form
    {
        private Color renk = Color.Red; // Default crosshair color
        int border, size, gap, kalinlik; // Crosshair parameters
        double opaklik; // Crosshair opacity
        byte R, G, B; // RGB values for custom color
        bool top = true, bottom = true, right = true, left = true, borderc = false;
        private string appDataPath;
        private string configPath;
        public MainFormEmreCrosshair()
        {
            InitializeComponent();
            crosshairpanel1.GetType().InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic,
            null, crosshairpanel1, new object[] { true });

            crosshairpanel1.Paint += CrosshairPanel_Paint;

            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmreCrosshair");
            configPath = Path.Combine(appDataPath, "Cross.config");

            // Klasör yoksa oluþtur
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            // Config dosyasý yoksa oluþtur
            if (!File.Exists(configPath))
            {
                CreateDefaultConfig();
            }

        }

        /// <summary>
        /// Determines the color of the crosshair based on the selected radio button.
        /// </summary>
        /// <returns>True if a color is selected.</returns>
        private bool colorcheck()
        {
            R = Convert.ToByte(rgbtrackR.Value);
            G = Convert.ToByte(rgbtrackG.Value);
            B = Convert.ToByte(rgbtrackB.Value);
            renk = Color.FromArgb(255, R, G, B);
            return true;
        }

        /// <summary>
        /// Handles the start button click event to create and display the crosshair form.
        /// </summary>
        private void startbutton_Click(object sender, EventArgs e)
        {
            if (colorcheck())
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
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmreCrosshair");
            configPath = Path.Combine(appDataPath, "Cross.config");
            try
            {
                if (File.Exists(configPath))
                {
                    SaveConfig();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            if (colorcheck())
            {
                size = uzunluktrack.Value;
                gap = gaptrack.Value;
                kalinlik = kalinliktrack.Value;
                opaklik = opaktrack.Value / 100.0;
                if (bordercheck.Checked) { border = bordertrack.Value; }
                else border = 0;
                crosshairpanel1.Invalidate();
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
            
            try
            {
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configPath };
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

                int red = int.Parse(config.AppSettings.Settings["CrosshairColorR"].Value);
                int green = int.Parse(config.AppSettings.Settings["CrosshairColorG"].Value);
                int blue = int.Parse(config.AppSettings.Settings["CrosshairColorB"].Value);
                renk = Color.FromArgb(255, red, green, blue);

                size = int.Parse(config.AppSettings.Settings["Size"].Value);
                gap = int.Parse(config.AppSettings.Settings["Gap"].Value);
                kalinlik = int.Parse(config.AppSettings.Settings["Thickness"].Value);
                opaklik = double.Parse(config.AppSettings.Settings["Opacity"].Value);
                border = int.Parse(config.AppSettings.Settings["Border"].Value);
                top = bool.Parse(config.AppSettings.Settings["Top"].Value);
                bottom = bool.Parse(config.AppSettings.Settings["Bottom"].Value);
                right = bool.Parse(config.AppSettings.Settings["Right"].Value);
                left = bool.Parse(config.AppSettings.Settings["Left"].Value);
                borderc = bool.Parse(config.AppSettings.Settings["BorderC"].Value);
                string lg = config.AppSettings.Settings["LG"].Value;
                LGCHANGE(lg);

                uzunluktrack.Value = size;
                gaptrack.Value = gap;
                kalinliktrack.Value = kalinlik;
                rgbtrackR.Value = red;
                rgbtrackG.Value = green;
                rgbtrackB.Value = blue;
                opaktrack.Value = Convert.ToInt32(opaklik * 100.0);
                bordertrack.Value = border;

                topbutton.BackColor = top ? Color.Lime : Color.Red;
                bottombutton.BackColor = bottom ? Color.Lime : Color.Red;
                rbutton.BackColor = right ? Color.Lime : Color.Red;
                lbutton.BackColor = left ? Color.Lime : Color.Red;
                bordercheck.Checked = borderc ? true : false;
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            crossguncelle();
            sizelabel.Text = uzunluktrack.Value.ToString();
            gaplabel.Text = gaptrack.Value.ToString();
            kalinliklabel.Text = kalinliktrack.Value.ToString();
            borderlabel.Text = bordertrack.Value.ToString();
            opaklabel.Text = opaktrack.Value.ToString();
            labelRed.Text = rgbtrackR.Value.ToString();
            labelGreen.Text = rgbtrackG.Value.ToString();
            labelBlue.Text = rgbtrackB.Value.ToString();
            
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
            DrawCrosshair(e.Graphics, size, gap, kalinlik, renk, border);
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
            //g.Clear(crosshairpanel1.BackColor); // Clear previous drawings

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
                bordercheck.Text = "Border Scale (4 Recommended)";
                label1.Text = "Length";
                label2.Text = "Offset";
                label3.Text = "Thickness";
                label4.Text = "Opacity";
                label5.Text = "Red";
                label6.Text = "Green";
                label7.Text = "Blue";
            }
            SaveConfig();
        }

        void LGCHANGE(string e)
        {
            if (e == "English")
            {
                lgbutton.Text = "English";
                ColorGB.Text = "Renk";
                startbutton.Text = "Baþlat";
                bordercheck.Text = "Dýþ Çizgi Kalýnlýðý (4 Önerilir)";
                label1.Text = "Uzunluk";
                label2.Text = "Boþluk";
                label3.Text = "Kalýnlýk";
                label4.Text = "Opaklýk";
                label5.Text = "Kýrmýzý";
                label6.Text = "Yeþil";
                label7.Text = "Mavi";
            }
            else if (e == "Türkçe")
            {
                lgbutton.Text = "Türkçe";
                ColorGB.Text = "Color";
                startbutton.Text = "Start";
                bordercheck.Text = "Border Scale (4 Recommended)";
                label1.Text = "Length";
                label2.Text = "Offset";
                label3.Text = "Thickness";
                label4.Text = "Opacity";
                label5.Text = "Red";
                label6.Text = "Green";
                label7.Text = "Blue";
            }
            SaveConfig();
        }

        private void CreateDefaultConfig()
        {
            
            var configContent = @"
                <configuration>
                    <appSettings>
                        <add key='CrosshairColorR' value='255'/>
                        <add key='CrosshairColorG' value='0'/>
                        <add key='CrosshairColorB' value='0'/>
                        <add key='Size' value='4'/>
                        <add key='Gap' value='0'/>
                        <add key='Thickness' value='2'/>
                        <add key='Opacity' value='1,0'/>
                        <add key='Border' value='4'/>
                        <add key='Top' value='true'/>
                        <add key='Bottom' value='true'/>
                        <add key='Right' value='true'/>
                        <add key='Left' value='true'/>
                        <add key='BorderC' value='false'/>
                        <add key='LG' value='Türkçe'/>
                    </appSettings>
                </configuration>";

            File.WriteAllText(configPath, configContent);
        }

        private void SaveConfig()
        {
            try
            {
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configPath };
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

                config.AppSettings.Settings["CrosshairColorR"].Value = renk.R.ToString();
                config.AppSettings.Settings["CrosshairColorG"].Value = renk.G.ToString();
                config.AppSettings.Settings["CrosshairColorB"].Value = renk.B.ToString();
                config.AppSettings.Settings["Size"].Value = uzunluktrack.Value.ToString();
                config.AppSettings.Settings["Gap"].Value = gaptrack.Value.ToString();
                config.AppSettings.Settings["Thickness"].Value = kalinliktrack.Value.ToString();
                config.AppSettings.Settings["Opacity"].Value = (opaktrack.Value / 100.0).ToString();  // Opaklýk 0-1 arasý olmalý
                config.AppSettings.Settings["Border"].Value = bordertrack.Value.ToString();
                config.AppSettings.Settings["Top"].Value = top.ToString();
                config.AppSettings.Settings["Bottom"].Value = bottom.ToString();
                config.AppSettings.Settings["Right"].Value = right.ToString();
                config.AppSettings.Settings["Left"].Value = left.ToString();
                config.AppSettings.Settings["BorderC"].Value = bordercheck.Checked.ToString();
                config.AppSettings.Settings["LG"].Value = lgbutton.Text;

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
