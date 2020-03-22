using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Loggers
{
    public interface ILogFile
    {
        public void Write(string message);

        int Size { get; }

    }
}
