using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlMain:Panel
    {
        private Label lblDashboard;
        private FrmHome form;
        public PnlMain(FrmHome form)
        {
            this.form = form;
            this.Location = new Point(182, 0);
            this.Size = new Size(618, 450);
            this.BackColor = Color.Beige;
            this.Name="PnlMain";
            this.Anchor = AnchorStyles.Right|AnchorStyles.Left|AnchorStyles.Top|AnchorStyles.Bottom;
           

            this.lblDashboard = new Label();
            this.Controls.Add(this.lblDashboard);
            this.lblDashboard.Location = new Point(223, 229);
            this.lblDashboard.Size = new Size(160, 37);
            this.lblDashboard.Text="Dahsboard";
            this.lblDashboard.Font=new Font("Arial", 16, FontStyle.Bold);
            this.lblDashboard.Anchor=AnchorStyles.None;

        }


    }
}
