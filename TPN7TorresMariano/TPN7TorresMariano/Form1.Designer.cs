namespace TPN7TorresMariano
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvEmpleados = new DataGridView();
            tabPage2 = new TabPage();
            groupCrearEmpleado = new GroupBox();
            btnCrearEmpleado = new Button();
            ckbCasado = new CheckBox();
            txtSalario = new TextBox();
            label5 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            tabPage2.SuspendLayout();
            groupCrearEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 415);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvEmpleados);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 387);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Empleados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.ImeMode = ImeMode.Off;
            dgvEmpleados.Location = new Point(3, 3);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(762, 381);
            dgvEmpleados.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupCrearEmpleado);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 387);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crear Empleado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupCrearEmpleado
            // 
            groupCrearEmpleado.Controls.Add(btnCrearEmpleado);
            groupCrearEmpleado.Controls.Add(ckbCasado);
            groupCrearEmpleado.Controls.Add(txtSalario);
            groupCrearEmpleado.Controls.Add(label5);
            groupCrearEmpleado.Controls.Add(txtEdad);
            groupCrearEmpleado.Controls.Add(label3);
            groupCrearEmpleado.Controls.Add(label4);
            groupCrearEmpleado.Controls.Add(txtDni);
            groupCrearEmpleado.Controls.Add(label2);
            groupCrearEmpleado.Controls.Add(txtNombre);
            groupCrearEmpleado.Controls.Add(label1);
            groupCrearEmpleado.Dock = DockStyle.Fill;
            groupCrearEmpleado.Location = new Point(3, 3);
            groupCrearEmpleado.Name = "groupCrearEmpleado";
            groupCrearEmpleado.Size = new Size(762, 381);
            groupCrearEmpleado.TabIndex = 0;
            groupCrearEmpleado.TabStop = false;
            groupCrearEmpleado.Text = "Crear Empleado";
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(108, 223);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(147, 33);
            btnCrearEmpleado.TabIndex = 11;
            btnCrearEmpleado.Text = "Crear Empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // ckbCasado
            // 
            ckbCasado.AutoSize = true;
            ckbCasado.Location = new Point(108, 149);
            ckbCasado.Name = "ckbCasado";
            ckbCasado.Size = new Size(83, 19);
            ckbCasado.TabIndex = 10;
            ckbCasado.Text = "checkBox1";
            ckbCasado.UseVisualStyleBackColor = true;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(108, 174);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(218, 23);
            txtSalario.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 177);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Salario";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(108, 120);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(218, 23);
            txtEdad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 123);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 150);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 4;
            label4.Text = "Casado";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(108, 91);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(218, 23);
            txtDni.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 94);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            tabPage2.ResumeLayout(false);
            groupCrearEmpleado.ResumeLayout(false);
            groupCrearEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvEmpleados;
        private TabPage tabPage2;
        private GroupBox groupCrearEmpleado;
        private TextBox txtEdad;
        private Label label3;
        private Label label4;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnCrearEmpleado;
        private CheckBox ckbCasado;
        private TextBox txtSalario;
        private Label label5;
    }
}
