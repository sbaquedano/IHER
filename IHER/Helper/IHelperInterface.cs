namespace IHER.Helper
{
    public interface IHelperInterface
    {
        Label BodyText(string body, string textColor = "", bool bold = false, bool verticalCenter = false, bool horizontalCenter = false);
        Label SubTitle(string subTitle, string textColor = "", bool bold = false, bool verticalCenter = false, bool horizontalCenter = false);
        Label Title(string title, string textColor = "", bool bold = false, bool verticalCenter = false, bool horizontalCenter = false);
    }
}
