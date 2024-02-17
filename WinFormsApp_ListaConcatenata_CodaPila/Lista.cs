using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp_ListaConcatenata_CodaPila
{
    public class Lista
    {
        Nodo inizio;
        Nodo fine;

        public Nodo Inizio { get => inizio; set => inizio = value; }
        public Nodo Fine { get => fine; set => fine = value; }

        public Lista(string Valore)
        {
            Nodo x = new Nodo(Valore);
            inizio = fine = x;
        }

        public void Push(string Valore)
        {
            Nodo x = new Nodo(Valore);
            fine = findLast(); //ci si assicura che il puntato da fine sia proprio l'ultimo nodo
            fine.Successivo = fine = x;
        }

        public void PopCoda()
        {
            if (inizio != null)
            {
                inizio = inizio.Successivo;
            }
            else
            {
                fine = null;
            }
        }

        public void PopPila()
        {
            Nodo corrente = inizio;
            Nodo precedente = null;
            
            if (inizio != null)
            {
                while (corrente.Successivo != null)
                {
                    precedente = corrente;
                    corrente = corrente.Successivo;
                }
            }

            if (precedente != null)
            {
                precedente.Successivo = null;
                fine = precedente;
            }
            else
            {
                inizio = null;
                fine = null;
            }
        }

        public virtual void Serializza()
        {
            File.WriteAllText("lista.json", JsonConvert.SerializeObject(this));
        }

        public static Lista Deserializza()
        {
            Lista? x;
            x = JsonConvert.DeserializeObject<Lista>(File.ReadAllText("lista.json"));
            return x;
        }
        
        private Nodo findLast()
        {
            Nodo x = inizio;
            while (x.Successivo != null)
            {
                x = x.Successivo;
            }
            return x;
        }
    }
}
