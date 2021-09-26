
namespace EJER1_G2_POO
{
    partial class frmventana
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(193, 92);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 1;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(106, 161);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(143, 23);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Enviar Mensaje";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(106, 256);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Location = new System.Drawing.Point(64, 92);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(108, 15);
            this.lbmensaje.TabIndex = 4;
            this.lbmensaje.Text = "Ingrese su nombre:";
            // 
            // frmventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "frmventana";
            this.Text = "EJER1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lbmensaje;
    }
}

