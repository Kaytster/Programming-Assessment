using System.Text;

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

        public void getEvents()
        {
            //Stack Overflow
            var sb = new StringBuilder();
            //ListViewItem listViewItem = new ListViewItem();
            foreach (ListViewItem item in lsvEvents.Items)
            {
                //string myItem = item.Text;
                sb.AppendLine(item.Text);
            }
            string data = sb.ToString();

            string relativePath = @"..\..\..\..\Programming-Assessment\Files\Events.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(data);
                //MessageBox.Show(data);
            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            string relativePath = @"..\..\..\..\Programming-Assessment\Files\Events.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            //using StreamReader reader = new(@"..\..\..\..\Programming-Assessment\ToDo.txt");

            try
            {
                // Clear existing items
                lsvEvents.Items.Clear();

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(@"..\..\..\..\Programming-Assessment\Files\Events.txt");

                // Add each line to the CheckedListBox
                foreach (string line in lines)
                {
                    lsvEvents.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        }

        //Menu
        private void menu_Back_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.ShowDialog();
            getEvents();
        }

        //To-Do Button
        private void menu_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo t = new ToDo();
            t.ShowDialog();
            getEvents();
        }

        //Diary Button
        private void menu_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.ShowDialog();
            getEvents();
        }

        //Notes Button
        private void menu_Notes_Click(object sender, EventArgs e)
        {
            Hide();
            Notes n = new Notes();
            n.ShowDialog();
            getEvents();
        }

        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.ShowDialog();
            getEvents();
        }
    }
}
