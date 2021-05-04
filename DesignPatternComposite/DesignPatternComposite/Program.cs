using DesignPatternComposite.Composite;
using System;

namespace DesignPatternComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Window: Button, text and image
            //Button: text and figure.

            WindowComposite Window = new WindowComposite("Window A");
            TextComposite Text = new TextComposite("Window Text A");
            ImageComposite Image = new ImageComposite("Window Image A");

            ButtonComposite Button = new ButtonComposite("Button A");
            TextComposite Text2 = new TextComposite("Button Text A");
            FigureComposite Figure = new FigureComposite("Button Figure A");

            Window.AddItem(Text);
            Window.AddItem(Image);
            Window.AddItem(Button);
            Console.WriteLine();
            Button.AddItem(Text2);
            Button.AddItem(Figure);

            Window.ShowItem();
            Console.WriteLine();
            Button.ShowItem();

        }
    }
}
