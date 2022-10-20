using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlHeader:Panel
    {
        private Label lblTitle;
        private FrmHome form;
        public PnlHeader(FrmHome form)
        {
            this.form = form;
            this.Location = new Point(150, 32);
            this.Size = new Size(618, 87);
            this.BackColor = Color.FromArgb(192, 192, 255);
            this.Name="PnlHeader";
            this.Anchor = AnchorStyles.Right|AnchorStyles.Left|AnchorStyles.Top;
            this.Dock= DockStyle.Top;

            this.lblTitle = new Label();
            this.Controls.Add(this.lblTitle);
            this.lblTitle.Location = new Point(168, 32);
            this.lblTitle.Size = new Size(400, 28);
            this.lblTitle.Text="Parking Management System";
            this.lblTitle.Font=new Font("Arial", 14, FontStyle.Bold);
            this.lblTitle.Anchor=AnchorStyles.None;

        }


        }
    }
