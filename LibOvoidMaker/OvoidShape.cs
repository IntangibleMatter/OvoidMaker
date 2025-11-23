using Svg;

namespace LibOvoidMaker;

public abstract class OvoidShape //: SvgElement
{
	public required float Width { get; set; }
	public required float Height { get; set; }
	public required SvgColourServer Stroke { get; set; }

	public abstract SvgElement ToSvgElement();
}