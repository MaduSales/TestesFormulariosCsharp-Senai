﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTesteCalculadora().Show();
            this.Hide();
        }

        private void descontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTesteDesconto().Show();
            this.Hide();
        }
    }
}