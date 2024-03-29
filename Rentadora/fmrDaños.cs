﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Rentadora
{
    public partial class fmrDaños : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);

        public fmrDaños()
        {
            InitializeComponent();
        }

        private void fmrDaños_Load(object sender, EventArgs e)
        {
            
        }

        private void actualizar(int grado)
        {
            try
            {
                oracle.Open();
                OracleCommand estado = new OracleCommand("UPDATE rentadora.DEVOLUCION SET DANIOID = " + grado +" WHERE devolucionid= " + Variable.idsolicitud, oracle);
                estado.ExecuteNonQuery();
                oracle.Close();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int g = 0;
            if (sinDaño.Checked) { g = 0; Variable.total = 0; }
            else if (grado1.Checked) { g = 1; Variable.total = 200; }
            else if (grado2.Checked) { g = 2; Variable.total = 400; }
            else if (grado3.Checked) { g = 3; Variable.total = 700; }
            else if (grado4.Checked) { g = 4; Variable.total = 1600; }
            else if (grado5.Checked) { g = 5; Variable.total = 3500; }
            else if (grave.Checked) { g = 6; Variable.total = 4500; }

            actualizar(g);
            DialogResult = DialogResult.OK;
        }
    }
}
