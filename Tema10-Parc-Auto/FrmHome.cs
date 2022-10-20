using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema10_Parc_Auto
{
    public partial class FrmHome : Form
    {

        public Panel aside;
        public Panel header;
        public Panel header2;
        public Panel activeMainPanel;

        public FrmHome()
        {
            InitializeComponent();

            this.aside=new PnlAside(this);
            this.header=new PnlHeader(this);
            this.header2=new PnlHeader2(this);
            this.activeMainPanel=new PnlMain(this);


            this.Controls.Add(this.header2);
            this.Controls.Add(this.aside);
            this.Controls.Add(this.header);
            this.Controls.Add(this.activeMainPanel);
        }
    }
}
