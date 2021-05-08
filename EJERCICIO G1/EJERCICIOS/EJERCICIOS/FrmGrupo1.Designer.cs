
namespace EJERCICIOS
{
    partial class FrmGrupo1
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.BtnTexto = new System.Windows.Forms.Button();
            this.dtgContenido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.Black;
            this.txtTexto.Location = new System.Drawing.Point(16, 195);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(173, 26);
            this.txtTexto.TabIndex = 0;
            // 
            // BtnTexto
            // 
            this.BtnTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.BtnTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTexto.ForeColor = System.Drawing.Color.White;
            this.BtnTexto.Location = new System.Drawing.Point(217, 184);
            this.BtnTexto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTexto.Name = "BtnTexto";
            this.BtnTexto.Size = new System.Drawing.Size(121, 45);
            this.BtnTexto.TabIndex = 1;
            this.BtnTexto.Text = "INGRESAR";
            this.BtnTexto.UseVisualStyleBackColor = false;
            this.BtnTexto.Click += new System.EventHandler(this.BtnTexto_Click);
            // 
            // dtgContenido
            // 
            this.dtgContenido.AllowUserToAddRows = false;
            this.dtgContenido.AllowUserToDeleteRows = false;
            this.dtgContenido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgContenido.BackgroundColor = System.Drawing.Color.Gray;
            this.dtgContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContenido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgContenido.Location = new System.Drawing.Point(359, 89);
            this.dtgContenido.Margin = new System.Windows.Forms.Padding(4);
            this.dtgContenido.Name = "dtgContenido";
            this.dtgContenido.ReadOnly = true;
            this.dtgContenido.Size = new System.Drawing.Size(302, 283);
            this.dtgContenido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese sus datos";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Datos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FrmGrupo1
            // 
            this.AcceptButton = this.BtnTexto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgContenido);
            this.Controls.Add(this.BtnTexto);
            this.Controls.Add(this.txtTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrupo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button BtnTexto;
        private System.Windows.Forms.DataGridView dtgContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

