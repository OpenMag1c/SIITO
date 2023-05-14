﻿using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CatalogForm : Form
    {
        MainForm mainForm;
        public CatalogForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonInstrument_Click(object sender, EventArgs e)
        {
            mainForm.OpenInstrumentForm(InstrumentTypeEnum.All);
        }

        private void buttonOsnastka_Click(object sender, EventArgs e)
        {
            mainForm.OpenOsnastkaForm(OsnastkaTypeEnum.All);
        }
    }
}
