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
            this.pnlEnemy = new System.Windows.Forms.Panel();
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.prgPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.prgEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.lblSom = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            this.pnlPlayer.SuspendLayout();
            this.pnlEnemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPlayer.InitialImage = null;
            this.pbxPlayer.Location = new System.Drawing.Point(3, 3);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(61, 122);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 0;
            this.pbxPlayer.TabStop = false;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer.Controls.Add(this.pbxPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(481, 262);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(64, 128);
            this.pnlPlayer.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(39, 56);
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
            // pnlEnemy
            // 
            this.pnlEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnemy.Controls.Add(this.pbxEnemy);
            this.pnlEnemy.Location = new System.Drawing.Point(593, 265);
            this.pnlEnemy.Name = "pnlEnemy";
            this.pnlEnemy.Size = new System.Drawing.Size(64, 128);
            this.pnlEnemy.TabIndex = 2;
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxEnemy.InitialImage = null;
            this.pbxEnemy.Location = new System.Drawing.Point(3, 6);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(61, 122);
            this.pbxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy.TabIndex = 1;
            this.pbxEnemy.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // prgPlayerHealth
            // 
            this.prgPlayerHealth.Location = new System.Drawing.Point(468, 221);
            this.prgPlayerHealth.Name = "prgPlayerHealth";
            this.prgPlayerHealth.Size = new System.Drawing.Size(100, 23);
            this.prgPlayerHealth.TabIndex = 4;
            // 
            // prgEnemyHealth
            // 
            this.prgEnemyHealth.Location = new System.Drawing.Point(593, 221);
            this.prgEnemyHealth.Name = "prgEnemyHealth";
            this.prgEnemyHealth.Size = new System.Drawing.Size(100, 23);
            this.prgEnemyHealth.TabIndex = 5;
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Font = new System.Drawing.Font("NSimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSom.Location = new System.Drawing.Point(161, 127);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(245, 48);
            this.lblSom.TabIndex = 6;
            this.lblSom.Text = "1 x 1 = ?";
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(430, 131);
            this.tbxInput.MaxLength = 2;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(77, 44);
            this.tbxInput.TabIndex = 7;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(513, 147);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // turnTimer
            // 
            this.turnTimer.Interval = 1000;
            this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("NSimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(161, 31);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(295, 48);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Player turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::RekenGame.Properties.Resources.d20sxct_bb202977_b992_49a9_82d1_c0b6b9c5c793;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.prgEnemyHealth);
            this.Controls.Add(this.prgPlayerHealth);
            this.Controls.Add(this.pnlEnemy);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pnlPlayer);
            this.Name = "Form1";
            this.Text = "23";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlEnemy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer tmrAnimationPlayer;
        private System.Windows.Forms.Panel pnlEnemy;
        private System.Windows.Forms.PictureBox pbxEnemy;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ProgressBar prgEnemyHealth;
        private System.Windows.Forms.ProgressBar prgPlayerHealth;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.Label lblMessage;
    }
}

