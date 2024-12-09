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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        //Menu
        private void menu_Back_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();
        }

        //To-Do Button
        private void menu_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo f2 = new ToDo();
            f2.Show();
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
            Hide();
            Notes n = new Notes();
            n.Show();
        }

        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string relativePath = @"..\..\..\..\Programming-Assessment\Notes.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(rtb_Notes.Text);
            }

            MessageBox.Show("Saved");

        }

        private void Notes_Load(object sender, EventArgs e)
        {
            string relativePath = @"..\..\..\..\Programming-Assessment\Notes.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);
            using (StreamReader sr = new StreamReader(fullPath))
            {
                rtb_Notes.Text = sr.ReadToEnd();
            }

        }

        private void btn_Colour_Click(object sender, EventArgs e)
        {
            ColorDialog TextColour = new ColorDialog();
            TextColour.ShowDialog();
            rtb_Notes.SelectionColor = TextColour.Color;
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            FontDialog TextFont = new FontDialog();
            TextFont.ShowDialog();
            rtb_Notes.SelectionFont = TextFont.Font;
        }

        private void btn_Highlight_Click(object sender, EventArgs e)
        {
            ColorDialog TextColour = new ColorDialog();
            TextColour.ShowDialog();
            rtb_Notes.SelectionBackColor = TextColour.Color;
        }

        private void rtb_Notes_TextChanged(object sender, EventArgs e)
        {
            lbl_CharCount.Text = rtb_Notes.Text.Length.ToString();
            int Spaces = rtb_Notes.Text.Count(f => f == ' ') + 1;

            lbl_WordCount.Text = Spaces.ToString();
        }
    }
}
