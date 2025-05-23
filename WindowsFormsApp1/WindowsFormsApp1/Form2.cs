using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //paths here
        string[] question_files = Directory.GetFiles("H:\\Programming\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\questions\\");
        string[] question_strings;
        Form f1;
        int current_question = 0;
        int streak = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Close();
        }

        public void show_form(Form f)
        {
            f1 = f;
            this.Show();
        }


        void read_question_files()
        {

            int i = 0;
            foreach (string file in question_files)
            {
                question_strings[i] = System.IO.File.ReadAllText(file);
                i++;
            }
            i = 0;

        }
        char[] alpha = "QWERTYUIOPASDFGHJKLZXCVBNM.qwertyui34opasdfghjklzxcvbnm{]:".ToCharArray();
        string answer;
        char[] quechar;
        string que;
        int changed_index;
        void create_question()
        {
            lbl_out.Text = "";

            if (current_question < question_strings.Length)
            {
                btn_next.Enabled = false;
                btn_next.Visible = false;
                btn_submit.Enabled = true;
                quechar = new char[question_strings[current_question].Length];
                Random rand = new Random();
                answer = question_strings[current_question];
                quechar = question_strings[current_question].ToCharArray();
                changed_index = rand.Next(0, quechar.Length);
                quechar[changed_index] = alpha[rand.Next(0, alpha.Length)];
                que = new string(quechar);

                richTextBox1.Text = que;
            }
            else
            {
                lbl_out.Text = "Complete!";
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            question_strings = new string[question_files.Length];
            read_question_files();
            create_question();


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            create_question();
        }
        char[] inputc;
        char[] anschar;
        string input;
        private void btn_submit_Click(object sender, EventArgs e)
        {
            input = richTextBox1.Text;

            inputc = input.ToCharArray();
            anschar = answer.ToCharArray();

            string pansw = purifychars(anschar);
            string pinput = purifychars(inputc);
            Console.WriteLine(pinput);
            Console.WriteLine(pansw);

            if (pinput.Equals(pansw) )
            {
                streak++;
                lbl_out.Text = "Correct!";
                current_question++;
                btn_next.Enabled = true;
                btn_next.Visible = true;
                btn_submit.Enabled = false;
            }
            else
            {
                streak = 0;
                lbl_out.Text = "try again";
            }
            lbl_streak.Text = "streak: " + streak.ToString();
        }

        char[] bruhalph = "qwertyuiopa!%&><,sdfghjklz*xcvbnmQWERT/+-YU=IPASDFGHJKL.ZXCVBNM{}[]()1234567890:;\"\'".ToCharArray();
        
        public string purifychars(char[] inputar )
        {
            
            int index = 0;
            int re_index = 0;
            char[] returner = new char[question_strings[current_question].Length];
            foreach(char i in inputar)
            {
                if (bruhalph.Contains(i))
                {
                    returner[re_index] = i;
                    re_index++;

                }
                index++;
            }

            string r = new string(returner);
            return (r);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            create_question();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
    }
}

      