namespace Programming_Assessment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Menu
        private void menu_Back_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();
        }

        //To-Do Button
        private void btn_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo f2 = new ToDo();
            f2.Show();
        }

        //Diary Button
        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.Show();
        }

        //Calendar Button
        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.Show();
        }

    }
}
