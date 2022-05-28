global using System.ComponentModel.DataAnnotations;
namespace business_logic
{
    public class Lection
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        Homework? HomeworkID { get; set; }
        [Required]
        Lecturer LecturerID { get; set; }
        [Required]
        Group GroupID { get; set; }

        public void SetHomework(Homework homework)
        {
            HomeworkID = homework;
        }
        public void SetGroup(Group group)
        {
            GroupID = group;
        }
        public void SetLector(Lecturer lect)
        {
            LecturerID = lect;
        }
        public Lection(string Name, DateTime Date, Homework? HomeworkID, Lecturer LecturerID, Group GroupID)
        {
            this.Name = Name;
            this.Date = Date;
            this.HomeworkID = HomeworkID;
            this.LecturerID = LecturerID;
            this.GroupID = GroupID;
        }

        public Lection()
        {

        }
    }
}
