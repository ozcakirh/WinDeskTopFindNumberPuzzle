namespace WinDeskTopFindNumberPuzzle
{
    partial class FrmHCNumberPuzzleMain
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
            this.YarismaSunucusu = new WinDeskTopFindNumberPuzzle.UserQuestioner();
            this.Yarismaci_1 = new WinDeskTopFindNumberPuzzle.UserPredictive();
            this.SuspendLayout();
            // 
            // YarismaSunucusu
            // 
            this.YarismaSunucusu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YarismaSunucusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YarismaSunucusu.Location = new System.Drawing.Point(338, 30);
            this.YarismaSunucusu.Margin = new System.Windows.Forms.Padding(4);
            this.YarismaSunucusu.Name = "YarismaSunucusu";
            this.YarismaSunucusu.oBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YarismaSunucusu.Size = new System.Drawing.Size(462, 185);
            this.YarismaSunucusu.TabIndex = 0;
            // 
            // Yarismaci_1
            // 
            this.Yarismaci_1.BenimAdim = "Hüseyin";
            this.Yarismaci_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yarismaci_1.Location = new System.Drawing.Point(13, 251);
            this.Yarismaci_1.Margin = new System.Windows.Forms.Padding(4);
            this.Yarismaci_1.Name = "Yarismaci_1";
            this.Yarismaci_1.Size = new System.Drawing.Size(574, 318);
            this.Yarismaci_1.TabIndex = 1;
            // 
            // FrmHCNumberPuzzleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 582);
            this.Controls.Add(this.Yarismaci_1);
            this.Controls.Add(this.YarismaSunucusu);
            this.Name = "FrmHCNumberPuzzleMain";
            this.Text = "Sayı Buldurma Oyunu";
            this.ResumeLayout(false);

        }

        #endregion

        private UserQuestioner YarismaSunucusu;
        private UserPredictive Yarismaci_1;
    }
}