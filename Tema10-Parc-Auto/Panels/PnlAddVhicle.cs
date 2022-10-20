using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class PnlAddVhicle:Panel
    {
        private Label lblMarca;
        private Label lblCaroser;
        private Label lblPrice;
        private Label lblYear;
        private TextBox txtMarca;
        private TextBox txtCaroser;
        private TextBox txtPrice;
        private TextBox txtYear;
        private Button btnAdd;
        private Button btnCancel;
        private FrmHome form;
        private ControlMasina control = new ControlMasina();

        public PnlAddVhicle(FrmHome form)
        {

            this.form = form;
            this.Location = new Point(182, 87);
            this.Size = new Size(618, 363);
            this.Name="PnlAddVhicle";
            this.BackColor=Color.Orange;
            this.Anchor=AnchorStyles.Right|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Top;

            this.lblMarca=new Label();
            this.Controls.Add(this.lblMarca);
            this.lblMarca.Location=new Point(88, 85);
            this.lblMarca.Text="Marca";
            this.lblMarca.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblMarca.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblCaroser=new Label();
            this.Controls.Add(this.lblCaroser);
            this.lblCaroser.Location=new Point(88, 148);
            this.lblCaroser.Text="Caroser";
            this.lblCaroser.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblCaroser.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblPrice=new Label();
            this.Controls.Add(this.lblPrice);
            this.lblPrice.Location=new Point(88, 210);
            this.lblPrice.Text="Price";
            this.lblPrice.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblPrice.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.lblYear=new Label();
            this.Controls.Add(this.lblYear);
            this.lblYear.Location=new Point(88, 270);
            this.lblYear.Text="Year";
            this.lblYear.Font=new Font("Arial", 11, FontStyle.Bold);
            this.lblYear.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtMarca=new TextBox();
            this.Controls.Add(this.txtMarca);
            this.txtMarca.Location=new Point(185, 82);
            this.txtMarca.Size=new Size(125, 27);
            this.txtMarca.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtCaroser=new TextBox();
            this.Controls.Add(this.txtCaroser);
            this.txtCaroser.Location=new Point(185, 145);
            this.txtCaroser.Size=new Size(125, 27);
            this.txtCaroser.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtPrice=new TextBox();
            this.Controls.Add(this.txtPrice);
            this.txtPrice.Location=new Point(185, 203);
            this.txtPrice.Size=new Size(125, 27);
            this.txtPrice.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.txtYear=new TextBox();
            this.Controls.Add(this.txtYear);
            this.txtYear.Location=new Point(185, 267);
            this.txtYear.Size=new Size(125, 27);
            this.txtYear.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            this.btnAdd=new Button();
            this.Controls.Add(this.btnAdd);
            this.btnAdd.Location=new Point(401, 139);
            this.btnAdd.Size=new Size(94, 29);
            this.btnAdd.FlatAppearance.BorderSize=0;
            this.btnAdd.FlatStyle=FlatStyle.Flat;
            this.btnAdd.Text="Add";
            this.btnAdd.Font=new Font("Arial", 13, FontStyle.Bold);
            this.btnAdd.Click+=new EventHandler(this.add_Click);

            this.btnCancel=new Button();
            this.Controls.Add(this.btnCancel);
            this.btnCancel.Location=new Point(401, 190);
            this.btnCancel.Size=new Size(94, 29);
            this.btnCancel.FlatAppearance.BorderSize=0;
            this.btnCancel.FlatStyle=FlatStyle.Flat;
            this.btnCancel.Text="Cancel";
            this.btnCancel.Font=new Font("Arial", 13, FontStyle.Bold);
            this.btnCancel.Click+=new EventHandler(this.cancel_Click);

        }

        private void add_Click(object sender, EventArgs e)
        {

            if (this.txtMarca.Equals("")==false&&this.txtCaroser.Equals("")==false&&this.txtPrice.Text.Equals("")==false&&this.txtYear.Equals("")==false)
            {

                Masina book = new Masina(this.txtMarca.Text, this.txtCaroser.Text, int.Parse(this.txtPrice.Text), int.Parse(this.txtYear.Text));

                this.control.add(book);
                this.control.save();

                this.form.Controls.Remove(this.form.activeMainPanel);
                this.form.activeMainPanel=new PnlMain(this.form);
                this.form.Controls.Add(this.form.activeMainPanel);

            }
            else if (this.txtMarca.Equals("")==true||this.txtCaroser.Equals("")==true||this.txtPrice.Text.Equals("")==true||this.txtYear.Equals("")==true)
            {
                MessageBox.Show("Exista minim un camp necompletat.");

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.form.Controls.Remove(this.form.activeMainPanel);
            this.form.activeMainPanel=new PnlMain(this.form);
            this.form.Controls.Add(this.form.activeMainPanel);

        }



    }
}
