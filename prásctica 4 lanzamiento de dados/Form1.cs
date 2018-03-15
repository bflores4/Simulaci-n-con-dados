using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prásctica_4_lanzamiento_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dado unDado = new dado();

        private void btnLanzarRepeticiones_Click(object sender, EventArgs e)
        {
            txtResutado.Text = "";
            int lanzamiento = 0;
            int[] dado = new int[6];
            int frecuenciaCara;

            while ( lanzamiento < 100)
            {
                unDado.lanzarDado();

                frecuenciaCara = dado[unDado.caraMostrada-1];
                frecuenciaCara++;
                dado[unDado.caraMostrada - 1] = frecuenciaCara;
                
                lanzamiento++;
            }

            lanzamiento = 1;
            while (lanzamiento < 7)
            {
                txtResutado.Text += "La cara " + lanzamiento + " cayo " + dado[lanzamiento - 1] + " veces" + Environment.NewLine;
                lanzamiento++;
            }
        }

        private void btnlanzarSuma_Click(object sender, EventArgs e)
        {
            txtResutado.Text = "";
            int lanzamientos = 0;
            int[] dado = new int[11];
            int frecuenciaSuma = 0;
            int suma;

            while (lanzamientos < 100)
            {
                suma= unDado.lanzarDado() + unDado.lanzarDado();
                
                frecuenciaSuma = dado[suma-2];
                frecuenciaSuma++;
                dado[suma-2] = frecuenciaSuma; 
                
                lanzamientos++;
            }

            for (int i = 0; i < 11; i++)  //11 posibles sumas
            {
                txtResutado.Text += "La sumatoria " + (i+2) + " se obtuvo " + dado[i] + " veces" + Environment.NewLine;
            }
        }
    }
}
