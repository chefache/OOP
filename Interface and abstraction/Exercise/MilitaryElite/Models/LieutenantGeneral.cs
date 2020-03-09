namespace MilitaryElite.Models
{
    using MilitaryElite.Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary,
            Dictionary<int, IPrivate> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public Dictionary<int, IPrivate> Privates  { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var currentPrivate in this.Privates)
            {
                sb.AppendLine("  " + currentPrivate.Value.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
