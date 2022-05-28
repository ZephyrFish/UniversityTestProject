namespace business_logic
{

    public class Homework
    {
        public int Id { get; set; }
        public string Task { get; set; }

        [Required]
        Lection LectionID { get; set; }

        public Homework(string Task, Lection LectionID)
        {
            this.Task = Task;
            this.LectionID = LectionID;
        }

        public Homework()
        {

        }

    }
}
