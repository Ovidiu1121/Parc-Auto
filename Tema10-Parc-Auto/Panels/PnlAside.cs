using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlAside:Panel
    {
        private Button btnVehicleCategory;
        private Button btnAddVehicle;
        private Button btnManageVehicle;
        private Button btnClients;
        private FrmHome form;

        public PnlAside(FrmHome form)
        {

            this.form = form;
            this.Location=new Point(0, 0);
            this.Size = new Size(182, 450);
            this.BackColor = Color.AliceBlue;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top|AnchorStyles.Bottom;
            this.Name="PnlAside";

            this.btnVehicleCategory = new Button();
            this.Controls.Add(this.btnVehicleCategory);
            this.btnVehicleCategory.FlatStyle = FlatStyle.Flat;
            this.btnVehicleCategory.FlatAppearance.BorderSize = 0;
            this.btnVehicleCategory.Font=new Font("Arial",10,FontStyle.Bold);
            this.btnVehicleCategory.Location=new Point(0, 87);
            this.btnVehicleCategory.Size=new Size(182, 68);
            this.btnVehicleCategory.Text="Vehicle Category";

            this.btnAddVehicle=new Button();
            this.Controls.Add(this.btnAddVehicle);
            this.btnAddVehicle.FlatStyle = FlatStyle.Flat;
            this.btnAddVehicle.FlatAppearance.BorderSize = 0;
            this.btnAddVehicle.Font=new Font("Arial", 10, FontStyle.Bold);
            this.btnAddVehicle.Location=new Point(0, 155);
            this.btnAddVehicle.Size=new Size(182, 68);
            this.btnAddVehicle.Text="Add Vehicle";

            this.btnManageVehicle=new Button();
            this.Controls.Add(this.btnManageVehicle);
            this.btnManageVehicle.FlatStyle = FlatStyle.Flat;
            this.btnManageVehicle.FlatAppearance.BorderSize = 0;
            this.btnManageVehicle.Font=new Font("Arial", 10, FontStyle.Bold);
            this.btnManageVehicle.Location=new Point(0, 223);
            this.btnManageVehicle.Size=new Size(182, 68);
            this.btnManageVehicle.Text="Manage Vehicle";

            this.btnClients=new Button();
            this.Controls.Add(this.btnClients);
            this.btnClients.FlatStyle = FlatStyle.Flat;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.Font=new Font("Arial", 10, FontStyle.Bold);
            this.btnClients.Location=new Point(0, 291);
            this.btnClients.Size=new Size(182, 68);
            this.btnClients.Text="Clinets";

        }

    }
}
