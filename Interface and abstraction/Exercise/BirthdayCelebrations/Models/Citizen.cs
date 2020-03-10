namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Interfaces;

    class Citizen : ISociety, ICitizen
    {
        public Citizen(string type, string name, int age, decimal id, string birthDate)
        {
            this.Type = type;
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Age { get ; set ; }

        public decimal Id { get ; set ; }

        public string BirthDate { get ; set ; }
    }
}
