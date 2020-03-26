using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameOfClass, params string[] fieldToInvestigate)
        {
            Type typeOfClass = Type.GetType(nameOfClass);

            FieldInfo[] classFields = typeOfClass.GetFields(               
                 BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.NonPublic
                | BindingFlags.Public);

            var sb = new StringBuilder();

            object classInstance = Activator.CreateInstance(typeOfClass, new object[] { });

            sb.AppendLine($"Class under investigation: {nameOfClass}");

            foreach (var field in classFields.Where(f => fieldToInvestigate.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }
    }
}
