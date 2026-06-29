for (int i = 0; i < 10; i++) 
	{
		if (i == 5) break; 
		Console.WriteLine(i); 
	}

// continue 
for (int i = 0; i < 10; i++) 
	{
		if (i % 2 == 0) continue; 
		Console.WriteLine(i); // prints odd numbers 
	}

// nested loop

for (int i = 1; i <= 3; i++) 
	{
		for (int j = 1; j <= 3; j++) 
		{
			Console.WriteLine($"i={i}, j={j}"); 
		} 
	}
