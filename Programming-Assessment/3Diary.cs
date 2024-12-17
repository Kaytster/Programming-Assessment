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
            t.ShowDialog();
        }

        //Diary Button
        private void menu_Diary_Click(object sender, EventArgs e)
        {
            Hide();
            Diary d = new Diary();
            d.ShowDialog();
        }

        //Notes Button
        private void menu_Notes_Click(object sender, EventArgs e)
        {
            Hide();
            Notes n = new Notes();
            n.ShowDialog();
        }


        //Calendar Button
        private void menu_Calendar_Click(object sender, EventArgs e)
        {
            Hide();
            Calendar c = new Calendar();
            c.ShowDialog();
        }


        //Getting the day and date of the button
        public string completeDate;

        public void daySelected(object sender, EventArgs e)
        {
            int selectedTab = tab_Diary.SelectedIndex;
            string month = "";

            Button b = sender as Button;
            FlowLayoutPanel flp = b.Parent as FlowLayoutPanel;

            int dayCounter = 0;
            int dateCounter = 1;

            foreach(Button currentButton in  flp.Controls)
            {
                if (currentButton == sender)
                {
                    int dayOfWeek = dayCounter % 7 + 1;
                    int dayIndex = dayOfWeek;
                    string date = "Unknown";
                    switch (dayIndex)
                    {
                        case 1: date = "Monday"; break;
                        case 2: date = "Tuesday"; break;
                        case 3: date = "Wednesday"; break;
                        case 4: date = "Thursday"; break;
                        case 5: date = "Friday"; break;
                        case 6: date = "Saturday"; break;
                        case 7: date = "Sunday"; break;
                    }
                    //MessageBox.Show($"Day: {date} Date: {dateCounter}");
                    string newDate = ($"{date} {dateCounter}");
                    completeDate = newDate;
                }

                //if (dateCounter % 7 == 0)
                //{
                //    int date = dateCounter + 1
                //}
                dateCounter++;
                dayCounter++;

            }


            Button clickedButton = (sender as Button)!;
            DiaryPage page = new DiaryPage((Button)sender, completeDate);
            page.Show();
            //MessageBox.Show($"{month} {clickedButton.Text}");
        }

        private int DayOfWeekToNum(DayOfWeek day)
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

        private int dateNum;

        //Creating and setting each button with the correct date and properties
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
                        int myDay = day;
                        Button b = new Button();
                        b.Text = $"{day} ({date.DayOfWeek})";
                        b.Height = buttonHeight;
                        b.Width = buttonWidth;
                        b.Click += daySelected;
                        flowPanel.Controls.Add(b);
                    }
                }

            }
            
        }
    }


}
