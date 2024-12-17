using System.Text;

namespace Programming_Assessment
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        //Saving the items in the checkedlistbox to a file
        public void getChkItems()
        {
            //Stack Overflow
            var sb = new StringBuilder();
            foreach (string item in chk_List.Items)
            {
                sb.AppendLine(item);
            }
            string data = sb.ToString();

            string relativePath = @"..\..\..\..\Programming-Assessment\Files\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(data);
                //MessageBox.Show(data);
            }
        }

        //Menu
        private void menu_Back_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.ShowDialog();
            getChkItems();
        }

        //To-Do Button
        private void menu_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo t = new ToDo();
            t.ShowDialog();
            getChkItems();
        }

        //Diary Button
        private void menu_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.ShowDialog();
            getChkItems();
        }

        //Notes Button
        private void menu_Notes_Click(object sender, EventArgs e)
        {
            Hide();
            Notes n = new Notes();
            n.ShowDialog();
            getChkItems();
        }

        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.ShowDialog();
            getChkItems();
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

        //Loading the file into the checkedlistbox
        private void ToDo_Load(object sender, EventArgs e)
        {
            string relativePath = @"..\..\..\..\Programming-Assessment\Files\ToDo.txt";
            string fullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

                //using StreamReader reader = new(@"..\..\..\..\Programming-Assessment\ToDo.txt");

            try
            {
                // Clear existing items
                chk_List.Items.Clear();

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(@"..\..\..\..\Programming-Assessment\Files\ToDo.txt");

                // Add each line to the CheckedListBox
                foreach (string line in lines)
                {
                    chk_List.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        


        //using (StreamReader sr = new StreamReader(fullPath))
        //{
        //    OpenFileDialog FileOpen = new OpenFileDialog();
        //    //FileOpen.ShowDialog();
        //    string pathtofile = FileOpen.FileName;
        //}
    }

}
}
