using System;
using System.Collections.Generic;


namespace StudentExercises
{
  public class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort Cohort { get; set; }
    public List<Exercise> Exercises { get; set; }

    // currentExercises

    public string FullName
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }
    // The collection of exercises that the student is currently working on
    public Student(string firstname, string lastname)
    {
      FirstName = firstname;
      LastName = lastname;
      Exercises = new List<Exercise>();
    }
  }
}