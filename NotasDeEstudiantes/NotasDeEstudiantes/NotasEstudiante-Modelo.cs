using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
 Autor Marcela Soler 
 
 */

namespace NotasDeEstudiantes
{
    internal class NotasEstudiante_Modelo

    {
        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NotasPolitecnicoInternacional;Data Source=JULIAN\\SQLEXPRESS");


        public void EnviarDatos(Estudiante estudiante) {

            string query = @"INSERT INTO tecnologiaDesarrolloSoftware 
                    (NombreEstudiante,Corte1,Corte2,Corte3,Definitiva)
                    VALUES (@nombre_estudiante,@corte1,@corte2,@corte3,@definitiva)";

            conn.Open();

            SqlParameter NombreEstudiante = new SqlParameter("@nombre_estudiante",estudiante.NombreEstudiante);
            SqlParameter Corte1 = new SqlParameter("@corte1", estudiante.Nota1);
            SqlParameter Corte2 = new SqlParameter("@corte2", estudiante.Nota2);
            SqlParameter Corte3 = new SqlParameter("@corte3", estudiante.Nota3);
            SqlParameter Definitiva = new SqlParameter("@definitiva", estudiante.Definitiva);


            SqlCommand ejecutar = new SqlCommand(query,conn);

            ejecutar.Parameters.Add(NombreEstudiante);
            ejecutar.Parameters.Add(Corte1);
            ejecutar.Parameters.Add(Corte2);
            ejecutar.Parameters.Add(Corte3);
            ejecutar.Parameters.Add(Definitiva);


            ejecutar.ExecuteNonQuery();

            conn.Close();

        }
    }
}
