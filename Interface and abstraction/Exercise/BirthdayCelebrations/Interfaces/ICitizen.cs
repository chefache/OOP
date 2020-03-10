namespace BirthdayCelebrations.Interfaces
{
    interface ICitizen : ISociety
    {
        public int Age { get; set; }
        public decimal Id { get; set; }
        public string BirthDate { get; set; }
    }
}
