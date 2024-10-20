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
    public partial class Form2 : Form
    {

        Dictionary<string, string> exerciseImages = new Dictionary<string, string>()
{
    { "Bench Press", "165710974746405e93d3730146b9b.jpg" },
    { "Squat", "the-barbell-squat.jpg" },
    { "Overhead Press", "Standing-wide-grip-barbell-overhead-press.png" },
     { "Deadlift", "Barbell-Deadlift-1.png" },
      { "Leg Extension", "lever-leg-extension-resized.png" },
    
};
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnDodajVjezbu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        public void lsbTrening_Click(object sender, EventArgs e)
        {
           
        }


        public void PopulateListBox(ListBox.SelectedObjectCollection selectedItems)
        {
           
            lsbTrening.Items.AddRange(selectedItems.Cast<object>().ToArray());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        

        private void lsbTrening_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exerciseName = lsbTrening.SelectedItem.ToString();

            Form5 frm5;

            if (exerciseImages.TryGetValue(exerciseName, out string imagePath))
            {
                frm5= new Form5(exerciseName, imagePath);
            }
            else
            {
                frm5 = new Form5(exerciseName);
            }

            frm5.Show(); 
            

           

        }

        private void btnZavrsiTrening_Click(object sender, EventArgs e)
        {
            string poruka = "Vjezbe koje ste odradili ovaj trening:\n";
            foreach(var item in lsbTrening.Items)
            {
                poruka+=item.ToString()+"\n";
            }

            DialogResult result= MessageBox.Show(poruka, "ListBox Content", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                Application.Exit();
            }
            

        }
    }
}
