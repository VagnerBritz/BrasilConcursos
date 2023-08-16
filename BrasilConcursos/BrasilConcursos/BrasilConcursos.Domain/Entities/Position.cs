using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasilConcursos.Domain.Entities
{
    public class Position
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string JobName { get; set; }
        public double Salary { get; set; }
        public int VacancyNumbers { get; set; }
        public Guid ConcourseId { get; set; }

        public Position() { }
        public Position(string jobName, double salary, int vacancyNumbers, Guid concourseId)
        {
            JobName = jobName;
            Salary = salary;
            VacancyNumbers = vacancyNumbers;
            ConcourseId = concourseId;
        }
    }
}
