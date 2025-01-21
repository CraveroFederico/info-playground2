﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMiaTextBox.Pulisci();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore del Testo: " + txtMiaTextBox.Testo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            impostaProperty(false);
        }

        private void impostaProperty(bool numero)
        { 
            txtMiaTextBox.Pulisci();
            numCifreDecimali.Value = 0;
            chkNumeri.Checked = numero;
            txtMiaTextBox.Numero = numero;
            try
            {
                txtMiaTextBox.CifreDecimali = Convert.ToInt32(numCifreDecimali.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkNumeri_CheckedChanged(object sender, EventArgs e)
        {
            impostaProperty(chkNumeri.Checked);
        }

        private void numCifreDecimali_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtMiaTextBox.CifreDecimali = Convert.ToInt32(numCifreDecimali.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
