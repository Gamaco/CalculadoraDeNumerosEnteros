using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeNumerosEnteros
{
    public partial class Calculadora : Form
    {
        // Variables Globales

        const char ADD = 's';
        const char DIVIDE = 'd';
        const char SUBSTRACT = 't';
        const char MULTIPLY = 'm';
        const char UNSELECTED = 'u';

        private double firstAmount = 0;
        private double secondAmount = 0;

        private Boolean opTriggered = false;
        private Boolean decimalCheck = false;
        private char operation = UNSELECTED;


        public Calculadora()
        {
            InitializeComponent();
        }

        #region Botones para los numeros

        /********************************************************************************
         * 
         *                   ~Sección de botones con numeros~
         *          la logica es la misma para todos los botones con numeros.
         *          Por eso solo explico uno de los botones, linea por linea.
         * 
         ********************************************************************************/

        private void rjButton16_Click(object sender, EventArgs e)
        {
            // Se obtiene el valor que se desea añadir para calcular del texto del mismo boton,
            // y se guarda en la variable value. En este caso este boton representa el numero uno.
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            // opTriggered es una variable para verificar si el usuario - 
            // presiono unos de los botones de operaciones: suma, resta, divicion, multiplicacion.
            if (opTriggered == true)
            {
                // Si el usuario acaba de presionar uno de los botones de operación, borra el valor que tenia escrito y -
                // pone el valor del boton presionado. Y nuevamente cambia la variable opTriggered a falsa para que no borre
                // los proximos numeros.
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                // En caso de que el usuario no haya seleccionado ninguno de los botones de operaciones todavia, 
                // se añade el numero al texo de "output". Uso esta condicion verificando si el valor del texto es cero
                // para reemplazar el cero por el valor del boton seleccionado. Para que se vea asi 56 y no asi 056.
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            // Esto es cosmetico, no afecta la logica de la calculadora. Cambia la letra del boton de borrar a C
            // que significa clear. Y luego en el codigo cuando lo borras vuelve a cambiar el texto "AC" que significa all clear.
            // La funcion unHighlightOperationButtons() lo que hace es cambiar el color de los botones de operaciones a anaranjado nuevamente
            // para que no se vean seleccionados.
            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }

        private void rjButton20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double value = double.Parse(button.Text);

            if (opTriggered == true)
            {
                lbl_output.Text = value.ToString();
                opTriggered = false;
            }
            else
            {
                lbl_output.Text = (lbl_output.Text == "0") ? value.ToString() : lbl_output.Text + value.ToString();
            }

            rjButton1.Text = "C";
            unHighlightOperationButtons();
        }
        #endregion

        #region Botones para: Reset, Negativo/Positivo, Punto
        // Boton para resetear (AC)
        private void rjButton1_Click(object sender, EventArgs e)
        {
            // La cantidad a calcular se reinicia a cero.
            firstAmount = 0;
            lbl_output.Text = firstAmount.ToString();

            // Decimal check es para indicar si ya hay un punto en el numero.
            // Se cambia a false porque al reiniciar el numero a 0 ya no hay punto.
            // Igual que el opTriggered se usa para verificar si hay un boton de operacion presionado.
            decimalCheck = false;
            opTriggered = false;

            // Cambia el nombre del boton a "AC". 
            // Y cambia los colores de los botones de operaciones a anaranjado 
            // para que no se vean presionados.
            rjButton1.Text = "AC";
            unHighlightOperationButtons();
        }

        // Boton para convertir de positivo a negativo y viceversa.
        private void rjButton2_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(lbl_output.Text);
            
            amount = (amount < 0) ? amount * -1 : -amount; // Se multiplica por negativo uno para convertir el valor a positivo.

            lbl_output.Text = amount.ToString();
        }

        // Boton para poner el punto.
        private void rjButton19_Click(object sender, EventArgs e)
        {
            // La condicion de decimal check es para verificar si ya el usuario uso el punto
            // para asi no ponerlo dos veces. Solo se puede usar un punto. E.g 123.456789
            if (decimalCheck == false && lbl_output.Text != "")
            {
                Button button = (Button)sender;
                lbl_output.Text += button.Text;
                decimalCheck = true;
            }

        }
        #endregion

        #region Botones para las operaciones

        // Suma
        private void rjButton13_Click(object sender, EventArgs e)
        {
            if (!(operation == UNSELECTED))
            {
                if (opTriggered == false)
                {
                    calculateResult();
                }
            }

            operation = ADD;
            firstAmount = double.Parse(lbl_output.Text);

            opTriggered = true;

            unHighlightOperationButtons();

            Button button = (Button) sender;
            button.BackColor = Color.Bisque;
        }

        // Resta
        private void rjButton9_Click(object sender, EventArgs e)
        {
            if (!(operation == UNSELECTED))
            {
                if (opTriggered == false)
                {
                    calculateResult();
                }
            }

            operation = SUBSTRACT;
            firstAmount = double.Parse(lbl_output.Text);

            opTriggered = true;

            unHighlightOperationButtons();

            Button button = (Button)sender;
            button.BackColor = Color.Bisque;
        }

        // Multiplicacion
        private void rjButton5_Click(object sender, EventArgs e)
        {
            if (!(operation == UNSELECTED))
            {
                if (opTriggered == false)
                {
                    calculateResult();
                }
            }

            operation = MULTIPLY;
            firstAmount = double.Parse(lbl_output.Text);

            opTriggered = true;

            unHighlightOperationButtons();

            Button button = (Button)sender;
            button.BackColor = Color.Bisque;
        }

        // Divición
        private void rjButton4_Click(object sender, EventArgs e)
        {
            if (!(operation == UNSELECTED))
            {
                if (opTriggered == false)
                {
                    calculateResult();
                }
            }

            operation = DIVIDE;
            firstAmount = double.Parse(lbl_output.Text);

            opTriggered = true;

            unHighlightOperationButtons();

            Button button = (Button)sender;
            button.BackColor = Color.Bisque;
        }

        // Boton Calcular " = "
        private void rjButton17_Click(object sender, EventArgs e)
        {
            calculateResult();

            opTriggered = false;

            operation = UNSELECTED;
        }
        #endregion

        // La matematica de la calculadora.
        private void calculateResult()
        {
            secondAmount = double.Parse(lbl_output.Text);

            switch (operation)
            {
                case ADD:
                    firstAmount += secondAmount; break;
                case SUBSTRACT:
                    firstAmount -= secondAmount; break;
                case DIVIDE:
                    firstAmount /= secondAmount; break;
                case MULTIPLY:
                    firstAmount *= secondAmount; break;
            }

            secondAmount = 0;
            lbl_output.Text = firstAmount.ToString();

            unHighlightOperationButtons();
        }

        // Cambia el color de los botones a anaranjado
        // para que no se vean seleccionados.
        private void unHighlightOperationButtons()
        {
            rjButton4.BackColor = Color.Orange;
            rjButton5.BackColor = Color.Orange;
            rjButton9.BackColor = Color.Orange;
            rjButton13.BackColor = Color.Orange;
            rjButton17.BackColor = Color.Orange;
        }

        // Porciento, divide el valor a calcular entre 100. 
        private void rjButton3_Click(object sender, EventArgs e)
        {
            firstAmount = double.Parse(lbl_output.Text);
            firstAmount /= 100;
            lbl_output.Text = firstAmount.ToString();
        }
    }
}
