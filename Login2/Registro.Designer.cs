namespace Login2
{
    partial class Registro2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n_password = new System.Windows.Forms.TextBox();
            this.n_user = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.cerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 73);
            this.panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            this.cerrar2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cerrar2.FlatAppearance.BorderSize = 0;
            this.cerrar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cerrar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cerrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar2.Image = ((System.Drawing.Image)(resources.GetObject("cerrar2.Image")));
            this.cerrar2.Location = new System.Drawing.Point(500, 15);
            this.cerrar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cerrar2.Name = "cerrar2";
            this.cerrar2.Size = new System.Drawing.Size(65, 38);
            this.cerrar2.TabIndex = 1;
            this.cerrar2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese su Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese su Usuario";
            // 
            // n_password
            // 
            this.n_password.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_password.Location = new System.Drawing.Point(223, 215);
            this.n_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.n_password.Name = "n_password";
            this.n_password.Size = new System.Drawing.Size(240, 40);
            this.n_password.TabIndex = 7;
            // 
            // n_user
            // 
            this.n_user.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_user.Location = new System.Drawing.Point(223, 135);
            this.n_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.n_user.Name = "n_user";
            this.n_user.Size = new System.Drawing.Size(240, 40);
            this.n_user.TabIndex = 6;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Red;
            this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(223, 310);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(113, 53);
            this.Guardar.TabIndex = 10;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Registro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 484);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_password);
            this.Controls.Add(this.n_user);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_password;
        private System.Windows.Forms.TextBox n_user;
        private System.Windows.Forms.Button Guardar;
    }
}