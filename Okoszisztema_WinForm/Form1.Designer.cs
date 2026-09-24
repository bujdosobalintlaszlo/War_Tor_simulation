namespace Okoszisztema_WinForm
{
    partial class Form1
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
            label1 = new Label();
            labeal2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NUDfoxCount = new NumericUpDown();
            NUDnumberOfRabbits = new NumericUpDown();
            NUDgrassChance = new NumericUpDown();
            NUDmapSize = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            NUDstepsPerSec = new NumericUpDown();
            FLPmenubar = new FlowLayoutPanel();
            BopenFile = new Button();
            BstartSim = new Button();
            Bexit = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDfoxCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDnumberOfRabbits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDgrassChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDmapSize).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDstepsPerSec).BeginInit();
            FLPmenubar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 167);
            label1.Name = "label1";
            label1.Size = new Size(517, 25);
            label1.TabIndex = 4;
            label1.Text = "Number of foxes:";
            // 
            // labeal2
            // 
            labeal2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labeal2.AutoSize = true;
            labeal2.Location = new Point(3, 47);
            labeal2.Name = "labeal2";
            labeal2.Size = new Size(517, 25);
            labeal2.TabIndex = 5;
            labeal2.Text = "Number of Rabbits:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 287);
            label3.Name = "label3";
            label3.Size = new Size(517, 25);
            label3.TabIndex = 6;
            label3.Text = "Steps/sec:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 407);
            label4.Name = "label4";
            label4.Size = new Size(517, 25);
            label4.TabIndex = 7;
            label4.Text = "Chance of regrow grass:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 528);
            label5.Name = "label5";
            label5.Size = new Size(517, 25);
            label5.TabIndex = 8;
            label5.Text = "Size of the map:(n*n)";
            // 
            // NUDfoxCount
            // 
            NUDfoxCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUDfoxCount.Location = new Point(526, 164);
            NUDfoxCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDfoxCount.Name = "NUDfoxCount";
            NUDfoxCount.Size = new Size(518, 31);
            NUDfoxCount.TabIndex = 9;
            NUDfoxCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NUDnumberOfRabbits
            // 
            NUDnumberOfRabbits.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUDnumberOfRabbits.Location = new Point(526, 44);
            NUDnumberOfRabbits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDnumberOfRabbits.Name = "NUDnumberOfRabbits";
            NUDnumberOfRabbits.Size = new Size(518, 31);
            NUDnumberOfRabbits.TabIndex = 10;
            NUDnumberOfRabbits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NUDgrassChance
            // 
            NUDgrassChance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUDgrassChance.Location = new Point(526, 404);
            NUDgrassChance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDgrassChance.Name = "NUDgrassChance";
            NUDgrassChance.Size = new Size(518, 31);
            NUDgrassChance.TabIndex = 12;
            NUDgrassChance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NUDmapSize
            // 
            NUDmapSize.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUDmapSize.Location = new Point(526, 525);
            NUDmapSize.Minimum = new decimal(new int[] { 9, 0, 0, 0 });
            NUDmapSize.Name = "NUDmapSize";
            NUDmapSize.Size = new Size(518, 31);
            NUDmapSize.TabIndex = 13;
            NUDmapSize.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NUDmapSize, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(NUDgrassChance, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(NUDstepsPerSec, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(labeal2, 0, 0);
            tableLayoutPanel1.Controls.Add(NUDfoxCount, 1, 1);
            tableLayoutPanel1.Controls.Add(NUDnumberOfRabbits, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1047, 602);
            tableLayoutPanel1.TabIndex = 14;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // NUDstepsPerSec
            // 
            NUDstepsPerSec.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUDstepsPerSec.Location = new Point(526, 284);
            NUDstepsPerSec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NUDstepsPerSec.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDstepsPerSec.Name = "NUDstepsPerSec";
            NUDstepsPerSec.Size = new Size(518, 31);
            NUDstepsPerSec.TabIndex = 11;
            NUDstepsPerSec.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FLPmenubar
            // 
            FLPmenubar.Controls.Add(BopenFile);
            FLPmenubar.Controls.Add(BstartSim);
            FLPmenubar.Controls.Add(Bexit);
            FLPmenubar.Controls.Add(button1);
            FLPmenubar.Dock = DockStyle.Top;
            FLPmenubar.Location = new Point(0, 0);
            FLPmenubar.Name = "FLPmenubar";
            FLPmenubar.Size = new Size(1047, 45);
            FLPmenubar.TabIndex = 15;
            // 
            // BopenFile
            // 
            BopenFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BopenFile.Location = new Point(3, 3);
            BopenFile.Name = "BopenFile";
            BopenFile.Size = new Size(112, 34);
            BopenFile.TabIndex = 0;
            BopenFile.Text = "Open file";
            BopenFile.UseVisualStyleBackColor = true;
            BopenFile.Click += button1_Click;
            // 
            // BstartSim
            // 
            BstartSim.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BstartSim.Location = new Point(121, 3);
            BstartSim.Name = "BstartSim";
            BstartSim.Size = new Size(194, 34);
            BstartSim.TabIndex = 1;
            BstartSim.Text = "Start simulation";
            BstartSim.UseVisualStyleBackColor = true;
            BstartSim.Click += BstartSim_Click;
            // 
            // Bexit
            // 
            Bexit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Bexit.Location = new Point(321, 3);
            Bexit.Name = "Bexit";
            Bexit.Size = new Size(119, 34);
            Bexit.TabIndex = 2;
            Bexit.Text = "Exit";
            Bexit.UseVisualStyleBackColor = true;
            Bexit.Click += Bexit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(446, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Docs";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 602);
            Controls.Add(FLPmenubar);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Okoszisztema";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NUDfoxCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDnumberOfRabbits).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDgrassChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDmapSize).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDstepsPerSec).EndInit();
            FLPmenubar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label labeal2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown NUDfoxCount;
        private NumericUpDown NUDnumberOfRabbits;
        private NumericUpDown NUDgrassChance;
        private NumericUpDown NUDmapSize;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel FLPmenubar;
        private Button BopenFile;
        private Button BstartSim;
        private Button Bexit;
        private NumericUpDown NUDstepsPerSec;
        private Button button1;
    }
}
