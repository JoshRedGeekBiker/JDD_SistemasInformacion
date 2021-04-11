using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda;

public partial class frmPrincipal : Form, iBD
{
    public siEntities si_BD { get; set; }

    public li



    public frmPrincipal()
    {
        InitializeComponent();
        //this.WindowState = FormWindowState.Minimized;
        this.Visible = false;
        RecuperarContactos();
    }

    

    public void maximizar()
    {
        this.WindowState = FormWindowState.Normal;
        this.TopMost = true;
    }


    /// <summary>
    /// Se encarga de crear la vista principal
    /// </summary>
    private void CrearLayout()
    {
        
    }


    private void RecuperarContactos()
    {

    }
}
