using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics.Text;

namespace IHER.Helper
{
    public class HelperInterface : IHelperInterface
    {
        [Obsolete]
        public Label BodyText(string body, string textColor = "", bool bold = false, bool verticalCenter = false, bool horizontalCenter = false)
        {
            var label = new Label
            {
                Padding = new Thickness(10),
                Text = body,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = (Color)App.Current.Resources.MergedDictionaries.First()["Gray600"],
            };

            if (!string.IsNullOrWhiteSpace(textColor)) label.TextColor = Color.FromHex(textColor);

            if (verticalCenter) label.VerticalOptions = LayoutOptions.CenterAndExpand;

            if (horizontalCenter) label.HorizontalOptions = LayoutOptions.CenterAndExpand;

            if (bold) label.FontAttributes = FontAttributes.Bold;

            return label;
        }

        [Obsolete]
        public Label SubTitle(string subTitle, string textColor = "", bool bold = true, bool verticalCenter = false, bool horizontalCenter = false)
        {
            var label = new Label
            {
                Padding = new Thickness(10, 10, 10, 0),
                Text = subTitle,
                TextColor = (Color)App.Current.Resources.MergedDictionaries.First()["Gray600"],
            };

            if (!string.IsNullOrWhiteSpace(textColor)) label.TextColor = Color.FromHex(textColor);

            if (verticalCenter) label.VerticalOptions = LayoutOptions.CenterAndExpand;

            if (horizontalCenter) label.HorizontalOptions = LayoutOptions.CenterAndExpand;

            if (bold) label.FontAttributes = FontAttributes.Bold;

            return label;
        }

        [Obsolete]
        public Label Title(string title, string textColor = "", bool bold = true, bool verticalCenter = true, bool horizontalCenter = true)
        {
            var label = new Label
            {
                Padding = new Thickness(10),
                Text = title,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 20,
                TextColor = (Color)App.Current.Resources.MergedDictionaries.First()["Black"],
            };

            if (!string.IsNullOrWhiteSpace(textColor)) label.TextColor = Color.FromHex(textColor);

            if (verticalCenter) label.VerticalOptions = LayoutOptions.CenterAndExpand;

            if (horizontalCenter) label.HorizontalOptions = LayoutOptions.CenterAndExpand;

            if (bold) label.FontAttributes = FontAttributes.Bold;

            return label;
        }
    }
}