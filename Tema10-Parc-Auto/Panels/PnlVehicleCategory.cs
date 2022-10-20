using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlVehicleCategory:Panel
    {
        private Label lblCategoryName;
        private Label lblAction;
        private Label lblCar;
        private Label lblTruck;
        private Label lblMorotCycle;
        private Button btnCar;
        private Button btnTruck;
        private Button btnMorotCycle;
        private FrmHome form;

        public PnlVehicleCategory(FrmHome form)
        {

            this.form = form;
            this.Location=new Point(182, 87);
            this.Size = new Size(618, 363);
            this.Name="PnlVehicleCategory";
            this.BackColor=Color.PaleVioletRed;
            this.Anchor=AnchorStyles.Right|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Top;

            this.lblAction=new Label();
            this.Controls.Add(this.lblAction);
            this.lblAction.Location=new Point(409, 61);
            this.lblAction.Size=new Size(77, 28);
            this.lblAction.Text="Action";
            this.lblAction.Font=new Font("Arial",12,FontStyle.Bold);
            
            this.lblCategoryName=new Label();
            this.Controls.Add(this.lblCategoryName);
            this.lblCategoryName.Location=new Point(49, 61);
            this.lblCategoryName.Size=new Size(164, 28);
            this.lblCategoryName.Text="Category Name";
            this.lblCategoryName.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblCar=new Label();
            this.Controls.Add(this.lblCar);
            this.lblCar.Location=new Point(49, 148);
            this.lblCar.Size=new Size(45, 28);
            this.lblCar.Text="Car";
            this.lblCar.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblTruck=new Label();
            this.Controls.Add(this.lblTruck);
            this.lblTruck.Location=new Point(49, 200);
            this.lblTruck.Size=new Size(69, 28);
            this.lblTruck.Text="Truck";
            this.lblTruck.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblMorotCycle=new Label();
            this.Controls.Add(this.lblMorotCycle);
            this.lblMorotCycle.Location=new Point(49, 254);
            this.lblMorotCycle.Size=new Size(123, 28);
            this.lblMorotCycle.Text="Motorcycle";
            this.lblMorotCycle.Font=new Font("Arial", 12, FontStyle.Bold);

            this.btnCar=new Button();
            this.Controls.Add(this.btnCar);
            this.btnCar.Location=new Point(430, 148);
            this.btnCar.Size=new Size(56, 38);
            this.btnCar.FlatAppearance.BorderSize=0;
            this.btnCar.FlatStyle=FlatStyle.Flat;
            this.btnCar.Text="X";
            this.btnCar.Font=new Font("Arial",12, FontStyle.Bold);

            this.btnTruck=new Button();
            this.Controls.Add(this.btnTruck);
            this.btnTruck.Location=new Point(430, 200);
            this.btnTruck.Size=new Size(56, 38);
            this.btnTruck.FlatAppearance.BorderSize=0;
            this.btnTruck.FlatStyle=FlatStyle.Flat;
            this.btnTruck.Text="X";
            this.btnTruck.Font=new Font("Arial", 12, FontStyle.Bold);

            this.btnMorotCycle=new Button();
            this.Controls.Add(this.btnMorotCycle);
            this.btnMorotCycle.Location=new Point(430, 254);
            this.btnMorotCycle.Size=new Size(56, 38);
            this.btnMorotCycle.FlatAppearance.BorderSize=0;
            this.btnMorotCycle.FlatStyle=FlatStyle.Flat;
            this.btnMorotCycle.Text="X";
            this.btnMorotCycle.Font=new Font("Arial", 12, FontStyle.Bold);

        }

    }
}
