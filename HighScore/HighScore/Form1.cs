using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HighScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            tbscore.Text = i.ToString();
            tbprescore.Text = i.ToString();
        }

        string path = Environment.CurrentDirectory + "/" + "score.txt";
        int count = 1, mark = 10;

        private void Btnnewgame_Click(object sender, EventArgs e)
        {
            int score = 0, currentscore = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach(string text in lines)
                {
                    score = int.Parse(text);
                    currentscore = int.Parse(lines[0]);

                    if(currentscore <= score)
                    {
                        currentscore = score;
                    }
                }
                tbprescore.Text = currentscore.ToString();
                MessageBox.Show("Try to beat this!" + tbprescore.Text);
                tbletter.Clear();
                tbscore.Clear();
                tbletter.Enabled = true;
                btnmatch.Enabled = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmatch_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
            if (tbletter.Text == "")
            {
                MessageBox.Show("Feilds can't be empty");
            }
            else
            {
                Random r = new Random();
                char[] ch = { 'A', 'B', 'C' };
                char rch = ch[r.Next(ch.Length)];

                if(count > 10)
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(tbscore.Text);
                        tbletter.Enabled = false;
                        btnmatch.Enabled = false;
                        tbscore.Clear();
                        MessageBox.Show("Game over!");
                        count = 1;
                        tbletter.Clear();
                    }
                }
                else
                {
                    if(rch.ToString() == tbletter.Text)
                    {
                        MessageBox.Show("Character's matched");
                        MessageBox.Show("The computer choose: " + rch.ToString());
                        tbscore.Text = mark.ToString();
                        mark = mark + 10;
                    }
                    else
                    {
                        MessageBox.Show("Computer choose: " + rch.ToString());
                        MessageBox.Show("Character's didn't match");

                    }
                    MessageBox.Show("Round: " + count.ToString());

                    count++;
                    tbletter.Clear();
                    tbletter.Focus();
                }
            }
        }
    }
}
