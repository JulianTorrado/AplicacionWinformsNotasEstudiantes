using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
 Autor Julian Torrado
 
 */


namespace NotasDeEstudiantes
{
    internal class NotasEstudiante_Controlador
    {
        NotasEstudiante_Modelo modelo = new NotasEstudiante_Modelo();
        Estudiante estudiante = new Estudiante();

        public string CalcularPromedio(Estudiante estudiante) {

            double nota1 = double.Parse(estudiante.Nota1);
            double nota2 = double.Parse(estudiante.Nota2);
            double nota3 = double.Parse(estudiante.Nota3);

            double definitiva = nota1 * 0.35 + nota2 * 0.35 + nota3 * 0.30;


            string definitivaString = definitiva.ToString();

            estudiante.Definitiva = definitivaString;
            

            return definitivaString;

        }

        public void EnviarDatos(Estudiante estudiante){

           
               modelo.EnviarDatos(estudiante);
          

            
        
        }
    }
}
