using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Portaria.VIEW.PALETT
{
    class Colors
    {

        private Color azulBackground = ColorTranslator.FromHtml("#5952FF");
        private Color azulHighLight = ColorTranslator.FromHtml("#716df2");

        public Color AzulBackground
        {
            get
            {
                return azulBackground;
            }

            set
            {
                azulBackground = value;
            }
        }

        public Color AzulHighLight
        {
            get
            {
                return azulHighLight;
            }

            set
            {
                azulHighLight = value;
            }
        }
    }
}
