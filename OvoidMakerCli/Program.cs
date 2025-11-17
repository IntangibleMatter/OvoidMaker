namespace OvoidMakerCli;

using LibOvoidMaker;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, world!");
		Console.WriteLine(OvoidMaker.Create(128, 128));
	}
}