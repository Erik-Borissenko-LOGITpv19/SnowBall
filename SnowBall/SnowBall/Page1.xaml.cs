using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SnowBall
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Hide_Clicked(object sender, EventArgs e)
        {
            Head.Opacity = 1;
            Head1.Opacity = 1;
            Head2.Opacity = 1;
            Head4.Opacity = 1;
            Head5.Opacity = 1;
        }

        private void Show_Clicked(object sender, EventArgs e)
        {
            Head.Opacity = 0;
            Head1.Opacity = 0;
            Head2.Opacity = 0;
            Head4.Opacity = 0;
            Head5.Opacity = 0;
        }
        Random rnd = new Random();
        private void Random_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            Head.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            Head2.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            Head4.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            Head5.BackgroundColor = Color.FromRgb(r, g, b);
        }

        private async void Melt_Clicked(object sender, EventArgs e)
        {
            Head.Opacity = 0.75;
            Head1.Opacity = 0.75;
            Head2.Opacity = 0.75;
            Head4.Opacity = 0.75;
            Head5.Opacity = 0.75;
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
            Head.Opacity = 0.50;
            Head1.Opacity = 0.50;
            Head2.Opacity = 0.50;
            Head4.Opacity = 0.50;
            Head5.Opacity = 0.50;
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
            Head.Opacity = 0.25;
            Head1.Opacity = 0.25;
            Head2.Opacity = 0.25;
            Head4.Opacity = 0.25;
            Head5.Opacity = 0.25;
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
            Head.Opacity = 0;
            Head1.Opacity = 0;
            Head2.Opacity = 0;
            Head4.Opacity = 0;
            Head5.Opacity = 0;
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
        }
        private void RotateHat_Clicked(object sender, EventArgs e)
        {

        }
    }
}