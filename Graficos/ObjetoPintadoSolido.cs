using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintarObjetos.Graficos
{
    public class ObjetoPintadoSolido : IDrawable
    {

        
        public void Draw(ICanvas superficie, RectF dirtyRect)
        {
            SolidPaint solidPaint = new SolidPaint(Colors.Silver);
            RectF solidRectangle = new RectF(100, 100, 200, 100);
            superficie.SetFillPaint(solidPaint, solidRectangle);
            superficie.SetShadow(new SizeF(10, 10), 10, Colors.Grey);
            superficie.FillRoundedRectangle(solidRectangle, 12);
        }
    }
}
