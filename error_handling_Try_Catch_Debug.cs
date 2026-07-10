using System;
					
public class Program
{
	public static void Main()
	{
		try {
			int[]Scores ={5,7,18};
			Console.WriteLine (Scores [5]);
		} catch (IndexOutOfRangeException ex){
				Console.WriteLine($"Index Error: {ex.Message}");
		} finally {
				Console.WriteLine("Program Ended");
				}
	}
}
