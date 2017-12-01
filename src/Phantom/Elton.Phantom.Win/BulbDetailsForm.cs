// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elton.Phantom.Win
{
    public partial class BulbDetailsForm : Form
    {
        readonly PhantomClient client = null;
        readonly Bulb bulb = null;
        public BulbDetailsForm(PhantomClient client, Bulb bulb)
        {
            if (bulb == null)
                throw new ArgumentNullException("bulb", "bulb不能为空。");

            this.client = client;
            this.bulb = bulb;
            InitializeComponent();

            this.client.BulbStateChanged += client_BulbStateChanged;
            this.client.BulbRemoved += client_BulbRemoved;
            labelBulb.Click += labelBulb_Click;
            trackBarHue.ValueChanged += trackBar_ValueChanged;
            trackBarBrightness.ValueChanged += trackBar_ValueChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RefreshUI();
        }

        void labelBulb_Click(object sender, EventArgs e)
        {
            if (this.bulb.TurnedOn)
                this.bulb.TurnOff();
            else
                this.bulb.TurnOn();
        }

        void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (isMyself)
                return;

            client.Api.SetBulb(this.bulb,
                (float)(trackBarBrightness.Value / 100.0),
                (float)(trackBarHue.Value / 100.0));
        }

        void client_BulbRemoved(object sender, BulbEventArgs e)
        {
            if(e.Bulb == this.bulb)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        void client_BulbStateChanged(object sender, BulbEventArgs e)
        {
            if (e.Bulb != this.bulb)
                return;

            RefreshUI();
        }

        volatile bool isMyself = false;
        void RefreshUI()
        {
            this.Text = string.Format("{0} ({1})", bulb.Name, bulb.Connectivity);
            labelBulb.Image = bulb.TurnedOn ? Properties.Resources.bulb_on_48 : Properties.Resources.bulb_off_48;

            isMyself = true;
            trackBarHue.Value = (int)(bulb.Hue * 100.0);
            trackBarBrightness.Value = (int)(bulb.Brightness * 100.0);
            isMyself = false;
        }
    }
}
