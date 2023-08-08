
namespace Test_Grila2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Permutari = new System.Windows.Forms.Button();
            this.Matrice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Permutari
            // 
            this.Permutari.BackColor = System.Drawing.Color.OliveDrab;
            this.Permutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permutari.ForeColor = System.Drawing.Color.Black;
            this.Permutari.Location = new System.Drawing.Point(208, 127);
            this.Permutari.Name = "Permutari";
            this.Permutari.Size = new System.Drawing.Size(244, 78);
            this.Permutari.TabIndex = 1;
            this.Permutari.Text = "Permutari";
            this.Permutari.UseVisualStyleBackColor = false;
            this.Permutari.Click += new System.EventHandler(this.Permutari_Click);
            this.Permutari.MouseLeave += new System.EventHandler(this.Permutari_MouseLeave);
            this.Permutari.MouseHover += new System.EventHandler(this.Permutari_MouseHover);
            // 
            // Matrice
            // 
            this.Matrice.BackColor = System.Drawing.Color.OliveDrab;
            this.Matrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matrice.ForeColor = System.Drawing.Color.Black;
            this.Matrice.Location = new System.Drawing.Point(208, 487);
            this.Matrice.Name = "Matrice";
            this.Matrice.Size = new System.Drawing.Size(244, 78);
            this.Matrice.TabIndex = 2;
            this.Matrice.Text = "Matrice";
            this.Matrice.UseVisualStyleBackColor = false;
            this.Matrice.Click += new System.EventHandler(this.Matrice_Click);
            this.Matrice.MouseLeave += new System.EventHandler(this.Matrice_MouseLeave);
            this.Matrice.MouseHover += new System.EventHandler(this.Matrice_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(208, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Determinanti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test_Grila2.Properties.Resources.pitagora;
            this.pictureBox1.Location = new System.Drawing.Point(626, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Grila2.Properties.Resources.Untitled_design;
            this.ClientSize = new System.Drawing.Size(1525, 793);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matrice);
            this.Controls.Add(this.Permutari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Permutari;
        private System.Windows.Forms.Button Matrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}