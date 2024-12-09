using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        //Menu
        private void menu_Back_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();

            //Saving the contents of the Checked List Box
            string relativePath = @"..\..\..\..\Programming-Assessment\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(chk_List.Text);
            }
        }

        //To-Do Button
        private void menu_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo f2 = new ToDo();
            f2.Show();

            //Saving the contents of the Checked List Box
            string relativePath = @"..\..\..\..\Programming-Assessment\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(chk_List.Text);
            }
        }

        //Diary Button
        private void menu_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.Show();

            //Saving the contents of the Checked List Box
            string relativePath = @"..\..\..\..\Programming-Assessment\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(chk_List.Text);
            }
        }

        //Notes Button
        private void menu_Notes_Click(object sender, EventArgs e)
        {
            Hide();
            Notes n = new Notes();
            n.Show();

            //Saving the contents of the Checked List Box
            string relativePath = @"..\..\..\..\Programming-Assessment\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(chk_List.Text);
            }
        }

        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.Show();

            //Saving the contents of the Checked List Box
            string relativePath = @"..\..\..\..\Programming-Assessment\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(chk_List.Text);
            }
        }

        // Method to add item to CheckedListBox
        public void AddItemToCheckedListBox(string item)
        {
            chk_List.Items.Add(item);
        }

        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            AddToDo addToDo = new AddToDo(this);
            addToDo.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();

        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            string relativePath = @"..\..\..\..\Programming-Assessment\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);
            using (StreamReader sr = new StreamReader(fullPath))
            {
                chk_List.Text = sr.ReadToEnd();
            }
        }
    }
}