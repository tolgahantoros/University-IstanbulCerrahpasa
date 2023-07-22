namespace WindowsFormsApp1
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiraİşlemlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralanabilecekAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.araçİşlemleriToolStripMenuItem,
            this.kiraİşlemlemleriToolStripMenuItem,
            this.kiralanabilecekAraçlarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(929, 56);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriİşlemleriToolStripMenuItem.Image")));
            this.müşteriİşlemleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(164, 52);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçKayıtToolStripMenuItem,
            this.araçListelemeToolStripMenuItem});
            this.araçİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçİşlemleriToolStripMenuItem.Image")));
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(146, 52);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            this.araçİşlemleriToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // araçKayıtToolStripMenuItem
            // 
            this.araçKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçKayıtToolStripMenuItem.Image")));
            this.araçKayıtToolStripMenuItem.Name = "araçKayıtToolStripMenuItem";
            this.araçKayıtToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.araçKayıtToolStripMenuItem.Text = "Araç Kayıt";
            this.araçKayıtToolStripMenuItem.Click += new System.EventHandler(this.araçKayıtToolStripMenuItem_Click);
            // 
            // araçListelemeToolStripMenuItem
            // 
            this.araçListelemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçListelemeToolStripMenuItem.Image")));
            this.araçListelemeToolStripMenuItem.Name = "araçListelemeToolStripMenuItem";
            this.araçListelemeToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.araçListelemeToolStripMenuItem.Text = "Araç Listeleme";
            this.araçListelemeToolStripMenuItem.Click += new System.EventHandler(this.araçListelemeToolStripMenuItem_Click);
            // 
            // kiraİşlemlemleriToolStripMenuItem
            // 
            this.kiraİşlemlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kiraİşlemlemleriToolStripMenuItem.Image")));
            this.kiraİşlemlemleriToolStripMenuItem.Name = "kiraİşlemlemleriToolStripMenuItem";
            this.kiraİşlemlemleriToolStripMenuItem.Size = new System.Drawing.Size(164, 52);
            this.kiraİşlemlemleriToolStripMenuItem.Text = "Kira İşlemlemleri";
            this.kiraİşlemlemleriToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kiraİşlemlemleriToolStripMenuItem.Click += new System.EventHandler(this.kiraİşlemlemleriToolStripMenuItem_Click);
            // 
            // kiralanabilecekAraçlarToolStripMenuItem
            // 
            this.kiralanabilecekAraçlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kiralanabilecekAraçlarToolStripMenuItem.Image")));
            this.kiralanabilecekAraçlarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kiralanabilecekAraçlarToolStripMenuItem.Name = "kiralanabilecekAraçlarToolStripMenuItem";
            this.kiralanabilecekAraçlarToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.kiralanabilecekAraçlarToolStripMenuItem.Text = "Kiralanabilecek Araçlar";
            this.kiralanabilecekAraçlarToolStripMenuItem.Click += new System.EventHandler(this.kiralanabilecekAraçlarToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(929, 559);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.ShowIcon = false;
            this.Text = "Rent a Car";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiraİşlemlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralanabilecekAraçlarToolStripMenuItem;
    }
}



