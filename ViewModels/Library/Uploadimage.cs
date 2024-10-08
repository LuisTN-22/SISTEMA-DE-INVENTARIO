﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox)
        {
            //Establecer la propiedad de WaitOnLoad a true significa que la imagen se carga de forma sincronica
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }
        public Image ResizeImage(Image srcImage, int newWidth, int newHeight)
        {
            using (var imagenBitmap = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.SetResolution(Convert.ToInt32(srcImage.HorizontalResolution),
                    Convert.ToInt32(srcImage.HorizontalResolution));
                using (var imagenGraphics = Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight),
                        new Rectangle(0, 0, srcImage.Width, srcImage.Height), GraphicsUnit.Pixel);
                    MemoryStream imagenmemoryStream = new MemoryStream();
                    imagenBitmap.Save(imagenmemoryStream, ImageFormat.Png);
                    srcImage = Image.FromStream(imagenmemoryStream);
                }

            }
            return srcImage;
        }
        public byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
