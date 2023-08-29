using System.ComponentModel.DataAnnotations;

namespace BrasilConcursos.Domain.Entities
{
    public sealed class Concourse
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Mínimo de 3 letras")]
        public string PublicAgency { get; set; }
        public string ExaminationBoard { get; set; }
        public ICollection<Position> Positions { get; set; } = new List<Position>();
        public string NoticeUrl { get; set; }
        public DateTime RegistrationStartDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public DateTime CreatedAt { get; set; } //ao invés de usar herança usar interface
        public DateTime UpdatedAt { get; set; }

        public Concourse()
        {
        }

        public Concourse(string publicAgency, string examinationBoard, List<Position> positions, string noticeUrl, DateTime registrationStartDate, DateTime registrationEndDate)
        {
            PublicAgency = publicAgency;
            ExaminationBoard = examinationBoard;
            Positions = positions;
            NoticeUrl = noticeUrl;
            RegistrationStartDate = registrationStartDate;
            RegistrationEndDate = registrationEndDate;
        }
    }

}
