using System;
					
public class Program
{
	static string schoolName = "RSU";
	
	public static void Main()
	{
		void ShowDept(){
			string department ="Computer Science";
			Console.WriteLine($"Department of {department}, School of {schoolName}");
		}
		ShowDept();
	}