using System;
using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;
using System.IO;using System.Linq;using System.Text;using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using MySql.Data.MySqlClient;


namespace Practica_05
{
    public partial class Form1 : Form
    {
        //Conexion a MySQL (XAMPP)
        string conexionSQL = "Server=localhost;Port=3306;Database=programacionavanzada;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();

            //Agregar controladores de eventos
            txt_age.TextChanged += ValidarEdad;
            txt_high.TextChanged += ValidarEstatura;
            txt_num.TextChanged += ValidarTelefono;
            txt_name.TextChanged += ValidarNombre;
            txt_lastname.TextChanged += ValidarApellido;

            rBtn_fem.Checked = false;
            rBtn_masc.Checked = false;
        }
        private void InsertarRegistro(string nombre, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(conexionSQL))
            {
                conection.Open();

                string insertQuery = "INSERT INTO registros (Nombre, Apellidos, Edad, Estatura, Telefono, Genero)" + "VALUES (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }
                conection.Close();
            }
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

            //Validar que los campos tengan el formato correcto
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) && EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                //Crear una cadena con los datos
                string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTeléfono: {telefono}\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}\n";

                //Guardar los datos en un archivo de texto
                string rutaArchivos = "C:/Users/Asus/Documents/datos.txt";
                bool archivoExiste = File.Exists(rutaArchivos);
                if(archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivos, datos);
                }
                else
                {
                    //Verificar si el archivo ya existe
                    using (StreamWriter writer = new StreamWriter(rutaArchivos, true))
                    {
                        if (archivoExiste)
                        {
                            //Si el archivo ya existe, añadir un separados antes del nuevo registro
                            writer.WriteLine();

                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos ingresados correctamente");
                        }

                        writer.WriteLine(datos);
                    }
                }

                //Mostrar un mensaje con los datos capturados
                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una estatura valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            //Eliminar espacios en blanco y guiones si es necesario
            //input = input.
            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    MessageBox.Show("Por favor ingrese un numero de telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
            /*else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un numero de telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una nombre valido (Solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una nombre valido (Solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
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











        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}