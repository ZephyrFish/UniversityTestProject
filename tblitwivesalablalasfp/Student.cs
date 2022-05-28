namespace business_logic
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        [Required]
        Group GroupID { get; set; }
        public void SetGroup(Group group)
        {
            GroupID = group;
        }
        public Student(string Name, string Surname, string Patronymic, Group GroupID)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.GroupID = GroupID;
        }

        public Student()
        {

        }
    }
}