using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlAside:Panel
    {
        private Button btnVehCateg;
        private Button btnAddVehicle;
        private Button btnManageVehicle;
        private Button btnClients;
        private FrmHome form;
        private Button currentButton;

        public PnlAside(FrmHome form)
        {

            this.form = form;
            this.Location=new Point(0, 0);
            this.Size = new Size(182, 450);
            this.BackColor = Color.AliceBlue;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top|AnchorStyles.Bottom;
            this.Name="PnlAside";
          
            this.btnVehCateg = new Button();
            this.Controls.Add(this.btnVehCateg);
            this.btnVehCateg.FlatStyle = FlatStyle.Flat;
            this.btnVehCateg.FlatAppearance.BorderSize = 0;
            this.btnVehCateg.Font=new Font("Arial",10,FontStyle.Bold);
            this.btnVehCateg.Location=new Point(0, 87);
            this.btnVehCateg.Size=new Size(182, 68);
            this.btnVehCateg.Text="Vehicle Category";
            this.btnVehCateg.Click+=new EventHandler(this.btnVehicleCategory);

            this.btnAddVehicle=new Button();
            this.Controls.Add(this.btnAddVehicle);
            this.btnAddVehicle.FlatStyle = FlatStyle.Flat;
            this.btnAddVehicle.FlatAppearance.BorderSize = 0;
            this.btnAddVehicle.Font=new Font("Arial", 10, FontStyle.Bold);
            this.btnAddVehicle.Location=new Point(0, 155);
            this.btnAddVehicle.Size=new Size(182, 68);
            this.btnAddVehicle.Text="Add Vehicle";
            this.btnAddVehicle.Click+=new EventHandler(this.btnAddVehicle_Click);

            this.btnManageVehicle=new Button();
            this.Controls.Add(this.btnManageVehicle);
            this.btnManageVehicle.FlatStyle = FlatStyle.Flat;
            this.btnManageVehicle.FlatAppearance.BorderSize = 0;
            this.btnManageVehicle.Font=new Font("Arial", 10, FontStyle.Bold);
            this.btnManageVehicle.Location=new Point(0, 223);
            this.btnManageVehicle.Size=new Size(182, 68);
            this.btnManageVehicle.Text="Manage Vehicle";
            this.btnManageVehicle.Click+=new EventHandler(this.btnManageVehicle_Click);

            this.btnClients=new Button();
            this.Controls.Add(this.btnClients);
            this.btnClients.FlatStyle = FlatStyle.Flat;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.Font=new Font("Arial", 10, FontStyle.Bold);
            this.btnClients.Location=new Point(0, 291);
            this.btnClients.Size=new Size(182, 68);
            this.btnClients.Text="Clinets";

        }

        private void activateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton!=(Button)btnSender)
                {
                    disableButton();
                    currentButton=(Button)btnSender;
                    currentButton.Font=new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    currentButton.ForeColor=Color.White;

                }
            }


        }

        private void disableButton()
        {

            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.Font=new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    previousBtn.ForeColor=Color.Black;
                }
            }

        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {

            this.form.Controls.Remove(this.form.activeMainPanel);
            this.form.activeMainPanel=new PnlManageVehicle(this.form);
            this.form.Controls.Add(this.form.activeMainPanel);

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {

            this.form.Controls.Remove(this.form.activeMainPanel);
            this.form.activeMainPanel=new PnlAddVhicle(this.form);
            this.form.Controls.Add(this.form.activeMainPanel);

        }

        private void btnVehicleCategory(object sender, EventArgs e)
        {

            this.form.Controls.Remove(this.form.activeMainPanel);
            this.form.activeMainPanel=new PnlVehicleCategory(this.form);
            this.form.Controls.Add(this.form.activeMainPanel);

        }
        

    }
}
