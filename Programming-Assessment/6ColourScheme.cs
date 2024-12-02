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
    public partial class Theme : Form
    {
        public Theme()
        {
            InitializeComponent();
        }

        private void btn_Dark_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.BackColor = Color.Green;

        }
    }
}
