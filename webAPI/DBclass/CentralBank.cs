namespace webAPI.DBclass
{
    public class CentralBank
    {
    }

    public class Trancation
    {
        public int TranscationID { get; set; }
        public DateTime TransTime { get; set; }
        public float TransAmout { get; set; }
        public string PayeeAccNumber { get; set; }
        public string ReceiverNumber { get; set; }
        public string Remark { get; set; }

    }

    public class Registration
    {
        public int RegistrationID { get; set; }
        public string ECNYNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Remark { get; set; }
    }

}
