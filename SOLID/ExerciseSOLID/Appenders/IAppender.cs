using ExerciseSOLID.Enums;
using ExerciseSOLID.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Appenders
{
    public interface IAppender
    {
        public ILayout Layout { get; }

        void Append(string dateTime, LogLevel logLevel, string message);
    }
}
