using System;
					
public class Program
{
	public static void Main()
	{
		
		void GetStudent(out string name, out int age, out string department ){
			name ="Alice";
			age = 20;
			department = "Computer Science";
		}
		string studentName;
		int studentAge;
		string studentDepartment;
		GetStudent (out studentName, out studentAge, out studentDepartment);
		
		Console.WriteLine($"Name: {studentName}");
		Console.WriteLine($"Age: {studentAge}");
		Console.WriteLine($"Department: {studentDepartment}");
	}
		
}


