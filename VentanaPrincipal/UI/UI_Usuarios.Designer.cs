namespace UI
{
    partial class UI_Usuarios
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
            this.txt_IDUsuario = new System.Windows.Forms.TextBox();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_ApellidoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IDUsuario
            // 
            this.txt_IDUsuario.Location = new System.Drawing.Point(120, 70);
            this.txt_IDUsuario.Name = "txt_IDUsuario";
            this.txt_IDUsuario.Size = new System.Drawing.Size(193, 20);
            this.txt_IDUsuario.TabIndex = 0;
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(120, 96);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(193, 20);
            this.txt_NombreUsuario.TabIndex = 4;
            // 
            // txt_ApellidoUsuario
            // 
            this.txt_ApellidoUsuario.Location = new System.Drawing.Point(120, 122);
            this.txt_ApellidoUsuario.Name = "txt_ApellidoUsuario";
            this.txt_ApellidoUsuario.Size = new System.Drawing.Size(193, 20);
            this.txt_ApellidoUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "APELLIDO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 227);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(365, 66);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarUsuario.TabIndex = 10;
            this.btn_AgregarUsuario.Text = "Agregar";
            this.btn_AgregarUsuario.UseVisualStyleBackColor = true;
            this.btn_AgregarUsuario.Click += new System.EventHandler(this.btn_AgregarUsuario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ventana Usuarios";
            // 
            // UI_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_AgregarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ApellidoUsuario);
            this.Controls.Add(this.txt_NombreUsuario);
            this.Controls.Add(this.txt_IDUsuario);
            this.Name = "UI_Usuarios";
            this.Text = "UI_Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDUsuario;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.TextBox txt_ApellidoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AgregarUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}