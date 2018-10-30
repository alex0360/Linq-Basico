namespace Linq1_1
{
    partial class FormInicio
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
            if(disposing && (components != null)) {
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
            this.BGuardar = new System.Windows.Forms.Button();
            this.BMostrar = new System.Windows.Forms.Button();
            this.BCargar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.LBLista = new System.Windows.Forms.ListBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LTel = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBTel = new System.Windows.Forms.TextBox();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(40, 233);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(92, 49);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BMostrar
            // 
            this.BMostrar.Location = new System.Drawing.Point(138, 233);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(92, 49);
            this.BMostrar.TabIndex = 9;
            this.BMostrar.Text = "Mostrar";
            this.BMostrar.UseVisualStyleBackColor = true;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // BCargar
            // 
            this.BCargar.Location = new System.Drawing.Point(236, 233);
            this.BCargar.Name = "BCargar";
            this.BCargar.Size = new System.Drawing.Size(92, 49);
            this.BCargar.TabIndex = 10;
            this.BCargar.Text = "Cargar";
            this.BCargar.UseVisualStyleBackColor = true;
            // 
            // BModificar
            // 
            this.BModificar.Location = new System.Drawing.Point(94, 297);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(92, 49);
            this.BModificar.TabIndex = 11;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(203, 297);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(92, 49);
            this.BEliminar.TabIndex = 12;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // LBLista
            // 
            this.LBLista.FormattingEnabled = true;
            this.LBLista.ItemHeight = 16;
            this.LBLista.Location = new System.Drawing.Point(40, 371);
            this.LBLista.Name = "LBLista";
            this.LBLista.Size = new System.Drawing.Size(288, 148);
            this.LBLista.TabIndex = 13;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(14, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(356, 37);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "EntityFramework_Linq";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(40, 73);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(58, 17);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            // 
            // LTel
            // 
            this.LTel.AutoSize = true;
            this.LTel.Location = new System.Drawing.Point(40, 120);
            this.LTel.Name = "LTel";
            this.LTel.Size = new System.Drawing.Size(64, 17);
            this.LTel.TabIndex = 3;
            this.LTel.Text = "Telefono";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(115, 70);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(180, 22);
            this.TBNombre.TabIndex = 5;
            // 
            // TBTel
            // 
            this.TBTel.Location = new System.Drawing.Point(115, 117);
            this.TBTel.Name = "TBTel";
            this.TBTel.Size = new System.Drawing.Size(180, 22);
            this.TBTel.TabIndex = 6;
            // 
            // CBBuscar
            // 
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Location = new System.Drawing.Point(115, 162);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(180, 24);
            this.CBBuscar.TabIndex = 7;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Location = new System.Drawing.Point(42, 165);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(52, 17);
            this.LBuscar.TabIndex = 4;
            this.LBuscar.Text = "Buscar";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 551);
            this.Controls.Add(this.CBBuscar);
            this.Controls.Add(this.TBTel);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.LTel);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.LBLista);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BCargar);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.BGuardar);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BMostrar;
        private System.Windows.Forms.Button BCargar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.ListBox LBLista;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LTel;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBTel;
        private System.Windows.Forms.ComboBox CBBuscar;
        private System.Windows.Forms.Label LBuscar;
    }
}