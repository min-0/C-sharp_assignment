namespace _13Week_예제3
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출력ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.출력ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "결과가 표시되는 곳입니다";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도구ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출력ToolStripMenuItem,
            this.출력ToolStripMenuItem1,
            this.출력ToolStripMenuItem2,
            this.종료ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 출력ToolStripMenuItem
            // 
            this.출력ToolStripMenuItem.Name = "출력ToolStripMenuItem";
            this.출력ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.출력ToolStripMenuItem.Text = "1출력";
            this.출력ToolStripMenuItem.Click += new System.EventHandler(this.출력ToolStripMenuItem_Click);
            // 
            // 출력ToolStripMenuItem1
            // 
            this.출력ToolStripMenuItem1.Name = "출력ToolStripMenuItem1";
            this.출력ToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.출력ToolStripMenuItem1.Text = "2출력";
            this.출력ToolStripMenuItem1.Click += new System.EventHandler(this.출력ToolStripMenuItem1_Click);
            // 
            // 출력ToolStripMenuItem2
            // 
            this.출력ToolStripMenuItem2.Name = "출력ToolStripMenuItem2";
            this.출력ToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.출력ToolStripMenuItem2.Text = "3출력";
            this.출력ToolStripMenuItem2.Click += new System.EventHandler(this.출력ToolStripMenuItem2_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출력ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 출력ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

