namespace RekenGame
{
    partial class Form1
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
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.tmrAnimationPlayer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPlayer.Image = global::RekenGame.Properties.Resources.advnt_full;
            this.pbxPlayer.Location = new System.Drawing.Point(0, 0);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(640, 1280);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 0;
            this.pbxPlayer.TabStop = false;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer.Controls.Add(this.pbxPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(24, 244);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(137, 134);
            this.pnlPlayer.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(438, 221);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tmrAnimationPlayer
            // 
            this.tmrAnimationPlayer.Tick += new System.EventHandler(this.tmrAnimationPlayer_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(312, 221);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::RekenGame.Properties.Resources.d20sxct_bb202977_b992_49a9_82d1_c0b6b9c5c793;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pnlPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            this.pnlPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer tmrAnimationPlayer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

