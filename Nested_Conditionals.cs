using System;
					
public class Program
{
	public static void Main()
	{
		int age = 20;
		bool hasID = true;
		if (age >= 18) {
			if (hasID) {
				Console.WriteLine("Access granted.");
			} else {
				Console.WriteLine("ID required.");
			}
		} else {
			Console.WriteLine("Access denied.");
		}
	}
}