﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApiClient
{
    public partial class frmShowContactInfo : Form
    {
        public frmShowContactInfo(int ContactID)
        {
            InitializeComponent();

            ctrlContactCard1.LoadContactInfo(ContactID);
        }

    }
}
