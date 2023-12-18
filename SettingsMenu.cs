namespace Software_Assistant
{
    internal class SettingsMenu
    {
        static public void SetTouch()
        {
            string filename = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe";
            string argument = "-executionpolicy Unrestricted -File C:\\Users\\autoscan\\Desktop\\set_TouchPad.ps1"; //13
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.Verb = "runas";
            startInfo.FileName = filename;
            startInfo.Arguments = argument;
            process.StartInfo = startInfo;
            process.Start();
            //System.Diagnostics.Process.Start(filename, " -executionpolicy Unrestricted -File " + argument);
        }     // Профиль панель
        static public void SetMouse()
        {
            string filename = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe";
            string argument = "-executionpolicy Unrestricted -File C:\\Users\\autoscan\\Desktop\\set_Mouse.ps1"; //10
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.Verb = "runas";
            startInfo.FileName = filename;
            startInfo.Arguments = argument;
            process.StartInfo = startInfo;
            process.Start();
            //System.Diagnostics.Process.Start(filename, " -executionpolicy Unrestricted -File " + argument);
        }     // Профиль мышь
        static public void Update()
        {
            string filename = "cmd.exe";
            string argument = "";
            int index = 0;
            while (index != 3)
            {
                if (index == 0) argument = @"/C del / f C:\Windows\J.A.R.V.I.S.exe";
                if (index == 1) argument = @"/C copy C:\Users\autoscan\Desktop\Jarvis\J.A.R.V.I.S\obj\Debug\J.A.R.V.I.S.exe C:\Windows";

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.Verb = "runas";
                startInfo.FileName = filename;
                startInfo.Arguments = argument;
                process.StartInfo = startInfo;
                process.Start();
                index++;
            }
        }
        static public void Open9_2Prog()
        {
            Update();

            Console.SetCursorPosition(17, 16);
            Console.Write("Обновление");
            ConsoleAnimation spin = new ConsoleAnimation();
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            string[] frames = {
                    "      ----------------",
                    "      #####-----------",
                    "      ###########-----",
                    "      ################",
                    "Обновление проведно успешно!" };
            while (i < 4)
            {
                spin.Turn(8, 17, frames);
                Thread.Sleep(250);
                i++;
            }
            Console.ResetColor();
            Console.WriteLine("\n  Нажмите на любую клавишу для продолжения");

            Console.ReadKey();
        }  // Обновление
        static public void Open9_3Prog()
        {
            System.Diagnostics.Process.Start(@"C:\Windows");
        }  // Папка C:\Windows
        static public void Open9_4Prog()
        {
            System.Diagnostics.Process.Start(@"C:\Users\autoscan\Desktop\Jarvis\J.A.R.V.I.S\obj\Debug");
        }  // Папка J.A.R.V.I.S. Debug
    }
}
