namespace Activos__examen_cesar_
{
    partial class Form1
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbTiposBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarTipo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(24, 410);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // cmbTiposBuscar
            // 
            this.cmbTiposBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposBuscar.FormattingEnabled = true;
            this.cmbTiposBuscar.Items.AddRange(new object[] {
            "Edificio",
            "Vehiculo",
            "Maquinaria",
            "Mobiliario",
            "EquipoComputo"});
            this.cmbTiposBuscar.Location = new System.Drawing.Point(147, 13);
            this.cmbTiposBuscar.Name = "cmbTiposBuscar";
            this.cmbTiposBuscar.Size = new System.Drawing.Size(209, 21);
            this.cmbTiposBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por:";
            // 
            // txtIngresarTipo
            // 
            this.txtIngresarTipo.Location = new System.Drawing.Point(394, 13);
            this.txtIngresarTipo.Name = "txtIngresarTipo";
            this.txtIngresarTipo.Size = new System.Drawing.Size(163, 20);
            this.txtIngresarTipo.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(571, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(53, 54);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(678, 314);
            this.rtbMostrar.TabIndex = 5;
            this.rtbMostrar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIngresarTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTiposBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Gestion activo fijo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbTiposBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarTipo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox rtbMostrar;
    }
}

