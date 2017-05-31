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
        private Color azulTitleBar = ColorTranslator.FromHtml("#1e88e5");
        private Color azulActionBar = ColorTranslator.FromHtml("#64b5f6");
        private Color azulSideBar = ColorTranslator.FromHtml("#90caf9");

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

        public Color AzulActionBar { get => azulActionBar; set => azulActionBar = value; }
        public Color AzulTitleBar { get => azulTitleBar; set => azulTitleBar = value; }
        public Color AzulSideBar { get => azulSideBar; set => azulSideBar = value; }
    }
}
