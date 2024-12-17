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
        //Getting which button has been clicked on to set the title of the page
        private Button source;
        public DiaryPage(Button source, string title)
        {
            InitializeComponent();

            this.source = source;
            lbl_Date.Text = title;
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

            SaveFileDialog FileSave = new SaveFileDialog();
            FileSave.ShowDialog();
            string pathtofile = FileSave.FileName;
            StreamWriter sw = new StreamWriter(pathtofile);
            sw.Write(txt_DiaryText.Text);
            sw.Close();

            MessageBox.Show("Saved");

        }


        private void DiaryPage_Load(object sender, EventArgs e)
        {
            OpenFileDialog FileOpen = new OpenFileDialog();
            FileOpen.ShowDialog();
            string pathtofile = FileOpen.FileName;
            StreamReader sr = new StreamReader(pathtofile);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                txt_DiaryText.Text = txt_DiaryText.Text + "\n" + line;
            }
            sr.Close();
        }
        public void setDiary(string text)
        {
            txt_DiaryText.Text = text;
        }
    }
}
