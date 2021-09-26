
namespace EJER1_G2_POO
{
    partial class Form2
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
            this.lbrecibido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbrecibido
            // 
            this.lbrecibido.Location = new System.Drawing.Point(144, 89);
            this.lbrecibido.Name = "lbrecibido";
            this.lbrecibido.Size = new System.Drawing.Size(146, 57);
            this.lbrecibido.TabIndex = 0;
            this.lbrecibido.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbrecibido);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbrecibido;
        private System.Windows.Forms.Button button1;
    }
}