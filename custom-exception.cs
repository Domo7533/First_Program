using System;
					
public class Program
{
	public class InvalidGradeException : Exception {
		public InvalidGradeException(string message) : base(message) { } 
	}
	public static void Main()
	{
		try { 
			int[] arr = {1, 2, 3}; 
			Console.WriteLine(arr[5]); 
		} catch (Exception ex) {
			Console.WriteLine("Error: " + ex.Message); 
			System.IO.File.WriteAllText("log.txt", ex.ToString()); 
			
		}
	}
}


Example 1: Bank Account Exception
using System;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
        : base("Insufficient funds for this transaction.")
    {
    }

    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientFundsException(
                $"Withdrawal of ₦{amount} failed. Available balance is ₦{Balance}."
            );
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful. Remaining balance: ₦{Balance}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(5000);
            account.Withdraw(7000);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

Output

Withdrawal of ₦7000 failed. Available balance is ₦5000.
Example 2: Student Registration Exception
using System;

public class CourseCapacityExceededException : Exception
{
    public CourseCapacityExceededException(string message)
        : base(message)
    {
    }
}

class Course
{
    public int Capacity { get; }
    public int RegisteredStudents { get; private set; }

    public Course(int capacity)
    {
        Capacity = capacity;
    }

    public void RegisterStudent()
    {
        if (RegisteredStudents >= Capacity)
        {
            throw new CourseCapacityExceededException(
                "Course registration failed. Maximum capacity reached."
            );
        }

        RegisteredStudents++;
        Console.WriteLine("Student registered successfully.");
    }
}
Example 3: Online Shopping Exception
using System;

public class OutOfStockException : Exception
{
    public OutOfStockException(string product)
        : base($"{product} is currently out of stock.")
    {
    }
}

class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public void Purchase()
    {
        if (Quantity <= 0)
            throw new OutOfStockException(Name);

        Quantity--;
        Console.WriteLine($"{Name} purchased successfully.");
    }
}
Example 4: Hospital Management Exception
using System;

public class InvalidPatientAgeException : Exception
{
    public InvalidPatientAgeException()
        : base("Patient age cannot be negative.")
    {
    }
}

class Patient
{
    public void Register(int age)
    {
        if (age < 0)
            throw new InvalidPatientAgeException();

        Console.WriteLine("Patient registered successfully.");
    }
}
Example 5: Library Management Exception
using System;

public class BookUnavailableException : Exception
{
    public BookUnavailableException(string title)
        : base($"'{title}' is currently unavailable.")
    {
    }
}

class Library
{
    public bool IsAvailable { get; set; }

    public void BorrowBook(string title)
    {
        if (!IsAvailable)
            throw new BookUnavailableException(title);

        Console.WriteLine($"You borrowed '{title}'.");
    }
}
Example 6: Airline Reservation Exception
using System;

public class SeatAlreadyBookedException : Exception
{
    public SeatAlreadyBookedException(string seatNumber)
        : base($"Seat {seatNumber} has already been booked.")
    {
    }
}

class Flight
{
    public bool SeatBooked { get; set; }

    public void BookSeat(string seatNumber)
    {
        if (SeatBooked)
            throw new SeatAlreadyBookedException(seatNumber);

        SeatBooked = true;
        Console.WriteLine($"Seat {seatNumber} booked successfully.");
    }
}
Example 7: Employee Payroll Exception
using System;

public class InvalidSalaryException : Exception
{
    public InvalidSalaryException()
        : base("Salary cannot be less than zero.")
    {
    }
}

class Payroll
{
    public void ProcessSalary(decimal salary)
    {
        if (salary < 0)
            throw new InvalidSalaryException();

        Console.WriteLine($"Salary processed: ₦{salary}");
    }
}
Example 8: E-Government Portal Exception
using System;

public class InvalidNationalIdException : Exception
{
    public InvalidNationalIdException()
        : base("The National ID provided is invalid.")
    {
    }
}

class CitizenService
{
    public void VerifyNationalId(string nationalId)
    {
        if (nationalId.Length != 11)
            throw new InvalidNationalIdException();

        Console.WriteLine("National ID verified successfully.");
    }
}
1. Log Exceptions

Always log exceptions with the full exception details.

try
{
    account.Withdraw(10000);
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex}");
}
2. Use Different Log Levels

Different events require different severity levels.

Log Level	Purpose	Example
Trace	Very detailed diagnostic information	Method entry/exit
Debug	Information useful during development	Variable values
Information	Normal application events	User logged in
Warning	Unexpected but recoverable events	Low disk space
Error	Operation failed	Database connection failed
Critical	Application cannot continue	Server crash

Example:

Console.WriteLine("[INFO] User logged in.");
Console.WriteLine("[WARNING] Inventory running low.");
Console.WriteLine("[ERROR] Payment failed.");
3. Log Domain-Specific Exceptions

Custom exceptions should include enough information to identify the business rule that failed.

try
{
    account.Withdraw(7000);
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine($"[{DateTime.Now}] {ex.Message}");
}

Output

[7/15/2026 3:45:00 PM] Withdrawal of ₦7000 failed. Available balance is ₦5000.
4. Include Context

Logs become much more useful when they include relevant context.

Console.WriteLine(
    $"User: {username}, Account: {accountNumber}, Amount: {amount}"
);

Instead of

Withdrawal failed.

Prefer

User: Domo, Account: 1234567890, Withdrawal of ₦7000 failed.
5. Log to a File

Instead of writing only to the console, save logs to a file.

using System.IO;

string log = $"{DateTime.Now}: User logged in";

File.AppendAllText("application.log", log + Environment.NewLine);

Example log file

2026-07-15 15:40:10 User logged in
2026-07-15 15:41:55 Withdrawal failed
6. Create a Simple Logger Class
using System;
using System.IO;

public static class Logger
{
    private static readonly string logFile = "application.log";

    public static void Log(string level, string message)
    {
        string entry =
            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";

        File.AppendAllText(logFile, entry + Environment.NewLine);
    }
}

Usage

Logger.Log("INFO", "Application started.");
Logger.Log("WARNING", "Password expires in 3 days.");
Logger.Log("ERROR", "Database connection failed.");

Sample output

2026-07-15 15:42:18 [INFO] Application started.
2026-07-15 15:42:30 [WARNING] Password expires in 3 days.
2026-07-15 15:42:42 [ERROR] Database connection failed.
7. Log Exceptions with Stack Trace
try
{
    int x = 10 / 0;
}
catch (Exception ex)
{
    Logger.Log("ERROR", ex.ToString());
}

ex.ToString() includes:

Exception type
Message
Stack trace
Inner exceptions (if any)
8. Log Application Startup and Shutdown
Logger.Log("INFO", "Application started.");
Logger.Log("INFO", "Application stopped.");

This helps determine when an application began and ended execution.

9. Avoid Logging Sensitive Information

❌ Avoid

Password: MyPassword123
Credit Card: 1234-5678-9876-5432

✔ Better

User login attempt for user: Alice
Payment processed for card ending in ****5432
10. Use a Professional Logging Framework

For production applications, prefer established logging libraries instead of writing your own logger.

Framework	Features
Microsoft.Extensions.Logging	Built into modern .NET applications, supports dependency injection and multiple logging providers.
Serilog	Structured logging with rich sinks (files, databases, cloud services).
NLog	Flexible configuration and multiple output targets.
log4net	Mature framework widely used in enterprise applications.

Example using Microsoft.Extensions.Logging

using Microsoft.Extensions.Logging;

ILogger logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Application started.");

logger.LogWarning("Inventory is running low.");

logger.LogError("Database connection failed.");
Logging Strategy for a Banking Application
try
{
    account.Withdraw(10000);

    Logger.Log(
        "INFO",
        $"Withdrawal successful. Account: {account.AccountNumber}"
    );
}
catch (InsufficientFundsException ex)
{
    Logger.Log(
        "WARNING",
        $"Withdrawal denied for Account: {account.AccountNumber}. {ex.Message}"
    );
}
catch (Exception ex)
{
    Logger.Log(
        "ERROR",
        ex.ToString()
    );
}