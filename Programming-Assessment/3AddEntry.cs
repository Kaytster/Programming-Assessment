using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment
{
    public partial class AddEntry : Form
    {
        private DiaryPage diaryPage;
        public AddEntry(DiaryPage diaryPage)
        {
            InitializeComponent();
            this.diaryPage = diaryPage;
        }

        private void btn_AddEntry_Click(object sender, EventArgs e)
        {
            string text = rtb_DiaryEntry.Text;
            diaryPage.AddItemToTextBox(text);
            Hide();

        }
    }
}
