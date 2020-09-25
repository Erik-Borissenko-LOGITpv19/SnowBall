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
    public partial class Page2 : ContentPage
    {
        BoxView pea, anber, keha, keha2, anber2;
        public Page2()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //Голова
            pea = new BoxView { Color = Color.LightSkyBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.5, 0.20, 50, 50));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pea);

            //Ведро
            anber = new BoxView { Color = Color.Black, CornerRadius = 10 };
            AbsoluteLayout.SetLayoutBounds(anber, new Rectangle(0.5, 0.10, 25, 50));
            AbsoluteLayout.SetLayoutFlags(anber, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(anber);

            //Тело
            keha = new BoxView { Color = Color.LightSkyBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.5, 0.30, 100, 100));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha);

            //Тело2
            keha2 = new BoxView { Color = Color.LightSkyBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(keha2, new Rectangle(0.5, 0.50, 150, 150));
            AbsoluteLayout.SetLayoutFlags(keha2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha2);

            //Нижняя часть ведра
            anber2 = new BoxView { Color = Color.Black, CornerRadius = 30 };
            AbsoluteLayout.SetLayoutBounds(anber2, new Rectangle(0.5, 0.17, 60, 15));
            AbsoluteLayout.SetLayoutFlags(anber2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(anber2);


            Content = abs;
        }
    }
}