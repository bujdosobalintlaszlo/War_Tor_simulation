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
            numericUpDown1 = new NumericUpDown();
            NUDnumberOfRabbits = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            NUDstepsPerSec = new NumericUpDown();
            FLPmenubar = new FlowLayoutPanel();
            BopenFile = new Button();
            BstartSim = new Button();
            Bexit = new Button();
            LerrorDisp = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDnumberOfRabbits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
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
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(526, 164);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(518, 31);
            numericUpDown1.TabIndex = 9;
            // 
            // NUDnumberOfRabbits
            // 
            NUDnumberOfRabbits.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUDnumberOfRabbits.Location = new Point(526, 44);
            NUDnumberOfRabbits.Name = "NUDnumberOfRabbits";
            NUDnumberOfRabbits.Size = new Size(518, 31);
            NUDnumberOfRabbits.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown4.Location = new Point(526, 404);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(518, 31);
            numericUpDown4.TabIndex = 12;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown5.Location = new Point(526, 525);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(518, 31);
            numericUpDown5.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(numericUpDown5, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown4, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(NUDstepsPerSec, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(labeal2, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 1);
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
            NUDstepsPerSec.Name = "NUDstepsPerSec";
            NUDstepsPerSec.Size = new Size(518, 31);
            NUDstepsPerSec.TabIndex = 11;
            // 
            // FLPmenubar
            // 
            FLPmenubar.Controls.Add(BopenFile);
            FLPmenubar.Controls.Add(BstartSim);
            FLPmenubar.Controls.Add(Bexit);
            FLPmenubar.Controls.Add(LerrorDisp);
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
            // 
            // LerrorDisp
            // 
            LerrorDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LerrorDisp.AutoSize = true;
            LerrorDisp.Location = new Point(446, 7);
            LerrorDisp.Name = "LerrorDisp";
            LerrorDisp.Size = new Size(59, 25);
            LerrorDisp.TabIndex = 3;
            LerrorDisp.Text = "label6";
            LerrorDisp.TextAlign = ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDnumberOfRabbits).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDstepsPerSec).EndInit();
            FLPmenubar.ResumeLayout(false);
            FLPmenubar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label labeal2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown NUDnumberOfRabbits;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel FLPmenubar;
        private Button BopenFile;
        private Button BstartSim;
        private Button Bexit;
        private Label LerrorDisp;
        private NumericUpDown NUDstepsPerSec;
    }
}
