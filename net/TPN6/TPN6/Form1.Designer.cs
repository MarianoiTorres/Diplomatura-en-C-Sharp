namespace TPN6
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
            groupBoxIngreso = new GroupBox();
            comboBoxGenero = new ComboBox();
            buttonIngresar = new Button();
            buttonCancel = new Button();
            textBoxPrecio = new TextBox();
            labelPrecio = new Label();
            checkBox1 = new CheckBox();
            labelImportado = new Label();
            textBoxPaginas = new TextBox();
            labelPaginas = new Label();
            labelGenero = new Label();
            textBoxAutor = new TextBox();
            labelAutor = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            tabPage2 = new TabPage();
            listBox1 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxIngreso.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxIngreso);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingreso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxIngreso
            // 
            groupBoxIngreso.Controls.Add(comboBoxGenero);
            groupBoxIngreso.Controls.Add(buttonIngresar);
            groupBoxIngreso.Controls.Add(buttonCancel);
            groupBoxIngreso.Controls.Add(textBoxPrecio);
            groupBoxIngreso.Controls.Add(labelPrecio);
            groupBoxIngreso.Controls.Add(checkBox1);
            groupBoxIngreso.Controls.Add(labelImportado);
            groupBoxIngreso.Controls.Add(textBoxPaginas);
            groupBoxIngreso.Controls.Add(labelPaginas);
            groupBoxIngreso.Controls.Add(labelGenero);
            groupBoxIngreso.Controls.Add(textBoxAutor);
            groupBoxIngreso.Controls.Add(labelAutor);
            groupBoxIngreso.Controls.Add(textBoxNombre);
            groupBoxIngreso.Controls.Add(labelNombre);
            groupBoxIngreso.Location = new Point(6, 6);
            groupBoxIngreso.Name = "groupBoxIngreso";
            groupBoxIngreso.Size = new Size(779, 411);
            groupBoxIngreso.TabIndex = 0;
            groupBoxIngreso.TabStop = false;
            groupBoxIngreso.Text = "Ingreso Libro";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Terror", "Ciencia Ficcion" });
            comboBoxGenero.Location = new Point(150, 137);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(148, 23);
            comboBoxGenero.TabIndex = 14;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(202, 341);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(96, 23);
            buttonIngresar.TabIndex = 13;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(89, 341);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(96, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(150, 276);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(148, 23);
            textBoxPrecio.TabIndex = 11;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(85, 279);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 10;
            labelPrecio.Text = "Precio";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(150, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(35, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelImportado
            // 
            labelImportado.AutoSize = true;
            labelImportado.Location = new Point(85, 234);
            labelImportado.Name = "labelImportado";
            labelImportado.Size = new Size(63, 15);
            labelImportado.TabIndex = 8;
            labelImportado.Text = "Importado";
            // 
            // textBoxPaginas
            // 
            textBoxPaginas.Location = new Point(150, 189);
            textBoxPaginas.Name = "textBoxPaginas";
            textBoxPaginas.Size = new Size(35, 23);
            textBoxPaginas.TabIndex = 7;
            // 
            // labelPaginas
            // 
            labelPaginas.AutoSize = true;
            labelPaginas.Location = new Point(85, 192);
            labelPaginas.Name = "labelPaginas";
            labelPaginas.Size = new Size(48, 15);
            labelPaginas.TabIndex = 6;
            labelPaginas.Text = "Paginas";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(85, 140);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 4;
            labelGenero.Text = "Genero";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(150, 92);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(148, 23);
            textBoxAutor.TabIndex = 3;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.Location = new Point(85, 95);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(37, 15);
            labelAutor.TabIndex = 2;
            labelAutor.Text = "Autor";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(150, 47);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(148, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(85, 50);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(176, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 229);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestion de libros";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBoxIngreso.ResumeLayout(false);
            groupBoxIngreso.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBoxIngreso;
        private Button buttonIngresar;
        private Button buttonCancel;
        private TextBox textBoxPrecio;
        private Label labelPrecio;
        private CheckBox checkBox1;
        private Label labelImportado;
        private TextBox textBoxPaginas;
        private Label labelPaginas;
        private TextBox textBox3;
        private Label labelGenero;
        private TextBox textBoxAutor;
        private Label labelAutor;
        private TextBox textBoxNombre;
        private Label labelNombre;
        private ComboBox comboBoxGenero;
        private ListBox listBox1;
    }
}
