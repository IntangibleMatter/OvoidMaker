using Svg;
using Svg.Pathing;
using System.Drawing;

namespace LibOvoidMaker;

public class OvoidShapeFlat : OvoidShape
{

	public override SvgElement ToSvgElement()
	{
		var element = new SvgPath() { PathData = new SvgPathSegmentList() };
		float centerX = Width / 2;
		float topHandleEdgeDistance = Width * 0.2f;
		float centerY = Height / 2;
		float topSideHandleEdgeDistance = Height * 0.2f;
		float sideMainNodeY = Height * 0.7f;
		float bottomSideHandleEdgeDistance = 0;
		float bottomHandleEdgeDistance = Width * 0.1f;
		float bottomLineEdgeDistance = Width * 0.3f;

		element.PathData.Add(
			new SvgMoveToSegment(false, new PointF(centerX, 0)));
		element.PathData.Add(new SvgCubicCurveSegment(
			false, new PointF(topHandleEdgeDistance, 0),
			new PointF(0, topSideHandleEdgeDistance),
			new PointF(0, sideMainNodeY)));
		element.PathData.Add(new SvgCubicCurveSegment(
			false, new PointF(0, Height - bottomSideHandleEdgeDistance),
			new PointF(bottomHandleEdgeDistance, Height),
			new PointF(bottomLineEdgeDistance, Height)));
		element.PathData.Add(new SvgLineSegment(
			false, new PointF(Width - bottomLineEdgeDistance, Height)));
		element.PathData.Add(new SvgCubicCurveSegment(
			false, new PointF(Width - bottomHandleEdgeDistance, Height),
			new PointF(Width, Height - bottomSideHandleEdgeDistance),
			new PointF(Width, sideMainNodeY)));
		element.PathData.Add(new SvgCubicCurveSegment(
			false, new PointF(Width, topSideHandleEdgeDistance),
			new PointF(Width - topHandleEdgeDistance, 0),
			new PointF(centerX, 0)));
		// element.PathData.Add(new SvgCubicCurveSegment(
		// 	true, new PointF(Width / 3, 0), new PointF(Width / 2, Height / 2),
		// 	new PointF(Width / 2, Height * 0.75f)));
		// element.PathData.Add(
		// 	new SvgCubicCurveSegment(true, new PointF(0, Height / 4),
		// 							 new PointF(-Height / 4, Height / 4),
		// 							 new PointF(-Width / 2, Height / 4)));
		// element.PathData.Add(new SvgCubicCurveSegment(
		// 	true, new PointF(-Width / 2 + Height / 4, 0),
		// 	new PointF(-Width / 2, 0), new PointF(-Width / 2, -Height / 4)));
		// element.PathData.Add(new SvgCubicCurveSegment(
		// 	true, new PointF(0, -Height / 4), new PointF(0, -Height * 0.75f),
		// 	new PointF(Width / 2, -Height * 0.75f)));
		//
		return element;
	}
}