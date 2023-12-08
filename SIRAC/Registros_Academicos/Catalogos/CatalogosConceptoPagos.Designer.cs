namespace SIRAC.Registros_Academicos.Catalogos
{
    partial class CatalogosConceptoPagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmontos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Concepto de Pago:";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconcepto.Location = new System.Drawing.Point(31, 119);
            this.txtconcepto.MaxLength = 50;
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(452, 26);
            this.txtconcepto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(31, 44);
            this.txtcodigo.MaxLength = 100;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(96, 26);
            this.txtcodigo.TabIndex = 16;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Monto Principal:";
            // 
            // txtmontop
            // 
            this.txtmontop.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontop.Location = new System.Drawing.Point(31, 197);
            this.txtmontop.MaxLength = 50;
            this.txtmontop.Name = "txtmontop";
            this.txtmontop.Size = new System.Drawing.Size(78, 26);
            this.txtmontop.TabIndex = 19;
            this.txtmontop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontop_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Monto Secundario:";
            // 
            // txtmontos
            // 
            this.txtmontos.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontos.Location = new System.Drawing.Point(31, 282);
            this.txtmontos.MaxLength = 50;
            this.txtmontos.Name = "txtmontos";
            this.txtmontos.Size = new System.Drawing.Size(78, 26);
            this.txtmontos.TabIndex = 21;
            this.txtmontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontos_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(611, 219);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(735, 399);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(128, 36);
            this.btnnuevo.TabIndex = 33;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(601, 399);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(128, 36);
            this.btnactualizar.TabIndex = 32;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(467, 399);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(128, 36);
            this.btneditar.TabIndex = 31;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(333, 399);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(128, 36);
            this.btneliminar.TabIndex = 30;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(199, 399);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(128, 36);
            this.btnguardar.TabIndex = 29;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // CatalogosConceptoPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmontop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconcepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatalogosConceptoPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogos Concepto Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmontos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
    }
}