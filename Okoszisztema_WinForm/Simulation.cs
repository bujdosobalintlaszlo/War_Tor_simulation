using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Okoszisztema;

namespace Okoszisztema_WinForm
{
    public partial class Simulation : Form
    {
        int mapX_;
        int mapY_;
        int grass_chance_;
        Map map_;
        bool stopped = false;
        public Simulation(int mapX_, int mapY_, int grass_chance_)
        {
            InitializeComponent();
            this.mapX_ = mapX_;
            this.mapY_ = mapY_;
            this.grass_chance_ = grass_chance_;
            map_ = new Map(mapX_, mapY_, grass_chance_);

        }
        private void CreateSimulationTable()
        {

            for (int i = 0; i < mapX_; ++i)
            {
                for (int j = 0; j < mapY_; ++j)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Simulation_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"{this.Height} - {this.Width}");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellWidth = splitContainer1.Panel1.Width / mapX_;
            int cellHeight = splitContainer1.Panel1.Height / mapY_;

            using (Pen selPen = new Pen(Color.Blue))
            {
                for (int i = 0; i < mapX_; ++i)
                {
                    for (int j = 0; j < mapY_; ++j)
                    {
                        int x = j * cellWidth;
                        int y = i * cellHeight;

                        g.DrawRectangle(selPen, x, y, cellWidth, cellHeight);
                    }
                }
            } 
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopped = true;
            if (stopped) {
                button1.Text = "Continue";

            }
        }
    }
}
