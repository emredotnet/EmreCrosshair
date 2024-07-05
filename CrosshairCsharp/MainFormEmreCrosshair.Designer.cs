namespace CrosshairCsharp
{
    partial class MainFormEmreCrosshair
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormEmreCrosshair));
            startbutton = new Button();
            uzunluktrack = new TrackBar();
            label1 = new Label();
            emrelabel = new Label();
            sizelabel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            ColorGB = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            labelBlue = new Label();
            labelGreen = new Label();
            labelRed = new Label();
            rgbtrackG = new TrackBar();
            rgbtrackB = new TrackBar();
            rgbtrackR = new TrackBar();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            notifyIcon1 = new NotifyIcon(components);
            Menu = new ContextMenuStrip(components);
            crosshairToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            gaplabel = new Label();
            gaptrack = new TrackBar();
            label3 = new Label();
            kalinliklabel = new Label();
            kalinliktrack = new TrackBar();
            CrosshairGB = new GroupBox();
            rbutton = new Button();
            lbutton = new Button();
            bottombutton = new Button();
            topbutton = new Button();
            lgbutton = new Button();
            label4 = new Label();
            opaklabel = new Label();
            borderlabel = new Label();
            opaktrack = new TrackBar();
            bordercheck = new CheckBox();
            bordertrack = new TrackBar();
            crosshairpanel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)uzunluktrack).BeginInit();
            ColorGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rgbtrackG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rgbtrackB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rgbtrackR).BeginInit();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gaptrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kalinliktrack).BeginInit();
            CrosshairGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)opaktrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bordertrack).BeginInit();
            SuspendLayout();
            // 
            // startbutton
            // 
            startbutton.Location = new Point(731, 189);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(121, 32);
            startbutton.TabIndex = 0;
            startbutton.Text = "Start";
            startbutton.UseVisualStyleBackColor = true;
            startbutton.Click += startbutton_Click;
            // 
            // uzunluktrack
            // 
            uzunluktrack.Location = new Point(47, 42);
            uzunluktrack.Maximum = 100;
            uzunluktrack.Minimum = 1;
            uzunluktrack.Name = "uzunluktrack";
            uzunluktrack.Size = new Size(349, 45);
            uzunluktrack.TabIndex = 1;
            uzunluktrack.Value = 5;
            uzunluktrack.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Length";
            // 
            // emrelabel
            // 
            emrelabel.AutoSize = true;
            emrelabel.Location = new Point(689, 171);
            emrelabel.Name = "emrelabel";
            emrelabel.Size = new Size(83, 15);
            emrelabel.TabIndex = 3;
            emrelabel.Text = "EmreCrosshair";
            // 
            // sizelabel
            // 
            sizelabel.AutoSize = true;
            sizelabel.Font = new Font("Segoe UI", 12F);
            sizelabel.Location = new Point(13, 42);
            sizelabel.Name = "sizelabel";
            sizelabel.Size = new Size(19, 21);
            sizelabel.TabIndex = 4;
            sizelabel.Text = "0";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(18, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Red";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 64);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Green";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(18, 115);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(53, 19);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "Black";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // ColorGB
            // 
            ColorGB.Controls.Add(label7);
            ColorGB.Controls.Add(label6);
            ColorGB.Controls.Add(label5);
            ColorGB.Controls.Add(labelBlue);
            ColorGB.Controls.Add(labelGreen);
            ColorGB.Controls.Add(labelRed);
            ColorGB.Controls.Add(rgbtrackG);
            ColorGB.Controls.Add(rgbtrackB);
            ColorGB.Controls.Add(rgbtrackR);
            ColorGB.Controls.Add(radioButton5);
            ColorGB.Controls.Add(radioButton4);
            ColorGB.Controls.Add(radioButton1);
            ColorGB.Controls.Add(radioButton3);
            ColorGB.Controls.Add(radioButton2);
            ColorGB.Location = new Point(329, 12);
            ColorGB.Name = "ColorGB";
            ColorGB.Size = new Size(666, 280);
            ColorGB.TabIndex = 8;
            ColorGB.TabStop = false;
            ColorGB.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 193);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 18;
            label7.Text = "Blue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 119);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 17;
            label6.Text = "Green";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 52);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 16;
            label5.Text = "Red";
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Font = new Font("Segoe UI", 12F);
            labelBlue.Location = new Point(171, 218);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(19, 21);
            labelBlue.TabIndex = 15;
            labelBlue.Text = "0";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Font = new Font("Segoe UI", 12F);
            labelGreen.Location = new Point(171, 145);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(19, 21);
            labelGreen.TabIndex = 14;
            labelGreen.Text = "0";
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Font = new Font("Segoe UI", 12F);
            labelRed.Location = new Point(171, 80);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(19, 21);
            labelRed.TabIndex = 13;
            labelRed.Text = "0";
            // 
            // rgbtrackG
            // 
            rgbtrackG.Enabled = false;
            rgbtrackG.Location = new Point(194, 145);
            rgbtrackG.Maximum = 255;
            rgbtrackG.Name = "rgbtrackG";
            rgbtrackG.Size = new Size(453, 45);
            rgbtrackG.TabIndex = 12;
            rgbtrackG.Scroll += rgbtrackG_Scroll;
            // 
            // rgbtrackB
            // 
            rgbtrackB.Enabled = false;
            rgbtrackB.Location = new Point(194, 218);
            rgbtrackB.Maximum = 255;
            rgbtrackB.Name = "rgbtrackB";
            rgbtrackB.Size = new Size(453, 45);
            rgbtrackB.TabIndex = 11;
            rgbtrackB.Scroll += rgbtrackB_Scroll;
            // 
            // rgbtrackR
            // 
            rgbtrackR.Enabled = false;
            rgbtrackR.Location = new Point(194, 80);
            rgbtrackR.Maximum = 255;
            rgbtrackR.Name = "rgbtrackR";
            rgbtrackR.Size = new Size(453, 45);
            rgbtrackR.TabIndex = 10;
            rgbtrackR.Scroll += rgbtrackR_Scroll;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(171, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(47, 19);
            radioButton5.TabIndex = 9;
            radioButton5.Text = "RGB";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(18, 173);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(93, 19);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "Spring Green";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = Menu;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "EmreCrosshair";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { crosshairToolStripMenuItem, exitToolStripMenuItem });
            Menu.Name = "Menu";
            Menu.Size = new Size(124, 48);
            // 
            // crosshairToolStripMenuItem
            // 
            crosshairToolStripMenuItem.Name = "crosshairToolStripMenuItem";
            crosshairToolStripMenuItem.Size = new Size(123, 22);
            crosshairToolStripMenuItem.Text = "Crosshair";
            crosshairToolStripMenuItem.Click += crosshairToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(123, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 84);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Offset";
            // 
            // gaplabel
            // 
            gaplabel.AutoSize = true;
            gaplabel.Font = new Font("Segoe UI", 12F);
            gaplabel.Location = new Point(13, 111);
            gaplabel.Name = "gaplabel";
            gaplabel.Size = new Size(19, 21);
            gaplabel.TabIndex = 10;
            gaplabel.Text = "0";
            // 
            // gaptrack
            // 
            gaptrack.Location = new Point(47, 111);
            gaptrack.Maximum = 100;
            gaptrack.Name = "gaptrack";
            gaptrack.Size = new Size(349, 45);
            gaptrack.TabIndex = 11;
            gaptrack.Scroll += trackBar2_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 165);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 12;
            label3.Text = "Thickness";
            // 
            // kalinliklabel
            // 
            kalinliklabel.AutoSize = true;
            kalinliklabel.Font = new Font("Segoe UI", 12F);
            kalinliklabel.Location = new Point(13, 193);
            kalinliklabel.Name = "kalinliklabel";
            kalinliklabel.Size = new Size(19, 21);
            kalinliklabel.TabIndex = 13;
            kalinliklabel.Text = "0";
            // 
            // kalinliktrack
            // 
            kalinliktrack.Location = new Point(47, 193);
            kalinliktrack.Maximum = 100;
            kalinliktrack.Minimum = 1;
            kalinliktrack.Name = "kalinliktrack";
            kalinliktrack.Size = new Size(349, 45);
            kalinliktrack.TabIndex = 14;
            kalinliktrack.Value = 2;
            kalinliktrack.Scroll += trackBar3_Scroll;
            // 
            // CrosshairGB
            // 
            CrosshairGB.Controls.Add(rbutton);
            CrosshairGB.Controls.Add(lbutton);
            CrosshairGB.Controls.Add(bottombutton);
            CrosshairGB.Controls.Add(topbutton);
            CrosshairGB.Controls.Add(lgbutton);
            CrosshairGB.Controls.Add(label4);
            CrosshairGB.Controls.Add(opaklabel);
            CrosshairGB.Controls.Add(borderlabel);
            CrosshairGB.Controls.Add(opaktrack);
            CrosshairGB.Controls.Add(bordercheck);
            CrosshairGB.Controls.Add(bordertrack);
            CrosshairGB.Controls.Add(startbutton);
            CrosshairGB.Controls.Add(emrelabel);
            CrosshairGB.Controls.Add(uzunluktrack);
            CrosshairGB.Controls.Add(label1);
            CrosshairGB.Controls.Add(sizelabel);
            CrosshairGB.Controls.Add(kalinliktrack);
            CrosshairGB.Controls.Add(label2);
            CrosshairGB.Controls.Add(kalinliklabel);
            CrosshairGB.Controls.Add(gaplabel);
            CrosshairGB.Controls.Add(label3);
            CrosshairGB.Controls.Add(gaptrack);
            CrosshairGB.Location = new Point(12, 298);
            CrosshairGB.Name = "CrosshairGB";
            CrosshairGB.Size = new Size(983, 242);
            CrosshairGB.TabIndex = 17;
            CrosshairGB.TabStop = false;
            CrosshairGB.Text = "Crosshair";
            // 
            // rbutton
            // 
            rbutton.BackColor = Color.Lime;
            rbutton.Location = new Point(924, 75);
            rbutton.Name = "rbutton";
            rbutton.Size = new Size(40, 18);
            rbutton.TabIndex = 25;
            rbutton.UseVisualStyleBackColor = false;
            rbutton.Click += rbutton_Click;
            // 
            // lbutton
            // 
            lbutton.BackColor = Color.Lime;
            lbutton.Location = new Point(848, 75);
            lbutton.Name = "lbutton";
            lbutton.Size = new Size(40, 18);
            lbutton.TabIndex = 24;
            lbutton.UseVisualStyleBackColor = false;
            lbutton.Click += lbutton_Click;
            // 
            // bottombutton
            // 
            bottombutton.BackColor = Color.Lime;
            bottombutton.Location = new Point(898, 101);
            bottombutton.Name = "bottombutton";
            bottombutton.Size = new Size(17, 44);
            bottombutton.TabIndex = 23;
            bottombutton.UseVisualStyleBackColor = false;
            bottombutton.Click += bottombutton_Click;
            // 
            // topbutton
            // 
            topbutton.BackColor = Color.Lime;
            topbutton.Location = new Point(898, 26);
            topbutton.Name = "topbutton";
            topbutton.Size = new Size(17, 44);
            topbutton.TabIndex = 22;
            topbutton.UseVisualStyleBackColor = false;
            topbutton.Click += topbutton_Click;
            // 
            // lgbutton
            // 
            lgbutton.Location = new Point(604, 189);
            lgbutton.Name = "lgbutton";
            lgbutton.Size = new Size(121, 32);
            lgbutton.TabIndex = 21;
            lgbutton.Text = "Türkçe";
            lgbutton.UseVisualStyleBackColor = true;
            lgbutton.Click += lgbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 90);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 20;
            label4.Text = "Opacity";
            // 
            // opaklabel
            // 
            opaklabel.AutoSize = true;
            opaklabel.Font = new Font("Segoe UI", 12F);
            opaklabel.Location = new Point(406, 117);
            opaklabel.Name = "opaklabel";
            opaklabel.Size = new Size(19, 21);
            opaklabel.TabIndex = 19;
            opaklabel.Text = "0";
            // 
            // borderlabel
            // 
            borderlabel.AutoSize = true;
            borderlabel.Font = new Font("Segoe UI", 12F);
            borderlabel.Location = new Point(406, 42);
            borderlabel.Name = "borderlabel";
            borderlabel.Size = new Size(19, 21);
            borderlabel.TabIndex = 18;
            borderlabel.Text = "0";
            // 
            // opaktrack
            // 
            opaktrack.LargeChange = 10;
            opaktrack.Location = new Point(450, 117);
            opaktrack.Maximum = 100;
            opaktrack.Name = "opaktrack";
            opaktrack.Size = new Size(361, 45);
            opaktrack.SmallChange = 10;
            opaktrack.TabIndex = 17;
            opaktrack.TickFrequency = 10;
            opaktrack.Value = 100;
            opaktrack.Scroll += opaktrack_Scroll;
            // 
            // bordercheck
            // 
            bordercheck.AutoSize = true;
            bordercheck.Location = new Point(450, 16);
            bordercheck.Name = "bordercheck";
            bordercheck.Size = new Size(195, 19);
            bordercheck.TabIndex = 16;
            bordercheck.Text = "Border Scale  (4 Recommended)";
            bordercheck.UseVisualStyleBackColor = true;
            bordercheck.CheckedChanged += bordercheck_CheckedChanged;
            // 
            // bordertrack
            // 
            bordertrack.Enabled = false;
            bordertrack.LargeChange = 1;
            bordertrack.Location = new Point(450, 42);
            bordertrack.Minimum = 1;
            bordertrack.Name = "bordertrack";
            bordertrack.Size = new Size(361, 45);
            bordertrack.TabIndex = 15;
            bordertrack.Value = 4;
            bordertrack.Scroll += bordertrack_Scroll;
            // 
            // crosshairpanel1
            // 
            crosshairpanel1.BorderStyle = BorderStyle.FixedSingle;
            crosshairpanel1.Location = new Point(12, 12);
            crosshairpanel1.Name = "crosshairpanel1";
            crosshairpanel1.Size = new Size(311, 280);
            crosshairpanel1.TabIndex = 18;
            // 
            // MainFormEmreCrosshair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 542);
            Controls.Add(crosshairpanel1);
            Controls.Add(CrosshairGB);
            Controls.Add(ColorGB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainFormEmreCrosshair";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmreCrosshair";
            Load += MainFormEmreCrosshair_Load;
            ((System.ComponentModel.ISupportInitialize)uzunluktrack).EndInit();
            ColorGB.ResumeLayout(false);
            ColorGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rgbtrackG).EndInit();
            ((System.ComponentModel.ISupportInitialize)rgbtrackB).EndInit();
            ((System.ComponentModel.ISupportInitialize)rgbtrackR).EndInit();
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gaptrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)kalinliktrack).EndInit();
            CrosshairGB.ResumeLayout(false);
            CrosshairGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)opaktrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)bordertrack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startbutton;
        private TrackBar uzunluktrack;
        private Label label1;
        private Label emrelabel;
        private Label sizelabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox ColorGB;
        private RadioButton radioButton4;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip Menu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label2;
        private Label gaplabel;
        private TrackBar gaptrack;
        private Label label3;
        private Label kalinliklabel;
        private TrackBar kalinliktrack;
        private ToolStripMenuItem crosshairToolStripMenuItem;
        private TrackBar rgbtrackG;
        private TrackBar rgbtrackB;
        private TrackBar rgbtrackR;
        private RadioButton radioButton5;
        private Label labelBlue;
        private Label labelGreen;
        private Label labelRed;
        private Label label5;
        private Label label7;
        private Label label6;
        private GroupBox CrosshairGB;
        private Panel crosshairpanel1;
        private TrackBar bordertrack;
        private CheckBox bordercheck;
        private Label opaklabel;
        private Label borderlabel;
        private TrackBar opaktrack;
        private Label label4;
        private Button lgbutton;
        private Button rbutton;
        private Button lbutton;
        private Button bottombutton;
        private Button topbutton;
    }
}
