using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace BindableLayoutsApp
{
    class SportIconConverter : IValueConverter
    {
        static readonly Dictionary<Sport, string> _SportIcons = new Dictionary<Sport, string>()
        {
            { Sport.Baskeball, IconFont.BasketballBall },
            { Sport.Running, IconFont.Running },
            { Sport.Swimming, IconFont.Swimmer },
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _SportIcons[(Sport)value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    static class IconFont
    {
        public const string BasketballBall = "\uf434";
        public const string Swimmer = "\uf5c4";
        public const string Running = "\uf70c";
        public const string FootballBall = "\uf44e";
        public const string VolleyballBall = "\uf45f";
        public const string Bicycle = "\uf206";
        public const string Heart = "\uf004";
    }
}
