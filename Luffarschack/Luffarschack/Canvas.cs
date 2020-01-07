using Xamarin.Forms;

namespace Luffarschack
{
    class Canvas
    {

        public static void GenerateGrid(out Grid board, out Grid layout)
        {
            board = new Grid
            {
                BackgroundColor = Color.White,

                ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                    },

                RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },                       
                    }
            };

            layout = new Grid
            {
                ColumnDefinitions =
                    {
                        new ColumnDefinition { },
                    },

                RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(7, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                    }
            };
        }
    }
}
