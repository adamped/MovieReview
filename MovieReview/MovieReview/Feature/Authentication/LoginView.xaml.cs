using MovieReview.Proxy;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieReview.Feature.Authentication
{
	public partial class LoginView : PageProxy
	{
		public LoginView()
		{
			InitializeComponent();
		}

		void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
		{
			// Initialize the Canvas
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			// Clear the Canvas
			canvas.Clear(Color.Transparent.ToSKColor());
			
			var rect = new SKRect(0, (info.Height) * -1, info.Width, info.Height);
			
			SKPaint arcPaint = new SKPaint
			{
				Style = SKPaintStyle.StrokeAndFill,
				Color = Color.FromHex("#FF6063").ToSKColor().WithAlpha(0xEE),
		
			};

			//canvas.DrawOval(info.Width / 2, 0, info.Width / 2, info.Height, arcPaint);

			using (SKPath path = new SKPath())
			{
				path.AddArc(rect, 0, 180);
				canvas.DrawPath(path, arcPaint);
			}

			SKPaint inversePaint = new SKPaint
			{
				Style = SKPaintStyle.StrokeAndFill,
				Color = Color.FromHex("#CCCCCCCC").ToSKColor(),

			};

			using (SKPath path = new SKPath())
			{
				
				path.AddArc(rect, 0, 180);
				path.FillType = SKPathFillType.InverseEvenOdd;
				canvas.DrawPath(path, inversePaint);
			}


		}
	}
}