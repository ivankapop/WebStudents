using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebStudents.Models
{    
    public class Student 
    {
        public  Student()
        {
           Scores = new List<Score>();
        }

        //public Subject Subject { get; set; }
        public List<Score> Scores { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }

        public double AvgScore
        {
            get
            {
                return Scores.Average(t => t.Value);
            }
        }
      
    }
}
