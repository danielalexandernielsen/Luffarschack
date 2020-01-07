using Xamarin.Forms;

namespace Luffarschack
{
    public class Game : ContentPage
    {
        public static string player;

        public Game()
        {
            Canvas.GenerateGrid(out Grid board, out Grid layout);
            Draw.Board(board);
            player = "x";

            layout.Children.Add(board, 0, 0);
            layout.Children.Add(new BoxView { BackgroundColor = Color.White }, 0, 1);

            Content = layout;
        }

        public static void NextTurn()
        {
            if("x".Equals(player))
                player = "o";
            else
                player = "x";
        }

    }
}