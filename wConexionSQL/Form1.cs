using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using wConexionSQL.CLASES;

namespace wConexionSQL
{
    public partial class frmConexionBD : Form
    {
        private clsEmpleado currentEmpleado;
        private clsPago currentPago;
        private int currentIndex = 0;

        public frmConexionBD()
        {
            InitializeComponent();
        }

        private void frmConexionBD_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            if (dtgEmpleados.Rows.Count > 0)
            {
                CargarDetallesEmpleado(currentIndex);
            }
        }

        private void CargarEmpleados()
        {
            clsEmpleado empleado = new clsEmpleado();
            dtgEmpleados.DataSource = empleado.ObtenerTodosEmpleados();
        }

        private void CargarDetallesEmpleado(int index)
        {
            if (index < 0 || index >= dtgEmpleados.Rows.Count)
                return;

            DataGridViewRow row = dtgEmpleados.Rows[index];
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtPosicion.Text = row.Cells["Posicion"].Value.ToString();
            txtSalario.Text = row.Cells["Salario"].Value.ToString();

            CargarPagos(Convert.ToInt32(txtId.Text));
        }

        private void CargarPagos(int idEmpleado)
        {
            clsPago pago = new clsPago();
            dtgPagos.DataSource = pago.ObtenerPagos(idEmpleado);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                currentEmpleado = new clsEmpleado
                {
                    Nombre = txtNombre.Text,
                    Salario = Convert.ToDecimal(txtSalario.Text)
                };

                currentEmpleado.InsertarEmpleado();
                MessageBox.Show("Datos ingresados correctamente");
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el dato: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                currentEmpleado = new clsEmpleado
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text,
                    Salario = Convert.ToDecimal(txtSalario.Text)
                };

                currentEmpleado.ActualizarEmpleado();
                MessageBox.Show("Datos actualizados correctamente");
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el dato: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(txtId.Text);
                currentEmpleado.EliminarEmpleado(idEmpleado);
                MessageBox.Show("Empleado eliminado correctamente");
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                currentPago = new clsPago
                {
                    IdEmpleado = Convert.ToInt32(lblEmpleado.Text),
                    FechaPago = Convert.ToDateTime(lblFechaPago.Text),
                    Monto = Convert.ToDecimal(lblMonto.Text)
                };

                currentPago.InsertarPago();
                MessageBox.Show("Pago agregado correctamente");
                CargarPagos(Convert.ToInt32(lblEmpleado.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el pago: " + ex.Message);
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                int idPago = Convert.ToInt32(txtIdPago.Text);
                currentPago.EliminarPago(idPago);
                MessageBox.Show("Pago eliminado correctamente");
                CargarPagos(Convert.ToInt32(lblEmpleado.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el pago: " + ex.Message);
            }
        }

        private void dtgEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgEmpleados.CurrentRow != null)
            {
                currentIndex = dtgEmpleados.CurrentRow.Index;
                CargarDetallesEmpleado(currentIndex);
            }
        }
    }
}