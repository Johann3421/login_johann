namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            cerrar = new Button();
            pictureBox1 = new PictureBox();
            user = new TextBox();
            password = new TextBox();
            muestra = new CheckBox();
            entrar = new Button();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 43);
            panel1.TabIndex = 0;
            // 
            // cerrar
            // 
            cerrar.FlatAppearance.BorderColor = Color.White;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.FlatAppearance.MouseDownBackColor = Color.White;
            cerrar.FlatAppearance.MouseOverBackColor = Color.White;
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.Image = (Image)resources.GetObject("cerrar.Image");
            cerrar.Location = new Point(328, 0);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(75, 43);
            cerrar.TabIndex = 0;
            cerrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(72, 201);
            user.Name = "user";
            user.Size = new Size(255, 21);
            user.TabIndex = 2;
            user.Text = "Ingrese su usuario";
            user.TextAlign = HorizontalAlignment.Center;
            user.TextChanged += user_TextChanged;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(72, 291);
            password.Name = "password";
            password.Size = new Size(255, 21);
            password.TabIndex = 3;
            password.Text = "Ingrese su Contraseña";
            password.TextAlign = HorizontalAlignment.Center;
            password.TextChanged += textBox1_TextChanged;
            // 
            // muestra
            // 
            muestra.AutoSize = true;
            muestra.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            muestra.Location = new Point(244, 333);
            muestra.Name = "muestra";
            muestra.Size = new Size(136, 20);
            muestra.TabIndex = 4;
            muestra.Text = "Mostrar Contraseña";
            muestra.UseVisualStyleBackColor = true;
            // 
            // entrar
            // 
            entrar.BackColor = Color.DodgerBlue;
            entrar.FlatAppearance.BorderColor = Color.Red;
            entrar.FlatAppearance.BorderSize = 0;
            entrar.FlatAppearance.MouseDownBackColor = Color.Red;
            entrar.FlatAppearance.MouseOverBackColor = Color.Red;
            entrar.FlatStyle = FlatStyle.Flat;
            entrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            entrar.ForeColor = Color.White;
            entrar.Location = new Point(146, 376);
            entrar.Name = "entrar";
            entrar.Size = new Size(110, 42);
            entrar.TabIndex = 5;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 431);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 6;
            label1.Text = "¿No estas Registrado?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(146, 474);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 7;
            button1.Text = "Registrarme";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 518);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(entrar);
            Controls.Add(muestra);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cerrar;
        private PictureBox pictureBox1;
        private TextBox user;
        private TextBox password;
        private CheckBox muestra;
        private Button entrar;
        private Label label1;
        private Button button1;
    }
}