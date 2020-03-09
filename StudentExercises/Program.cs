using System;
using System.Collections.Generic;
using System.Linq;


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

      //add students to a list
      List<Student> studentsList = new List<Student>() {
        one,
        two,
        three,
        four
      };

      List<Exercise> exercises = new List<Exercise>() {
        kennel,
        donutShop,
        coinPurse,
        monkeySee
      };

      List<Instructor> instructors = new List<Instructor>() {
        five,
        six,
        seven
      };

      List<Cohort> cohorts = new List<Cohort>() {
        thirtyfive,
        thirtysix,
        eleven
      };

      var jsExercises = exercises.Where(exercise =>
      {
        return exercise.Language == "JS";
      });

      // var c35Students = studentsList.Where(student => {
      //   return student.Cohort == ""
      // });

      // var studentsOrderByLastName = studentsList.OrderBy(student >= {
      //   return students.LastName
      // });

      // var studentsWithNoExercises = studentsList.Where(student =>
      // {
      //   int exCount = student.Exercises.Count;
      // });

      foreach (var item in studentsList)
      {
        Console.WriteLine($"name {item.FirstName}");
      }

      var studentWithMostExercises = studentsList.OrderByDescending(student =>
      {
        return student.Exercises.Count;
      }).FirstOrDefault();

      var orderByLastName = studentsList.OrderBy(student =>
      {
        return student.LastName;
      });

      var studentNoExercies = studentsList.Where(student =>
      {
        int exCount = student.Exercises.Count;
        return exCount > 0;
      });

      //GroupBy
      //picture a sign above each group

      var groups = studentsList.GroupBy(student => student.Cohort.Name);

      foreach (var group in groups)
      {
        Console.WriteLine($"There are {group.Count()} students in {group.Key}");
      }

    }
  }
}
