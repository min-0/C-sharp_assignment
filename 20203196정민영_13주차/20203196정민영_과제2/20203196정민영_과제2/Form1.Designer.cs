namespace _20203196정민영_과제2
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
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기XCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택ACtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FCtrlFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색깔CCtrlShiftCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식JToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NCtrlNToolStripMenuItem,
            this.열기OCtrlOToolStripMenuItem,
            this.저장SCtrlSToolStripMenuItem,
            this.끝내기XCtrlXToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내기TCtrlTToolStripMenuItem,
            this.복사CCtrlCToolStripMenuItem,
            this.붙여넣기PCtrlPToolStripMenuItem,
            this.삭제DCtrlDToolStripMenuItem,
            this.모두선택ACtrlAToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 서식JToolStripMenuItem
            // 
            this.서식JToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴FCtrlFToolStripMenuItem,
            this.색깔CCtrlShiftCToolStripMenuItem});
            this.서식JToolStripMenuItem.Name = "서식JToolStripMenuItem";
            this.서식JToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.서식JToolStripMenuItem.Text = "서식(J)";
            // 
            // 새로만들기NCtrlNToolStripMenuItem
            // 
            this.새로만들기NCtrlNToolStripMenuItem.Name = "새로만들기NCtrlNToolStripMenuItem";
            this.새로만들기NCtrlNToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.새로만들기NCtrlNToolStripMenuItem.Text = "새로만들기(N)   Ctrl+N";
            this.새로만들기NCtrlNToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NCtrlNToolStripMenuItem_Click);
            // 
            // 열기OCtrlOToolStripMenuItem
            // 
            this.열기OCtrlOToolStripMenuItem.Name = "열기OCtrlOToolStripMenuItem";
            this.열기OCtrlOToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.열기OCtrlOToolStripMenuItem.Text = "열기(O)            Ctrl+O";
            this.열기OCtrlOToolStripMenuItem.Click += new System.EventHandler(this.열기OCtrlOToolStripMenuItem_Click);
            // 
            // 저장SCtrlSToolStripMenuItem
            // 
            this.저장SCtrlSToolStripMenuItem.Name = "저장SCtrlSToolStripMenuItem";
            this.저장SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.저장SCtrlSToolStripMenuItem.Text = "저장(S)            Ctrl+S";
            this.저장SCtrlSToolStripMenuItem.Click += new System.EventHandler(this.저장SCtrlSToolStripMenuItem_Click);
            // 
            // 끝내기XCtrlXToolStripMenuItem
            // 
            this.끝내기XCtrlXToolStripMenuItem.Name = "끝내기XCtrlXToolStripMenuItem";
            this.끝내기XCtrlXToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.끝내기XCtrlXToolStripMenuItem.Text = "끝내기(X)         Ctrl+X";
            this.끝내기XCtrlXToolStripMenuItem.Click += new System.EventHandler(this.끝내기XCtrlXToolStripMenuItem_Click);
            // 
            // 잘라내기TCtrlTToolStripMenuItem
            // 
            this.잘라내기TCtrlTToolStripMenuItem.Name = "잘라내기TCtrlTToolStripMenuItem";
            this.잘라내기TCtrlTToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.잘라내기TCtrlTToolStripMenuItem.Text = "잘라내기(T)    Ctrl+T";
            this.잘라내기TCtrlTToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TCtrlTToolStripMenuItem_Click);
            // 
            // 복사CCtrlCToolStripMenuItem
            // 
            this.복사CCtrlCToolStripMenuItem.Name = "복사CCtrlCToolStripMenuItem";
            this.복사CCtrlCToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.복사CCtrlCToolStripMenuItem.Text = "복사(C)         Ctrl+C";
            this.복사CCtrlCToolStripMenuItem.Click += new System.EventHandler(this.복사CCtrlCToolStripMenuItem_Click);
            // 
            // 붙여넣기PCtrlPToolStripMenuItem
            // 
            this.붙여넣기PCtrlPToolStripMenuItem.Name = "붙여넣기PCtrlPToolStripMenuItem";
            this.붙여넣기PCtrlPToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.붙여넣기PCtrlPToolStripMenuItem.Text = "붙여넣기(P)   Ctrl+P";
            this.붙여넣기PCtrlPToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기PCtrlPToolStripMenuItem_Click);
            // 
            // 삭제DCtrlDToolStripMenuItem
            // 
            this.삭제DCtrlDToolStripMenuItem.Name = "삭제DCtrlDToolStripMenuItem";
            this.삭제DCtrlDToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.삭제DCtrlDToolStripMenuItem.Text = "삭제(D)         Ctrl+D";
            this.삭제DCtrlDToolStripMenuItem.Click += new System.EventHandler(this.삭제DCtrlDToolStripMenuItem_Click);
            // 
            // 모두선택ACtrlAToolStripMenuItem
            // 
            this.모두선택ACtrlAToolStripMenuItem.Name = "모두선택ACtrlAToolStripMenuItem";
            this.모두선택ACtrlAToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.모두선택ACtrlAToolStripMenuItem.Text = "모두선택(A)   Ctrl+A";
            this.모두선택ACtrlAToolStripMenuItem.Click += new System.EventHandler(this.모두선택ACtrlAToolStripMenuItem_Click);
            // 
            // 글꼴FCtrlFToolStripMenuItem
            // 
            this.글꼴FCtrlFToolStripMenuItem.Name = "글꼴FCtrlFToolStripMenuItem";
            this.글꼴FCtrlFToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.글꼴FCtrlFToolStripMenuItem.Text = "글꼴(F)            Ctrl+F";
            this.글꼴FCtrlFToolStripMenuItem.Click += new System.EventHandler(this.글꼴FCtrlFToolStripMenuItem_Click);
            // 
            // 색깔CCtrlShiftCToolStripMenuItem
            // 
            this.색깔CCtrlShiftCToolStripMenuItem.Name = "색깔CCtrlShiftCToolStripMenuItem";
            this.색깔CCtrlShiftCToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.색깔CCtrlShiftCToolStripMenuItem.Text = "색깔(C)   Ctrl+Shift+C";
            this.색깔CCtrlShiftCToolStripMenuItem.Click += new System.EventHandler(this.색깔CCtrlShiftCToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(722, 474);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 508);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TCtrlTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DCtrlDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ACtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식JToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FCtrlFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색깔CCtrlShiftCToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

