// A Hello World! program in C#.
using System;
namespace HelloWorld
{
	class Hello
	{
		static void Main()
		{
			Console.WriteLine("{0}\n{1}", "Hello World", "from Sean Eustace");

			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
}