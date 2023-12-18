namespace Software_Assistant
{
    internal class Program
    {
        static public string Version() { return "\n v3.2.6.0"; }
        static public void SetWindow()
        {
            Console.Title = "Software Assistiant";
            Console.Clear();
            int height = 21; // Высота
            int width = 45; // Широта
            Console.WindowHeight = height;
            Console.BufferHeight = height;
            Console.WindowWidth = width;
            Console.BufferWidth = width;
        } // Настройка окна
        static public void CreateMenu(string head, int footer, Dictionary<string, Action> programs)
        {
            string coursor1 = ">|";
            string coursor2 = "//";
            string coursor3 = "$$";


            Console.Clear();
            string[] items = new string[programs.Keys.Count];
            programs.Keys.CopyTo(items, 0);

            int index = 0;
            while (true)
            {
                Console.CursorVisible = false;

                if (head != "0")
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write(head);
                }

                for (int i = 0; i < items.Length; i++)
                {
                    Console.SetCursorPosition(8, i + 8);
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine(coursor2 + " " + items[i]);
                        Console.ResetColor();
                    }
                    else { Console.WriteLine(" " + items[i] + "  "); }
                }

                if (footer == 1)
                {
                    Console.SetCursorPosition(0, Console.WindowHeight - 2);
                    Console.Write(Version());
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Q: Console.Clear(); return;
                    case ConsoleKey.S: MainMenu.OpenSettings(); break;
                    case ConsoleKey.R: Program.SetWindow(); break;

                    case ConsoleKey.DownArrow:
                        if (index < items.Length - 1) index++;

                        else index = 0;

                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0) index--;

                        else index = items.Length - 1;

                        break;
                    case ConsoleKey.Enter:
                        if (index == items.Length - 1) { Console.Clear(); return; }
                        else programs.Values.ElementAt(index).Invoke(); Console.Clear(); break; // Выполнение функции класса Execute
                }
            }
        }
        static void Main()
        {
            //#error version
            string welcome = "" +
                "\n" +
                "\n" +
                "\t     С возвращением, сэр\n" +
                "\n" +
                "\n" +
                "\tВыберите действие, которое вы\n" +
                "\t    хотели бы выполнить:\n";

            Dictionary<string, Action> programs = new Dictionary<string, Action>()
            {
                ["Открыть Телеграм"] = MainMenu.Open1Prog,
                ["Открыть Visual Studio"] = MainMenu.Open2Prog,
                ["Открыть Visual Studio"] = MainMenu.Open2Prog,
                ["GitBash Here"] = MainMenu.OpenBash,
                ["Открыть браузер"] = MainMenu.Open8Prog,
                ["Открыть Wath Dogs 2"] = MainMenu.Open6Prog,
                ["Открыть WMPlayer"] = MainMenu.Open5Prog,
                ["Открыть программу шифрования"] = MainMenu.Open3Prog,
                ["Открыть аудиоплеер"] = MainMenu.Open4Prog,
                ["Открыть настройки"] = MainMenu.OpenSettings,
                ["Выйти на рабочий стол"] = null
            };

            SetWindow();
            CreateMenu(welcome, 0, programs);
            SetWindow();
        }
    }
}