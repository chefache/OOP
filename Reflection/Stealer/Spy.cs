using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFiles)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.NonPublic
                | BindingFlags.Public);

            var sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            foreach (FieldInfo field in classFields.Where(f => requestedFiles.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim(); 
        }
    }
}
