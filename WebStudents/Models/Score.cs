using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebStudents.Models
{
    public class Score
    {   
        public Score(Subject subject,int score)
        {
            Subject = subject;
            Value = score;          
        }

        public Score() { }

        public Student Student { get; set; }
        public Subject Subject { get; set; }


        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public int Value { get; set; }
    }
}