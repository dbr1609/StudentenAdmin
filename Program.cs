using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAdmin
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>
			{
				new Student { FirstName = "Quentin", LastName = "Vanhoutte", Grade = 77},
				new Student { FirstName = "Brian", LastName = "Leroy", Grade = 55},
				new Student { FirstName = "Chiara", LastName = "Vancluysen", Grade = 80},
				new Student { FirstName = "Bavo", LastName = "Van Daele", Grade = 30},
				new Student { FirstName = "Timothy", LastName = "Borremans", Grade = 60},
				new Student { FirstName = "Lisa", LastName = "Peeters", Grade = 75},
				new Student { FirstName = "Lenny", LastName = "Louage", Grade = 45},
				new Student { FirstName = "Ayoub", LastName = "Edris", Grade = 90},
				new Student { FirstName = "Jeroen", LastName = "Callens", Grade = 60},
				new Student { FirstName = "Anke", LastName = "De Smedt", Grade = 70},
				new Student { FirstName = "Hans", LastName = "Leroy", Grade = 55},
				new Student { FirstName = "Arnaud", LastName = "Blindeman", Grade = 88},
				new Student { FirstName = "Brian", LastName = "Dujardin", Grade = 45},
				new Student { FirstName = "Perrine", LastName = "Desmet", Grade = 50},
				new Student { FirstName = "Abdullah", LastName = "Taslim", Grade = 70},
				new Student { FirstName = "Zaira", LastName = "Akman", Grade = 55}
			};
			Console.WriteLine("De geslaagde studenten zijn: ");
			var passedStudents = students.Where(x => x.Grade >= 50).OrderBy(x => x.Grade);
            foreach (Student student in passedStudents)
            {
				Console.WriteLine(student.ToString()); ;
            }
			Console.WriteLine("De gebuisde studenten zijn: ");
			var failedStudents = students.Where(x => x.Grade < 50).OrderBy(x => x.Grade);
			foreach (Student student in failedStudents)
			{
				Console.WriteLine(student.ToString());
			}
            Console.WriteLine("De 3 beste studenten zijn: ");
			var bestThreeStudents = students.OrderByDescending(x => x.Grade).Take(3);
			foreach (Student student in bestThreeStudents)
			{
				Console.WriteLine(student.ToString());
			}
			Console.WriteLine("De beste student is: ");
            Console.WriteLine(bestThreeStudents.First());
			Console.WriteLine("De resultaten op 10 zijn: ");
			var quotationOnTen = students.Select(x => (double)x.Grade/10);
			foreach (var punt in quotationOnTen)
			{
				Console.WriteLine(punt); ;
			}
            Console.Write("Gemiddelde van de studenten:");
            Console.WriteLine(students.Select(x => x.Grade).Average());

			Console.WriteLine(students.Select(p => p.FirstName).Aggregate((prev, curr) => prev + "," + curr));
		}
	}
}
