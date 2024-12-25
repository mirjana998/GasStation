using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Model
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public String? Description { set; get; }

        public override string ToString()
        {
            return "Theme id: " + ThemeId + " Description: " + Description;
        }

        public override bool Equals(object? obj)
        {
            return obj is Theme theme && ThemeId == theme.ThemeId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + ThemeId.GetHashCode();
        }


    }
}
