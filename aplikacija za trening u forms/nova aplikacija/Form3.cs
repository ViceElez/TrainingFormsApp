using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nova_aplikacija
{

    
    public partial class Form3 : Form
    {
       private List<string> vjezbeData;

        public Form3()
        {
            InitializeComponent();
            LoadVjezbeData();


        }

        private void LoadVjezbeData()
        {
            vjezbeData = File.ReadAllLines("vjezbe.txt").ToList();
            lsbListaVjezbi.DataSource = vjezbeData;
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            isFormJustLaunched = true;
            lsbListaVjezbi.DataSource = Admin.Vjezbe();
            lsbListaVjezbi.SelectedIndex = -1;
            
        }

        private void btnDodajNovuVjezbu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        public void DodajVjezbu(string vjezba)
        {

            vjezbeData.Add(vjezba);

            
            using (StreamWriter writer = File.AppendText("vjezbe.txt"))
            {
                writer.WriteLine(vjezba);
            }

           
            lsbListaVjezbi.DataSource = null;
            lsbListaVjezbi.DataSource = vjezbeData;
        }
        private bool isFormJustLaunched = true;

        private void lsbListaVjezbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormJustLaunched)
            {
                isFormJustLaunched = false; 
                return; 
            }

           
            if (lsbListaVjezbi.SelectedIndex != -1)
            {
                string selectedExercise = lsbListaVjezbi.SelectedItem.ToString();

               
                Form2 form2 = (Form2)Application.OpenForms["Form2"];
                form2.lsbTrening.Items.Add(selectedExercise);
            }

        }

       

        private void Form3_Shown(object sender, EventArgs e)
        {
           
              
            
        }

      
    }
}
