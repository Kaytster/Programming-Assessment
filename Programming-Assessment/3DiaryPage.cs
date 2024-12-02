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
    public partial class DiaryPage : Form
    {
        public DiaryPage()
        {
            InitializeComponent();
        }
        public void AddItemToTextBox(string item)
        {
            txt_DiaryText.Text = item;

        }

        private void btn_Entry_Click(object sender, EventArgs e)
        {
            AddEntry addentry = new AddEntry(this);
            addentry.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.Show();
        }
    }
}
