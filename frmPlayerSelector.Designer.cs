
namespace PAndPPointsCalculator
{
    partial class frmPlayerSelector
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
            this.tabPlayerSetup = new System.Windows.Forms.TabControl();
            this.tabPlayerCount = new System.Windows.Forms.TabPage();
            this.tabPlayerAvatar = new System.Windows.Forms.TabPage();
            this.hsbPlayers = new System.Windows.Forms.HScrollBar();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabPlayerSetup.SuspendLayout();
            this.tabPlayerCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPlayerSetup
            // 
            this.tabPlayerSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPlayerSetup.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPlayerSetup.Controls.Add(this.tabPlayerCount);
            this.tabPlayerSetup.Controls.Add(this.tabPlayerAvatar);
            this.tabPlayerSetup.Location = new System.Drawing.Point(4, 0);
            this.tabPlayerSetup.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPlayerSetup.Name = "tabPlayerSetup";
            this.tabPlayerSetup.SelectedIndex = 0;
            this.tabPlayerSetup.Size = new System.Drawing.Size(992, 400);
            this.tabPlayerSetup.TabIndex = 0;
            // 
            // tabPlayerCount
            // 
            this.tabPlayerCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPlayerCount.Controls.Add(this.btnConfirm);
            this.tabPlayerCount.Controls.Add(this.label1);
            this.tabPlayerCount.Controls.Add(this.lblPlayers);
            this.tabPlayerCount.Controls.Add(this.hsbPlayers);
            this.tabPlayerCount.Location = new System.Drawing.Point(4, 34);
            this.tabPlayerCount.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPlayerCount.Name = "tabPlayerCount";
            this.tabPlayerCount.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPlayerCount.Size = new System.Drawing.Size(984, 362);
            this.tabPlayerCount.TabIndex = 0;
            this.tabPlayerCount.Text = "PlayerCount";
            // 
            // tabPlayerAvatar
            // 
            this.tabPlayerAvatar.BackColor = System.Drawing.Color.GreenYellow;
            this.tabPlayerAvatar.Location = new System.Drawing.Point(4, 34);
            this.tabPlayerAvatar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPlayerAvatar.Name = "tabPlayerAvatar";
            this.tabPlayerAvatar.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPlayerAvatar.Size = new System.Drawing.Size(984, 362);
            this.tabPlayerAvatar.TabIndex = 1;
            this.tabPlayerAvatar.Text = "Avatar Selction ";
            // 
            // hsbPlayers
            // 
            this.hsbPlayers.LargeChange = 1;
            this.hsbPlayers.Location = new System.Drawing.Point(1, 232);
            this.hsbPlayers.Maximum = 5;
            this.hsbPlayers.Minimum = 2;
            this.hsbPlayers.Name = "hsbPlayers";
            this.hsbPlayers.Size = new System.Drawing.Size(983, 130);
            this.hsbPlayers.TabIndex = 0;
            this.hsbPlayers.Value = 2;
            this.hsbPlayers.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPlayers.Location = new System.Drawing.Point(108, 52);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(620, 96);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "Players: 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(22, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please note that this count excludes the Princess Player";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirm.Location = new System.Drawing.Point(816, 142);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(158, 74);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmPlayerSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 401);
            this.Controls.Add(this.tabPlayerSetup);
            this.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmPlayerSelector";
            this.Text = "Player Count Selector";
            this.Load += new System.EventHandler(this.frmPlayerSelector_Load);
            this.tabPlayerSetup.ResumeLayout(false);
            this.tabPlayerCount.ResumeLayout(false);
            this.tabPlayerCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPlayerSetup;
        private System.Windows.Forms.TabPage tabPlayerCount;
        private System.Windows.Forms.TabPage tabPlayerAvatar;
        private System.Windows.Forms.HScrollBar hsbPlayers;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
    }
}