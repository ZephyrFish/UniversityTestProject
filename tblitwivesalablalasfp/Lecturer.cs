namespace business_logic
{
    public class Lecturer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "Ivan";
        [Required]
        public string Surname { get; set; } = "Petrov";
        public string Patronymic { get; set; } = "Pushkov";
        [Required]
        public int Degree { get; set; }

        public Lecturer(string Name, string Surname, string Patronymic, int Degree)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Degree = Degree;
        }

        public Lecturer()
        {

        }
    }
}
