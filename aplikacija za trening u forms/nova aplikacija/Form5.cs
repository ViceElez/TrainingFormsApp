using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nova_aplikacija
{
    public partial class Form5 : Form
    {
        private string exerciseName;
        private string imagePath;

        public Form5(string exerciseName, string imagePath = null)
        {
            InitializeComponent();
            this.exerciseName = exerciseName;
            this.imagePath = imagePath;



        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = exerciseName;

            // Set the picture box image if image path is available
            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {

        }
       
    }
}
