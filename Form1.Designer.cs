namespace Practica_05
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_high = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn_bi = new System.Windows.Forms.RadioButton();
            this.rBtn_fem = new System.Windows.Forms.RadioButton();
            this.rBtn_masc = new System.Windows.Forms.RadioButton();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_high = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(44, 43);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(44, 84);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(52, 13);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "Apellidos:";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(44, 127);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(52, 13);
            this.lbl_num.TabIndex = 2;
            this.lbl_num.Text = "Teléfono:";
            // 
            // lbl_high
            // 
            this.lbl_high.AutoSize = true;
            this.lbl_high.Location = new System.Drawing.Point(44, 167);
            this.lbl_high.Name = "lbl_high";
            this.lbl_high.Size = new System.Drawing.Size(49, 13);
            this.lbl_high.TabIndex = 3;
            this.lbl_high.Text = "Estatura:";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(44, 211);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(35, 13);
            this.lbl_age.TabIndex = 4;
            this.lbl_age.Text = "Edad:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.rBtn_bi);
            this.groupBox1.Controls.Add(this.rBtn_fem);
            this.groupBox1.Controls.Add(this.rBtn_masc);
            this.groupBox1.Location = new System.Drawing.Point(38, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género";
            // 
            // rBtn_bi
            // 
            this.rBtn_bi.AutoSize = true;
            this.rBtn_bi.Location = new System.Drawing.Point(133, 19);
            this.rBtn_bi.Name = "rBtn_bi";
            this.rBtn_bi.Size = new System.Drawing.Size(74, 17);
            this.rBtn_bi.TabIndex = 2;
            this.rBtn_bi.TabStop = true;
            this.rBtn_bi.Text = "No Binario";
            this.rBtn_bi.UseVisualStyleBackColor = true;
            // 
            // rBtn_fem
            // 
            this.rBtn_fem.AutoSize = true;
            this.rBtn_fem.Location = new System.Drawing.Point(74, 19);
            this.rBtn_fem.Name = "rBtn_fem";
            this.rBtn_fem.Size = new System.Drawing.Size(51, 17);
            this.rBtn_fem.TabIndex = 1;
            this.rBtn_fem.TabStop = true;
            this.rBtn_fem.Text = "Mujer";
            this.rBtn_fem.UseVisualStyleBackColor = true;
            // 
            // rBtn_masc
            // 
            this.rBtn_masc.AutoSize = true;
            this.rBtn_masc.Location = new System.Drawing.Point(6, 19);
            this.rBtn_masc.Name = "rBtn_masc";
            this.rBtn_masc.Size = new System.Drawing.Size(62, 17);
            this.rBtn_masc.TabIndex = 0;
            this.rBtn_masc.TabStop = true;
            this.rBtn_masc.Text = "Hombre";
            this.rBtn_masc.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(128, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 6;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(128, 77);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 7;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(128, 120);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 8;
            // 
            // txt_high
            // 
            this.txt_high.Location = new System.Drawing.Point(128, 160);
            this.txt_high.Name = "txt_high";
            this.txt_high.Size = new System.Drawing.Size(100, 20);
            this.txt_high.TabIndex = 9;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(128, 204);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(47, 327);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(181, 37);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(47, 372);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(181, 37);
            this.btn_can.TabIndex = 12;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 427);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_high);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_high);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_high;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn_fem;
        private System.Windows.Forms.RadioButton rBtn_masc;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_high;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.RadioButton rBtn_bi;
    }
}

