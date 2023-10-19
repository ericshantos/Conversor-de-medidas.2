using Conversor_de_medidas;
using Conversor_de_medidas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conversor_de_medidas
{
    public partial class Form1 : Form
    {
        public string[] selecionar = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Temperatura");
            comboBox1.Items.Add("Comprimento");

            textBoxCB2.KeyPress += ManipuladorDeCaracteres_KeyPress;
            textBoxCB3.KeyPress += ManipuladorDeCaracteres_KeyPress;

        }

        private void ManipuladorDeCaracteres_KeyPress(object sender, KeyPressEventArgs teclado)
        {
            if (!char.IsDigit(teclado.KeyChar) && teclado.KeyChar != (char)Keys.Back)
            {
                teclado.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temperatura = { "Celsius", "Kelvin", "Fahrenheit" };
            string[] comprimento = { "Quilômetro", "Hectômetro", "Decâmetro", "Metro", "Decímetro", "Centímetro" };

            string[] selecionado = null;

            switch(comboBox1.SelectedItem)
            {
                case "Comprimento":
                    selecionado = comprimento;

                    break;

                case "Temperatura":
                    selecionado = temperatura;

                    break;
            }

            if (selecionado != null)
            {
                comboBox2.Items.Clear();

                foreach (string item in selecionado)
                {
                    comboBox2.Items.Add(item);
                    comboBox3.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Erro nas caixas de seleção!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Temperatura temperatura = new Temperatura();


            switch(comboBox1.SelectedItem)
            {
                case "Temperatura":

                    double.TryParse(textBoxCB2.Text, out double valorTemperatura);

                    switch(comboBox2.SelectedItem)
                    {
                        case "Celsius":

                            Celsius celsius = new Celsius();

                            if (comboBox3.SelectedItem.ToString() == "Kelvin")
                            {
                                temperatura.retorno = celsius.Kelvin(valorTemperatura);
                            }
                            break;
                    }

                    break;
            }

            textBoxCB3.Text = temperatura.retorno.ToString();
        }
    }
}
