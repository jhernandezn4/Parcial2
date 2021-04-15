﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2.clases;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public string[,] matriz;
        ClsArreglo arreglo = new ClsArreglo();
        ClsPromedios promedios = new ClsPromedios();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
             * SE ABRE EL ARCHIVO
             */
            ClsArchivo archivo = new ClsArchivo(); //La clase abre la ventana de dialogo
            this.textBox1.Text = archivo.ruta; //Se pasa la ruta del archivo al texbox del formdulario;
            string[] filas = archivo.obtenerFilas(); //SE OBTIENEN LAS FILAS DEL ARCHIVO

            /**
             * SE CARGAN LAS FILAS DEL ARCHIVO EN UN LIST BOX
             */
            foreach (string linea in filas)
            {
                this.listArchivo.Items.Add(linea);
            }

            /*
             *SE CONVIERTE EL ARREGLO DE UNA DIMENSION EN DOS DIMENSIONES 
             */
            
            this.matriz= arreglo.DosDimensiones(filas,7);
            

        }

        private void btnOrdenNombre_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string[] datos = arreglo.OrdenarString(this.matriz, 1);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listP1.Items.Add(datos[i]);
            }
        }

        private void btnOrdenP1_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            int [] datos = arreglo.OrdenarInt(this.matriz, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listP1.Items.Add(datos[i]);
            }
        }

        private void btnOrdenP2_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            int[] datos = arreglo.OrdenarInt(this.matriz, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listP1.Items.Add(datos[i]);
            }
        }

        private void btnOrdenP3_Click(object sender, EventArgs e)
        {

            this.listP1.Items.Clear();
            int[] datos = arreglo.OrdenarInt(this.matriz, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listP1.Items.Add(datos[i]);
            }
            
        }

        private void btnPromediosAlumnos_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                this.listP1.Items.Add(matriz[i,1]+" - "+ matriz[i,6]);
            }
        }

        private void btnPromedioP1_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            int datos = promedios.promedios_por_parcial(this.matriz, 2);
            this.listP1.Items.Add("Promedio por Parcial Uno: "+datos);
        }

        private void btnPromedioP2_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            int datos = promedios.promedios_por_parcial(this.matriz, 3);
            this.listP1.Items.Add("Promedio por Parcial Dos: " + datos);
        }

        private void btnPromedioP3_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            int datos = promedios.promedios_por_parcial(this.matriz, 4);
            this.listP1.Items.Add("Promedio por Parcial Dos: " + datos);
        }

        private void btnPromediosSeccion_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string seccion = this.txtSeccion.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 6,seccion);
            this.listP1.Items.Add("Promedio General Por Seccion "+seccion+" :" + datos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string seccion = this.txtSeccion.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 2, seccion);
            this.listP1.Items.Add("Promedio General Por Parcial Uno en la Sección " + seccion + " :" + datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string seccion = this.txtSeccion.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 3, seccion);
            this.listP1.Items.Add("Promedio General Por Parcial Uno en la Sección " + seccion + " :" + datos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string seccion = this.txtSeccion.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 3, seccion);
            this.listP1.Items.Add("Promedio General Por Parcial Uno en la Sección " + seccion + " :" + datos);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string[,] datos = promedios.sumatoria_general_por_alumno(this.matriz);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listP1.Items.Add(datos[i,0]+"- Sumatoria: " +datos[i, 1]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listP1.Items.Clear();
            string seccion = this.txtSeccion.Text;
            string[,] datos = promedios.Clasificar_Alumnos(this.matriz,seccion);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listP1.Items.Add(datos[i, 0] + "; "+ datos[i, 1] + "; "+ datos[i, 2] + "; "+ datos[i, 3] + "; "+ datos[i, 4] + "; "+datos[i, 5] + "; "+datos[i, 6] + "; ");
            }
        }
    }
}
