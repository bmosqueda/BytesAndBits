using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_bits_y_bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);

            //Muestra en la consola la representación binaria del número ingresa (los 32 bits)
            verBinario(num);

            //Hace toda la manipulación del primer byte y muestra el tablero
            getBytesFirst(num);

            //Manipula el 2do y 3er byte para obtener la fecha
            getBytesDate(num);
        }

        private void getBytesFirst( int num )
        {
            //El bit 0 no se utiliza
            num >>= 1;

            int direccion = num & 7;
            num >>= 3;

            int nivelTanque = num & 3;
            num >>= 2;

            bool sensor2 = num % 2 != 0;
            num >>= 1;

            bool sensor1 = num % 2 != 0;
            num >>= 1;

            //Carga las imagénes 
            mostrarTablero(direccion, nivelTanque, sensor1, sensor2);
        }

        private void getBytesDate( int num )
        {
            //Se desechan los primeros 8 bytes porque son los del tablero que ya se usaron
            num >>= 8;

            int dia = num & 31;
            if (dia == 0)
                dia++;
            num >>= 5;

            int mes = num & 15;
            if (mes == 0)
                mes++;
            else if( mes > 12 )
            {
                MessageBox.Show("El mes número " + mes + " no puede ser representado, en su lugar se puso Diciembre (12)");
                mes = 12;
            }
            num >>= 4;

            int anio = 1900 + (num & 127);

            lblDate.Text = "Fecha de lectura: " + (new DateTime(anio, mes, dia).ToLongDateString());
        }

        private void mostrarTablero(int direccion, int nivelTanque, bool sensor1, bool sensor2)
        {
            Bitmap bitm;

            //Girar la imagen de la dirreción
            switch ( direccion )
            {
                //Norte
                case 0:
                    bitm = new Bitmap(Properties.Resources.iconmonstr_arrow_18_120);
                    bitm.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                //Noreste
                case 1:
                    bitm = new Bitmap(Properties.Resources.arrowInclinada);
                    bitm.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                //Este
                case 2:
                    bitm = new Bitmap(Properties.Resources.iconmonstr_arrow_18_120);
                    //No gira, es la posicion original de la imagen
                    break;
                //Sureste
                case 3:
                    bitm = new Bitmap(Properties.Resources.arrowInclinada);
                    //No gira, es la posición original de la imagen
                    break;
                //Sur
                case 4:
                    bitm = new Bitmap(Properties.Resources.iconmonstr_arrow_18_120);
                    bitm.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                //Suroeste
                case 5:
                    bitm = new Bitmap(Properties.Resources.arrowInclinada);
                    bitm.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                //Oeste
                case 6:
                    bitm = new Bitmap(Properties.Resources.iconmonstr_arrow_18_120);
                    bitm.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                //Noreste
                default:
                    bitm = new Bitmap(Properties.Resources.arrowInclinada);
                    bitm.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
            }

            imgDirec.BackgroundImage = bitm;
            imgDirec.BackgroundImageLayout = ImageLayout.Zoom;

            switch(nivelTanque)
            {
                case 0:
                    imgFull.Size = new Size(90, 140);
                    lblProcesoLLenado.Text = "Vacío";
                    break;
                case 1:
                    imgFull.Size = new Size(90, 70);
                    lblProcesoLLenado.Text = "Medio lleno";
                    break;
                case 2:
                    imgFull.Size = new Size(90, 1);
                    lblProcesoLLenado.Text = "Lleno";
                    break;
                default:
                    imgFull.Size = new Size(90,140);
                    timer1.Start();
                    lblProcesoLLenado.Text = "Llenándose";
                    break;
            }

            imgSen1.Visible = sensor1;

            imgSen2.Visible = sensor2;
        }

        //Método de animación de llenado del tanque
        private void Timer_Tick(object sender, EventArgs e)
        {
            int tamanio = imgFull.Height;

            if( tamanio < 2 )
            {
                imgFull.Size = new Size(90, 1);
                lblProcesoLLenado.Text = "Lleno";
                ((Timer)sender).Stop();
            }
            else
            {
                tamanio -= 10;
                imgFull.Height = tamanio;
            }
        }

        private void verBinario( int num )
        {
            string binario = "";
            
            for( int i = 0; i < 32; i++ )
            {
                if( num % 2 == 0 )
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }

                if ((i + 1) % 8 == 0)
                    binario = "  " + binario;

                num >>= 1;
            }

            Console.WriteLine("Binario: " + binario );
        }

        private void btnAjustarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = datePicker.Value;

            int dia = fecha.Day;
            int mes = fecha.Month;
            int anio = fecha.Year - 1900;

            string fechaEnBinario = toBinary(anio, 7) + toBinary(mes, 4) + toBinary(dia, 5);

            Console.WriteLine("Año: " + anio + " Mes: " + mes + " Día: " + dia);
            Console.WriteLine("Fecha en binario: "+ fechaEnBinario);
            Console.WriteLine("Fecha en decimal: " + toDecimal(fechaEnBinario));

            txtFechaDecimal.Text = toDecimal(fechaEnBinario).ToString();
        }

        private int toDecimal( string binario )
        {
            int num = 0;
            int potencia = 15;
            for( int i = 0; i < 16; i++, potencia-- )
            {
                if( binario[i] == '1')
                {
                    num += (int)Math.Pow(2, potencia);
                }
            }
            return num;
        }

        private string toBinary(int num, int digitos)
        {
            string binario = "";
            for( int i = 1; i <= digitos; i++ )
            {
                if( num % 2 == 0 )
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                num >>= 1;
            }

            Console.WriteLine(binario);
            return binario;
        }
    }
}
