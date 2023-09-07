namespace Login
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            cerrar2 = new Button();
            label1 = new Label();
            user2 = new TextBox();
            label2 = new Label();
            password2 = new TextBox();
            guardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(cerrar2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 44);
            panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            cerrar2.FlatAppearance.BorderColor = Color.White;
            cerrar2.FlatAppearance.BorderSize = 0;
            cerrar2.FlatAppearance.MouseDownBackColor = Color.White;
            cerrar2.FlatAppearance.MouseOverBackColor = Color.White;
            cerrar2.FlatStyle = FlatStyle.Flat;
            cerrar2.Image = (Image)resources.GetObject("cerrar2.Image");
            cerrar2.Location = new Point(302, 1);
            cerrar2.Name = "cerrar2";
            cerrar2.Size = new Size(75, 43);
            cerrar2.TabIndex = 1;
            cerrar2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 110);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // user2
            // 
            user2.BorderStyle = BorderStyle.None;
            user2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user2.Location = new Point(98, 104);
            user2.Name = "user2";
            user2.Size = new Size(255, 21);
            user2.TabIndex = 3;
            user2.Text = "Ingrese su usuario";
            user2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 166);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // password2
            // 
            password2.BorderStyle = BorderStyle.None;
            password2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password2.Location = new Point(98, 165);
            password2.Name = "password2";
            password2.Size = new Size(255, 21);
            password2.TabIndex = 5;
            password2.Text = "Ingrese su Contraseña";
            password2.TextAlign = HorizontalAlignment.Center;
            password2.TextChanged += password2_TextChanged;
            // 
            // guardar
            // 
            guardar.BackColor = Color.DodgerBlue;
            guardar.FlatAppearance.BorderColor = Color.Red;
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatAppearance.MouseDownBackColor = Color.Red;
            guardar.FlatAppearance.MouseOverBackColor = Color.Red;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guardar.Location = new Point(125, 235);
            guardar.Name = "guardar";
            guardar.Size = new Size(110, 42);
            guardar.TabIndex = 6;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 346);
            Controls.Add(guardar);
            Controls.Add(password2);
            Controls.Add(label2);
            Controls.Add(user2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cerrar2;
        private Label label1;
        private TextBox user2;
        private Label label2;
        private TextBox password2;
        private Button guardar;
    }
}