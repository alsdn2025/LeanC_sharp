namespace _21Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.항목보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.머지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.왜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.은안보여ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ㄷToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이상해ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.항목보기ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "보기";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른이름으로저장";
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.닫기ToolStripMenuItem.Text = "닫기";
            // 
            // 항목보기ToolStripMenuItem
            // 
            this.항목보기ToolStripMenuItem.Name = "항목보기ToolStripMenuItem";
            this.항목보기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.항목보기ToolStripMenuItem.Text = "항목보기";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.머지ToolStripMenuItem,
            this.왜ToolStripMenuItem,
            this.은안보여ToolStripMenuItem,
            this.ㄷToolStripMenuItem,
            this.이상해ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 136);
            // 
            // 머지ToolStripMenuItem
            // 
            this.머지ToolStripMenuItem.Name = "머지ToolStripMenuItem";
            this.머지ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.머지ToolStripMenuItem.Text = "머지";
            // 
            // 왜ToolStripMenuItem
            // 
            this.왜ToolStripMenuItem.Name = "왜ToolStripMenuItem";
            this.왜ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.왜ToolStripMenuItem.Text = "왜";
            // 
            // 은안보여ToolStripMenuItem
            // 
            this.은안보여ToolStripMenuItem.Name = "은안보여ToolStripMenuItem";
            this.은안보여ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.은안보여ToolStripMenuItem.Text = "1은 안보여";
            // 
            // ㄷToolStripMenuItem
            // 
            this.ㄷToolStripMenuItem.Name = "ㄷToolStripMenuItem";
            this.ㄷToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ㄷToolStripMenuItem.Text = "ㄷ";
            // 
            // 이상해ToolStripMenuItem
            // 
            this.이상해ToolStripMenuItem.Name = "이상해ToolStripMenuItem";
            this.이상해ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.이상해ToolStripMenuItem.Text = "이상해";
            this.이상해ToolStripMenuItem.Click += new System.EventHandler(this.이상해ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 485);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 항목보기ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 머지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 왜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 은안보여ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㄷToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이상해ToolStripMenuItem;
    }
}

