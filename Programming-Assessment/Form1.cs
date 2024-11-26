namespace Programming_Assessment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo f2 = new ToDo();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendar f4 = new Calendar();
            f4.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            Hide();
            m.Show();

        }

        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.Show();
        }
    }
}
