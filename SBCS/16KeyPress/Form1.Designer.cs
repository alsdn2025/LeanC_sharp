namespace _16KeyPress
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 401);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }


        // 정리
        // 만약 내가 어떤 행동을 하면 -> 
        // os가 가장 먼저 이를 감지하여 행동에 대응하는 메세지를 보냄->
        // 메세지(고유 값)에 연동되어있는 이벤트가 자동 발생(자동 생성 코드에 의해) ->
        // 이벤트가 자동 발생하여 이벤트핸들러를 호출 ->
        // 이벤트 핸들러에 연결된 메서드들이 호출


        // 40번줄의 Paint 같은 친구가 이벤트핸들러
        // 우리에게 보여지는 건, Form1.cs에 있는 메서드와,
        // Paint라는 이벤트핸들러에 메서드를 연결시키는 코드 뿐.
        // 메세지를 감지하고, 이벤트를 발생시키는 건 알아서 한다. 
        // 그 이벤트의 실제 내용도 어디있는지 모름. <-- 나중에 찾아보고 싶네. 
        // 즉, Form에 있는 코드가 실제 최종적으로 작동하는 메서드의 내용이며 내가 그걸 코딩하는것이고, 
        // designer에 있는 코드는 내가 코딩한 메서드를 이벤트핸들러에 연결시키는 내용임. 
        // 이벤트의 내용도, 이벤트를 발생시키는 내용도 여기엔 없다. 
        
        #endregion
    }
}

