﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class PruebaControlesPersonalizados : Form
    {
        public PruebaControlesPersonalizados()
        {
            InitializeComponent();
            texto.Texts = "Esta es una prueba";
        }

        private void customTextBox4__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
        }
    }
}