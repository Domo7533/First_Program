using System;
					
public class Area
{
	static int AreaRectangle(int length, int breadth){
			return length * breadth;
		}
		static double AreaRectangle(double length, double breadth){
			return length * breadth;
		}
	public static void Main()
	{
		int length = 10;
		int breadth = 15;
		Console.WriteLine($"Area of Rectangle of length {length} and breadth {breadth} is {AreaRectangle(length,breadth)}");
		double length2 = 10.2;
		double breadth2 = 15.8;
		Console.WriteLine($"Area of Rectangle of length and breadth is {AreaRectangle(length2,breadth2)}");
		
	}
}