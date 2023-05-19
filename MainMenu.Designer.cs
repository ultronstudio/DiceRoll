namespace DiceRoll
{
    partial class MainMenu
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
            this.sEllipseForm = new Sipaa.Framework.SEllipse();
            this.btnHrat = new System.Windows.Forms.Button();
            this.btnDialogClose = new System.Windows.Forms.Button();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sEllipseForm
            // 
            this.sEllipseForm.CornerRadius = 10;
            this.sEllipseForm.TargetControl = this;
            // 
            // btnHrat
            // 
            this.btnHrat.BackColor = System.Drawing.Color.Gray;
            this.btnHrat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHrat.FlatAppearance.BorderSize = 0;
            this.btnHrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnHrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnHrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHrat.ForeColor = System.Drawing.Color.White;
            this.btnHrat.Location = new System.Drawing.Point(165, 200);
            this.btnHrat.Name = "btnHrat";
            this.btnHrat.Size = new System.Drawing.Size(75, 35);
            this.btnHrat.TabIndex = 6;
            this.btnHrat.Text = "Hrát";
            this.btnHrat.UseVisualStyleBackColor = false;
            this.btnHrat.Click += new System.EventHandler(this.btnHrat_Click);
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
            this.btnDialogClose.Location = new System.Drawing.Point(376, 2);
            this.btnDialogClose.Name = "btnDialogClose";
            this.btnDialogClose.Size = new System.Drawing.Size(20, 20);
            this.btnDialogClose.TabIndex = 5;
            this.btnDialogClose.UseVisualStyleBackColor = false;
            this.btnDialogClose.Click += new System.EventHandler(this.btnDialogClose_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackgroundImage = global::DiceRoll.Properties.Resources.game_logo;
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxLogo.Location = new System.Drawing.Point(110, 80);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(187, 91);
            this.picboxLogo.TabIndex = 7;
            this.picboxLogo.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.btnHrat);
            this.Controls.Add(this.btnDialogClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipseForm;
        private System.Windows.Forms.Button btnDialogClose;
        private System.Windows.Forms.Button btnHrat;
        private System.Windows.Forms.PictureBox picboxLogo;
    }
}