﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintarObjetos.Graficos
{
    internal class DegradadoLinealHor : IDrawable
    {
        public void Draw(ICanvas superficie, RectF dirtyRect)
        {
            LinearGradientPaint linearGradientPaint = new LinearGradientPaint
            {
                StartColor = Colors.Yellow,
                EndColor = Colors.Green,
                EndPoint = new Point(1, 0)
            };

            RectF linearRectangle = new RectF(10, 10, 200, 100);
            superficie.SetFillPaint(linearGradientPaint, linearRectangle);
            superficie.SetShadow(new SizeF(10, 10), 10, Colors.Gray);
            superficie.FillRoundedRectangle(linearRectangle, 12);
        }
    }
}
