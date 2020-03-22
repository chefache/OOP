using ExerciseSOLID.Enums;
using ExerciseSOLID.Layouts;
using ExerciseSOLID.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Appenders
{
    public class FileAppender : IAppender
    {

        public FileAppender(ILayout layout, ILogFile logFile)
        {
            this.Layout = layout;
            this.LogFile = logFile;
        }

        private ILogFile LogFile;

        public ILayout Layout { get; }

        public void Append(string dateTime, LogLevel logLevel, string message)
        {
            this.LogFile.Write(string.Format(Layout.Format, dateTime, logLevel, message));
        }
    }
}
