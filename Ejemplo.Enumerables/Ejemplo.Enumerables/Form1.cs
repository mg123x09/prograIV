using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo.Enumerables
{
    public partial class Form1 : Form
    {
        IList<string> miListaDeHileras = new List<string>() { "Hello", "WORLD", "TO","EVERYBODY"};
        int contador = 0;
        HashSet<string> miHashSet = new HashSet<string>();
        LinkedList<string> miListaEnlazada = new LinkedList<string>();
        IDictionary <int, string> miDiccionario = new Dictionary<int, string>();
        int tamanoVector = 5;
        string[] miVetorString = new string[5];








        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miListaDeHileras.Add(tbAgregar.Text); //hileras en enumerable
            miDiccionario.Add(contador, tbAgregar.Text); //Diccionario
            miHashSet.Add(tbAgregar.Text);
            if (cbAgregarAlFinal.Checked)
                miListaEnlazada.AddLast(tbAgregar.Text);
                    else
                    miListaEnlazada.AddFirst(tbAgregar.Text);
            //TRY AND CATCH
            try
            {
                miVetorString[contador] = tbAgregar.Text;
                contador++;
                tbAgregar.Text = string.Empty;
                
            }
            catch (IndexOutOfRangeException)//Cuando se sobrepase de 5 en el vector
            {
                //msj de error
                throw;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cbSalida.Items.Clear();//SIEMPRE SE LIMPIA
            foreach (var item in miListaDeHileras)
            {
                cbSalida.Items.Add(item); 
            }
        }

      

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            cbSalida.Items.Clear();//SIEMPRE SE LIMPIA
            foreach (var item in miListaEnlazada)
            {
                cbSalida.Items.Add(item);
            }
        }
    }
}
