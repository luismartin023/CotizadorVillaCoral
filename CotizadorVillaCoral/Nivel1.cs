using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Nivel1 : Form
    {
        public Nivel1()
        {
            InitializeComponent();
        }

        public class Ejercicios
        {
            public int Cantidad { get; set; }              // propiedad de entrada: se llena desde fuera
            public decimal Precio { get; set; }
            public decimal Total => Cantidad * Precio;     // propiedad calculada: se calcula sola
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ejercicio = new Ejercicios { Cantidad = 3, Precio = 10m };   // construir el objeto
            lstResultados.Items.Add($"Total: {ejercicio.Total:N2}");

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };
        }

        private void btn_Calcular1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 3;
            int r = a / b;
        }

        // Este es el huesped que se va a hospedar en la villa
        private void txtHuesped_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    