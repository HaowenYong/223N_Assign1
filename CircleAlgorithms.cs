using System;
using System.Drawing;
using System.Windows.Forms;

public class CircleAlgorithms
{
	public static Rectangle getInformation(int uiwidth, int uiheight, int radius)
	{
		int width = (uiwidth / 2) - radius;
		int height = (uiheight / 2) - radius;
		Point corner = new Point(width, height);
		Size widhigh = new Size(2*radius, 2*radius);
		Rectangle rect = new Rectangle(corner, widhigh);
		return rect;
	}
}