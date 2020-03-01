using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using MoonSharp.Interpreter;
using Minecraft_But_Classes;
using System.Windows.Forms;

namespace Minecraft_But
{
    public static class Effects
    {
        public static Bitmap ApplyEffect(Bitmap img, FileInfo effect, params Type[] args)
        {
            UserData.RegisterAssembly();
            Script scr = new Script();
            scr.Globals["bmp"] = new decompBitmap(img);
            scr.Globals["effects"] = new ImageEffects();
            scr.Globals["Math"] = new LuaMath();
            scr.Globals["Vector2"] = new Vector2();
            scr.Globals["Vector2List"] = new Vector2List();
            try
            {
                scr.DoFile(effect.FullName);
                DynValue val = scr.Call(scr.Globals["effect"]);

                decompBitmap bmp = (decompBitmap)val.UserData.Object;
                return bmp.toBitmap();
            } catch (ScriptRuntimeException ex)
            {
                MessageBox.Show($@"Plugin {effect.Name} encountered an error:
                {ex.DecoratedMessage}", "Lua error");
                Console.WriteLine("Doh! An error occured! {0}", ex.DecoratedMessage);
                return img;
            }
            catch (InterpreterException e)
            {
                MessageBox.Show($@"Plugin {effect.Name} encountered an error:
                {e.Message}", "Lua error");
                return img;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.Half;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.Clamp);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }

    [MoonSharpUserData]
    public class ImageEffects
    {
        public static decompBitmap Resize(decompBitmap bitmap, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            Bitmap image = bitmap.toBitmap();

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.Half;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.Clamp);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return new decompBitmap(destImage);
        }


    }
}
