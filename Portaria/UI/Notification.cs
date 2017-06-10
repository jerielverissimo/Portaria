using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Portaria.UI
{
    class Notification
    {
        #region OBJ
        
        private Timer delay = new Timer();
        PALETT.Colors color = new PALETT.Colors();

        #endregion

        #region VAR

        private float posPanNotify = 0, largPanNotify = 0, tamPanNotify = 0, origemPanNotify = 0;
        private bool notifyAtivada = false;
        private const float PORCENEFX = 0.2f;
        private const int INTERVAL = 4000;

        #endregion

        #region PROPRETIES

        public float PosPanNotify { get => posPanNotify; set => posPanNotify = value; }
        public float LargPanNotify { get => largPanNotify; set => largPanNotify = value; }
        public float TamPanNotify { get => tamPanNotify; set => tamPanNotify = value; }
        public float OrigemPanNotify { get => origemPanNotify; set => origemPanNotify = value; }
        public bool NotifyAtivada { get => notifyAtivada; set => notifyAtivada = value; }
        public Timer Delay { get => delay; set => delay = value; }

        public static float __PORCENEFX => PORCENEFX;


        #endregion


        #region METHODS


        public void setMessage(string msg, bool type, Label lbl, PictureBox ptb, Panel pan)
        {
            switch (type)
            {
                case true:

                    pan.BackColor = color.VerdeNotify;
                    lbl.Text = msg;
                    lbl.ForeColor = color.Gray;
                    ptb.Image = Properties.Resources.check_gray;
                    break;
                case false:
                    pan.BackColor = color.VermelhoNotify;
                    lbl.Text = msg;
                    lbl.ForeColor = color.White;
                    ptb.Image = Properties.Resources.alert;
                    break;
            }
        }
            
        public void elasticAnimation(Panel pan, Timer tm)
        {
            var panel = (Panel) tm.Tag;


            Delay.Tag = tm;

            Delay.Interval = INTERVAL;

            Delay.Tick += new EventHandler(delayEvent);

            pan.Width = Convert.ToInt32(TamPanNotify);
            pan.Left = Convert.ToInt32(OrigemPanNotify);

            switch (NotifyAtivada)
            {
                case false:

                    TamPanNotify += LargPanNotify;
                    OrigemPanNotify -= PosPanNotify;

                    if (pan.Width == panel.ClientSize.Width && pan.Left == 0)
                    {
                        pan.Dock = DockStyle.Top;

                        Delay.Start();

                        NotifyAtivada = true;
                        tm.Enabled = false;
                    }

                    break;

                case true:

                    delay.Stop();
                    pan.Dock = DockStyle.None;
                    TamPanNotify -= LargPanNotify;
                    OrigemPanNotify += PosPanNotify;

                    if (pan.Width == 0 && pan.Left == panel.ClientSize.Width / 2)
                    {
                        Delay.Start();
                        NotifyAtivada = false;
                        tm.Enabled = false;
                    }

                    break;
            }
        }

        private void delayEvent(object sender, EventArgs e)
        {

            var tm = (Timer)Delay.Tag;
            NotifyAtivada = true;

            Delay.Stop();
            tm.Enabled = true;
        }


        #endregion


    }
}
