namespace LibOvoidMaker;

using Svg;
using System.Drawing;

public class OvoidMaker
{
	public enum OvoidShape
	{
		Flat,
		Concave,
		Convex,
	}

	public static SvgDocument Create(int width, int height)
	{
		var doc = new SvgDocument() {
			Width = width,
			Height = height,
		};

		var group = new SvgGroup();

		doc.Children.Add(group);
		group.Children.Add(new SvgCircle {
			Radius = 100,
			Fill = new SvgColourServer(Color.Red),
			Stroke = new SvgColourServer(Color.Black),
			StrokeWidth = 2,
		});

		return doc;
	}
}