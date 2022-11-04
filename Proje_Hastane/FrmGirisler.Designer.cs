
namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDoktorGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSekreterGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHastaGiris
            // 
            this.BtnHastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGiris.BackgroundImage")));
            this.BtnHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGiris.Location = new System.Drawing.Point(63, 232);
            this.BtnHastaGiris.Name = "BtnHastaGiris";
            this.BtnHastaGiris.Size = new System.Drawing.Size(249, 233);
            this.BtnHastaGiris.TabIndex = 0;
            this.BtnHastaGiris.UseVisualStyleBackColor = true;
            this.BtnHastaGiris.Click += new System.EventHandler(this.BtnHastaGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(459, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor";
            // 
            // BtnDoktorGiris
            // 
            this.BtnDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGiris.BackgroundImage")));
            this.BtnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGiris.Location = new System.Drawing.Point(377, 232);
            this.BtnDoktorGiris.Name = "BtnDoktorGiris";
            this.BtnDoktorGiris.Size = new System.Drawing.Size(249, 233);
            this.BtnDoktorGiris.TabIndex = 2;
            this.BtnDoktorGiris.UseVisualStyleBackColor = true;
            this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(751, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // BtnSekreterGiris
            // 
            this.BtnSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGiris.BackgroundImage")));
            this.BtnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGiris.Location = new System.Drawing.Point(679, 232);
            this.BtnSekreterGiris.Name = "BtnSekreterGiris";
            this.BtnSekreterGiris.Size = new System.Drawing.Size(249, 233);
            this.BtnSekreterGiris.TabIndex = 4;
            this.BtnSekreterGiris.UseVisualStyleBackColor = true;
            this.BtnSekreterGiris.Click += new System.EventHandler(this.BtnSekreterGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(108, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 87);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aktaş Hospital";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(996, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSekreterGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDoktorGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHastaGiris);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Aktaş Hospital Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDoktorGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSekreterGiris;
        private System.Windows.Forms.Label label4;
    }
}

