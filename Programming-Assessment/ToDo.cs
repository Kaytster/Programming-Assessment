using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        // Method to add item to CheckedListBox
        public void AddItemToCheckedListBox(string item)
        {
            chk_List.Items.Add(item);
        }

        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            AddToDo addToDo = new AddToDo(this);
            addToDo.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();

        }
    }
}