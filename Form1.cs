using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox(" ingrese un numero"));
            num += Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox(" ingrese un numero"));

            TX_1.Text = num.ToString();

        }
    }
}
