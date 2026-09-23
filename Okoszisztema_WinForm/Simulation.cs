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
        public Simulation(int mapX_, int mapY_,int grass_chance_)
        {
            InitializeComponent();
            this.mapX_ = mapX_;
            this.mapY_ = mapY_;
            this.grass_chance_ = grass_chance_;
            map_ = new Map(mapX_, mapY_,grass_chance_);
            
        }
        private void CreateSimulationTable() {
            
            for (int i = 0; i < mapX_; ++i) {
                for (int j = 0; j < mapY_; ++j) {
                     
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }
    }
}
