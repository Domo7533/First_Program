using System;
					
public class Program
{
	public static void Main()
	{
		int x = 10;
		int y = 0;
		try {
			Console.WriteLine(x / y);
		} catch (Exception ex) {
			Console.WriteLine($"Error: {ex.Message");
		}	
	}
}