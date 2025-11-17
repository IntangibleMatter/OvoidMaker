namespace OvoidMakerCli;

using LibOvoidMaker;

class Program
{
	static void Main(string[] args)
	{
		// Console.WriteLine("Hello, world!");
		var doc = OvoidMaker.Create(128, 128);
		Console.WriteLine(Svg.SvgExtentions.GetXML(doc));
	}
}