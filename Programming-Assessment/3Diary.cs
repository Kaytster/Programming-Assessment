using System.Data;
using System.Runtime.CompilerServices;

namespace Programming_Assessment
{
    public partial class Diary : Form
    {

        public Diary()
        {
            InitializeComponent();
        }

        //To-Do Button
        private void menu_ToDo_Click(object sender, EventArgs e)
        {
            Hide();
            ToDo t = new ToDo();
            t.Show();
        }

        //Diary Button
        private void menu_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.Show();
        }

        //Notes Button
        private void menu_Notes_Click(object sender, EventArgs e)
        {
            Hide();
            Notes n = new Notes();
            n.Show();
        }
        private void menu_Notes_Click_1(object sender, EventArgs e)
        {

        }

        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.Show();
        }

        public void daySelected(object sender, EventArgs e)
        {
            int selectedTab = tab_Diary.SelectedIndex;
            string month = "";

            Button b = sender as Button;
            FlowLayoutPanel flp = b.Parent as FlowLayoutPanel;

            // create a counter starting at 0
            foreach(Button currentButton in  flp.Controls)
            {
                bool btnSend;
                if ((currentButton == sender) == true)
                {
                    btnSend = true;
                    
                }

                // check if the current button is the sender button, if it is, we have the index and can work out the day of the week by doing a remainder 7 thing

                // add 1 to the counter
            }

                
            switch (tab_Diary.SelectedIndex)
            {
                case 0: month = "January"; break;
                case 1: month = "February"; break;
                case 2: month = "March"; break;
                case 3: month = "April"; break;
                case 4: month = "May"; break;
                case 5: month = "June"; break;
                case 6: month = "July"; break;
                case 7: month = "August"; break;
                case 8: month = "September"; break;
                case 9: month = "October"; break;
                case 10: month = "November"; break;
                case 11: month = "December"; break;
            }

            Button clickedButton = (sender as Button)!;
            DiaryPage page = new DiaryPage((Button)sender, "title");
            page.Show();
            //MessageBox.Show($"{month} {clickedButton.Text}");
        }

        private int DayeOfWeekToNum(DayOfWeek day)
        {
            int dayInt = 0;
            switch (day)
            {
                case DayOfWeek.Monday:
                    dayInt = 1;
                    break;
                case DayOfWeek.Tuesday:
                    dayInt = 2;
                    break;
                case DayOfWeek.Wednesday:
                    dayInt = 3;
                    break;
                case DayOfWeek.Thursday:
                    dayInt = 4;
                    break;
                case DayOfWeek.Friday:
                    dayInt = 5;
                    break;
                case DayOfWeek.Saturday:
                    dayInt = 6;
                    break;
                case DayOfWeek.Sunday:
                    dayInt = 7;
                    break;
            }

            return dayInt;
        }

        private void Diary_Load(object sender, EventArgs e)
        {

            //for (int tabMonthIndex = 0; tabMonthIndex < 12; tabMonthIndex++) 
            {
                int year = DateTime.Now.Year;

                for (int monthTab = 0; monthTab < tab_Diary.TabPages.Count; monthTab++)
                {
                    int month = monthTab + 1;
                    TabPage tp = tab_Diary.TabPages[monthTab];
                    FlowLayoutPanel flowPanel = (FlowLayoutPanel) tp.Controls[0];

                    int buttonWidth = (flowPanel.Width / 7) - 10;
                    int buttonHeight = (flowPanel.Height / 7) - 5;

                    flowPanel.Height = 48;
                    List<int> days = Enumerable.Range(1, DateTime.DaysInMonth(year, month)).ToList();
                    foreach (int day in days)
                    {
                        DateTime date = new DateTime(DateTime.Now.Year, month, day);
                        
                        Button b = new Button();
                        b.Text = $"{day} ({date.DayOfWeek})";
                        b.Height = buttonHeight;
                        b.Width = buttonWidth;
                        b.Click += daySelected;
                        flowPanel.Controls.Add(b);
                    }
                }






                //for (int i = 0; i < 5; i++)
                //{
                //    // create a FlowLayoutPanel and set the properties
                //    // add the flow layout to the Copntolrs propertie of the tab
                //    FlowLayoutPanel p = new FlowLayoutPanel();
                //    p.Height = 48;
                //    p.Width = 772;
                //    p.BorderStyle = BorderStyle.FixedSingle;
                //    int x = 7;
                //    p.Location = new Point(7, (x + 63) * i);
                //    tp.Controls.Add(p);

                //    for (int j = 0; j < 7; j++)
                //    {
                //        Button b = new Button();
                //        b.Text = $"{j + 1}";
                //        b.Height = 44;
                //        b.Width = 104;
                //        b.Click += daySelected;
                //        p.Controls.Add(b);
                //    }
                //}
            }
            //Size 104w, 44h
            //for (int i = 0; i < 7; i++)
            //{
            //    Button b = new Button();
            //    b.Text = $"{i + 1}";
            //    b.Height = 44;
            //    b.Width = 104;
            //    b.Click += daySelected;
            //    flow_1.Controls.Add(b);
            //}
            //for (int i = 7; i < 14; i++)
            //{
            //    Button b = new Button();
            //    b.Text = $"{i + 1}";
            //    b.Height = 44;
            //    b.Width = 104;
            //    b.Click += daySelected;
            //    flow_2.Controls.Add(b);
            //}
            //for (int i = 14; i < 21; i++)
            //{
            //    Button b = new Button();
            //    b.Text = $"{i + 1}";
            //    b.Height = 44;
            //    b.Width = 104;
            //    b.Click += daySelected;
            //    flow_3.Controls.Add(b);
            //}
            //for (int i = 21; i < 28; i++)
            //{
            //    Button b = new Button();
            //    b.Text = $"{i + 1}";
            //    b.Height = 44;
            //    b.Width = 104;
            //    b.Click += daySelected;
            //    flow_4.Controls.Add(b);
            //}
            //for (int i = 28; i < 31; i++)
            //{
            //    Button b = new Button();
            //    b.Text = $"{i + 1}";
            //    b.Height = 44;
            //    b.Width = 104;
            //    b.Click += daySelected;
            //    flow_5.Controls.Add(b);
            //}


        }
    }


}
