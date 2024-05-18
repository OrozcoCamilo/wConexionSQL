
namespace wConexionSQL
{
    partial class frmConexionBD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.Label();
            this.txtUnidadesStock = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.dtgPagos = new System.Windows.Forms.DataGridView();
            this.txtPago = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.txtIdPago = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(71, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(18, 16);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "Id";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 6);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(376, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(56, 16);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(492, 12);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(162, 22);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // txtPosicion
            // 
            this.txtPosicion.AutoSize = true;
            this.txtPosicion.Location = new System.Drawing.Point(71, 57);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(59, 16);
            this.txtPosicion.TabIndex = 4;
            this.txtPosicion.Text = "Posicion";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(146, 51);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(128, 22);
            this.txtPrecioUnitario.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.AutoSize = true;
            this.txtSalario.Location = new System.Drawing.Point(382, 57);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(50, 16);
            this.txtSalario.TabIndex = 6;
            this.txtSalario.Text = "Salario";
            // 
            // txtUnidadesStock
            // 
            this.txtUnidadesStock.Location = new System.Drawing.Point(492, 54);
            this.txtUnidadesStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidadesStock.Name = "txtUnidadesStock";
            this.txtUnidadesStock.Size = new System.Drawing.Size(162, 22);
            this.txtUnidadesStock.TabIndex = 7;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(146, 136);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(93, 27);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(303, 136);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 27);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "ACTUALIZAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(482, 136);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 27);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(47, 179);
            this.dtgEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.RowHeadersWidth = 62;
            this.dtgEmpleados.RowTemplate.Height = 28;
            this.dtgEmpleados.Size = new System.Drawing.Size(620, 156);
            this.dtgEmpleados.TabIndex = 12;
            // 
            // dtgPagos
            // 
            this.dtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagos.Location = new System.Drawing.Point(47, 566);
            this.dtgPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPagos.Name = "dtgPagos";
            this.dtgPagos.RowHeadersWidth = 62;
            this.dtgPagos.RowTemplate.Height = 28;
            this.dtgPagos.Size = new System.Drawing.Size(635, 156);
            this.dtgPagos.TabIndex = 14;
            // 
            // txtPago
            // 
            this.txtPago.AutoSize = true;
            this.txtPago.Location = new System.Drawing.Point(71, 383);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(51, 16);
            this.txtPago.TabIndex = 15;
            this.txtPago.Text = "IdPago";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(382, 383);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(81, 16);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "IdEmpleado";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(33, 452);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(89, 16);
            this.lblFechaPago.TabIndex = 17;
            this.lblFechaPago.Text = "IdFechaPago";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(382, 452);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 18;
            this.lblMonto.Text = "Monto";
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(166, 533);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(152, 27);
            this.btnAgregarPago.TabIndex = 19;
            this.btnAgregarPago.Text = "AGREGAR PAGO";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Location = new System.Drawing.Point(391, 533);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(135, 27);
            this.btnEliminarPago.TabIndex = 20;
            this.btnEliminarPago.Text = "ELIMINAR PAGO";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            // 
            // txtIdPago
            // 
            this.txtIdPago.Location = new System.Drawing.Point(146, 383);
            this.txtIdPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(128, 22);
            this.txtIdPago.TabIndex = 21;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(146, 452);
            this.txtFechaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(128, 22);
            this.txtFechaPago.TabIndex = 22;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(473, 449);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(128, 22);
            this.txtMonto.TabIndex = 23;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(473, 380);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(128, 22);
            this.txtIdEmpleado.TabIndex = 24;
            // 
            // frmConexionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 740);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.txtIdPago);
            this.Controls.Add(this.btnEliminarPago);
            this.Controls.Add(this.btnAgregarPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.dtgPagos);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtUnidadesStock);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConexionBD";
            this.Text = "Conexión Base de Datos";
            this.Load += new System.EventHandler(this.frmConexionBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label txtPosicion;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label txtSalario;
        private System.Windows.Forms.TextBox txtUnidadesStock;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.DataGridView dtgPagos;
        private System.Windows.Forms.Label txtPago;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtIdEmpleado;
    }
}

