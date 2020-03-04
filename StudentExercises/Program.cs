using System;
using System.Collections.Generic;


namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");


      // Create 4, or more, exercises.
      Exercise kennel = new Exercise()
      {
        Name = "Kennel",
        Language = "React"
      };
      Exercise donutShop = new Exercise()
      {
        Name = "Donut Shop",
        Language = "JS"
      };
      Exercise coinPurse = new Exercise()
      {
        Name = "Coin Purse",
        Language = "JS"
      };
      Exercise monkeySee = new Exercise()
      {
        Name = "Monkey See Monkey Do",
        Language = "HTML/CSS"
      };

      // Create 3, or more, cohorts.
      Cohort thirtyfive = new Cohort("35 Day");
      Cohort thirtysix = new Cohort("36 Day");
      Cohort eleven = new Cohort("11 Evening");

      // Create 4, or more, students and assign them to one of the cohorts.
      Student one = new Student("Sage", "Klein");
      thirtyfive.AddStudent(one);
      Student two = new Student("John", "Smith");
      thirtyfive.AddStudent(two);
      Student three = new Student("Bryan", "Google");
      eleven.AddStudent(three);
      Student four = new Student("Jessic", "Smot");
      thirtysix.AddStudent(four);

      // Create 3, or more, instructors and assign them to one of the cohorts.
      Instructor five = new Instructor("Brenda", "L");
      thirtyfive.AddInstructor(five);
      Instructor six = new Instructor("Joe", "S");
      thirtyfive.AddInstructor(six);
      Instructor seven = new Instructor("Adam", "S");
      eleven.AddInstructor(seven);
      // Have each instructor assign 2 exercises to each of the students.

      five.AssignExercise(three, donutShop);
      five.AssignExercise(four, donutShop);
      six.AssignExercise(two, kennel);
      seven.AssignExercise(one, coinPurse);

    }
  }
}
