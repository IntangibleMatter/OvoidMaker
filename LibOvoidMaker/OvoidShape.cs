using Svg;

namespace LibOvoidMaker;

public abstract class OvoidShape
{
	public float Width { get; set; }
	public float Height { get; set; }

	public abstract SvgDocument ToSvgElement();
}