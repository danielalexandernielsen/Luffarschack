using System;
using Xamarin.Forms;

namespace Luffarschack
{
    class Draw
    {
        static Grid catchBoard;

        static Button button00 = new Button { BackgroundColor = Color.Beige };
        static Button button10 = new Button { BackgroundColor = Color.Beige };
        static Button button20 = new Button { BackgroundColor = Color.Beige };
        static Button button01 = new Button { BackgroundColor = Color.Beige };
        static Button button11 = new Button { BackgroundColor = Color.Beige };
        static Button button21 = new Button { BackgroundColor = Color.Beige };
        static Button button02 = new Button { BackgroundColor = Color.Beige };
        static Button button12 = new Button { BackgroundColor = Color.Beige };
        static Button button22 = new Button { BackgroundColor = Color.Beige };

        public static void Button00(object sender, EventArgs e) { putMarkerAndNextTurn(0, 0, button00); }
        public static void Button10(object sender, EventArgs e) { putMarkerAndNextTurn(1, 0, button10); }
        public static void Button20(object sender, EventArgs e) { putMarkerAndNextTurn(2, 0, button20); }
        public static void Button01(object sender, EventArgs e) { putMarkerAndNextTurn(0, 1, button01); }
        public static void Button11(object sender, EventArgs e) { putMarkerAndNextTurn(1, 1, button11); }
        public static void Button21(object sender, EventArgs e) { putMarkerAndNextTurn(2, 1, button21); }
        public static void Button02(object sender, EventArgs e) { putMarkerAndNextTurn(0, 2, button02); }
        public static void Button12(object sender, EventArgs e) { putMarkerAndNextTurn(1, 2, button12); }
        public static void Button22(object sender, EventArgs e) { putMarkerAndNextTurn(2, 2, button22); }


        public static void Board(Grid board)
        {
            catchBoard = board;

            button00.Clicked += Button00;
            button10.Clicked += Button10;
            button20.Clicked += Button20;
            button01.Clicked += Button01;
            button11.Clicked += Button11;
            button21.Clicked += Button21;
            button02.Clicked += Button02;
            button12.Clicked += Button12;
            button22.Clicked += Button22;

            board.Children.Add(button00, 0, 0);
            board.Children.Add(button10, 1, 0);
            board.Children.Add(button20, 2, 0);

            board.Children.Add(button01, 0, 1);
            board.Children.Add(button11, 1, 1);
            board.Children.Add(button21, 2, 1);

            board.Children.Add(button02, 0, 2);
            board.Children.Add(button12, 1, 2);
            board.Children.Add(button22, 2, 2);
        }



        static void putMarkerAndNextTurn(int column, int row, Button button)
        {
            catchBoard.Children.Remove(button);
            if ("x".Equals(Game.player))
                catchBoard.Children.Add(new Image { Source = "cross", BackgroundColor = Color.Beige }, column, row);
            else
                catchBoard.Children.Add(new Image { Source = "circle", BackgroundColor = Color.Beige }, column, row);

            Game.NextTurn();
        }
    }
}
