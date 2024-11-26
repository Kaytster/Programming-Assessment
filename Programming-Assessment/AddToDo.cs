using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment
{
    public partial class AddToDo : Form
    {
        private ToDo toDo;

        public AddToDo(ToDo toDo)
        {
            InitializeComponent();
            this.toDo = toDo;
        }

        private void btn_SubmitTask_Click_1(object sender, EventArgs e)
        {
            string text = txt_Add.Text;
            toDo.AddItemToCheckedListBox(text);
            txt_Add.Clear();
        }

        private void txt_Add_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
