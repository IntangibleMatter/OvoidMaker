using Svg;
using Svg.Pathing;
using System.Drawing;

namespace LibOvoidMaker;

public class OvoidShapeFlat : OvoidShape
{

	public override SvgElement ToSvgElement()
	{
		var element = new SvgPath() { PathData = new SvgPathSegmentList() };

		element.PathData.Add(
			new SvgMoveToSegment(false, new PointF(Width / 2, 0)));
		element.PathData.Add(new SvgCubicCurveSegment(
			true, new PointF(Width / 3, 0), new PointF(Width / 2, Height / 2),
			new PointF(Width / 2, Height * 0.75f)));
		element.PathData.Add(
			new SvgCubicCurveSegment(true, new PointF(0, Height / 4),
									 new PointF(-Height / 4, Height / 4),
									 new PointF(-Width / 2, Height / 4)));
		element.PathData.Add(new SvgCubicCurveSegment(
			true, new PointF(-Width / 2 + Height / 4, 0),
			new PointF(-Width / 2, 0), new PointF(-Width / 2, -Height / 4)));
		element.PathData.Add(new SvgCubicCurveSegment(
			true, new PointF(0, -Height / 4), new PointF(0, -Height * 0.75f),
			new PointF(Width / 2, -Height * 0.75f)));

		return element;
	}
}