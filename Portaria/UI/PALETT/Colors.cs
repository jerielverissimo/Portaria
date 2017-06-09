﻿using System;
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
        private Color azulTitleBar = ColorTranslator.FromHtml("#1976D2");
        private Color azulSideBar = ColorTranslator.FromHtml("#58aff4");
        private Color azulSideBarHighlight = ColorTranslator.FromHtml("#7bc0f7");
        private Color azulActionBar = ColorTranslator.FromHtml("#2196F3");
        private Color verdeNotify = ColorTranslator.FromHtml("#b2ff59");

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

        public Color AzulTitleBar
        {
            get
            {
                return azulTitleBar;
            }

            set
            {
                azulTitleBar = value;
            }
        }

        public Color AzulSideBar
        {
            get
            {
                return azulSideBar;
            }

            set
            {
                azulSideBar = value;
            }
        }

        public Color AzulSideBarHighlight
        {
            get
            {
                return azulSideBarHighlight;
            }

            set
            {
                azulSideBarHighlight = value;
            }
        }

        public Color AzulActionBar
        {
            get
            {
                return azulActionBar;
            }

            set
            {
                azulActionBar = value;
            }
        }

        public Color VerdeNotify
        {
            get
            {
                return verdeNotify;
            }

            set
            {
                verdeNotify = value;
            }
        }
    }
}