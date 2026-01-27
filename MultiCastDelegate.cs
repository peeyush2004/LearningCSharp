namespace MultiDelegate

{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            logHandler("This is a multi-delegate log message.");
            logHandler -= logger.LogToFile;

            InvokeSafely(logHandler, "After removing LogToFile");
            // logHandler("After removing LogToFile");

            Console.ReadKey();

            static void InvokeSafely(LogHandler logHandler, string message)
            {

                LogHandler tempLogHandler = logHandler;
                if (tempLogHandler != null)
                {
                    tempLogHandler(message);
                }
            }



        }
    }
}

