﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class frmTeste2 : Form
    {
        public frmTeste2()
        {
            InitializeComponent();
        }

        private void frmTeste2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }
    }
}
