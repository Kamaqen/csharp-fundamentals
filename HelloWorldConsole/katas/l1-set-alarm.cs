namespace HelloWorldConsole.Katas
{
    public class Alarm
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            return employed && !vacation ? true : false;
        }
    }
}

// https://www.codewars.com/kata/568dcc3c7f12767a62000038/train/csharp
