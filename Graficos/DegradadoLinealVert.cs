using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintarObjetos.Graficos
{
    internal class DegradadoLinealVert : IDrawable
    {
        public void Draw(ICanvas superficie, RectF dirtyRect)
        {
            LinearGradientPaint linearGradientPaint = new LinearGradientPaint
            {
                StartColor = Colors.Yellow,
                EndColor = Colors.Green,
                // StartPoint is already (0,0)
                EndPoint = new Point(0, 1)
            };

            RectF linearRectangle = new RectF(10, 10, 200, 100);
            superficie.SetFillPaint(linearGradientPaint, linearRectangle);
            superficie.SetShadow(new SizeF(10, 10), 10, Colors.Grey);
            superficie.FillRoundedRectangle(linearRectangle, 12);
        }
    }
}
