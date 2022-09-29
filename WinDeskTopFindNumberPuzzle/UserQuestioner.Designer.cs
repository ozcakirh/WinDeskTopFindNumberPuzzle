namespace WinDeskTopFindNumberPuzzle
{
    partial class UserQuestioner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.otxtIstenenSayi = new System.Windows.Forms.TextBox();
            this.BtnSayiUret = new System.Windows.Forms.Button();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.olblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Edilecek Sayı";
            // 
            // otxtIstenenSayi
            // 
            this.otxtIstenenSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otxtIstenenSayi.Location = new System.Drawing.Point(203, 20);
            this.otxtIstenenSayi.Margin = new System.Windows.Forms.Padding(4);
            this.otxtIstenenSayi.Name = "otxtIstenenSayi";
            this.otxtIstenenSayi.Size = new System.Drawing.Size(111, 26);
            this.otxtIstenenSayi.TabIndex = 1;
            // 
            // BtnSayiUret
            // 
            this.BtnSayiUret.Location = new System.Drawing.Point(331, 9);
            this.BtnSayiUret.Name = "BtnSayiUret";
            this.BtnSayiUret.Size = new System.Drawing.Size(119, 51);
            this.BtnSayiUret.TabIndex = 2;
            this.BtnSayiUret.Text = "Rastgele Sayı Üret";
            this.BtnSayiUret.UseVisualStyleBackColor = true;
            this.BtnSayiUret.Click += new System.EventHandler(this.BtnSayiUret_Click);
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Location = new System.Drawing.Point(31, 70);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(419, 51);
            this.BtnStartGame.TabIndex = 3;
            this.BtnStartGame.Text = "Oyunu Başlat";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // olblMsg
            // 
            this.olblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olblMsg.Location = new System.Drawing.Point(0, 141);
            this.olblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olblMsg.Name = "olblMsg";
            this.olblMsg.Size = new System.Drawing.Size(462, 44);
            this.olblMsg.TabIndex = 4;
            this.olblMsg.Text = "Tahmin Edilecek Sayı";
            this.olblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserQuestioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.olblMsg);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.BtnSayiUret);
            this.Controls.Add(this.otxtIstenenSayi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserQuestioner";
            this.Size = new System.Drawing.Size(462, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox otxtIstenenSayi;
        private System.Windows.Forms.Button BtnSayiUret;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Label olblMsg;
    }
}
