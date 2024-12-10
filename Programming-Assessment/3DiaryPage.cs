using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming_Assessment
{
    public partial class DiaryPage : Form
    {
        private Button source;
        public DiaryPage(Button source)
        {
            InitializeComponent();
            this.source = source;
        }
        public void AddItemToTextBox(string item)
        {
            txt_DiaryText.Text = item;
        }

        private void btn_Entry_Click(object sender, EventArgs e)
        {
            AddEntry addentry = new AddEntry(this);
            this.source.BackColor = Color.Tan;
            addentry.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void DiaryPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
