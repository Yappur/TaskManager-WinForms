namespace Desktop_form
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
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            cmbUrgencia = new ComboBox();
            btnguardar = new Button();
            btnlimpiar = new Button();
            grilla = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            timeLimit = new Label();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de tarea";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 76);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Urgencia de tarea";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(149, 20);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(254, 23);
            txtnombre.TabIndex = 2;
            // 
            // cmbUrgencia
            // 
            cmbUrgencia.FormattingEnabled = true;
            cmbUrgencia.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbUrgencia.Location = new Point(149, 73);
            cmbUrgencia.Name = "cmbUrgencia";
            cmbUrgencia.Size = new Size(121, 23);
            cmbUrgencia.TabIndex = 4;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(34, 179);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(114, 179);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 6;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += button1_Click;
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(34, 232);
            grilla.Name = "grilla";
            grilla.Size = new Size(714, 150);
            grilla.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // timeLimit
            // 
            timeLimit.AutoSize = true;
            timeLimit.Location = new Point(34, 125);
            timeLimit.Name = "timeLimit";
            timeLimit.Size = new Size(74, 15);
            timeLimit.TabIndex = 9;
            timeLimit.Text = "Fecha Limite";
            timeLimit.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 464);
            Controls.Add(timeLimit);
            Controls.Add(dateTimePicker1);
            Controls.Add(grilla);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(cmbUrgencia);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private ComboBox cmbUrgencia;
        private Button btnguardar;
        private Button btnlimpiar;
        private DataGridView grilla;
        private DateTimePicker dateTimePicker1;
        private Label timeLimit;
    }
}
