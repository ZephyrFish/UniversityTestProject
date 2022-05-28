namespace business_logic
{
    public class Group
    {
        public int Id { get; set; }
        public string Number { get; set; }

        [Required]
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudents(object stud)
        {
            if (stud is Student)
            {
                Students.Add(stud as Student);
            }
            else if (stud is List<Student>)
            {
                Students.AddRange(stud as List<Student>);
            }
        }
        public void RemoveStudent(object stud)
        {
            if (stud is Student)
            {
                Students.Remove(stud as Student);
            }
            else if (stud is List<Student>)
            {
                foreach (var s in stud as List<Student>)
                {
                    Students.Remove(s);
                }
            }
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public Group(string Number, List<Student> Students)
        {
            this.Number = Number;
            this.Students = Students;
        }

        public Group()
        {

        }
    }
    
}

