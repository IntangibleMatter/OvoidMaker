namespace OvoidMakerCli;

using LibOvoidMaker;

class Program
{
	static void Main(string[] args)
	{
		// Console.WriteLine("Hello, world!");
		var doc = OvoidMaker.Create(16, 8);
		Console.WriteLine(Svg.SvgExtentions.GetXML(doc));
	}
}