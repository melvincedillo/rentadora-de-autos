﻿
namespace Rentadora
{
    partial class fmrEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.add_empleado = new System.Windows.Forms.Button();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dpFecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cH_Extras = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cSueldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cIdentidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cS_Apellido = new System.Windows.Forms.TextBox();
            this.cP_Apellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cS_Nombre = new System.Windows.Forms.TextBox();
            this.cP_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idSucur = new System.Windows.Forms.Label();
            this.idEmp = new System.Windows.Forms.Label();
            this.delete_empleado = new System.Windows.Forms.Button();
            this.editar_empleado = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR EMPLEADO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.aceptar);
            this.panel1.Controls.Add(this.add_empleado);
            this.panel1.Controls.Add(this.cbSucursal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dpFecha_ingreso);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cH_Extras);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cSueldo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cIdentidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cS_Apellido);
            this.panel1.Controls.Add(this.cP_Apellido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cS_Nombre);
            this.panel1.Controls.Add(this.cP_Nombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cNombreEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 695);
            this.panel1.TabIndex = 1;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(53, 485);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(81, 33);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click_1);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.SandyBrown;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(234, 485);
            this.aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(84, 33);
            this.aceptar.TabIndex = 24;
            this.aceptar.Text = "Actualizar Empleado";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // add_empleado
            // 
            this.add_empleado.BackColor = System.Drawing.Color.SandyBrown;
            this.add_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_empleado.Location = new System.Drawing.Point(145, 485);
            this.add_empleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_empleado.Name = "add_empleado";
            this.add_empleado.Size = new System.Drawing.Size(73, 33);
            this.add_empleado.TabIndex = 23;
            this.add_empleado.Text = "Crear Empleado";
            this.add_empleado.UseVisualStyleBackColor = false;
            this.add_empleado.Click += new System.EventHandler(this.add_empleado_Click);
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(105, 449);
            this.cbSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(168, 21);
            this.cbSucursal.TabIndex = 22;
            this.cbSucursal.SelectedIndexChanged += new System.EventHandler(this.cbSucursal_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(156, 434);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sucursal";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.cbSexo.Location = new System.Drawing.Point(31, 354);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(82, 21);
            this.cbSexo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 339);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sexo";
            // 
            // dpFecha_ingreso
            // 
            this.dpFecha_ingreso.Location = new System.Drawing.Point(136, 397);
            this.dpFecha_ingreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpFecha_ingreso.Name = "dpFecha_ingreso";
            this.dpFecha_ingreso.Size = new System.Drawing.Size(223, 20);
            this.dpFecha_ingreso.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha Ingreso";
            // 
            // cH_Extras
            // 
            this.cH_Extras.Location = new System.Drawing.Point(265, 354);
            this.cH_Extras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cH_Extras.Name = "cH_Extras";
            this.cH_Extras.Size = new System.Drawing.Size(85, 20);
            this.cH_Extras.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 339);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Horas Extras";
            // 
            // cSueldo
            // 
            this.cSueldo.Location = new System.Drawing.Point(136, 354);
            this.cSueldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cSueldo.Name = "cSueldo";
            this.cSueldo.Size = new System.Drawing.Size(102, 20);
            this.cSueldo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sueldo";
            // 
            // cIdentidad
            // 
            this.cIdentidad.Location = new System.Drawing.Point(81, 301);
            this.cIdentidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cIdentidad.Name = "cIdentidad";
            this.cIdentidad.Size = new System.Drawing.Size(215, 20);
            this.cIdentidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Identidad";
            // 
            // cS_Apellido
            // 
            this.cS_Apellido.Location = new System.Drawing.Point(191, 248);
            this.cS_Apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cS_Apellido.Name = "cS_Apellido";
            this.cS_Apellido.Size = new System.Drawing.Size(144, 20);
            this.cS_Apellido.TabIndex = 10;
            // 
            // cP_Apellido
            // 
            this.cP_Apellido.Location = new System.Drawing.Point(19, 248);
            this.cP_Apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cP_Apellido.Name = "cP_Apellido";
            this.cP_Apellido.Size = new System.Drawing.Size(144, 20);
            this.cP_Apellido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primer Apellido";
            // 
            // cS_Nombre
            // 
            this.cS_Nombre.Location = new System.Drawing.Point(191, 194);
            this.cS_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cS_Nombre.Name = "cS_Nombre";
            this.cS_Nombre.Size = new System.Drawing.Size(144, 20);
            this.cS_Nombre.TabIndex = 6;
            // 
            // cP_Nombre
            // 
            this.cP_Nombre.Location = new System.Drawing.Point(19, 194);
            this.cP_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cP_Nombre.Name = "cP_Nombre";
            this.cP_Nombre.Size = new System.Drawing.Size(144, 20);
            this.cP_Nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Primer Nombre";
            // 
            // cNombreEmpleado
            // 
            this.cNombreEmpleado.Location = new System.Drawing.Point(31, 129);
            this.cNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cNombreEmpleado.Name = "cNombreEmpleado";
            this.cNombreEmpleado.Size = new System.Drawing.Size(264, 20);
            this.cNombreEmpleado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Empleado";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.dgvEmpleados);
            this.panel2.Controls.Add(this.idSucur);
            this.panel2.Controls.Add(this.idEmp);
            this.panel2.Controls.Add(this.delete_empleado);
            this.panel2.Controls.Add(this.editar_empleado);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(389, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 695);
            this.panel2.TabIndex = 2;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.Location = new System.Drawing.Point(9, 99);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 62;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(592, 360);
            this.dgvEmpleados.TabIndex = 28;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick_1);
            // 
            // idSucur
            // 
            this.idSucur.AutoSize = true;
            this.idSucur.Location = new System.Drawing.Point(76, 80);
            this.idSucur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idSucur.Name = "idSucur";
            this.idSucur.Size = new System.Drawing.Size(43, 13);
            this.idSucur.TabIndex = 27;
            this.idSucur.Text = "idSucur";
            // 
            // idEmp
            // 
            this.idEmp.AutoSize = true;
            this.idEmp.Location = new System.Drawing.Point(36, 80);
            this.idEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idEmp.Name = "idEmp";
            this.idEmp.Size = new System.Drawing.Size(36, 13);
            this.idEmp.TabIndex = 26;
            this.idEmp.Text = "idEmp";
            // 
            // delete_empleado
            // 
            this.delete_empleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_empleado.BackColor = System.Drawing.Color.Firebrick;
            this.delete_empleado.BackgroundImage = global::Rentadora.Properties.Resources.descargar__1_;
            this.delete_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.delete_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_empleado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delete_empleado.Location = new System.Drawing.Point(340, 475);
            this.delete_empleado.Name = "delete_empleado";
            this.delete_empleado.Size = new System.Drawing.Size(63, 63);
            this.delete_empleado.TabIndex = 26;
            this.delete_empleado.UseVisualStyleBackColor = false;
            this.delete_empleado.Click += new System.EventHandler(this.delete_empleado_Click_1);
            // 
            // editar_empleado
            // 
            this.editar_empleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editar_empleado.BackColor = System.Drawing.Color.Firebrick;
            this.editar_empleado.BackgroundImage = global::Rentadora.Properties.Resources.png_transparent_human_figure_human_behavior_neck_microphone_hand_male_user_edit_microphone_hand_smiley_thumbnail;
            this.editar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.editar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_empleado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editar_empleado.Location = new System.Drawing.Point(246, 475);
            this.editar_empleado.Name = "editar_empleado";
            this.editar_empleado.Size = new System.Drawing.Size(63, 63);
            this.editar_empleado.TabIndex = 25;
            this.editar_empleado.UseVisualStyleBackColor = false;
            this.editar_empleado.Click += new System.EventHandler(this.editar_empleado_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(145, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(353, 32);
            this.label13.TabIndex = 24;
            this.label13.Text = "INFORMACION EMPLEADOS";
            // 
            // fmrEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrEmpleados";
            this.Text = "fmrEmpleados";
            this.Load += new System.EventHandler(this.fmrEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_empleado;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dpFecha_ingreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cH_Extras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cSueldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cIdentidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cS_Apellido;
        private System.Windows.Forms.TextBox cP_Apellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cS_Nombre;
        private System.Windows.Forms.TextBox cP_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cNombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button editar_empleado;
        private System.Windows.Forms.Button delete_empleado;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label idEmp;
        private System.Windows.Forms.Label idSucur;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}