namespace BrasilConcursos.Domain.Entities
{
    public sealed class Concourse
    {
        public int Id { get; set; }
        public string PublicAgency { get; set; }
        public string ExaminationBoard { get; set; }
        //public List<string> Positions { get; set; } = new List<string>();
        public string NoticeUrl { get; set; }
        public DateTime RegistrationStartDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Concourse()
        {
        }

        public Concourse(string publicAgency, string examinationBoard, /*List<string> positions, */string noticeUrl, DateTime registrationStartDate, DateTime registrationEndDate)
        {
            PublicAgency = publicAgency;
            ExaminationBoard = examinationBoard;
            //Positions = positions;
            NoticeUrl = noticeUrl;
            RegistrationStartDate = registrationStartDate;
            RegistrationEndDate = registrationEndDate;
        }
    }

}
