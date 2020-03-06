using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
  class Program
  {
    static void Main(string[] args)
    {

      var nssStudents = new List<Student>()
            {
                new Student()
                {
                Name = "Spencer",
                CohortName = "Day Cohort 37"
                },

                new Student()
                {
                Name = "Heidi",
                CohortName = "Day Cohort 35"
                },

                new Student()
                {
                Name = "Namita",
                CohortName = "Day Cohort 37"
                },

                new Student()
                {
                Name = "Holden",
                CohortName = "Day Cohort 37"
                },

                new Student()
                {
                Name = "Aryn",
                CohortName = "Day Cohort 35"
                },

                new Student()
                {
                Name = "Aryn",
                CohortName = "Day Cohort 35"
                },

                new Student()
                {
                Name = "Jansen",
                CohortName = "Day Cohort 37"
                }
            };

      var names = nssStudents.Select(student =>
      {
        return student.Name;
      });

      //AKA
      var names2 = nssStudents.Select(student => student.Name);


      var studentDescription = nssStudents.Select(student =>
      {
        return ($"{student.Name} is a memeber of {student.CohortName}");
      });

      var students37 = nssStudents.Where(student =>
      {
        return student.CohortName == "Day Cohort 37";
      });

      /////////// adam do ////////////
      // List<int> cohortStudentCount = new List<int>()
      //   {
      //       25, 12, 28, 22, 11, 25, 27, 24, 19
      //   };

      // /*
      //     Now we need to determine which cohorts fell within the range
      //     of acceptable size - between 20 and 26 students. Also, sort
      //     the new enumerable collection in ascending order.
      // */
      // IEnumerable<int> idealSizes = from count in cohortStudentCount
      //                               where count < 27 && count > 19
      //                               orderby count ascending
      //                               select count;

      // cohortStudentCount.Where(count < 27 && cohortStudentCount > 19)
      // .Orderby(count)

      // // Display each number that was the acceptable size
      // foreach (int c in idealSizes)
      // {
      //   Console.WriteLine($"{c}");
      // }

      //find the first one
      var spencer = nssStudents.FirstOrDefault(student =>
      {
        // return student.Name == "Spencer";
        return student.Name.Contains("pen");
      });

      var hasStudentsFrom45 = nssStudents.Any(student =>
      {
        return student.CohortName == "Day Cohort 45";
      });

      // var whatAllExists = nssStudents.GroupBy()

      var countdown = nssStudents
      .GroupBy(student => student.CohortName)
      .Select(group =>
      {
        return new CohortReport
        {
          StudentCount = group.Count(),
          CohortName = group.Key
        };
      });

      foreach (var item in countdown)
      {
        Console.WriteLine($"name {item.CohortName}");
      }
    }
  }
}

public class CohortReport
{
  public string CohortName { get; set; }
  public int StudentCount { get; set; }
}