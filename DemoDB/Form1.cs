﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.DataSource = new ACMEEntities().Products.ToList();
        }
    }
}
