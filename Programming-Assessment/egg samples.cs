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
            for (int i = 0; i < 7; i++)
            {
                Button b = new Button();
                b.Text = $"{i+1}";
                b.Height = 100;
                b.Click += DayClick;
                row1.Controls.Add(b);
            }
        }
    }
}
