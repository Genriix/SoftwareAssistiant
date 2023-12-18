namespace Software_Assistant
{
    public class ConsoleAnimation
    {
        int counter;
        public ConsoleAnimation() { counter = 0; }
        public void Turn(int left, int top, string[] frames)
        {
            Console.SetCursorPosition(left, top);
            if (counter == frames.Length) counter = 0;
            Console.WriteLine(frames[counter]);
            counter++;
        }
    }
}
