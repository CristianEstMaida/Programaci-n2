using System;
using System.Text;

namespace Estudiar
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random = new Random();

        public double CalcularNotaFinal()
        {
            double notaFinal;
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
               notaFinal = random.Next(6, 10);
               
            }
            else
            {
               notaFinal = -1;
            }
            return notaFinal;
        }
        private float CalcularPromedio()
        {
            float promedio=(this.notaPrimerParcial+this.notaSegundoParcial)/2;
            return promedio;
        }
        private Estudiante()
        {
           
        }
        public Estudiante(string nombre, string apellido, string legajo)
        { 
            this.nombre=nombre;
            this.apellido=apellido;
            this.legajo=legajo;
        }
        public string Mostrar()
        {
            float promedio;
            double notaFinal;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Nota Uno: " + this.notaPrimerParcial);
            sb.AppendLine("Nota Dos: " + this.notaSegundoParcial);

            //CALCULA PROMEDIO

            promedio = CalcularPromedio();
            sb.AppendLine("Promedio: " + promedio);

            //CALCULA NOTA FINAL

            notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                
                sb.AppendLine("Nota Final: " + notaFinal);
            }
            else
            {
                sb.AppendLine("Nota Final: Alumno Desaprobado");
            }

            sb.AppendLine("--------------------------------");
            return sb.ToString();
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
    }
}
