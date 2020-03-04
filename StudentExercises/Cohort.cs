using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Cohort
  {

    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public List<Instructor> Instructors { get; set; }

    //define what a cohort needs when constructed/initialized
    public Cohort(string name)
    {
      Name = name;
      Students = new List<Student>();
      Instructors = new List<Instructor>();
    }

    public void AddStudent(Student student)
    {
      Students.Add(student);
      student.Cohort = this;
    }

    public void AddInstructor(Instructor instructor)
    {
      Instructors.Add(instructor);
      instructor.Cohort = this;
    }
  }
}