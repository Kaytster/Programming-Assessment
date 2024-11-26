using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public void daySelected()
        {

        }

        private void menu_Notes_Click_1(object sender, EventArgs e)
        {

        }
    }


}
