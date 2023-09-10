
namespace Login2
{
    partial class flapyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flapyBird));
            this.Player = new System.Windows.Forms.PictureBox();
            this.TuboArriba = new System.Windows.Forms.PictureBox();
            this.TuboAbajo = new System.Windows.Forms.PictureBox();
            this.Barrera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrera)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Login2.Properties.Resources.PngItem_2299145;
            this.Player.Location = new System.Drawing.Point(19, 225);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(83, 55);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // TuboArriba
            // 
            this.TuboArriba.BackColor = System.Drawing.Color.Transparent;
            this.TuboArriba.Image = ((System.Drawing.Image)(resources.GetObject("TuboArriba.Image")));
            this.TuboArriba.Location = new System.Drawing.Point(134, -173);
            this.TuboArriba.Name = "TuboArriba";
            this.TuboArriba.Size = new System.Drawing.Size(135, 366);
            this.TuboArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TuboArriba.TabIndex = 1;
            this.TuboArriba.TabStop = false;
            // 
            // TuboAbajo
            // 
            this.TuboAbajo.BackColor = System.Drawing.Color.Transparent;
            this.TuboAbajo.Image = ((System.Drawing.Image)(resources.GetObject("TuboAbajo.Image")));
            this.TuboAbajo.Location = new System.Drawing.Point(134, 319);
            this.TuboAbajo.Name = "TuboAbajo";
            this.TuboAbajo.Size = new System.Drawing.Size(135, 366);
            this.TuboAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TuboAbajo.TabIndex = 2;
            this.TuboAbajo.TabStop = false;
            // 
            // Barrera
            // 
            this.Barrera.Image = global::Login2.Properties.Resources.suelo2;
            this.Barrera.Location = new System.Drawing.Point(-274, 443);
            this.Barrera.Name = "Barrera";
            this.Barrera.Size = new System.Drawing.Size(779, 24);
            this.Barrera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barrera.TabIndex = 3;
            this.Barrera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.Color.Transparent;
            this.Puntaje.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.Location = new System.Drawing.Point(52, 198);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(28, 31);
            this.Puntaje.TabIndex = 4;
            this.Puntaje.Text = "0";
            // 
            // flapyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login2.Properties.Resources._725e5dc00ba49c240cd489e7b87e0496__1_;
            this.ClientSize = new System.Drawing.Size(290, 456);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.Barrera);
            this.Controls.Add(this.TuboAbajo);
            this.Controls.Add(this.TuboArriba);
            this.Controls.Add(this.Player);
            this.Name = "flapyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flapyBird";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flapyBird_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox TuboArriba;
        private System.Windows.Forms.PictureBox TuboAbajo;
        private System.Windows.Forms.PictureBox Barrera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Puntaje;
    }
}