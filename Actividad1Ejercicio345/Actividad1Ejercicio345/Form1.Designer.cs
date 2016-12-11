namespace Actividad1Ejercicio345
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbActivar = new System.Windows.Forms.RadioButton();
            this.gbEjercicio3 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbLado3 = new System.Windows.Forms.TextBox();
            this.txbLado2 = new System.Windows.Forms.TextBox();
            this.txbLado1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEjercicio3WithClass = new System.Windows.Forms.GroupBox();
            this.btnCalcularPer = new System.Windows.Forms.Button();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbEnable = new System.Windows.Forms.RadioButton();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.gbEjercicio3.SuspendLayout();
            this.gbEjercicio3WithClass.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbActivar
            // 
            this.rdbActivar.AutoSize = true;
            this.rdbActivar.Location = new System.Drawing.Point(12, 41);
            this.rdbActivar.Name = "rdbActivar";
            this.rdbActivar.Size = new System.Drawing.Size(58, 17);
            this.rdbActivar.TabIndex = 0;
            this.rdbActivar.Text = "Activar";
            this.rdbActivar.UseVisualStyleBackColor = true;
            this.rdbActivar.CheckedChanged += new System.EventHandler(this.rdbActivar_CheckedChanged);
            // 
            // gbEjercicio3
            // 
            this.gbEjercicio3.Controls.Add(this.btnCalcular);
            this.gbEjercicio3.Controls.Add(this.txbLado3);
            this.gbEjercicio3.Controls.Add(this.txbLado2);
            this.gbEjercicio3.Controls.Add(this.txbLado1);
            this.gbEjercicio3.Controls.Add(this.label3);
            this.gbEjercicio3.Controls.Add(this.label2);
            this.gbEjercicio3.Controls.Add(this.label1);
            this.gbEjercicio3.Enabled = false;
            this.gbEjercicio3.Location = new System.Drawing.Point(12, 64);
            this.gbEjercicio3.Name = "gbEjercicio3";
            this.gbEjercicio3.Size = new System.Drawing.Size(234, 200);
            this.gbEjercicio3.TabIndex = 1;
            this.gbEjercicio3.TabStop = false;
            this.gbEjercicio3.Text = "Ejercicio 3";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(50, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular perimetro";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbLado3
            // 
            this.txbLado3.Location = new System.Drawing.Point(69, 90);
            this.txbLado3.Name = "txbLado3";
            this.txbLado3.Size = new System.Drawing.Size(100, 20);
            this.txbLado3.TabIndex = 5;
            // 
            // txbLado2
            // 
            this.txbLado2.Location = new System.Drawing.Point(70, 60);
            this.txbLado2.Name = "txbLado2";
            this.txbLado2.Size = new System.Drawing.Size(100, 20);
            this.txbLado2.TabIndex = 4;
            // 
            // txbLado1
            // 
            this.txbLado1.Location = new System.Drawing.Point(69, 32);
            this.txbLado1.Name = "txbLado1";
            this.txbLado1.Size = new System.Drawing.Size(100, 20);
            this.txbLado1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1";
            // 
            // gbEjercicio3WithClass
            // 
            this.gbEjercicio3WithClass.Controls.Add(this.btnCalcularPer);
            this.gbEjercicio3WithClass.Controls.Add(this.txtLado3);
            this.gbEjercicio3WithClass.Controls.Add(this.txtLado2);
            this.gbEjercicio3WithClass.Controls.Add(this.txtLado1);
            this.gbEjercicio3WithClass.Controls.Add(this.label4);
            this.gbEjercicio3WithClass.Controls.Add(this.label5);
            this.gbEjercicio3WithClass.Controls.Add(this.label6);
            this.gbEjercicio3WithClass.Enabled = false;
            this.gbEjercicio3WithClass.Location = new System.Drawing.Point(261, 64);
            this.gbEjercicio3WithClass.Name = "gbEjercicio3WithClass";
            this.gbEjercicio3WithClass.Size = new System.Drawing.Size(234, 200);
            this.gbEjercicio3WithClass.TabIndex = 3;
            this.gbEjercicio3WithClass.TabStop = false;
            this.gbEjercicio3WithClass.Text = "Ejercicio 3 con Clase";
            // 
            // btnCalcularPer
            // 
            this.btnCalcularPer.Location = new System.Drawing.Point(51, 137);
            this.btnCalcularPer.Name = "btnCalcularPer";
            this.btnCalcularPer.Size = new System.Drawing.Size(134, 23);
            this.btnCalcularPer.TabIndex = 6;
            this.btnCalcularPer.Text = "Calcular perimetro";
            this.btnCalcularPer.UseVisualStyleBackColor = true;
            this.btnCalcularPer.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(69, 90);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 5;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(70, 60);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 4;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(69, 32);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lado 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lado 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lado 1";
            // 
            // rbEnable
            // 
            this.rbEnable.AutoSize = true;
            this.rbEnable.Location = new System.Drawing.Point(261, 41);
            this.rbEnable.Name = "rbEnable";
            this.rbEnable.Size = new System.Drawing.Size(58, 17);
            this.rbEnable.TabIndex = 2;
            this.rbEnable.Text = "Activar";
            this.rbEnable.UseVisualStyleBackColor = true;
            this.rbEnable.CheckedChanged += new System.EventHandler(this.rbEnable_CheckedChanged);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.lblEdad);
            this.gbList.Controls.Add(this.txtEdad);
            this.gbList.Controls.Add(this.btnAdd);
            this.gbList.Controls.Add(this.lblNombre);
            this.gbList.Controls.Add(this.txtNombre);
            this.gbList.Location = new System.Drawing.Point(501, 64);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(278, 121);
            this.gbList.TabIndex = 4;
            this.gbList.TabStop = false;
            this.gbList.Text = "Listas con clases";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(29, 60);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(76, 60);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(501, 191);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(278, 162);
            this.dgvPersonas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 377);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbEjercicio3WithClass);
            this.Controls.Add(this.rbEnable);
            this.Controls.Add(this.gbEjercicio3);
            this.Controls.Add(this.rdbActivar);
            this.Name = "Form1";
            this.Text = "Practica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEjercicio3.ResumeLayout(false);
            this.gbEjercicio3.PerformLayout();
            this.gbEjercicio3WithClass.ResumeLayout(false);
            this.gbEjercicio3WithClass.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbActivar;
        private System.Windows.Forms.GroupBox gbEjercicio3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbLado3;
        private System.Windows.Forms.TextBox txbLado2;
        private System.Windows.Forms.TextBox txbLado1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEjercicio3WithClass;
        private System.Windows.Forms.Button btnCalcularPer;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbEnable;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvPersonas;
    }
}

