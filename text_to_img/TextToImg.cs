using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_to_img
{
    /*
    Я пытался сделать расшифровку jpg, но там проблемы в том что jpg сжимает пиксели 
    и цвет в разных пикселях может иметь разный rgb и выглядеть при этом одинаково.
    По этому я начал юзать Bmp.
    */
    class TextToImg
    {
        public string Text { get; set; }
        int imgSize;
        public Bitmap bmp;

        public TextToImg(string txt, int size)
        {
            Text = txt;
            imgSize = size;
            bmp = new(imgSize, imgSize);
        }

        public string TextToBin()
        {
            string res = "";
            string tmp = "";
            for (int i = 0; i < Text.Length; i++)
            {
                tmp = Convert.ToString(Text[i], 2);
                for (int j = 0; j < 8 - tmp.Length; j++)
                {
                    res += '0';
                }
                res += tmp;
            }
            
            return res;
        }

        public Graphics CreateImg(Color color)
        {
            //Работа с текстом
            string bin = TextToBin();
            int size = (int)(Math.Sqrt(bin.Length) + 1);
            char[,] arr = new char[size, size];
            int x = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (x < bin.Length)
                        arr[i, j] = bin[x++];
                    else
                        arr[i, j] = '0';
                }
            }

            //Создание картинки
            int rectSz = imgSize / size;

            Brush b = new SolidBrush(Color.Gray);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(b, 0,0, imgSize, imgSize);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) 
                { 
                    if(arr[i, j] == '0')
                        b = new SolidBrush(Color.Black);
                    else if (arr[i, j] == '1')
                        b = new SolidBrush(color);

                    g.FillRectangle(b, j * rectSz, i * rectSz, rectSz-1, rectSz-1);
                }
            }
            g.FillRectangle(new SolidBrush(Color.Black), 0, 1, 1, 1);

            return g;
        }

        public static string Decode(string fileName)
        {
            string res = "";
            try
            {
                Bitmap img = new Bitmap(fileName);
                int imgsz = img.Width;

                int RectCount = 0;
                for (int i = 0; i < imgsz-1; i++)
                {
                    if(img.GetPixel(i, 0) == img.GetPixel(imgsz - 1, 0) && img.GetPixel(i+1, 0)!=img.GetPixel(imgsz - 1, 0))
                        if (img.GetPixel(i, 0) == img.GetPixel(imgsz-1, 0))
                            RectCount++;
                }
                RectCount++;

                int RectSZ = imgsz /RectCount;
                int count = 0;
                for (int i = 0; i < RectCount; i++)
                {
                    for (int j = 0; j < RectCount; j++)
                    {
                        if (img.GetPixel(j * RectSZ, i * RectSZ) == img.GetPixel(0, 1))
                        {
                            res += "0";
                            count++;
                        }
                        else if (img.GetPixel(j * RectSZ, i * RectSZ) != img.GetPixel(imgsz - 1, 0))
                        {
                            res += "1";
                            count++;
                        }
                    }
                }

                byte[] bytes = new byte[res.Length / 8];
                for (int i = 0; i < res.Length / 8; i++)
                {
                    bytes[i] = Convert.ToByte(res.Substring(i * 8, 8), 2);
                }

                res = Encoding.UTF8.GetString(bytes);
            }
            catch { }
            return res;
        }

        public void SaveFile(string path)
        {
            bmp.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
