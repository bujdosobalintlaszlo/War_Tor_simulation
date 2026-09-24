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
            MessageBox.Show(splitContainer1.Width.ToString());
            MessageBox.Show($"{splitContainer1.Panel1.Width / mapY_} - {splitContainer1.Panel1.Width / mapX_}");
            Graphics g = e.Graphics;
            Pen selPen = new Pen(Color.Blue);
            //g.DrawRectangle(selPen, 10, 10, 50, 50);
            int startX;
            int startY = 0;
            for (int i = 0; i < mapX_; ++i)
            {
                startX = 0;
                for (int j = 0; j < mapY_; ++j)
                {
                    g.DrawRectangle(selPen, startX, startY, (splitContainer1.Panel1.Width - mapX_ * 10) / mapX_, (splitContainer1.Panel1.Height - mapY_ * 10) / mapY_);
                    startX += 70;
                }
                startY += 55;
            }
            g.Dispose();
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
