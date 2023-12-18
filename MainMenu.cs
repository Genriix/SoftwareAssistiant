namespace Software_Assistant
{
    internal class MainMenu
    {
        static public void Open1Prog()
        {
            System.Diagnostics.Process.Start(@"D:\J.A.R.V.I.S_PROGRAMS\Telegram");
        }    // Telegram
        static public void Open2Prog()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe");
        }    // Visual Studio
        static public void OpenBash()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Git\git-bash.exe");
        }     // Git Bash
        static public void Open3Prog()
        {
            System.Diagnostics.Process.Start(@"C:\Users\autoscan\Desktop\Blez_de_Vijener_2.0.exe");
        }    // Программа шифрования
        static public void Open4Prog()
        {
            System.Diagnostics.Process.Start(@"C:\Users\autoscan\Desktop\quest13.3.exe");
        }    // Разраб 13.3
        static public void Open5Prog()
        {
            System.Diagnostics.Process.Start(@"D:\J.A.R.V.I.S_PROGRAMS\wmplayer");
        }    // Windows Media Player
        static public void Open6Prog()
        {
            System.Diagnostics.Process.Start(@"D:\J.A.R.V.I.S_PROGRAMS\Watch Dogs 2");
        }    // Watch dogs 2
        static public void Open7Prog()
        {
            Console.Clear();
            ConsoleAnimation spin = new ConsoleAnimation();
            string[] frames = {
                 "Ожидание диска   ",
                 "Ожидание диска.  ",
                 "Ожидание диска.. ",
                 "Ожидание диска...",
            };
            do
            {
                while (!Console.KeyAvailable)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(@"I:\Дисциплины\Разраб_repos");
                        return;
                    }
                    catch
                    {
                        Console.SetCursorPosition(13, 7);
                        Console.Write("Диск не обнаружен.");
                        spin.Turn(14, 8, frames);
                        Thread.Sleep(250);
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }    // Папка I:/repos
        static public void Open8Prog()
        {
            System.Diagnostics.Process.Start(@"C:\Users\autoscan\AppData\Local\Yandex\YandexBrowser\Application\browser.exe");
        }    // Браузер
        static public void OpenSettings()
        {
            string settings = "\n\n\n\t\t Настройки";

            Dictionary<string, Action> executes = new Dictionary<string, Action>()
            {
                ["Профиль мышь"] = SettingsMenu.SetMouse,
                ["Профиль панель"] = SettingsMenu.SetTouch,
                ["Сбросить габариты экрана"] = Program.SetWindow,
                ["Обновить рабочую версию"] = SettingsMenu.Open9_2Prog,
                ["Открыть папку программ"] = SettingsMenu.Open9_3Prog,
                ["Открыть папку Debug"] = SettingsMenu.Open9_4Prog,
                ["Выйти в главное меню"] = null
            };
            Program.CreateMenu(settings, 1, executes);
        } // Настройки
    }
}
