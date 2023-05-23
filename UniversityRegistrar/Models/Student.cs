using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "The student's name can't be empty!")]
    public string Name { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public List<StudentCourse> JoinEntities { get; }
    
  }
}