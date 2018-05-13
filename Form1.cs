using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Markov
{
    public partial class Form1 : Form
    {
        private int number_of_enter;

        public Form1()
        {
            InitializeComponent();
            number_of_enter = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++number_of_enter;

            Label new_lb = new Label();
            new_lb.Name = "Number" + number_of_enter;
            new_lb.Text = number_of_enter + ":";
            new_lb.Location = new Point(4, 5 + (number_of_enter - 1) * 23);
            new_lb.Size = new Size(28, 13);

            panel.Controls.Add(new_lb);


            TextBox new_tb = new TextBox();
            new_tb.Name = "In" + number_of_enter;
            new_tb.Location = new Point(38, 3 + (number_of_enter - 1) * 23);
            new_tb.Size = new Size(150, 20);

            panel.Controls.Add(new_tb);


            new_lb = new Label();
            new_lb.Name = "Label" + number_of_enter;
            new_lb.Text = "→";
            new_lb.Location = new Point(204, 5 + (number_of_enter - 1) * 23);
            new_lb.Size = new Size(19, 13);

            panel.Controls.Add(new_lb);


            new_tb = new TextBox();
            new_tb.Name = "Out" + number_of_enter;
            new_tb.Location = new Point(241, 3 + (number_of_enter - 1) * 23);
            new_tb.Size = new Size(150, 20);

            panel.Controls.Add(new_tb);


            CheckBox new_ck = new CheckBox();
            new_ck.Name = "End" + number_of_enter;
            new_ck.Location = new Point(397, 5 + (number_of_enter - 1) * 23);
            new_ck.Size = new Size(48, 17);
            new_ck.Text = "Final";

            panel.Controls.Add(new_ck);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number_of_enter == 1)
                return;

            panel.Controls.Remove(panel.Controls.Find("Number" + number_of_enter, true)[0]);
            panel.Controls.Remove(panel.Controls.Find("In" + number_of_enter, true)[0]);
            panel.Controls.Remove(panel.Controls.Find("Label" + number_of_enter, true)[0]);
            panel.Controls.Remove(panel.Controls.Find("Out" + number_of_enter, true)[0]);
            panel.Controls.Remove(panel.Controls.Find("End" + number_of_enter, true)[0]);
            
            --number_of_enter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputWord.Text = InputWord.Text.Replace("\n", "");
          
            MainConsole.Clear();

            MainConsole.AppendText("Старт\n");
            MainConsole.Select(0, 5);
            MainConsole.SelectionFont = new Font(MainConsole.Font.FontFamily, this.Font.Size, FontStyle.Bold);

            string word = InputWord.Text;
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();


            for (int i = 1; i <= number_of_enter; ++i)
            {
                string enter = (panel.Controls.Find("In" + i, true)[0] as TextBox).Text;
                string exit = (panel.Controls.Find("Out" + i, true)[0] as TextBox).Text;

                list.Add(new Tuple<string, string>(enter, exit));
            }

            MainConsole.AppendText("Слово: " + word + "\n");
            MainConsole.Select(6, 6);
            MainConsole.SelectionFont = new Font(MainConsole.Font.FontFamily, this.Font.Size, FontStyle.Bold);

            while (true)
            {
                bool exit = true;

                for (int i = 0; i < number_of_enter; ++i)
                {

                    if (list[i].Item1 == "")
                    {
                        word = list[i].Item2 + word;

                        MainConsole.AppendText("Подстановка " + (i + 1) + ":  " + word + "\n");
                        MainConsole.Select(MainConsole.Text.Length - word.Length - 17, 13);
                        MainConsole.SelectionFont = new Font(MainConsole.Font.FontFamily, this.Font.Size, FontStyle.Bold);

                        exit = (panel.Controls.Find("End" + (i + 1), true)[0] as CheckBox).Checked;
                        break;
                    }

                    int index = word.IndexOf(list[i].Item1);

                    if (index != -1)
                    {
                        word = word.Remove(index, list[i].Item1.Length);
                        word = word.Insert(index, list[i].Item2);

                        MainConsole.AppendText("Подстановка " + (i + 1) + ":  " + word + "\n");
                        MainConsole.Select(MainConsole.Text.Length - word.Length - 17, 13);
                        MainConsole.SelectionFont = new Font(MainConsole.Font.FontFamily, this.Font.Size, FontStyle.Bold);

                        exit = (panel.Controls.Find("End" + (i + 1), true)[0] as CheckBox).Checked;
                        break;
                    }
                }

                if (exit)
                {
                    MainConsole.AppendText("Стоп: " + word + "\n");
                    MainConsole.Select(MainConsole.Text.Length - word.Length - 8, 6);
                    MainConsole.SelectionFont = new Font(MainConsole.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                    break;
                }
            }
        }
    }
}
