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
        BoxView pea, anber, keha;
        public Page2()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //Голова
            pea = new BoxView { Color = Color.LightBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.5, 0.5, 200, 200));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pea);

            //Ведро
            anber = new BoxView { Color = Color.LightBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(anber, new Rectangle(0.4, 0.4, 100, 100));
            AbsoluteLayout.SetLayoutFlags(anber, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(anber);

            //Тело
            keha = new BoxView { Color = Color.LightBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.6, 0.6, 250, 250));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha);
            Content = abs;
        }
    }
}