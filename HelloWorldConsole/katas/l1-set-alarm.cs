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
