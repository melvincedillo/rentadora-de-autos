﻿
namespace Rentadora
{
    partial class fmrPrincipal
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
            this.Pcabeza = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Plateral = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.empleados = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.Button();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.contrato = new System.Windows.Forms.Button();
            this.solicitud = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNameUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pfmrs = new System.Windows.Forms.Panel();
            this.usertype = new System.Windows.Forms.Label();
            this.finalizar = new System.Windows.Forms.Button();
            this.Pcabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Plateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pfmrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pcabeza
            // 
            this.Pcabeza.BackColor = System.Drawing.Color.White;
            this.Pcabeza.Controls.Add(this.pictureBox2);
            this.Pcabeza.Controls.Add(this.salir);
            this.Pcabeza.Controls.Add(this.label1);
            this.Pcabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pcabeza.Location = new System.Drawing.Point(200, 0);
            this.Pcabeza.Name = "Pcabeza";
            this.Pcabeza.Size = new System.Drawing.Size(1000, 50);
            this.Pcabeza.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Rentadora.Properties.Resources.cars_crashing_clip_art_car_vector_logo_png_288492_free_car_vector_png_920_595;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.BackgroundImage = global::Rentadora.Properties.Resources.Salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.ForeColor = System.Drawing.Color.Transparent;
            this.salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salir.Location = new System.Drawing.Point(946, 6);
            this.salir.Name = "salir";
            this.salir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salir.Size = new System.Drawing.Size(42, 38);
            this.salir.TabIndex = 0;
            this.salir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA RENTADORA DE AUTOS";
            // 
            // Plateral
            // 
            this.Plateral.BackColor = System.Drawing.Color.Black;
            this.Plateral.Controls.Add(this.finalizar);
            this.Plateral.Controls.Add(this.btnMenu);
            this.Plateral.Controls.Add(this.auto);
            this.Plateral.Controls.Add(this.empleados);
            this.Plateral.Controls.Add(this.cliente);
            this.Plateral.Controls.Add(this.historial);
            this.Plateral.Controls.Add(this.flecha);
            this.Plateral.Controls.Add(this.contrato);
            this.Plateral.Controls.Add(this.solicitud);
            this.Plateral.Controls.Add(this.label4);
            this.Plateral.Controls.Add(this.textNameUser);
            this.Plateral.Controls.Add(this.label3);
            this.Plateral.Controls.Add(this.pictureBox1);
            this.Plateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Plateral.Location = new System.Drawing.Point(0, 0);
            this.Plateral.Name = "Plateral";
            this.Plateral.Size = new System.Drawing.Size(200, 600);
            this.Plateral.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(66, 207);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(80, 32);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "MENÚ";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // auto
            // 
            this.auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto.FlatAppearance.BorderSize = 0;
            this.auto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto.ForeColor = System.Drawing.Color.White;
            this.auto.Location = new System.Drawing.Point(22, 474);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(124, 32);
            this.auto.TabIndex = 8;
            this.auto.Text = "Autos";
            this.auto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // empleados
            // 
            this.empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empleados.FlatAppearance.BorderSize = 0;
            this.empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleados.ForeColor = System.Drawing.Color.White;
            this.empleados.Location = new System.Drawing.Point(21, 436);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(125, 32);
            this.empleados.TabIndex = 7;
            this.empleados.Text = "Empleados";
            this.empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empleados.UseVisualStyleBackColor = true;
            this.empleados.Click += new System.EventHandler(this.empleados_Click);
            // 
            // cliente
            // 
            this.cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente.FlatAppearance.BorderSize = 0;
            this.cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.ForeColor = System.Drawing.Color.White;
            this.cliente.Location = new System.Drawing.Point(22, 284);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(124, 32);
            this.cliente.TabIndex = 4;
            this.cliente.Text = "Clientes";
            this.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // historial
            // 
            this.historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historial.FlatAppearance.BorderSize = 0;
            this.historial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.ForeColor = System.Drawing.Color.White;
            this.historial.Location = new System.Drawing.Point(21, 512);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(125, 32);
            this.historial.TabIndex = 6;
            this.historial.Text = "Historial";
            this.historial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historial.UseVisualStyleBackColor = true;
            this.historial.Click += new System.EventHandler(this.historial_Click);
            // 
            // flecha
            // 
            this.flecha.Image = global::Rentadora.Properties.Resources.Flecha;
            this.flecha.Location = new System.Drawing.Point(163, 282);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(37, 34);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 0;
            this.flecha.TabStop = false;
            this.flecha.Visible = false;
            // 
            // contrato
            // 
            this.contrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrato.FlatAppearance.BorderSize = 0;
            this.contrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contrato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrato.ForeColor = System.Drawing.Color.White;
            this.contrato.Location = new System.Drawing.Point(21, 360);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(125, 32);
            this.contrato.TabIndex = 5;
            this.contrato.Text = "Contrato";
            this.contrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contrato.UseVisualStyleBackColor = true;
            this.contrato.Click += new System.EventHandler(this.contrato_Click);
            // 
            // solicitud
            // 
            this.solicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solicitud.FlatAppearance.BorderSize = 0;
            this.solicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.solicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solicitud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitud.ForeColor = System.Drawing.Color.White;
            this.solicitud.Location = new System.Drawing.Point(21, 322);
            this.solicitud.Name = "solicitud";
            this.solicitud.Size = new System.Drawing.Size(125, 32);
            this.solicitud.TabIndex = 0;
            this.solicitud.Text = "Solicitudes";
            this.solicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.solicitud.UseVisualStyleBackColor = true;
            this.solicitud.Click += new System.EventHandler(this.solicitud_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "______________";
            // 
            // textNameUser
            // 
            this.textNameUser.AutoSize = true;
            this.textNameUser.BackColor = System.Drawing.Color.Transparent;
            this.textNameUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameUser.ForeColor = System.Drawing.Color.Brown;
            this.textNameUser.Location = new System.Drawing.Point(63, 153);
            this.textNameUser.Name = "textNameUser";
            this.textNameUser.Size = new System.Drawing.Size(63, 18);
            this.textNameUser.TabIndex = 2;
            this.textNameUser.Text = "Usuario";
            this.textNameUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentadora.Properties.Resources.Administrador;
            this.pictureBox1.Location = new System.Drawing.Point(33, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pfmrs
            // 
            this.Pfmrs.Controls.Add(this.usertype);
            this.Pfmrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pfmrs.Location = new System.Drawing.Point(200, 50);
            this.Pfmrs.Name = "Pfmrs";
            this.Pfmrs.Size = new System.Drawing.Size(1000, 550);
            this.Pfmrs.TabIndex = 4;
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype.Location = new System.Drawing.Point(175, 81);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(130, 24);
            this.usertype.TabIndex = 0;
            this.usertype.Text = "Bienvenidos (:";
            // 
            // finalizar
            // 
            this.finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizar.FlatAppearance.BorderSize = 0;
            this.finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar.ForeColor = System.Drawing.Color.White;
            this.finalizar.Location = new System.Drawing.Point(21, 398);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(125, 32);
            this.finalizar.TabIndex = 10;
            this.finalizar.Text = "Finalización";
            this.finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.Pfmrs);
            this.Controls.Add(this.Pcabeza);
            this.Controls.Add(this.Plateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrPrincipal";
            this.Load += new System.EventHandler(this.fmrPrincipal_Load);
            this.Pcabeza.ResumeLayout(false);
            this.Pcabeza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Plateral.ResumeLayout(false);
            this.Plateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pfmrs.ResumeLayout(false);
            this.Pfmrs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Panel Pcabeza;
        private System.Windows.Forms.Panel Plateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textNameUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button contrato;
        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.Button solicitud;
        private System.Windows.Forms.PictureBox flecha;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button empleados;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Pfmrs;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.Button finalizar;
    }
}