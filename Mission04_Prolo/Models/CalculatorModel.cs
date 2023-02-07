using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_Prolo.Models
{
    public class CalculatorModel
    {
        [Range(0, 100, ErrorMessage ="Assignments must be 0 - 100" )]
        public int Assign { get; set; }
        [Range(0, 100, ErrorMessage = "Group Projects must be 0 - 100")]
        public int Proj { get; set; }
        [Range(0, 100, ErrorMessage = "Quizzes must be 0 - 100")]
        public int Quiz { get; set; }
        [Range(0, 100, ErrorMessage = "Midterm must be 0 - 100")]
        public int Mid { get; set; }
        [Range(0, 100, ErrorMessage = "Final must be 0 - 100")]
        public int Final { get; set; }
        [Range(0, 100, ErrorMessage = "Intex must be 0 - 100")]
        public int Intex { get; set; }
       

  

     }


}
