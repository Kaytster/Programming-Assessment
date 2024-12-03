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
    public partial class egg_samples : Form
    {
        public egg_samples()
        {
            InitializeComponent();
        }

        private void DayClick(object sender, EventArgs e)
        {
            Button clickeButton = (sender as Button)!;

            MessageBox.Show(clickeButton.Text);
        }

        private void egg_samples_Load(object sender, EventArgs e)
        {
            
        }
    }
}
