using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlHeader2:Panel
    {

        private Button btnHome;
        private FrmHome form;
        public PnlHeader2(FrmHome form)
        {
            this.form = form;
            this.Location = new Point(0, 0);
            this.Size = new Size(182, 87);
            this.BackColor = Color.FromArgb(192, 192, 255);
            this.Name="PnlHeader2";
            this.Anchor =AnchorStyles.Left|AnchorStyles.Top;

            this.btnHome = new Button();
            this.Controls.Add(this.btnHome);
            this.btnHome.FlatStyle = FlatStyle.Flat;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Font=new Font("Arial", 14, FontStyle.Bold);
            this.btnHome.Location=new Point(0, 3);
            this.btnHome.Size=new Size(182, 87);
            this.btnHome.Text="Home";
            this.btnHome.Click+=new EventHandler(this.go_to_dashBoard_Click);

        }

        private void go_to_dashBoard_Click(object sender, EventArgs e)
        {

            this.form.Controls.Remove(this.form.activeMainPanel);
            this.form.activeMainPanel=new PnlMain(this.form);
            this.form.Controls.Add(this.form.activeMainPanel);

        }


    }
}
