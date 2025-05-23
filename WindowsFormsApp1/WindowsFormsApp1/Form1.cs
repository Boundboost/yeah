using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {       
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = Location;
            f2.show_form(this);
            this.Hide();
            
        }

        public void show_form(Form f)
        {
            
            this.Show();
            f.Close();
        }

        private void btn_play_other_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = Location;
            f3.show_form(this);
            this.Hide();
        }
    }
}
