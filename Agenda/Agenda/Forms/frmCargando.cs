using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class frmCargando : Form
{
    private int opacidad = 0;

    public frmCargando()
    {
        InitializeComponent();
        this.Opacity = this.opacidad;
    }

    private void tmr_opacidad_Tick(object sender, EventArgs e)
    {
        if (opacidad >= 100)
        {
            tmr_opacidad.Stop();
            this.Close();
        }
        else
        {
            opacidad = opacidad + 10;
            this.Opacity = this.opacidad;
            this.Refresh();
        }
    }
}
