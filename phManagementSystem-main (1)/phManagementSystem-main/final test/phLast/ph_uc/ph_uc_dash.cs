﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph.ph_uc
{
  public partial class ph_uc_dash : UserControl
  {
    public ph_uc_dash()
    {
      InitializeComponent();
    }

    

    private void button1_Click(object sender, EventArgs e)
    {
      this.Refresh();
      ph_uc_dash_Load(this, null);

    }

    private void ph_uc_dash_Load(object sender, EventArgs e)
    {

    }
  }
}
