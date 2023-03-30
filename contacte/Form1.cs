using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contacte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class persoana
        {
            public string codpersoana;
            public string nume;
            public string prenume;
            public string telefon;
            public string compania;
            public string adresa;
            public string email;
            public string socialnetworkaccount;
            public DateTime data = new DateTime();
            public string alteinfo;
            public persoana() { }
            public persoana(string pcodpersoana, string pnume, string pprenume, string ptelefon, string pcompania, string padresa, string pemail, string psocialnetworkaccount)
            { 
                this.codpersoana = pcodpersoana;
                this.nume = pnume;
                this.prenume = pprenume;
                this.telefon = ptelefon;
                this.compania = pcompania;
                this.adresa = padresa;
                this.email = pemail;
                this.socialnetworkaccount = psocialnetworkaccount;
                this.data = DateTime.Now;
            }
        }

        public class contacte
        { 
            public List<persoana> listadecontacte = new List<persoana>();
            public void addPersoanaInListaDeContacte(persoana pp)
            {
                listadecontacte.Add(pp);
            }
            public string printPersoana(int i)
            {
                string str = "";
                str += listadecontacte[i].codpersoana;
                str += ",";
                str += listadecontacte[i].nume;
                str += ",";
                str += listadecontacte[i].prenume;
                str += ",";
                str += listadecontacte[i].telefon;
                str += ",";
                str += listadecontacte[i].compania;
                str += ",";
                str += listadecontacte[i].adresa;
                str += ",";
                str += listadecontacte[i].email;
                str += ",";
                str += listadecontacte[i].socialnetworkaccount;
                str += ",";
                str += listadecontacte[i].data.ToString();
                str += ";\r\n";


                return str;
            }
            public void printToataListaDeContacte(ref TextBox pt)
            { 
                for(int i = 0; i < listadecontacte.Count; i++)
                {
                    pt.Text += printPersoana(i);
                }
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public contacte olistadecontacte = new contacte();
        private void button1_Click(object sender, EventArgs e)
        {
            olistadecontacte.addPersoanaInListaDeContacte(new persoana("1","alexandrescu","sebastian","0754678567","nac","nc","nc","nc"));
            this.textBox1.Text = olistadecontacte.printPersoana(0);
        }
    }
}
