using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_But_Classes
{
    public class Effect
    {
        public string Name { get; set; }
        public FileInfo fileInfo { get; set; }
        public Effect(string name, FileInfo fi)
        {
            Name = name;
            fileInfo = fi;
        }
    }

    [MoonSharpUserData]
    public class decompBitmap
    {
        public List<color> colors { get; } = new List<color>();
        public int Width { get; }
        public int Height { get; }
        public int baseWidth { get; }
        public int baseHeight { get; }

        public decompBitmap(int width, int height)
        {
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    colors.Add(new color(255, 255, 255, 0));
                }
            }
            Height = height;
            Width = width;
            baseWidth = Width - 1;
            baseHeight = Height - 1;
        }

        public decompBitmap(Bitmap bitmap)
        {

            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {
                    colors.Add(new color(bitmap.GetPixel(x, y)));
                }
            }
            Height = bitmap.Height;
            Width = bitmap.Width;
        }

        public Bitmap toBitmap()
        {
            Bitmap output = new Bitmap(Width, Height);

            for (var y = 0; y < output.Height; y++)
            {
                for (var x = 0; x < output.Width; x++)
                {
                    output.SetPixel(x, y, GetPixel(x, y).toColor());
                }
            }
            return output;
        }

        public color GetPixel(int x, int y)
        {
            if (x > Width - 1) x = Width - 1;
            if (y > Height - 1) y = Height - 1;
            return colors[y * Width + x];
        }

        public void SetPixel(int x, int y, color col)
        {
            if (!(x > Width - 1 || y > Height - 1)) colors[y * Width + x] = col;
        }

        public int[] GetR()
        {
            List<int> c = new List<int>();
            foreach (color col in colors)
            {
                c.Add(col.r);
            }
            return c.ToArray();
        }

        public int[] GetB()
        {
            List<int> c = new List<int>();
            foreach (color col in colors)
            {
                c.Add(col.g);
            }
            return c.ToArray();
        }

        public int[] GetG()
        {
            List<int> c = new List<int>();
            foreach (color col in colors)
            {
                c.Add(col.b);
            }
            return c.ToArray();
        }

        public int[] GetA()
        {
            List<int> c = new List<int>();
            foreach (color col in colors)
            {
                c.Add(col.a);
            }
            return c.ToArray();
        }

        public int[] GetRGBA()
        {
            List<int> c = new List<int>();
            foreach (color col in colors)
            {
                c.Add(col.a);
            }
            return c.ToArray();
        }

        public Vector2List toVector2List()
        {
            Vector2List v2l = new Vector2List();
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (GetPixel(x, y).a != 0) v2l.add(new Vector2(x, y));
                }
            }
            return v2l;
        }

    }

    [MoonSharpUserData]
    public class color
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int a { get; set; }

        public color() {}
        public color(Color col)
        {
            r = col.R;
            g = col.G;
            b = col.B;
            a = col.A;
        }

        public color(int R, int G, int B, int A)
        {
            r = R;
            g = G;
            b = B;
            a = A;
        }

        public Color toColor()
        {
            return Color.FromArgb(a, r, g, b);
        }

        public HSLA toHSLA()
        {
            return new HSLA(new color(r, g, b, a));
        }

        public bool compareColor(color other)
        {
            return (r == other.r && b == other.b && g == other.g && a == other.a);
        }
    }

    [MoonSharpUserData]
    public class HSLA
    {
        public float h { get; set; }
        public float l { get; set; }
        public float s { get; set; }
        public int a { get; set; }

        public HSLA() { }
        public HSLA(color col)
        {
            float R = (col.r / 255f);
            float G = (col.g / 255f);
            float B = (col.b / 255f);

            float Min = Math.Min(Math.Min(R, G), B);
            float Max = Math.Max(Math.Max(R, G), B);
            float Delta = Max - Min;

            float H = 0;
            float S = 0;
            float L = (float)((Max + Min) / 2.0f);

            if (Delta != 0)
            {
                if (L < 0.5f)
                {
                    S = (float)(Delta / (Max + Min));
                }
                else
                {
                    S = (float)(Delta / (2.0f - Max - Min));
                }


                if (R == Max)
                {
                    H = (G - B) / Delta;
                }
                else if (G == Max)
                {
                    H = 2f + (B - R) / Delta;
                }
                else if (B == Max)
                {
                    H = 4f + (R - G) / Delta;
                }
            }

            h = H;
            s = S;
            l = L;
            a = col.a;
        }

        public color toRGBA()
        {
            byte r, g, b;

            if (h > 1) h = 1;
            if (s > 1) s = 1;
            if (l > 1) l = 1;

            if (s == 0)
            {
                r = (byte)Math.Round(l * 255d);
                g = (byte)Math.Round(l * 255d);
                b = (byte)Math.Round(l * 255d);
            }
            else
            {
                double t1, t2;
                double th = h / 6.0d;

                if (l < 0.5d)
                {
                    t2 = l * (1d + s);
                }
                else
                {
                    t2 = (l + s) - (l * s);
                }
                t1 = 2d * l - t2;

                double tr, tg, tb;
                tr = th + (1.0d / 3.0d);
                tg = th;
                tb = th - (1.0d / 3.0d);

                tr = ColorCalc(tr, t1, t2);
                tg = ColorCalc(tg, t1, t2);
                tb = ColorCalc(tb, t1, t2);
                r = (byte)Math.Round(tr * 255d);
                g = (byte)Math.Round(tg * 255d);
                b = (byte)Math.Round(tb * 255d);
            }
            return new color(r, g, b, a);
        }

        private static double ColorCalc(double c, double t1, double t2)
        {

            if (c < 0) c += 1d;
            if (c > 1) c -= 1d;
            if (6.0d * c < 1.0d) return t1 + (t2 - t1) * 6.0d * c;
            if (2.0d * c < 1.0d) return t2;
            if (3.0d * c < 2.0d) return t1 + (t2 - t1) * (2.0d / 3.0d - c) * 6.0d;
            return t1;
        }
    }

    [MoonSharpUserData]
    class LuaMath
    {
        public int GetRandom(int min, int max, int seed)
        {
            Random rand;
            rand = new Random(seed);
            return rand.Next(min, max);
        }

        /*
        public int[] RandomArray(int min, int max, int arraySize, int seed)
        {
            Random rand;
            rand = new Random(seed);
            return rand.Next(min, max);
        }
        */
    }

    class ExportSettings
    {
        public bool unicode = false;
        public bool blocks = true;
        public bool items = true;
        public bool colormap = true;
        public bool effect = true;
        public bool entity = true;
        public bool environment = true;
        public bool gui = true;
        public bool map = true;
        public bool misc = true;
        public bool potion = true;
        public bool armor = true;
        public bool painting = true;
        public bool particle = true;
    }

    [MoonSharpUserData]
    public class Vector2
    {
        int x { get; set; }
        int y { get; set; }

        public Vector2() { }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    [MoonSharpUserData]
    public class Vector2List
    {
        new List<Vector2> v2s = new List<Vector2>();

        public Vector2List() { }
        public void add(Vector2 vec)
        {
            v2s.Add(vec);
        }

        public void remove(Vector2 vec)
        {
            v2s.Remove(vec);
        }

        public void remove(int index)
        {
            v2s.RemoveAt(index);
        }

        public int count () { return v2s.Count; }

        public bool contains(Vector2 vec)
        {
            return v2s.Contains(vec);
        }

        public bool contains(int x, int y)
        {
            return v2s.Contains(new Vector2(x, y));
        }

        public Vector2 get(int index)
        {
            return v2s[index];
        }
    }

}
