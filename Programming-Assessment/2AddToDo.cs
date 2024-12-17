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
