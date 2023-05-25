using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set;}
    
    [Required(ErrorMessage = "The Name of the Course can't be empty")]
    public string CourseName { get; set;}

    [Required(ErrorMessage = "The Course number can't be left empty")]
    public string CourseNumber { get; set;}

    [Range(1, int.MaxValue, ErrorMessage = "You must add your course to a department. Have you created a department yet?")]    
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    
    public List<StudentCourse> JoinEntities { get; }

  }
}