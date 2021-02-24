namespace _25폼분할_MDI_다중폼_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.윈도우ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.윈도우ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 윈도우ToolStripMenuItem
            // 
            this.윈도우ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼1ToolStripMenuItem,
            this.폼2ToolStripMenuItem});
            this.윈도우ToolStripMenuItem.Name = "윈도우ToolStripMenuItem";
            this.윈도우ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.윈도우ToolStripMenuItem.Text = "윈도우";
            // 
            // 폼1ToolStripMenuItem
            // 
            this.폼1ToolStripMenuItem.Name = "폼1ToolStripMenuItem";
            this.폼1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.폼1ToolStripMenuItem.Text = "폼1";
            this.폼1ToolStripMenuItem.Click += new System.EventHandler(this.폼1ToolStripMenuItem_Click);
            // 
            // 폼2ToolStripMenuItem
            // 
            this.폼2ToolStripMenuItem.Name = "폼2ToolStripMenuItem";
            this.폼2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.폼2ToolStripMenuItem.Text = "폼2";
            this.폼2ToolStripMenuItem.Click += new System.EventHandler(this.폼2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 342);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼2ToolStripMenuItem;
    }
}

