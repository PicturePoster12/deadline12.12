using System;
namespace Tumakov
{
    public class IFormatable
    {
        public bool IFormat(object obj)
        {
            if (obj is IFormattable formattableObject)
            {
                IFormattable formattableAs = obj as IFormattable;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
