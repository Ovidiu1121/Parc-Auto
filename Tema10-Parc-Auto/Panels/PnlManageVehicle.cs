using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlManageVehicle:Panel
    {
        private ListView lst;
        private FrmHome form;
        private ControlMasina control=new ControlMasina();

        public PnlManageVehicle(FrmHome form)
        {

            this.form = form;
            this.Location = new Point(182, 87);
            this.Size = new Size(618, 363);
            this.Name="PnlManageVehicle";
            this.BackColor = Color.Wheat;
            this.Anchor=AnchorStyles.Right|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Top;
            

            this.lst = new ListView();
            this.Controls.Add(this.lst);
            this.lst.View=View.Details;
            this.lst.GridLines=true;
            this.lst.Location=new Point(39, 40);
            this.lst.Size=new Size(551, 294);
            this.lst.BackColor=Color.AliceBlue;

            this.populate(this.control.getAllMasini());

        }

        private void populate(List<Masina> lista)
        {

            this.lst.Clear();
            this.lst.Columns.Add("Marca",100,HorizontalAlignment.Left);
            this.lst.Columns.Add("Caroser", 150, HorizontalAlignment.Center);
            this.lst.Columns.Add("Price", 150, HorizontalAlignment.Center);
            this.lst.Columns.Add("Year", 145, HorizontalAlignment.Center);

            foreach(Masina masina in lista)
            {
               
                ListViewItem item=new ListViewItem();

                item.Text=masina.getMarca();
                item.SubItems.Add(masina.getCaroser().ToString());
                item.SubItems.Add(masina.getPrice().ToString());
                item.SubItems.Add(masina.getYear().ToString());

                this.lst.Items.Add(item);
            }

        }


    }
}
