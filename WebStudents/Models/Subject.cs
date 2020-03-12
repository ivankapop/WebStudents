using System.Collections.Generic;

namespace WebStudents.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public List<Score> Scores { get; set; }

    }
}