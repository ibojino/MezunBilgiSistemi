﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MezunBilgiSistemi.Forms
{
    public partial class frmOgrenciList : Form
    {
        public frmOgrenciList()
        {
            InitializeComponent();
        }

        private void btnOgrList_Click(object sender, EventArgs e)
        {

        }

        private void frmOgrenciList_Load(object sender, EventArgs e)
        {

        }

        private void frmOgrenciList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }
    }
}
