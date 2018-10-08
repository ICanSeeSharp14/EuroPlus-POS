using System;

namespace ITA_UI.Classes.Helpers
{
    public class EnumHelper
    {
        public static T ParseEnum<T>(string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }
    }
}