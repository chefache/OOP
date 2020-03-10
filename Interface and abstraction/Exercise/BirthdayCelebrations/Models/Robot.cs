namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Interfaces;

    class Robot : IRobot, ISociety
    {
        public Robot(string type, string name, decimal id)
        {
            this.Type = type;
            this.Name = name;
            this.Id = id;
        }

        public string Type { get; set; }

        public string Name { get; set; }

        public decimal Id { get ; set ; }
    }
}
