namespace BrasilConcursos.Application.DTOs
{
    public class PositionDto
    {
        public Guid Id { get; set; }
        public string JobName { get; set; }
        public double Salary { get; set; }
        public int VacancyNumbers { get; set; }
        public Guid ConcourseId { get; set; }
    }
}
