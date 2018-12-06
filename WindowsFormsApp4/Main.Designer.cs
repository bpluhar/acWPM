namespace WindowsFormsApp4
{
    partial class Main
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
            this.btnMaxAmmo = new System.Windows.Forms.Button();
            this.btnReadMemory = new System.Windows.Forms.Button();
            this.lblProcessId = new System.Windows.Forms.Label();
            this.btnMaxHealth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaxAmmo
            // 
            this.btnMaxAmmo.Location = new System.Drawing.Point(134, 41);
            this.btnMaxAmmo.Name = "btnMaxAmmo";
            this.btnMaxAmmo.Size = new System.Drawing.Size(120, 23);
            this.btnMaxAmmo.TabIndex = 0;
            this.btnMaxAmmo.Text = "1000 Ammo";
            this.btnMaxAmmo.UseVisualStyleBackColor = true;
            this.btnMaxAmmo.Click += new System.EventHandler(this.btnMaxAmmo_Click);
            // 
            // btnReadMemory
            // 
            this.btnReadMemory.Location = new System.Drawing.Point(12, 12);
            this.btnReadMemory.Name = "btnReadMemory";
            this.btnReadMemory.Size = new System.Drawing.Size(242, 23);
            this.btnReadMemory.TabIndex = 1;
            this.btnReadMemory.Text = "Attach";
            this.btnReadMemory.UseVisualStyleBackColor = true;
            this.btnReadMemory.Click += new System.EventHandler(this.btnReadMemory_Click);
            // 
            // lblProcessId
            // 
            this.lblProcessId.AutoSize = true;
            this.lblProcessId.Location = new System.Drawing.Point(13, 101);
            this.lblProcessId.Name = "lblProcessId";
            this.lblProcessId.Size = new System.Drawing.Size(0, 13);
            this.lblProcessId.TabIndex = 2;
            // 
            // btnMaxHealth
            // 
            this.btnMaxHealth.Location = new System.Drawing.Point(12, 41);
            this.btnMaxHealth.Name = "btnMaxHealth";
            this.btnMaxHealth.Size = new System.Drawing.Size(116, 23);
            this.btnMaxHealth.TabIndex = 3;
            this.btnMaxHealth.Text = "1000 Health";
            this.btnMaxHealth.UseVisualStyleBackColor = true;
            this.btnMaxHealth.Click += new System.EventHandler(this.btnMaxHealth_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 126);
            this.Controls.Add(this.btnMaxHealth);
            this.Controls.Add(this.lblProcessId);
            this.Controls.Add(this.btnReadMemory);
            this.Controls.Add(this.btnMaxAmmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssaultCube Trainer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaxAmmo;
        private System.Windows.Forms.Button btnReadMemory;
        private System.Windows.Forms.Label lblProcessId;
        private System.Windows.Forms.Button btnMaxHealth;
    }
}

