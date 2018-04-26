// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Elton.Phantom.Models;

namespace Elton.Phantom.Win.Controls
{
    public partial class HouseView : UserControl
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        readonly Bitmap background = Properties.Resources.house_256;
        readonly Bitmap windowTop = Properties.Resources.house_window_top;
        readonly Bitmap windowBottom = Properties.Resources.house_window_bottom;
        public HouseView()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.FixedWidth
                | ControlStyles.FixedHeight
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.UserPaint,
                true);

            this.BottomBulbName = "客厅";
            this.TopBulbName = "卧室";
        }

        PhantomClientEx client = null;
        public void SetClient(PhantomClientEx client)
        {
            this.client = client;
            this.client.BulbStateChanged += client_BulbStateChanged;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshUI();
        }
        void client_BulbStateChanged(object sender, BulbEventArgs e)
        {
            if (e.Bulb.Name != this.TopBulbName && e.Bulb.Name != this.BottomBulbName)
                return;
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<BulbEventArgs>(client_BulbStateChanged), sender, e);
                return;
            }

            RefreshUI();
        }

        /// <summary>
        /// 
        /// </summary>
        public string BottomBulbName { get; set; }
        public string TopBulbName { get; set; }

        volatile float brightnessBottom = 0.0F;
        volatile float brightnessTop = 0.0F;
        void RefreshUI()
        {
            brightnessBottom = 0.0F;
            brightnessTop = 0.0F;
            if (this.client != null)
            {
                foreach (BulbDetails item in this.client.Bulbs)
                {
                    if (item.Name == this.TopBulbName)
                        this.brightnessTop = item.TurnedOn ? item.Brightness : 0.0F;
                    else if (item.Name == this.BottomBulbName)
                        this.brightnessBottom = item.TurnedOn ? item.Brightness : 0.0F;
                    else
                    {
                        continue;
                    }
                }
            }

            this.Invalidate();
        }

        public static Bitmap ToGray(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色 
                    Color color = bmp.GetPixel(i, j);
                    //利用公式计算灰度值 
                    int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }
        /// <summary>
        /// 图像明暗调整
        /// </summary>
        /// <param name="b">原始图</param>
        /// <param name="degree">亮度[-255, 255]</param>
        /// <returns></returns>
        public static Bitmap KiLighten(Bitmap b, int degree)
        {
            if (b == null)
            {
                return null;
            }

            if (degree < -255) degree = -255;
            if (degree > 255) degree = 255;

            try
            {

                int width = b.Width;
                int height = b.Height;

                int pix = 0;

                BitmapData data = b.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                unsafe
                {
                    byte* p = (byte*)data.Scan0;
                    int offset = data.Stride - width * 3;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            // 处理指定位置像素的亮度
                            for (int i = 0; i < 3; i++)
                            {
                                pix = p[i] + degree;

                                if (degree < 0) p[i] = (byte)Math.Max(0, pix);
                                if (degree > 0) p[i] = (byte)Math.Min(255, pix);

                            } // i
                            p += 3;
                        } // x
                        p += offset;
                    } // y
                }

                b.UnlockBits(data);

                return b;
            }
            catch
            {
                return null;
            }

        } // end of Lighten
        /// <summary>
        /// 图像对比度调整
        /// </summary>
        /// <param name="b">原始图</param>
        /// <param name="degree">对比度[-100, 100]</param>
        /// <returns></returns>
        public static Bitmap KiContrast(Bitmap b, int degree)
        {
            if (b == null)
            {
                return null;
            }

            if (degree < -100) degree = -100;
            if (degree > 100) degree = 100;

            try
            {

                double pixel = 0;
                double contrast = (100.0 + degree) / 100.0;
                contrast *= contrast;
                int width = b.Width;
                int height = b.Height;
                BitmapData data = b.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                unsafe
                {
                    byte* p = (byte*)data.Scan0;
                    int offset = data.Stride - width * 3;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            // 处理指定位置像素的对比度
                            for (int i = 0; i < 3; i++)
                            {
                                pixel = ((p[i] / 255.0 - 0.5) * contrast + 0.5) * 255;
                                if (pixel < 0) pixel = 0;
                                if (pixel > 255) pixel = 255;
                                p[i] = (byte)pixel;
                            } // i
                            p += 3;
                        } // x
                        p += offset;
                    } // y
                }
                b.UnlockBits(data);
                return b;
            }
            catch
            {
                return null;
            }
        } // end of Contrast
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(Color.LightGray);

            int min = -150;
            int max = 20;
            
            Bitmap imageTopWindow = windowTop.Clone(new Rectangle(0, 0, windowTop.Width, windowTop.Height), windowTop.PixelFormat);
            KiLighten(imageTopWindow, (int)(min + (max - min) * this.brightnessTop));
            g.DrawImageUnscaledAndClipped(imageTopWindow, new Rectangle(113, 102, windowTop.Width, windowTop.Height));

            Bitmap imageBottomWindow = windowBottom.Clone(new Rectangle(0, 0, windowBottom.Width, windowBottom.Height), windowBottom.PixelFormat);
            KiLighten(imageBottomWindow, (int)(min + (max - min) * this.brightnessBottom));
            g.DrawImageUnscaledAndClipped(imageBottomWindow, new Rectangle(151, 172, windowBottom.Width, windowBottom.Height));

            g.DrawImageUnscaledAndClipped(background, new Rectangle(0, 0, background.Width, background.Height));
        }
    }
}
