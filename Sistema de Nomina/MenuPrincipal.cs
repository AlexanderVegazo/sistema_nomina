using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnConsultaAsientosC_Click(object sender, EventArgs e)
        {

            ConsultaAsientosContables CAC = new ConsultaAsientosContables();
            CAC.Show();
        }

        private void btnConsultaTransacciones_Click(object sender, EventArgs e)
        {

            ConsultaTransacciones Ct = new ConsultaTransacciones();
            Ct.Show();
        }

        private void btnGestionarEmpleados_Click(object sender, EventArgs e)
        {
           

            FrmEmpleados emp = new FrmEmpleados();
            emp.Show();

        }

        private void btnGesionarDeducciones_Click(object sender, EventArgs e)
        {

            FrmTiposDeducciones ftd = new FrmTiposDeducciones();
            ftd.Show();

        }

        private void btnGestionarTiposDeIngr_Click(object sender, EventArgs e)
        {

            FrmTiposDeIngreso fti = new FrmTiposDeIngreso();
            fti.Show();

        }
    }
}
