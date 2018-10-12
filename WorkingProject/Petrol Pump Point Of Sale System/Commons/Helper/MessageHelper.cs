
namespace Petrol_Pump_Point_Of_Sale_System.Commons.Helper
{
    public static class MessageHelper
    {
        public static string DuplicateRecord(string text)
        {
            return string.Format("{0} is already used.", text);
        }

        public static string NoInput()
        {
            return "input required.";
        }

        public static string InvalidTextRange(int minimum, int maximum)
        {
            return @"input must have a range between {minimum} to {maximum} characters.";
        }

        public static string InvalidValueRange(int minimum, int maximum)
        {
            return @"value must have a range between {minimum} to {maximum}.";
        }
    }
}
