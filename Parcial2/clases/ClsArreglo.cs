using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.clases
{
    class ClsArreglo
    {

        public string[,] DosDimensiones(string[] arreglo, int numeroColumnas)
        {
            string[,] arregloDosDimensiones = new string[arreglo.Length, numeroColumnas];
            int contador = 0;
            foreach (string fila in arreglo)
            {
                string[] columnas = fila.Split(',');
                arregloDosDimensiones[contador, 0] = columnas[0]; //Correlativo
                arregloDosDimensiones[contador, 1] = columnas[1]; //Nombre
                arregloDosDimensiones[contador, 2] = columnas[2]; //Parcial Uno
                arregloDosDimensiones[contador, 3] = columnas[3]; //Parcial Dos
                arregloDosDimensiones[contador, 4] = columnas[4]; //Parical Tres
                arregloDosDimensiones[contador, 5] = columnas[5]; //Seccion
                contador++;
            }
            return arregloDosDimensiones;
        }
        public string[] OrdenarString(string[,] matriz, int columna)
        {
            string[] arreglo = new string[matriz.GetLength(0) - 1];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = matriz[i + 1, columna];
            }
            
            string[] ArregloTemporal = arreglo;
            string datosTemporal;

            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    /**
                     *  COMO NO ES UN NUMERO SE UTILIZA EL COMPARE.TO 
                     *  PARA COMPARAR LOS 2 STRING POR ORDEN ALFABETICO
                     */
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return arreglo;
        }
        public int[] OrdenarInt(string[,] matriz, int columna)
        {

            /**
             * SE CREA EL ARREGLO NUEVO
             */
            int[] arreglo = new int[matriz.GetLength(0) - 1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(matriz[i + 1, columna]);
            }

            /**
             * SE ORDENA EL ARREGLO NUEVO
             */
            int[] ArregloTemporal = arreglo;
            int datosTemporal;
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = i + 1; j < arreglo.GetLength(0); j++)
                {
                    /**
                     *  COMO NO ES UN NUMERO SE UTILIZA EL COMPARE.TO 
                     *  PARA COMPARAR LOS 2 STRING POR ORDEN ALFABETICO
                     */
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return arreglo;
        }
    }
}
