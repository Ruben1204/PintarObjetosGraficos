﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintarObjetos.Graficos
{
    internal class DegradadoRadialEnd : IDrawable
    {
        public void Draw(ICanvas superficie, RectF dirtyRect)
        {
            RadialGradientPaint radialGradientPaint = new RadialGradientPaint
            {
                StartColor = Colors.Red,
                EndColor = Colors.DarkBlue,
                Center = new Point(1.0, 1.0)
                // Radius is already 0.5
            };

            RectF radialRectangle = new RectF(10, 10, 200, 100);
            superficie.SetFillPaint(radialGradientPaint, radialRectangle);
            superficie.SetShadow(new SizeF(10, 10), 10, Colors.Grey);
            superficie.FillRoundedRectangle(radialRectangle, 12);
        }
    }
}
