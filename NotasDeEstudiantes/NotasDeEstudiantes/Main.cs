using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 
 Autor Julian Torrado
 
 */

namespace NotasDeEstudiantes
{
    public partial class Main : Form

    {
        NotasEstudiante_Controlador controlador = new NotasEstudiante_Controlador();
        Estudiante estudiante = new Estudiante();
        public Main()
        {
            InitializeComponent();
        }

       

       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            CalcularPromedio();
            EnviarDatos();
        }

        private void AsignarDatos() {

            estudiante.NombreEstudiante = txtEstudiante.Text;
            estudiante.Nota1 = txtNota1.Text;
            estudiante.Nota2 = txtNota2.Text;
            estudiante.Nota3 = txtNota3.Text;


            
        }

        private void CalcularPromedio() {

            string promedio;

            promedio = controlador.CalcularPromedio(estudiante);

            txtDefinitiva.Text = estudiante.Definitiva;
        
        }

        private void EnviarDatos() {
            controlador.EnviarDatos(estudiante);
        
        }
    }
}
