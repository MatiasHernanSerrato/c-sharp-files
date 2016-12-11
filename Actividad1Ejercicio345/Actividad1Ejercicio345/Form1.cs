using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1Ejercicio345
{
    public partial class Form1 : Form
    {
        List<Persona> Persons = new List<Persona>();
        private void llenarDgv()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = Persons;

        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void rdbActivar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivar.Checked == true)
            {
                gbEjercicio3.Enabled = true;
                
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Convert.ToDouble(txbLado1.Text) + Convert.ToDouble(txbLado2.Text) + Convert.ToDouble(txbLado3.Text);
            MessageBox.Show("El perimetro es de: "+ Convert.ToString(resultado));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones sum= new Operaciones(Convert.ToDouble(txtLado1.Text), Convert.ToDouble(txtLado2.Text), Convert.ToDouble(txtLado3.Text));
            MessageBox.Show(sum.Sumar().ToString());
        }

        private void rbEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnable.Enabled == true)
            {
                gbEjercicio3WithClass.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Persona human = new Persona(txtNombre.Text, Convert.ToInt32(txtEdad.Text));
            Persons.Add(human);
            llenarDgv();

        }

        
    }
}
