namespace Programming_Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ToDo_Click(object sender, EventArgs e)
        {
            //this.Close();
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
    }
}
