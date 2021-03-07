using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMedida_Click(object sender, EventArgs e)
        {
            Mensajes.MedidaHumedad registro = new Mensajes.MedidaHumedad()
            {
                Hora = DateTime.Now,
                Humedad = (new Random()).Next(40, 60)
            };
            (new HttpClient()).PostAsJsonAsync("https://dweet.io/dweet/for/medidatomate", registro);
        }

        private void btnActuacion_Click(object sender, EventArgs e)
        {
            Mensajes.MedidaTemperatura registro = new Mensajes.MedidaTemperatura()
            {
                Hora = DateTime.Now,
                Descripcion = "Hase frío che"
            };
            (new HttpClient()).PostAsJsonAsync("https://dweet.io/dweet/for/medidatomate", registro);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://dweet.io/get/dweets/for/medidatomate");
        }
    }
}
