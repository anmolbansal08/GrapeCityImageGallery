using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGalleryv1._0._1
{
    class CircularTextBox:TextBox
    {
        protected override void OnPaint(PaintEventArgs pevent)//overrides OnPaint Method of TextBox Class
                                                              //modify the abstract or implementation of  inherited method OnPaint Method
                                                              // pevent:
                                                              //     A System.Windows.Forms.PaintEventArgs that contains the event data
        {
            GraphicsPath grPath = new GraphicsPath();//initialises a new instance of the GraphicsPath Class
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }

    }
}
