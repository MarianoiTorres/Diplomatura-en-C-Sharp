namespace NET2U4_1_UI
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
            tbxNombre = new TextBox();
            label1 = new Label();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(221, 91);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(133, 23);
            tbxNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 94);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(221, 135);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(133, 27);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar!";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 283);
            Controls.Add(btnSaludar);
            Controls.Add(label1);
            Controls.Add(tbxNombre);
            Name = "Form1";
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNombre;
        private Label label1;
        private Button btnSaludar;
    }
}
