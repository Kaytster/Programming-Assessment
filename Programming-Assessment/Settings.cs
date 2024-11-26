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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_Colour_Click(object sender, EventArgs e)
        {
            Theme t = new Theme();
            t.Show();
        }

        // Back Button
        private void menu_Back_Click(object sender, EventArgs e)
        {
            //Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
