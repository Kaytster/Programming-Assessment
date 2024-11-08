//Menu - To-Do, Calendar, Diary, Notes.
Console.WriteLine("Welcome!");
Console.WriteLine("1|To-Do");
Console.WriteLine("2|Notes");
Console.WriteLine("3|Diary");
Console.WriteLine("4|Calendar");
Console.WriteLine("");

Menu menu = new Menu();
menu.userSelect = Console.ReadLine();
menu.optionSelect();