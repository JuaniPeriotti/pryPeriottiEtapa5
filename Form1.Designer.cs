namespace pryPeriottiEtapa5
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
            btnCrearVehiculos = new Button();
            SuspendLayout();
            // 
            // btnCrearVehiculos
            // 
            btnCrearVehiculos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearVehiculos.Location = new Point(165, 436);
            btnCrearVehiculos.Name = "btnCrearVehiculos";
            btnCrearVehiculos.Size = new Size(246, 67);
            btnCrearVehiculos.TabIndex = 0;
            btnCrearVehiculos.Text = "Crear Vehículos";
            btnCrearVehiculos.UseVisualStyleBackColor = true;
            btnCrearVehiculos.Click += btnCrearVehiculos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 515);
            Controls.Add(btnCrearVehiculos);
            MaximumSize = new Size(592, 554);
            MinimumSize = new Size(592, 554);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearVehiculos;
    }
}
