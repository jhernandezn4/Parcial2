using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.clases
{
    class ClsPromedios : InterfacePromedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int suma = 0;
            for(int i=0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion && i>0)
                {
                    suma = suma + Convert.ToInt32(matriz[i, columna_parcial]);
                }
            }
            int promedio = suma / matriz.GetLength(0);
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            throw new NotImplementedException();
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            throw new NotImplementedException();
        }
    }
}
