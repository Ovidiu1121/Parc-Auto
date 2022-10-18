using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10_Parc_Auto
{
    internal class ControlMasina
    {
        public List<Masina> lista=new List<Masina>();

        public string path = Application.StartupPath+@"/data/masini.txt";

        public ControlMasina()
        {
            this.load();

        }

        public void load()
        {
            this.lista.Clear();

            StreamReader read=new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Masina masina = new Masina(line);
                lista.Add(masina);
            }
            read.Close();
        }

        public string afisare()
        {
            string text = "";

            for(int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].describe();
            }
            return text;
        }

        public List<Masina> getAllMasini()
        {
            return this.lista;
        }

        public string toSave()
        {

            string text = "";
            int i = 0;

            for (i=0; i<lista.Count-1; i++)
            {
                text+=lista[i].toSave()+"\n";
            }

            text+=lista[i].toSave();

            return text;
        }

        public void save()
        {

            StreamWriter writer = new StreamWriter(path);

            writer.Write(toSave());

            writer.Close();

        }

        public void add(Masina masina)
        {

            lista.Add(masina);

        }

        public void delete(string marca)
        {

            for (int i = 0; i<lista.Count; i++)
            {
                if (this.lista[i].getMarca().Equals(marca))
                {
                    this.lista.RemoveAt(i);
                    i--;
                }
            }

        }

        public Masina returnMasinaByMarca(string marca)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getMarca().Equals(marca))
                {
                    return lista[i];
                }
            }
            return null;
        }

        public void update(string marca, Masina newMasina)
        {

            Masina oldMasina = this.returnMasinaByMarca(marca);

            oldMasina.setCaroser(newMasina.getCaroser());
            oldMasina.setPrice(newMasina.getPrice());
            oldMasina.setYear(newMasina.getYear());

        }

    }
}
