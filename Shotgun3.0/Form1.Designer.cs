namespace Shotgun3._0
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
            label1 = new Label();
            btnLoad = new Button();
            btnShoot = new Button();
            btnBlock = new Button();
            btnShotgun = new Button();
            label2 = new Label();
            lblComputerAction = new Label();
            lblPlayerAction = new Label();
            lblComputerShots = new Label();
            lblPlayerShots = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Computer";
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ImageAlign = ContentAlignment.TopCenter;
            btnLoad.Location = new Point(63, 338);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(129, 45);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnShoot
            // 
            btnShoot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnShoot.Location = new Point(198, 338);
            btnShoot.Name = "btnShoot";
            btnShoot.Size = new Size(129, 45);
            btnShoot.TabIndex = 2;
            btnShoot.Text = "Shoot";
            btnShoot.UseVisualStyleBackColor = true;
            btnShoot.Click += btnShoot_Click;
            // 
            // btnBlock
            // 
            btnBlock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBlock.Location = new Point(333, 338);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(129, 45);
            btnBlock.TabIndex = 3;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // btnShotgun
            // 
            btnShotgun.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnShotgun.Location = new Point(190, 389);
            btnShotgun.Name = "btnShotgun";
            btnShotgun.Size = new Size(146, 52);
            btnShotgun.TabIndex = 4;
            btnShotgun.Text = "Shotgun";
            btnShotgun.UseVisualStyleBackColor = true;
            btnShotgun.Click += btnShotgun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 223);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Player";
            // 
            // lblComputerAction
            // 
            lblComputerAction.AutoEllipsis = true;
            lblComputerAction.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblComputerAction.Location = new Point(98, 88);
            lblComputerAction.Name = "lblComputerAction";
            lblComputerAction.Size = new Size(336, 68);
            lblComputerAction.TabIndex = 6;
            lblComputerAction.Text = "Action";
            lblComputerAction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerAction
            // 
            lblPlayerAction.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerAction.Location = new Point(98, 250);
            lblPlayerAction.Name = "lblPlayerAction";
            lblPlayerAction.Size = new Size(336, 73);
            lblPlayerAction.TabIndex = 7;
            lblPlayerAction.Text = "Action";
            lblPlayerAction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblComputerShots
            // 
            lblComputerShots.AutoSize = true;
            lblComputerShots.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblComputerShots.ForeColor = Color.Red;
            lblComputerShots.Location = new Point(457, 91);
            lblComputerShots.Name = "lblComputerShots";
            lblComputerShots.Size = new Size(56, 65);
            lblComputerShots.TabIndex = 8;
            lblComputerShots.Text = "0";
            // 
            // lblPlayerShots
            // 
            lblPlayerShots.AutoSize = true;
            lblPlayerShots.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerShots.ForeColor = Color.Red;
            lblPlayerShots.Location = new Point(457, 254);
            lblPlayerShots.Name = "lblPlayerShots";
            lblPlayerShots.Size = new Size(56, 65);
            lblPlayerShots.TabIndex = 9;
            lblPlayerShots.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(lblPlayerShots);
            Controls.Add(lblComputerShots);
            Controls.Add(lblPlayerAction);
            Controls.Add(lblComputerAction);
            Controls.Add(label2);
            Controls.Add(btnShotgun);
            Controls.Add(btnBlock);
            Controls.Add(btnShoot);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoad;
        private Button btnShoot;
        private Button btnBlock;
        private Button btnShotgun;
        private Label label2;
        private Label lblComputerAction;
        private Label lblPlayerAction;
        private Label lblComputerShots;
        private Label lblPlayerShots;
    }
}