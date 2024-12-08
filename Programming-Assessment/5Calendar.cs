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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();

            // load data from file
        }

        private void btn_AddEvent_Click(object sender, EventArgs e)
        {
            if (txt_AddEvent.Text.Trim().Length > 0)
            {

                ListViewItem listViewItem = new ListViewItem(txt_AddEvent.Text);
                listViewItem.SubItems.Add(monthCalendar.SelectionStart.ToString());

                lsvEvents.Items.Add(listViewItem);

                // add data to file

            }
            else
            {
                MessageBox.Show("Provide a name for the event to add it.");

            }

        }

        public void saveEvent()
        {
            List<string> saveEvents = new List<string>();
            saveEvents.Add(txt_AddEvent.Text);
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
