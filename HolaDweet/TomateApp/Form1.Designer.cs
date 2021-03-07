
namespace TomateApp
{
    partial class Form1
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
            this.btnAddMedida = new System.Windows.Forms.Button();
            this.btnActuacion = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAddMedida
            // 
            this.btnAddMedida.Location = new System.Drawing.Point(67, 37);
            this.btnAddMedida.Name = "btnAddMedida";
            this.btnAddMedida.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedida.TabIndex = 0;
            this.btnAddMedida.Text = "Humedad";
            this.btnAddMedida.UseVisualStyleBackColor = true;
            this.btnAddMedida.Click += new System.EventHandler(this.btnAddMedida_Click);
            // 
            // btnActuacion
            // 
            this.btnActuacion.Location = new System.Drawing.Point(67, 89);
            this.btnActuacion.Name = "btnActuacion";
            this.btnActuacion.Size = new System.Drawing.Size(75, 23);
            this.btnActuacion.TabIndex = 0;
            this.btnActuacion.Text = "Temperatura";
            this.btnActuacion.UseVisualStyleBackColor = true;
            this.btnActuacion.Click += new System.EventHandler(this.btnActuacion_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(67, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver en web";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnActuacion);
            this.Controls.Add(this.btnAddMedida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedida;
        private System.Windows.Forms.Button btnActuacion;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

