namespace Tests
{
    using business_logic;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StudentReplaceGroups()
        {
            Student student1 = new Student();
            List<Student> stList = new List<Student>();
            stList.Add(student1);
            Group group = new Group("3228/1", stList);
            Student student = new Student("Ivan", "Ivanov", "Ivanovich", group);
            Group n_group = new Group();
            n_group.Number = "1337/2";
            n_group.AddStudents(student);
            student.SetGroup(n_group);
            Assert.Equals(n_group.Students[0].Name, student.Name);
        }
        [Test]
        public void LecturerNLections()
        {
            Lection lection = new Lection();
            Homework homework = new Homework();
            lection.SetHomework(homework);
            Lecturer lecturer = new Lecturer("Peter", "petrov", "Petrovich", 3);
            lection.SetLector(lecturer);
            Assert.Equals("Peter", lecturer.Name);
        }
        [Test]
        public void CheckStud()
        {
            Presence presence = new Presence();
            presence.isPresence = false;
            Assert.Equals(0, presence.Mark);

        }
    }
}