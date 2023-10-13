using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintarObjetos.Graficos
{
    internal class PintarConPatron : IDrawable
    {
        IPattern pattern;
        public void Draw(ICanvas superficie, RectF dirtyRect)
        {
            // Create a 10x10 template for the pattern
            using (PictureCanvas picture = new PictureCanvas(0, 0, 10, 10))
            {
                picture.StrokeColor = Colors.Red;
                picture.DrawLine(0, 0, 10, 10);
                picture.DrawLine(0, 10, 10, 0);
                pattern = new PicturePattern(picture.Picture, 10, 10);
            }

            // Fill the rectangle with the 10x10 pattern
            PatternPaint patternPaint = new PatternPaint
            {
                Pattern = pattern
            };
            superficie.SetFillPaint(patternPaint, RectF.Zero);
            superficie.FillRectangle(10, 10, 250, 250);
        }
    }
}
