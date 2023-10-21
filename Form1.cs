using Conversor.Model;
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

namespace Conversor
{
    public partial class Form1 : Form
    {
        private string valorAntesDeApagar = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void ManipuladorDeCaracteres_KeyPress(object sender, KeyPressEventArgs teclado)
        {
            if (!char.IsDigit(teclado.KeyChar) && teclado.KeyChar != (char)Keys.Back && teclado.KeyChar != (char)Keys.OemMinus)
            {
                teclado.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCB1.Items.Add("Temperatura");
            comboBoxCB1.Items.Add("Comprimento");

            textBoxCB2.KeyPress += ManipuladorDeCaracteres_KeyPress;
            textBoxCB3.KeyPress += ManipuladorDeCaracteres_KeyPress;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] temperatura = { "Celsius", "Kelvin", "Fahrenheit" };
            string[] comprimento = { "Quilômetro", "Hectômetro", "Decâmetro", "Metro", "Decímetro", "Centímetro" ,"Milímetro" };

            string[] selecionado = null;

            switch (comboBoxCB1.SelectedItem)
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
                comboBoxCB2.Items.Clear();
                comboBoxCB3.Items.Clear();

                foreach (string item in selecionado)
                {
                    comboBoxCB2.Items.Add(item);
                    comboBoxCB3.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Erro nas caixas de seleção!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxCB2_TextChanged(object sender, EventArgs e)
        {

            ValoresPadrao valor = new ValoresPadrao();

            if (comboBoxCB2.SelectedIndex >= 0 && comboBoxCB3.SelectedIndex >= 0)
            {
                if (!double.TryParse(textBoxCB2.Text, out valor.valorIsirido))
                {
                    textBoxCB2.Text = "";
                    textBoxCB3.Text = "";
                }
            }

            switch(comboBoxCB1.SelectedItem)
            {
                case "Temperatura":

                    switch(comboBoxCB2.SelectedItem)
                    {
                        case "Celsius":

                            Celsius celsius = new Celsius();

                            if (comboBoxCB3.SelectedItem.Equals("Kelvin"))
                            {
                                valor.resultado = celsius.Kelvin(valor.valorIsirido);
                            }
                            else if (comboBoxCB3.SelectedItem.Equals("Fahrenhait"))
                            {
                                valor.resultado = celsius.Fahrenhait(valor.valorIsirido);
                            }

                            break;

                        case "Fahrenheit":

                            Fahrenhait fahrenheit = new Fahrenhait();

                            if (comboBoxCB3.SelectedItem.Equals("Celsius"))
                            {
                                valor.resultado = fahrenheit.Celsius(valor.valorIsirido);
                            }
                            else if (comboBoxCB3.SelectedItem.Equals("kelvin"))
                            {
                                valor.resultado = fahrenheit.Kelvin(valor.valorIsirido);
                            }

                            break;

                        case "Kelvin":

                            Kelvin kelvin = new Kelvin();

                            if (comboBoxCB3.SelectedItem.Equals("Celsius"))
                            {
                                valor.resultado = kelvin.Celsius(valor.valorIsirido);
                            }
                            else if (comboBoxCB3.SelectedItem.Equals("Fahrenheit"))
                            {
                                valor.resultado = kelvin.Fahrenhait(valor.valorIsirido);
                            }

                            break;
                    }

                    break;
            }

            textBoxCB3.Text = $"{Math.Round(valor.resultado, 2)}";
        }
    }
}
