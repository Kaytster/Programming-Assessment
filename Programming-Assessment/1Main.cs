namespace Programming_Assessment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //To-Do Button
        private void btn_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo t = new ToDo();
            t.ShowDialog();
        }

        //Diary Button
        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.ShowDialog();
        }

        //Notes Button
        private void btn_Notes_Click(object sender, EventArgs e)
        {
            Hide();
            Notes n = new Notes();
            n.ShowDialog();
        }

        //Calendar Button
        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.ShowDialog();
        }

    }
}
