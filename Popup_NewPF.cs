﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette_Belle_Table_Final
{
    public partial class Popup_NewPF : Form
    {
        public Popup_NewPF()
        {
            InitializeComponent();
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            buttonVal.DialogResult = DialogResult.OK;
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }
    }
}
