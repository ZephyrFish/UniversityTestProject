namespace business_logic
{
    public class Exceptions : Exception
    {
        public Exceptions() : base() { }
        public Exceptions(string message) : base(message) { }
        public Exceptions(string message, Exception e) : base(message, e) { }
        //If there is extra error information that needs to be captured
        //create properties for them.

        private string? strExtraInfo;
        public string? ExtraErrorInfo
        {
            get
            {
                return strExtraInfo;
            }

            set
            {
                strExtraInfo = value;
            }
        }
    }
}
