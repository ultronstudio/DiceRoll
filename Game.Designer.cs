namespace DiceRoll
{
    partial class Game
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sEllipseForm = new Sipaa.Framework.SEllipse();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHazej = new System.Windows.Forms.Button();
            this.sEllipseBtnHazej = new Sipaa.Framework.SEllipse();
            this.timerHod = new System.Windows.Forms.Timer(this.components);
            this.picboxKostka = new System.Windows.Forms.PictureBox();
            this.btnAppClose = new System.Windows.Forms.Button();
            this.lblPenize = new System.Windows.Forms.Label();
            this.btnVic = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnStejne = new System.Windows.Forms.Button();
            this.lblPredchozi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKostka)).BeginInit();
            this.SuspendLayout();
            // 
            // sEllipseForm
            // 
            this.sEllipseForm.CornerRadius = 10;
            this.sEllipseForm.TargetControl = this;
            // 
            // btnHazej
            // 
            this.btnHazej.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHazej.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHazej.FlatAppearance.BorderSize = 0;
            this.btnHazej.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnHazej.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnHazej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHazej.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHazej.ForeColor = System.Drawing.Color.White;
            this.btnHazej.Location = new System.Drawing.Point(41, 137);
            this.btnHazej.Name = "btnHazej";
            this.btnHazej.Size = new System.Drawing.Size(75, 30);
            this.btnHazej.TabIndex = 2;
            this.btnHazej.Text = "HÁZEJ";
            this.btnHazej.UseVisualStyleBackColor = false;
            this.btnHazej.Click += new System.EventHandler(this.btnHazej_Click);
            // 
            // sEllipseBtnHazej
            // 
            this.sEllipseBtnHazej.CornerRadius = 10;
            this.sEllipseBtnHazej.TargetControl = this.btnHazej;
            // 
            // timerHod
            // 
            this.timerHod.Interval = 1;
            this.timerHod.Tick += new System.EventHandler(this.timerHod_Tick);
            // 
            // picboxKostka
            // 
            this.picboxKostka.BackColor = System.Drawing.Color.Transparent;
            this.picboxKostka.BackgroundImage = global::DiceRoll.Properties.Resources._6;
            this.picboxKostka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxKostka.Location = new System.Drawing.Point(25, 31);
            this.picboxKostka.Name = "picboxKostka";
            this.picboxKostka.Size = new System.Drawing.Size(100, 100);
            this.picboxKostka.TabIndex = 1;
            this.picboxKostka.TabStop = false;
            // 
            // btnAppClose
            // 
            this.btnAppClose.BackColor = System.Drawing.Color.Transparent;
            this.btnAppClose.BackgroundImage = global::DiceRoll.Properties.Resources.close;
            this.btnAppClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAppClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppClose.FlatAppearance.BorderSize = 0;
            this.btnAppClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAppClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAppClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppClose.Location = new System.Drawing.Point(777, 2);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Size = new System.Drawing.Size(20, 20);
            this.btnAppClose.TabIndex = 0;
            this.btnAppClose.UseVisualStyleBackColor = false;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
            this.btnAppClose.MouseHover += new System.EventHandler(this.btnAppClose_MouseHover);
            // 
            // lblPenize
            // 
            this.lblPenize.AutoSize = true;
            this.lblPenize.BackColor = System.Drawing.Color.Transparent;
            this.lblPenize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPenize.Location = new System.Drawing.Point(40, 185);
            this.lblPenize.Name = "lblPenize";
            this.lblPenize.Size = new System.Drawing.Size(85, 25);
            this.lblPenize.TabIndex = 3;
            this.lblPenize.Text = "100 Kč";
            // 
            // btnVic
            // 
            this.btnVic.BackColor = System.Drawing.Color.LawnGreen;
            this.btnVic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVic.FlatAppearance.BorderSize = 0;
            this.btnVic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnVic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnVic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVic.ForeColor = System.Drawing.Color.White;
            this.btnVic.Location = new System.Drawing.Point(146, 31);
            this.btnVic.Name = "btnVic";
            this.btnVic.Size = new System.Drawing.Size(75, 30);
            this.btnVic.TabIndex = 4;
            this.btnVic.Text = "VÍC";
            this.btnVic.UseVisualStyleBackColor = false;
            this.btnVic.Click += new System.EventHandler(this.btnVic_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Red;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(146, 101);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 30);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "MÍŇ";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnStejne
            // 
            this.btnStejne.BackColor = System.Drawing.Color.Gray;
            this.btnStejne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStejne.FlatAppearance.BorderSize = 0;
            this.btnStejne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnStejne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnStejne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStejne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStejne.ForeColor = System.Drawing.Color.White;
            this.btnStejne.Location = new System.Drawing.Point(146, 66);
            this.btnStejne.Name = "btnStejne";
            this.btnStejne.Size = new System.Drawing.Size(75, 30);
            this.btnStejne.TabIndex = 6;
            this.btnStejne.Text = "STEJNĚ";
            this.btnStejne.UseVisualStyleBackColor = false;
            this.btnStejne.Click += new System.EventHandler(this.btnStejne_Click);
            // 
            // lblPredchozi
            // 
            this.lblPredchozi.AutoSize = true;
            this.lblPredchozi.Location = new System.Drawing.Point(227, 31);
            this.lblPredchozi.Name = "lblPredchozi";
            this.lblPredchozi.Size = new System.Drawing.Size(149, 13);
            this.lblPredchozi.TabIndex = 7;
            this.lblPredchozi.Text = "Předchozí hozená hodnota: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPredchozi);
            this.Controls.Add(this.btnStejne);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnVic);
            this.Controls.Add(this.lblPenize);
            this.Controls.Add(this.btnHazej);
            this.Controls.Add(this.picboxKostka);
            this.Controls.Add(this.btnAppClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roll";
            ((System.ComponentModel.ISupportInitialize)(this.picboxKostka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipseForm;
        private System.Windows.Forms.Button btnAppClose;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.PictureBox picboxKostka;
        private System.Windows.Forms.Button btnHazej;
        private Sipaa.Framework.SEllipse sEllipseBtnHazej;
        private System.Windows.Forms.Timer timerHod;
        private System.Windows.Forms.Label lblPenize;
        private System.Windows.Forms.Button btnVic;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnStejne;
        private System.Windows.Forms.Label lblPredchozi;
    }
}

