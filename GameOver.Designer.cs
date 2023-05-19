namespace DiceRoll
{
    partial class GameOver
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.picboxIkona = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.sEllipseForm = new Sipaa.Framework.SEllipse();
            this.btnDialogClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIkona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Location = new System.Drawing.Point(101, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 89);
            this.panel1.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(220, 89);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Description";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picboxIkona
            // 
            this.picboxIkona.BackColor = System.Drawing.Color.Transparent;
            this.picboxIkona.BackgroundImage = global::DiceRoll.Properties.Resources.dead;
            this.picboxIkona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxIkona.Location = new System.Drawing.Point(6, 22);
            this.picboxIkona.Name = "picboxIkona";
            this.picboxIkona.Size = new System.Drawing.Size(89, 89);
            this.picboxIkona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxIkona.TabIndex = 2;
            this.picboxIkona.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(246, 114);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // sEllipseForm
            // 
            this.sEllipseForm.CornerRadius = 10;
            this.sEllipseForm.TargetControl = this;
            // 
            // btnDialogClose
            // 
            this.btnDialogClose.BackColor = System.Drawing.Color.Transparent;
            this.btnDialogClose.BackgroundImage = global::DiceRoll.Properties.Resources.close;
            this.btnDialogClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDialogClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDialogClose.FlatAppearance.BorderSize = 0;
            this.btnDialogClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDialogClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDialogClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDialogClose.Location = new System.Drawing.Point(310, 2);
            this.btnDialogClose.Name = "btnDialogClose";
            this.btnDialogClose.Size = new System.Drawing.Size(20, 20);
            this.btnDialogClose.TabIndex = 4;
            this.btnDialogClose.UseVisualStyleBackColor = false;
            this.btnDialogClose.Click += new System.EventHandler(this.btnDialogClose_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(333, 144);
            this.ControlBox = false;
            this.Controls.Add(this.btnDialogClose);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.picboxIkona);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxIkona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxIkona;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnPlayAgain;
        private Sipaa.Framework.SEllipse sEllipseForm;
        private System.Windows.Forms.Button btnDialogClose;
    }
}