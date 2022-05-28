namespace business_logic
{
    public class Presence
    {
        public int Id { get; set; }
        [Required]
        public bool isPresence {
            get {
                return isPresence;
            }
            set {
                isPresence = value;
                if (!isPresence)
                    Mark = 0;
            }
        }

        [Required]
        public int Mark {
            get
            {
                return Mark;
            }
            set
            {
                if (value <= 5 && value >= 0)
                {
                    Mark = value;
                }
            }
        }
        [Required]
        Lection LectionID { get; set; }
        [Required]
        Student StudentID { get; set; }

        public Presence(bool isPresence, int Mark, Lection LectionID, Student StudentID)
        {
            Exceptions ex;
            ex = new Exceptions("Wrong Mark");
            ex.ExtraErrorInfo = "Incorrect mark value";
            this.isPresence = isPresence;
            if (!isPresence)
            {
                this.Mark = 0;
            }
            else if(Mark <= 5 && Mark >= 0)
            {
                this.Mark = Mark;
            }
            else
            {
                throw ex;
            }
            this.LectionID = LectionID;
            this.StudentID = StudentID;
        }

        public Presence()
        {

        }

    }
}
