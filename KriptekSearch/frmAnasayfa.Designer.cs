
namespace KriptekSearch
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDosyaYol = new System.Windows.Forms.TextBox();
            this.txtAranacakKelime = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnSimdiAra = new System.Windows.Forms.Button();
            this.listBoxSonuc = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.61555F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.29743F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.08702F));
            this.tableLayoutPanelMain.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.btnDosyaSec, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.btnSimdiAra, 2, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(808, 538);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 26);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDosyaYol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(104, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 26);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 26);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAranacakKelime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(104, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 26);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 26);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.panel6, 3);
            this.panel6.Controls.Add(this.listBoxSonuc);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(802, 436);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yolu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aranacak Kelime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dosya Uzantıları (virgül ile ayırın)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDosyaYol
            // 
            this.txtDosyaYol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDosyaYol.Enabled = false;
            this.txtDosyaYol.Location = new System.Drawing.Point(4, 4);
            this.txtDosyaYol.Name = "txtDosyaYol";
            this.txtDosyaYol.Size = new System.Drawing.Size(382, 20);
            this.txtDosyaYol.TabIndex = 0;
            // 
            // txtAranacakKelime
            // 
            this.txtAranacakKelime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAranacakKelime.Location = new System.Drawing.Point(4, 2);
            this.txtAranacakKelime.Name = "txtAranacakKelime";
            this.txtAranacakKelime.Size = new System.Drawing.Size(382, 20);
            this.txtAranacakKelime.TabIndex = 2;
            // 
            // panel7
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.txtFiltre);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(104, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(701, 26);
            this.panel7.TabIndex = 2;
            // 
            // txtFiltre
            // 
            this.txtFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltre.Location = new System.Drawing.Point(4, 4);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(688, 20);
            this.txtFiltre.TabIndex = 4;
            this.txtFiltre.Text = "*";
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDosyaSec.Image = global::KriptekSearch.Properties.Resources.icons8_cursor_24px;
            this.btnDosyaSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSec.Location = new System.Drawing.Point(510, 3);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(295, 26);
            this.btnDosyaSec.TabIndex = 1;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // btnSimdiAra
            // 
            this.btnSimdiAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimdiAra.Image = global::KriptekSearch.Properties.Resources.icons8_search_24px;
            this.btnSimdiAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimdiAra.Location = new System.Drawing.Point(510, 35);
            this.btnSimdiAra.Name = "btnSimdiAra";
            this.btnSimdiAra.Size = new System.Drawing.Size(295, 26);
            this.btnSimdiAra.TabIndex = 3;
            this.btnSimdiAra.Text = "Şimdi Ara";
            this.btnSimdiAra.UseVisualStyleBackColor = true;
            this.btnSimdiAra.Click += new System.EventHandler(this.btnSimdiAra_Click);
            // 
            // listBoxSonuc
            // 
            this.listBoxSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSonuc.FormattingEnabled = true;
            this.listBoxSonuc.Location = new System.Drawing.Point(0, 0);
            this.listBoxSonuc.Name = "listBoxSonuc";
            this.listBoxSonuc.Size = new System.Drawing.Size(802, 436);
            this.listBoxSonuc.TabIndex = 5;
            this.listBoxSonuc.SelectedIndexChanged += new System.EventHandler(this.listBoxSonuc_SelectedIndexChanged);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 538);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KriptekSearch & Dosya Arama - v1.0.1";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosyaYol;
        private System.Windows.Forms.TextBox txtAranacakKelime;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnSimdiAra;
        private System.Windows.Forms.ListBox listBoxSonuc;
    }
}

