public class Menu
{
    public string userSelect = "";
    int option1 = 1;
    int option2 = 2;
    int option3 = 3;
    int option4 = 4;
    public void optionSelect()
    {
        int select = Convert.ToInt32(userSelect);
        //Console.WriteLine(select);
        switch (select)
        {
            case 1: Console.WriteLine("To-Do"); break;
            case 2: Console.WriteLine("Notes"); break;
            case 3: Console.WriteLine("Diary"); break;
            case 4: Console.WriteLine("Calendar"); break;
        }
    }
}
