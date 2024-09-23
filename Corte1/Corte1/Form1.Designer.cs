namespace Corte1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbapellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbciudad = new System.Windows.Forms.ComboBox();
            this.labciud = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnedad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(79, 19);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(128, 20);
            this.tbname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(302, 19);
            this.tbapellidos.Margin = new System.Windows.Forms.Padding(2);
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.Size = new System.Drawing.Size(128, 20);
            this.tbapellidos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // dtpfechanacimiento
            // 
            this.dtpfechanacimiento.Location = new System.Drawing.Point(145, 65);
            this.dtpfechanacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfechanacimiento.Name = "dtpfechanacimiento";
            this.dtpfechanacimiento.Size = new System.Drawing.Size(233, 20);
            this.dtpfechanacimiento.TabIndex = 6;
            // 
            // cmbciudad
            // 
            this.cmbciudad.FormattingEnabled = true;
            this.cmbciudad.Items.AddRange(new object[] {
            "Managua",
            "Esteli ",
            "Granada"});
            this.cmbciudad.Location = new System.Drawing.Point(79, 109);
            this.cmbciudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbciudad.Name = "cmbciudad";
            this.cmbciudad.Size = new System.Drawing.Size(82, 21);
            this.cmbciudad.TabIndex = 7;
            // 
            // labciud
            // 
            this.labciud.AutoSize = true;
            this.labciud.Location = new System.Drawing.Point(11, 109);
            this.labciud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labciud.Name = "labciud";
            this.labciud.Size = new System.Drawing.Size(43, 13);
            this.labciud.TabIndex = 8;
            this.labciud.Text = "Ciudad:";
            // 
            // btnagregar
            // 
            this.btnagregar.ForeColor = System.Drawing.Color.Lime;
            this.btnagregar.Location = new System.Drawing.Point(40, 163);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(137, 45);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedad
            // 
            this.btnedad.ForeColor = System.Drawing.Color.Red;
            this.btnedad.Location = new System.Drawing.Point(302, 163);
            this.btnedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnedad.Name = "btnedad";
            this.btnedad.Size = new System.Drawing.Size(128, 45);
            this.btnedad.TabIndex = 10;
            this.btnedad.Text = "Mayor de Edad";
            this.btnedad.UseVisualStyleBackColor = true;
            this.btnedad.Click += new System.EventHandler(this.btnMayorEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnedad);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.labciud);
            this.Controls.Add(this.cmbciudad);
            this.Controls.Add(this.dtpfechanacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Registro de edades - DGMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbapellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfechanacimiento;
        private System.Windows.Forms.ComboBox cmbciudad;
        private System.Windows.Forms.Label labciud;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnedad;
    }
}

