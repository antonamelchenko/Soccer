using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer
{
    public class Entity
    {
        public Physics myPhysics;
        public Image sprite;
        public Size mySize;
        int angle = 4;
        public Entity(Size size)
        {
            myPhysics = new Physics();
            sprite = new Bitmap("D:/Учеба/Проекты Visual Studio/Моб разработка/8.jpg");
            mySize = size;
        }

        public void DrawSprite(Graphics g)
        {
            //sprite = new Bitmap(RotateImage(sprite));
            g.DrawImage(sprite, myPhysics.position.X, myPhysics.position.Y, mySize.Width, mySize.Height);
        }

        public Image RotateImage(Image img)
        {
            Bitmap bmp = new Bitmap(170,170);
            
            Graphics gfx = Graphics.FromImage(bmp);

            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //Вращаем изображение
            gfx.RotateTransform(angle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            gfx.DrawImage(img, new PointF(0,0));
            
            gfx.Dispose();

            return bmp;
        }
    }
}
