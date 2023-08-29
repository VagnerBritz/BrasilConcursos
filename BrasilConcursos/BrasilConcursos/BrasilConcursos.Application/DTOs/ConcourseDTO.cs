using BrasilConcursos.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BrasilConcursos.Application.DTOs
{
    public class ConcourseDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "The name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string PublicAgency { get; set; }
        [Required(ErrorMessage = "The name is Required")]
        [MinLength(3)]
        public string ExaminationBoard { get; set; }
        [Required(ErrorMessage = "The Url patch is Required")]
        public string NoticeUrl { get; set; }

        [Required]
        public DateTime RegistrationStartDate { get; set; }
        [Required]

        public DateTime RegistrationEndDate { get; set; }
        public ICollection<Position> Positions { get; set; }

        //public ConcourseDto()
        //{
        //}

        //public  ConcourseDto(Guid id, string publicAgency, string examinationBoard, string noticeUrl, DateTime registrationStartDate, DateTime registrationEndDate, ICollection<Position> positions)
        //{
        //    Id = id;
        //    PublicAgency = publicAgency;
        //    ExaminationBoard = examinationBoard;
        //    NoticeUrl = noticeUrl;
        //    RegistrationStartDate = registrationStartDate;
        //    RegistrationEndDate = registrationEndDate;
        //    Positions = positions;
        //}
    }

}
