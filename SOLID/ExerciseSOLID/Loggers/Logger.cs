using ExerciseSOLID.Appenders;
using ExerciseSOLID.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Loggers
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;

            //TODO: if appender == null => exeption
        }

        public IAppender[] Appenders { get; }

        public void Error(string dateTime, string message)
        {
            foreach (IAppender appender in this.Appenders)
            {
                appender.Append(dateTime, LogLevel.Error, message);
            }
        }

        public void Info(string dateTime, string message)
        {
            foreach (IAppender appender in this.Appenders)
            {
                appender.Append(dateTime, LogLevel.Info, message);
            }
        }
    }
}
