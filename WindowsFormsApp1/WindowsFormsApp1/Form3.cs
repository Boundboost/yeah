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
    public partial class Form3 : Form
    {
        string[] ques = { "make the output of this script be \"Hello world!\"",
            "change the name of this function to \" read_question_files()\"", 
            "add the int perameter name \"length\" to the function" };
        Dictionary<int, string> keywrds = new Dictionary<int, string>()
        {
            {0, "Hello ☆Goodbye "},
            {1, "read_question_files()☆read_files()" },
            {2, ", int length☆ " }
        };
        int current_question = 0;
        string[] question_files = Directory.GetFiles("H:\\Programming\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\OtherQuestions\\");
        string[] question_strings;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            question_strings = new string[question_files.Length];
            read_question_files();
            create_question();
        }
        Form f1;
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

        void create_question()
        {
            lbl_out.Text = "";
            string outer = question_strings[current_question];
            string key = keywrds[current_question].Remove(keywrds[current_question].IndexOf('☆'), (keywrds[current_question].Length - keywrds[current_question].IndexOf('☆')));
            string str = keywrds[current_question].Replace((key + "☆"), "");
            Console.WriteLine(key);
            Console.WriteLine(str);
            outer = outer.Replace(key, str);
            Console.WriteLine(outer);
            lbl_que.Text = ques[current_question];
            lbl_quenum.Text = "Question " + (current_question + 1).ToString();
            richTextBox1.Text = outer;
        }



        char[] bruhalph = "qwertyuiopa!%&><,sdfghjklz*xcvbnmQWERT/+-YU=IPASDFGHJKL.ZXCVBNM{}[]()1234567890:;\"\'".ToCharArray();
        public string purifychars(char[] inputar, int length)
        {

            int index = 0;
            int re_index = 0;
            char[] returner = new char[length];
            foreach (char i in inputar)
            {
                if (bruhalph.Contains(i))
                {
                    returner[re_index] = i;
                    re_index++;

                }
                index++;
            }

            string r = new string(returner);
            return (r.ToLower());
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string input;
            string ans;
            input = purifychars(richTextBox1.Text.ToCharArray(), question_strings[current_question].Length);
            ans = purifychars(question_strings[current_question].ToCharArray(), question_strings[current_question].Length);
            if (ans.Equals(input))
            {
                lbl_out.Text = "correct!";
                btn_next.Enabled = true;
            }
            else
            {
                lbl_out.Text = "incorrect!";
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (current_question +1 < question_strings.Length)
            {


                current_question++;
                btn_next.Enabled = false;
                create_question();
            }

        }
    }
}
