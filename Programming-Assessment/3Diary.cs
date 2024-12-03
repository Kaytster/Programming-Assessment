using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        //To-Do Button
        private void menu_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo t = new ToDo();
            t.Show();
        }

        //Diary Button
        private void menu_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.Show();
        }

        //Notes Button
        private void menu_Notes_Click(object sender, EventArgs e)
        {
            //Hide();
            //Diary d = new Diary();
            //d.Show();
        }
        private void menu_Notes_Click_1(object sender, EventArgs e)
        {

        }

        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.Show();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void daySelected(object sender, EventArgs e)
        {
            int selectedTab = tab_Diary.SelectedIndex;
            string month = "";

            switch (tab_Diary.SelectedIndex)
            {
                case 0: month = "January"; break;
                case 1: month = "February"; break;
                case 2: month = "March"; break;
                case 3: month = "April"; break;
                case 4: month = "May"; break;
                case 5: month = "June"; break;
                case 6: month = "July"; break;
                case 7: month = "August"; break;
                case 8: month = "September"; break;
                case 9: month = "October"; break;
                case 10: month = "November"; break;
                case 11: month = "December"; break;
            }

            Button clickedButton = (sender as Button)!;

            //MessageBox.Show($"{month} {clickedButton.Text}");
        }

        private void DayClick(object sender, EventArgs e)
        {
            
        }



        private void Diary_Load(object sender, EventArgs e)
        {
            //Size 104w, 44h
            for (int i = 0; i < 7; i++)
            {
                Button b = new Button();
                b.Text = $"{i + 1}";
                b.Height = 44;
                b.Width = 104;
                b.Click += daySelected;
                flow_1.Controls.Add(b);
            }
            for (int i = 7; i < 14; i++)
            {
                Button b = new Button();
                b.Text = $"{i + 1}";
                b.Height = 44;
                b.Width = 104;
                b.Click += daySelected;
                flow_2.Controls.Add(b);
            }
            for (int i = 14; i < 21; i++)
            {
                Button b = new Button();
                b.Text = $"{i + 1}";
                b.Height = 44;
                b.Width = 104;
                b.Click += daySelected;
                flow_3.Controls.Add(b);
            }
            for (int i = 21; i < 28; i++)
            {
                Button b = new Button();
                b.Text = $"{i + 1}";
                b.Height = 44;
                b.Width = 104;
                b.Click += daySelected;
                flow_4.Controls.Add(b);
            }
            for (int i = 28; i < 31; i++)
            {
                Button b = new Button();
                b.Text = $"{i + 1}";
                b.Height = 44;
                b.Width = 104;
                b.Click += daySelected;
                flow_5.Controls.Add(b);
            }

        }
    }


}
