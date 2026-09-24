using System.Text;

namespace Okoszisztema_WinForm
{
    public partial class Form1 : Form
    {
        int rabbit_count_, fox_count_, grass_grow_chance_, step_per_sec_, map_size_;
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rabbit_count_ = 1;
            fox_count_ = 1;
            grass_grow_chance_ = 1;
            step_per_sec_ = 1;
            map_size_ = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) { 
                filePath = openFileDialog.FileName;
            }
        }

        private void BstartSim_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            rabbit_count_ = Convert.ToInt32(NUDnumberOfRabbits.Value);
            if (rabbit_count_ <= 0)
            {
                errorMessage.Append("Number of rabbits needs to be at least 1!");
                errorMessage.Append("\n");
            }
            fox_count_ = Convert.ToInt32(NUDfoxCount.Value);
            if (rabbit_count_ <= 0)
            {
                errorMessage.Append("Number of foxes needs to be at least 1!");
                errorMessage.Append("\n");
            }
            step_per_sec_ = Convert.ToInt32(NUDstepsPerSec.Value);
            if (step_per_sec_ <= 0)
            {

                errorMessage.Append("Number of steps needs to be at least 1!");
                errorMessage.Append("\n");
            }
            grass_grow_chance_ = Convert.ToInt32(NUDgrassChance.Value);
            if (grass_grow_chance_ <= 0)
            {

                errorMessage.Append("Number of steps needs to be at least 1!");
                errorMessage.Append("\n");
            }
            map_size_ = Convert.ToInt32(NUDmapSize.Value);
            if (map_size_ <= 0)
            {

                errorMessage.Append("Mapsize is at least 9, and max 30 by default! (max 1000 is allowed tho ;))");
                errorMessage.Append("\n");
            }
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString());
                return;
            }

            Simulation simForm = new Simulation(map_size_,map_size_,grass_grow_chance_);
            this.Hide();
            simForm.ShowDialog();
            this.Close();

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
