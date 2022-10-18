using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class Masina
    {

        private string marca;
        private string caroser;
        private int price;
        private int year;

        public Masina()
        {

        }

        public Masina(string marca,string caroser,int price, int year)
        {
            this.marca = marca;
            this.caroser = caroser;
            this.price = price;
            this.year = year;
        }

        public Masina(string text)
        {

            string[] p = text.Split(",");

            this.marca=p[0];
            this.caroser=p[1];
            this.price = int.Parse(p[2]);
            this.year=int.Parse(p[3]);
        }

        public string describe()
        {

            string text = "";

            text+=this.marca+",";
            text+=this.caroser+",";
            text+=this.price+",";
            text+=this.year+"\n";

            return text;

        }

        public string getMarca()
        {
            return this.marca;
        }

        public void setMarca(string marca)
        {
            this.marca=marca;
        }

        public string getCaroser()
        {
            return this.caroser;
        }

        public void setCaroser(string caroser)
        {
            this.caroser=caroser;
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setPrice(int price)
        {
            this.price=price;

        }

        public int getYear()
        {
            return this.year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public string toSave()
        {

            string text = "";

            text+=this.marca+",";
            text+=this.caroser+",";
            text+=this.price+",";
            text+=this.year;

            return text;

        }


    }
}
