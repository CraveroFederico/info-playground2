using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interf_Icomperer
{
    internal class Persona
    {
        public string nome;
        public string citta;
        public Persona(string nome, string citta)
        {
            this.nome = nome;
            this.citta = citta;
        }

        public override string ToString()
        {
            return $"{nome} - {citta}";
        }

        public class confrontaNome : IComparer<Object>
        {
            int IComparer<Object>.Compare(Object o1, Object o2)
            {
                if (o1 == null && o2 == null) return 0;
                else if (o1 == null) return 1;
                else if (o2 == null) return -1;
                else
                {
                    Persona p1 = (Persona)o1;
                    Persona p2 = (Persona)o2;
                    return String.Compare(p1.nome, p2.nome, true);

                }
            }
        }


        public class confrontaCitta : IComparer<Object>
        {
            int IComparer<Object>.Compare(Object o1, Object o2)
            {
                if (o1 == null && o2 == null) return 0;
                else if (o1 == null) return 1;
                else if (o2 == null) return -1;
                else
                {
                    Persona p1 = (Persona)o1;
                    Persona p2 = (Persona)o2;
                    return String.Compare(p1.nome, p2.nome, true);

                }
            }
        }
    }
}
