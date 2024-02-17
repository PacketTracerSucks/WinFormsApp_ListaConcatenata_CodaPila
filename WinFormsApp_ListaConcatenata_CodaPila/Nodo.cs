using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ListaConcatenata_CodaPila
{
    public class Nodo
    {
        string valore;
        Nodo successivo;

        public Nodo(string Valore)
        {
            valore = Valore;
        }

        public string Valore { get => valore; set => valore = value; }
        public Nodo Successivo { get => successivo; set => successivo = value; }
    }
}
