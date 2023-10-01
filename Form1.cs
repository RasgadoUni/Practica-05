using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nombres = txt_name.Text;
            string apellidos = txt_lastname.Text;
            string edad = txt_age.Text;
            string estatura = txt_high.Text;
            string telefono = txt_num.Text;

            string genero = "";
            if (rBtn_masc.Checked)
            {
                genero = "Hombre";
            }
            else if (rBtn_fem.Checked)
            {
                genero = "Mujer";
            }
            else if (rBtn_bi.Checked)
            {
                genero = "No Binario";
            }

            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTeléfono: {telefono}\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}\n";

            string rutaArchivos = "C:/Users/Asus/Documents/datos.txt";

            bool archivoExiste = File.Exists(rutaArchivos);

            using (StreamWriter writer = new StreamWriter(rutaArchivos, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine(datos);
                }
                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            txt_age.Clear();
            txt_name.Clear();
            txt_lastname.Clear();
            txt_num.Clear();
            txt_high.Clear();
            rBtn_fem.Checked = false;
            rBtn_masc.Checked = false;
            rBtn_bi.Checked = false;
        }
    }
}