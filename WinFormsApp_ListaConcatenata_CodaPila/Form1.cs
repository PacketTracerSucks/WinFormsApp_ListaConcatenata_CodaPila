namespace WinFormsApp_ListaConcatenata_CodaPila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista l;
        private void buttonPush_Click(object sender, EventArgs e)
        {
            string valore = textBoxValore.Text;
            textBoxValore.Clear();
            textBoxValore.Focus();
            if (l == null)
            {
                l = new Lista(valore); Visualizza();
            }
            else
            {
                l.Push(valore); Visualizza();
            }
        }

        private void buttonPopCoda_Click(object sender, EventArgs e)
        {
            if (l != null)
            {
                l.PopCoda(); Visualizza();
            }
        }

        private void buttonPopPila_Click(object sender, EventArgs e)
        {
            if (l != null)
            {
                l.PopPila(); Visualizza();
            }
        }

        private void buttonSerializza_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Vuoi salvare la lista?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                l.Serializza();
                MessageBox.Show("Salvataggio avvenuto correttamente", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeserializza_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Vuoi caricare l'ultima lista?", "Carica ultimo stato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                l = Lista.Deserializza();
                Visualizza();
                MessageBox.Show("La lista è stata caricata con successo", "Carica ultimo stato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Visualizza()
        {
            listBoxLista.Items.Clear();
            Nodo x = l.Inizio;
            if (x != null)
            {
                listBoxLista.Items.Add(x.Valore);
                while (x.Successivo != null)
                {
                    x = x.Successivo;
                    listBoxLista.Items.Add(x.Valore);
                }
            }
        }
    }
}
