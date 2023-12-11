using System.Threading.Tasks.Sources;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		Console.WriteLine("Starting the operation...");
		await DoWorkAsync(); // try without await
		Console.WriteLine("Operation completed.");
		// await Task.Delay(3000);
	}

	static async Task DoWorkAsync()
	{
		Console.WriteLine("Starting the asynchronous work...");
		await Task.Delay(2000); // Simulates an async operation taking 2 seconds
		Console.WriteLine("Asynchronous work completed.");
	}
}
