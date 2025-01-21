using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interf_Icomperer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Persona[] vect = new Persona[] {new Persona("Luca", "Fossano"),
                                            new Persona("Stefano", "Fossano"),
                                            new Persona("Samuele", "Savigliano")};

            Array.Sort(vect, new Persona.confrontaNome());

            string s1 = "ORDINATO IN BASE AL NOME\n";
            for (int i = 0; i < vect.Length; i++)
            {
                s1 += vect[i].ToString() + "\n";
            }
            MessageBox.Show(s1);

            Array.Sort(vect, new Persona.confrontaCitta());

            string s2 = "ORDINATO IN BASE ALLA CITTA\n";
            for (int i = 0; i < vect.Length; i++)
            {
                s2 += vect[i].ToString() + "\n";
            }
            MessageBox.Show(s2);
        }
    }
}
