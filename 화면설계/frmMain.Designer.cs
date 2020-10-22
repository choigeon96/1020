namespace 화면설계
{
    partial class frmMain
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.매출등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.매장관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매뉴얼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.매장관리ToolStripMenuItem,
            this.통계ToolStripMenuItem,
            this.매뉴얼ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매출등록ToolStripMenuItem,
            this.매출현황ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "매출관리";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 매출등록ToolStripMenuItem
            // 
            this.매출등록ToolStripMenuItem.Name = "매출등록ToolStripMenuItem";
            this.매출등록ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.매출등록ToolStripMenuItem.Text = "매출등록";
            // 
            // 매출현황ToolStripMenuItem
            // 
            this.매출현황ToolStripMenuItem.Name = "매출현황ToolStripMenuItem";
            this.매출현황ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.매출현황ToolStripMenuItem.Text = "매출현황";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem2.Text = "매입관리";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem3.Text = "고객관리";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 매장관리ToolStripMenuItem
            // 
            this.매장관리ToolStripMenuItem.Name = "매장관리ToolStripMenuItem";
            this.매장관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.매장관리ToolStripMenuItem.Text = "매장관리";
            // 
            // 통계ToolStripMenuItem
            // 
            this.통계ToolStripMenuItem.Name = "통계ToolStripMenuItem";
            this.통계ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.통계ToolStripMenuItem.Text = "통계";
            this.통계ToolStripMenuItem.Click += new System.EventHandler(this.통계ToolStripMenuItem_Click);
            // 
            // 매뉴얼ToolStripMenuItem
            // 
            this.매뉴얼ToolStripMenuItem.Name = "매뉴얼ToolStripMenuItem";
            this.매뉴얼ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.매뉴얼ToolStripMenuItem.Text = "매뉴얼";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "최건";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 매장관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매뉴얼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출현황ToolStripMenuItem;
    }
}

