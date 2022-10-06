namespace WinDeskTopFindNumberPuzzle
{
    partial class UserPredictive
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.olblAdim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.olblKonusmam = new System.Windows.Forms.Label();
            this.olistboxCevaplar = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ochk_A_Modeli = new System.Windows.Forms.CheckBox();
            this.oradio_Kurnazlik = new System.Windows.Forms.RadioButton();
            this.oradio_RastGele = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.tmrCevaplayici = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benim Adım :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // olblAdim
            // 
            this.olblAdim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.olblAdim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olblAdim.Location = new System.Drawing.Point(92, 0);
            this.olblAdim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olblAdim.Name = "olblAdim";
            this.olblAdim.Size = new System.Drawing.Size(480, 31);
            this.olblAdim.TabIndex = 0;
            this.olblAdim.Text = "Benim Adım :";
            this.olblAdim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.olblAdim.DoubleClick += new System.EventHandler(this.olblAdim_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.olblAdim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 31);
            this.panel1.TabIndex = 1;
            // 
            // olblKonusmam
            // 
            this.olblKonusmam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.olblKonusmam.Dock = System.Windows.Forms.DockStyle.Top;
            this.olblKonusmam.Location = new System.Drawing.Point(0, 31);
            this.olblKonusmam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olblKonusmam.Name = "olblKonusmam";
            this.olblKonusmam.Size = new System.Drawing.Size(572, 31);
            this.olblKonusmam.TabIndex = 2;
            this.olblKonusmam.Text = "Benim Adım :";
            this.olblKonusmam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.olblKonusmam.DoubleClick += new System.EventHandler(this.olblKonusmam_DoubleClick);
            // 
            // olistboxCevaplar
            // 
            this.olistboxCevaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.olistboxCevaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olistboxCevaplar.FormattingEnabled = true;
            this.olistboxCevaplar.ItemHeight = 16;
            this.olistboxCevaplar.Location = new System.Drawing.Point(0, 108);
            this.olistboxCevaplar.Name = "olistboxCevaplar";
            this.olistboxCevaplar.Size = new System.Drawing.Size(572, 208);
            this.olistboxCevaplar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnStart);
            this.panel2.Controls.Add(this.ochk_A_Modeli);
            this.panel2.Controls.Add(this.oradio_Kurnazlik);
            this.panel2.Controls.Add(this.oradio_RastGele);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 46);
            this.panel2.TabIndex = 4;
            // 
            // ochk_A_Modeli
            // 
            this.ochk_A_Modeli.AutoSize = true;
            this.ochk_A_Modeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ochk_A_Modeli.Location = new System.Drawing.Point(297, 0);
            this.ochk_A_Modeli.Name = "ochk_A_Modeli";
            this.ochk_A_Modeli.Size = new System.Drawing.Size(275, 46);
            this.ochk_A_Modeli.TabIndex = 3;
            this.ochk_A_Modeli.Text = "Kurnazlıkta A Modeli Kullan";
            this.ochk_A_Modeli.UseVisualStyleBackColor = true;
            // 
            // oradio_Kurnazlik
            // 
            this.oradio_Kurnazlik.AutoSize = true;
            this.oradio_Kurnazlik.Dock = System.Windows.Forms.DockStyle.Left;
            this.oradio_Kurnazlik.Location = new System.Drawing.Point(209, 0);
            this.oradio_Kurnazlik.Margin = new System.Windows.Forms.Padding(5);
            this.oradio_Kurnazlik.Name = "oradio_Kurnazlik";
            this.oradio_Kurnazlik.Padding = new System.Windows.Forms.Padding(5);
            this.oradio_Kurnazlik.Size = new System.Drawing.Size(88, 46);
            this.oradio_Kurnazlik.TabIndex = 1;
            this.oradio_Kurnazlik.TabStop = true;
            this.oradio_Kurnazlik.Text = "Kurnazlik";
            this.oradio_Kurnazlik.UseVisualStyleBackColor = true;
            // 
            // oradio_RastGele
            // 
            this.oradio_RastGele.AutoSize = true;
            this.oradio_RastGele.Checked = true;
            this.oradio_RastGele.Dock = System.Windows.Forms.DockStyle.Left;
            this.oradio_RastGele.Location = new System.Drawing.Point(117, 0);
            this.oradio_RastGele.Margin = new System.Windows.Forms.Padding(5);
            this.oradio_RastGele.Name = "oradio_RastGele";
            this.oradio_RastGele.Padding = new System.Windows.Forms.Padding(5);
            this.oradio_RastGele.Size = new System.Drawing.Size(92, 46);
            this.oradio_RastGele.TabIndex = 0;
            this.oradio_RastGele.TabStop = true;
            this.oradio_RastGele.Text = "RastGele";
            this.oradio_RastGele.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çözüm Şekli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnStart
            // 
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnStart.Location = new System.Drawing.Point(485, 0);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(87, 46);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Başla";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrCevaplayici
            // 
            this.tmrCevaplayici.Tick += new System.EventHandler(this.tmrCevaplayici_Tick);
            // 
            // UserPredictive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.olistboxCevaplar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.olblKonusmam);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserPredictive";
            this.Size = new System.Drawing.Size(572, 316);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label olblAdim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label olblKonusmam;
        private System.Windows.Forms.ListBox olistboxCevaplar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton oradio_Kurnazlik;
        private System.Windows.Forms.RadioButton oradio_RastGele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ochk_A_Modeli;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer tmrCevaplayici;
    }
}
