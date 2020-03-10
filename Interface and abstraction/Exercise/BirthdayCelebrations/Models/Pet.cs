namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Interfaces;

    class Pet : ISociety, IPet
    {
        public Pet(string type, string name, string birthtDate)
        {
            this.Type = type;
            this.Name = name;
            this.BirthtDate = birthtDate;
        }

        public string Type { get ; set ; }
        public string Name { get ; set ; }
        public string BirthtDate { get ; set ; }
    }
}
