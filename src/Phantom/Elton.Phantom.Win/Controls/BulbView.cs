// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elton.Phantom.Models;

namespace Elton.Phantom.Win.Controls
{
    public partial class BulbView : UserControl
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BulbView()
        {
            InitializeComponent();

            labelBulb.Click += labelBulb_Click;
            btnMore.Click += btnMore_Click;
        }

        BulbDetails bulb = null;
        public BulbDetails Bulb
        {
            get { return this.bulb; }
            set
            {
                if (this.bulb == value)
                    return;
                this.bulb = value;

                RefreshUI();
            }
        }

        PhantomClientEx client = null;
        public void SetClient(PhantomClientEx client)
        {
            this.client = client;
            this.client.BulbStateChanged += client_BulbStateChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshUI();
        }

        void client_BulbStateChanged(object sender, BulbEventArgs e)
        {
            if (e.Bulb != this.bulb)
                return;
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<BulbEventArgs>(client_BulbStateChanged), sender, e);
                return;
            }

            RefreshUI();
        }

        void RefreshUI()
        {
            if (this.bulb == null)
            {
                labelBulb.Visible = false;
                labelTitle.Visible = false;
                btnMore.Visible = false;
            }
            else
            {
                labelBulb.Visible = true;
                labelTitle.Visible = true;
                btnMore.Visible = true;

                this.Enabled = (bulb.Connectivity == "在线");
                labelTitle.Text = string.Format("{0}({1:0}%)", bulb.Name, bulb.Brightness * 100);
                labelBulb.Image = bulb.TurnedOn ? Properties.Resources.bulb_on_48 : Properties.Resources.bulb_off_48;
            }
        }

        void btnMore_Click(object sender, EventArgs e)
        {
            if (this.bulb == null)
                return;

            BulbDetailsForm form = new BulbDetailsForm(this.client, this.bulb);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        void labelBulb_Click(object sender, EventArgs e)
        {
            if (this.bulb == null)
                return;

            if (this.bulb.TurnedOn)
                client.Api.SetBulb(bulb, false);
            else
                client.Api.SetBulb(bulb, true);
        }
    }
}
