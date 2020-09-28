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
        BoxView pea, anber, keha, keha2, anber2, eye1, eye2, nupp1, nupp2, nupp3, nupp4, nupp5, mounth;
        Button Hide, randm, melt;
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

            //Левый глаз
            eye1 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(eye1, new Rectangle(0.48, 0.2, 10, 10));
            AbsoluteLayout.SetLayoutFlags(eye1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(eye1);
            Content = abs;

            //Правый глаз
            eye2 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(eye2, new Rectangle(0.52, 0.2, 10, 10));
            AbsoluteLayout.SetLayoutFlags(eye2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(eye2);
            Content = abs;

            //Пуговица1
            nupp1 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(nupp1, new Rectangle(0.5, 0.55, 20, 20));
            AbsoluteLayout.SetLayoutFlags(nupp1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(nupp1);
            Content = abs;

            //Пуговица2
            nupp2 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(nupp2, new Rectangle(0.5, 0.50, 20, 20));
            AbsoluteLayout.SetLayoutFlags(nupp2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(nupp2);
            Content = abs;

            //Пуговица3
            nupp3 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(nupp3, new Rectangle(0.5, 0.45, 20, 20));
            AbsoluteLayout.SetLayoutFlags(nupp3, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(nupp3);
            Content = abs;

            //Пуговица4
            nupp4 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(nupp4, new Rectangle(0.5, 0.35, 20, 20));
            AbsoluteLayout.SetLayoutFlags(nupp4, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(nupp4);

            //Пуговица5
            nupp5 = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(nupp5, new Rectangle(0.5, 0.30, 20, 20));
            AbsoluteLayout.SetLayoutFlags(nupp5, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(nupp5);

            //Ротик
            mounth = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(mounth, new Rectangle(0.5, 0.23, 40, 10));
            AbsoluteLayout.SetLayoutFlags(mounth, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(mounth);

           //Кнопка спрятать или показать
            Hide = new Button { Text = "Спрячь или покажи" };
            Hide.Clicked += Hide_Clicked;
            AbsoluteLayout.SetLayoutBounds(Hide, new Rectangle(0.1, 0.9, 100, 100));
            AbsoluteLayout.SetLayoutFlags(Hide, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(Hide);
            Hide.BackgroundColor = Color.Red;

            //Кнопка Рандомный цвет снеговика или вернуть на предыдущий
            randm = new Button { Text = "Разукрась или верни" };
            randm.Clicked += Randm_Clicked;
            AbsoluteLayout.SetLayoutBounds(randm, new Rectangle(0.5, 0.9, 100, 100));
            AbsoluteLayout.SetLayoutFlags(randm, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(randm);
            randm.BackgroundColor = Color.Yellow;

            //Кнопка чтобы растопить и вернуть обратно
            melt = new Button { Text = "Растопи и верни" };
            melt.Clicked += Melt_Clicked;
            AbsoluteLayout.SetLayoutBounds(melt, new Rectangle(0.9, 0.9, 100, 100));
            AbsoluteLayout.SetLayoutFlags(melt, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(melt);
            melt.BackgroundColor = Color.Green;
            Content = abs;

        }

        private void Melt_Clicked(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        private void Randm_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b = rnd.Next(0, 255);
                pea.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                anber.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                keha.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                keha2.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                anber2.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                eye1.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                eye2.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                nupp1.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                nupp2.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                nupp3.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                nupp4.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                nupp5.Color = Color.FromRgb(r, g, b);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b = rnd.Next(0, 255);
                mounth.Color = Color.FromRgb(r, g, b);
                flag = false;
            }
            else
            {
                
                pea.Color = Color.LightSkyBlue;
                anber.Color = Color.Black;
                keha.Color = Color.LightSkyBlue;
                keha2.Color = Color.LightSkyBlue;
                anber2.Color = Color.Black;
                eye1.Color = Color.Black;
                eye2.Color = Color.Black;
                nupp1.Color = Color.Black;
                nupp2.Color = Color.Black;
                nupp3.Color = Color.Black;
                nupp4.Color = Color.Black;
                nupp5.Color = Color.Black;
                mounth.Color = Color.Black;
                flag = true;

            }

        }
        bool flag = true;
        private void Hide_Clicked(object sender, EventArgs e)
        {
            if (flag)
          { pea.Opacity = 0;
            anber.Opacity = 0;
            keha.Opacity = 0;
            keha2.Opacity = 0;
            anber2.Opacity = 0;
            eye1.Opacity = 0;
            eye2.Opacity = 0;
            nupp1.Opacity = 0;
            nupp2.Opacity = 0;
            nupp3.Opacity = 0;
            nupp4.Opacity = 0;
            nupp5.Opacity = 0;
            mounth.Opacity = 0;
                flag = false;
           }
            else
            {
                pea.Opacity = 1;
                anber.Opacity = 1;
                keha.Opacity = 1;
                keha2.Opacity = 1;
                anber2.Opacity = 1;
                eye1.Opacity = 1;
                eye2.Opacity = 1;
                nupp1.Opacity = 1;
                nupp2.Opacity = 1;
                nupp3.Opacity = 1;
                nupp4.Opacity = 1;
                nupp5.Opacity = 1;
                mounth.Opacity = 1;
                flag = true;
            }
        }
}
}