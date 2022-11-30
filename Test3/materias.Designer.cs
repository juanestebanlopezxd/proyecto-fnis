namespace Test3
{
    partial class materias
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
            this.submenumaterias = new System.Windows.Forms.Panel();
            this.btnmodimate = new System.Windows.Forms.Button();
            this.btndeletemat = new System.Windows.Forms.Button();
            this.btnaggmat = new System.Windows.Forms.Button();
            this.GPsavemateria = new System.Windows.Forms.GroupBox();
            this.gpmodimaterias = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxmodinombre = new System.Windows.Forms.TextBox();
            this.textboxmodicredi = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.textboxmodid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cargarmodimaterias = new System.Windows.Forms.Button();
            this.dgvModimat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnumcredi = new System.Windows.Forms.TextBox();
            this.butonsavemate = new System.Windows.Forms.Button();
            this.textBoxidmate = new System.Windows.Forms.TextBox();
            this.textBoxnamemate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submenumaterias.SuspendLayout();
            this.GPsavemateria.SuspendLayout();
            this.gpmodimaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModimat)).BeginInit();
            this.SuspendLayout();
            // 
            // submenumaterias
            // 
            this.submenumaterias.BackColor = System.Drawing.Color.ForestGreen;
            this.submenumaterias.Controls.Add(this.btnmodimate);
            this.submenumaterias.Controls.Add(this.btndeletemat);
            this.submenumaterias.Controls.Add(this.btnaggmat);
            this.submenumaterias.Location = new System.Drawing.Point(99, 134);
            this.submenumaterias.Name = "submenumaterias";
            this.submenumaterias.Size = new System.Drawing.Size(153, 164);
            this.submenumaterias.TabIndex = 26;
            // 
            // btnmodimate
            // 
            this.btnmodimate.FlatAppearance.BorderSize = 0;
            this.btnmodimate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnmodimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodimate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodimate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodimate.Location = new System.Drawing.Point(9, 74);
            this.btnmodimate.Name = "btnmodimate";
            this.btnmodimate.Size = new System.Drawing.Size(137, 55);
            this.btnmodimate.TabIndex = 22;
            this.btnmodimate.Text = "Modificar materias";
            this.btnmodimate.UseVisualStyleBackColor = true;
            this.btnmodimate.Click += new System.EventHandler(this.btnmodimate_Click);
            // 
            // btndeletemat
            // 
            this.btndeletemat.FlatAppearance.BorderSize = 0;
            this.btndeletemat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btndeletemat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletemat.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndeletemat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletemat.Location = new System.Drawing.Point(9, 41);
            this.btndeletemat.Name = "btndeletemat";
            this.btndeletemat.Size = new System.Drawing.Size(137, 37);
            this.btndeletemat.TabIndex = 21;
            this.btndeletemat.Text = "Eliminar materia";
            this.btndeletemat.UseVisualStyleBackColor = true;
            // 
            // btnaggmat
            // 
            this.btnaggmat.FlatAppearance.BorderSize = 0;
            this.btnaggmat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaggmat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaggmat.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaggmat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaggmat.Location = new System.Drawing.Point(3, 3);
            this.btnaggmat.Name = "btnaggmat";
            this.btnaggmat.Size = new System.Drawing.Size(131, 36);
            this.btnaggmat.TabIndex = 20;
            this.btnaggmat.Text = "Agregar materia";
            this.btnaggmat.UseVisualStyleBackColor = true;
            this.btnaggmat.Click += new System.EventHandler(this.btnaggmat_Click);
            // 
            // GPsavemateria
            // 
            this.GPsavemateria.BackColor = System.Drawing.Color.LightSlateGray;
            this.GPsavemateria.Controls.Add(this.gpmodimaterias);
            this.GPsavemateria.Controls.Add(this.label3);
            this.GPsavemateria.Controls.Add(this.textBoxnumcredi);
            this.GPsavemateria.Controls.Add(this.butonsavemate);
            this.GPsavemateria.Controls.Add(this.textBoxidmate);
            this.GPsavemateria.Controls.Add(this.textBoxnamemate);
            this.GPsavemateria.Controls.Add(this.label2);
            this.GPsavemateria.Controls.Add(this.label1);
            this.GPsavemateria.Location = new System.Drawing.Point(239, 35);
            this.GPsavemateria.Name = "GPsavemateria";
            this.GPsavemateria.Size = new System.Drawing.Size(515, 554);
            this.GPsavemateria.TabIndex = 25;
            this.GPsavemateria.TabStop = false;
            this.GPsavemateria.Text = "groupBox1";
            this.GPsavemateria.Visible = false;
            // 
            // gpmodimaterias
            // 
            this.gpmodimaterias.Controls.Add(this.label9);
            this.gpmodimaterias.Controls.Add(this.label8);
            this.gpmodimaterias.Controls.Add(this.textboxmodinombre);
            this.gpmodimaterias.Controls.Add(this.textboxmodicredi);
            this.gpmodimaterias.Controls.Add(this.btnmodificar);
            this.gpmodimaterias.Controls.Add(this.textboxmodid);
            this.gpmodimaterias.Controls.Add(this.label7);
            this.gpmodimaterias.Controls.Add(this.cargarmodimaterias);
            this.gpmodimaterias.Controls.Add(this.dgvModimat);
            this.gpmodimaterias.Location = new System.Drawing.Point(306, 45);
            this.gpmodimaterias.Name = "gpmodimaterias";
            this.gpmodimaterias.Size = new System.Drawing.Size(488, 509);
            this.gpmodimaterias.TabIndex = 28;
            this.gpmodimaterias.TabStop = false;
            this.gpmodimaterias.Text = "gpmodimaterias";
            this.gpmodimaterias.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ingrese nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ingrese creditos";
            // 
            // textboxmodinombre
            // 
            this.textboxmodinombre.Location = new System.Drawing.Point(25, 284);
            this.textboxmodinombre.Name = "textboxmodinombre";
            this.textboxmodinombre.Size = new System.Drawing.Size(123, 23);
            this.textboxmodinombre.TabIndex = 28;
            // 
            // textboxmodicredi
            // 
            this.textboxmodicredi.Location = new System.Drawing.Point(168, 284);
            this.textboxmodicredi.Name = "textboxmodicredi";
            this.textboxmodicredi.Size = new System.Drawing.Size(123, 23);
            this.textboxmodicredi.TabIndex = 27;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(316, 272);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(92, 23);
            this.btnmodificar.TabIndex = 26;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // textboxmodid
            // 
            this.textboxmodid.Location = new System.Drawing.Point(27, 242);
            this.textboxmodid.Name = "textboxmodid";
            this.textboxmodid.Size = new System.Drawing.Size(123, 23);
            this.textboxmodid.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ingrese ID ";
            // 
            // cargarmodimaterias
            // 
            this.cargarmodimaterias.Location = new System.Drawing.Point(191, 199);
            this.cargarmodimaterias.Name = "cargarmodimaterias";
            this.cargarmodimaterias.Size = new System.Drawing.Size(75, 23);
            this.cargarmodimaterias.TabIndex = 23;
            this.cargarmodimaterias.Text = "Cargar";
            this.cargarmodimaterias.UseVisualStyleBackColor = true;
            this.cargarmodimaterias.Click += new System.EventHandler(this.cargarmodimaterias_Click);
            // 
            // dgvModimat
            // 
            this.dgvModimat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModimat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvModimat.Location = new System.Drawing.Point(65, 13);
            this.dgvModimat.Name = "dgvModimat";
            this.dgvModimat.RowTemplate.Height = 25;
            this.dgvModimat.Size = new System.Drawing.Size(343, 173);
            this.dgvModimat.TabIndex = 22;
            this.dgvModimat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModimat_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Creditos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese numero de creditos";
            // 
            // textBoxnumcredi
            // 
            this.textBoxnumcredi.Location = new System.Drawing.Point(224, 309);
            this.textBoxnumcredi.Name = "textBoxnumcredi";
            this.textBoxnumcredi.Size = new System.Drawing.Size(100, 23);
            this.textBoxnumcredi.TabIndex = 7;
            // 
            // butonsavemate
            // 
            this.butonsavemate.Location = new System.Drawing.Point(238, 368);
            this.butonsavemate.Name = "butonsavemate";
            this.butonsavemate.Size = new System.Drawing.Size(75, 23);
            this.butonsavemate.TabIndex = 6;
            this.butonsavemate.Text = "Guardar";
            this.butonsavemate.UseVisualStyleBackColor = true;
            this.butonsavemate.Click += new System.EventHandler(this.butonsavemate_Click);
            // 
            // textBoxidmate
            // 
            this.textBoxidmate.Location = new System.Drawing.Point(224, 239);
            this.textBoxidmate.Name = "textBoxidmate";
            this.textBoxidmate.Size = new System.Drawing.Size(100, 23);
            this.textBoxidmate.TabIndex = 4;
            // 
            // textBoxnamemate
            // 
            this.textBoxnamemate.Location = new System.Drawing.Point(224, 172);
            this.textBoxnamemate.Name = "textBoxnamemate";
            this.textBoxnamemate.Size = new System.Drawing.Size(100, 23);
            this.textBoxnamemate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Id de la materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de la materia";
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 601);
            this.Controls.Add(this.submenumaterias);
            this.Controls.Add(this.GPsavemateria);
            this.Name = "materias";
            this.Text = "materias";
            this.submenumaterias.ResumeLayout(false);
            this.GPsavemateria.ResumeLayout(false);
            this.GPsavemateria.PerformLayout();
            this.gpmodimaterias.ResumeLayout(false);
            this.gpmodimaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModimat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel submenumaterias;
        private Button btnmodimate;
        private Button btndeletemat;
        private Button btnaggmat;
        private GroupBox GPsavemateria;
        private Label label3;
        private TextBox textBoxnumcredi;
        private Button butonsavemate;
        private TextBox textBoxidmate;
        private TextBox textBoxnamemate;
        private Label label2;
        private Label label1;
        private GroupBox gpmodimaterias;
        private Label label9;
        private Label label8;
        private TextBox textboxmodinombre;
        private TextBox textboxmodicredi;
        private Button btnmodificar;
        private TextBox textboxmodid;
        private Label label7;
        private Button cargarmodimaterias;
        private DataGridView dgvModimat;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}