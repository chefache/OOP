using ExerciseSOLID.Appenders;
using ExerciseSOLID.Layouts;
using ExerciseSOLID.Loggers;
using System;

namespace ExerciseSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);

            var file = new LogFile();
            IAppender fileAppender = new FileAppender(simpleLayout, file);

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
        }
    }
}
