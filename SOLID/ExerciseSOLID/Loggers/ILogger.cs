using ExerciseSOLID.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Loggers
{
    public interface ILogger
    {
       IAppender[] Appenders { get; }

        public void Error(string dateTime, string message);

        public void Info(string dateTime, string message);
    }
}
