namespace TCPClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPanTilt;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;

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
            this.lblPanTilt = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPanTilt
            // 
            this.lblPanTilt.AutoSize = true;
            this.lblPanTilt.Location = new System.Drawing.Point(127, 135);
            this.lblPanTilt.Name = "lblPanTilt";
            this.lblPanTilt.Size = new System.Drawing.Size(79, 12);
            this.lblPanTilt.TabIndex = 0;
            this.lblPanTilt.Text = "팬틸트: (0, 0)";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(337, 135);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(41, 12);
            this.lblZoom.TabIndex = 1;
            this.lblZoom.Text = "줌: 0.0";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(510, 135);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(49, 12);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "볼륨: 10";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(157, 236);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(23, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(109, 282);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(23, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(157, 329);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(23, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(205, 282);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 23);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnZoomIn.Location = new System.Drawing.Point(320, 215);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 7;
            this.btnZoomIn.Text = "+ Zoom";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(320, 346);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.Text = "- Zoom";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Location = new System.Drawing.Point(493, 215);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(75, 23);
            this.btnVolumeUp.TabIndex = 9;
            this.btnVolumeUp.Text = "+ Volume";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(493, 346);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(75, 23);
            this.btnVolumeDown.TabIndex = 10;
            this.btnVolumeDown.Text = "- Volume";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(127, 29);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(101, 12);
            this.lblConnectionStatus.TabIndex = 11;
            this.lblConnectionStatus.Text = "연결 상태: 끊어짐";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(320, 29);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "TCP 연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(493, 29);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "TCP 해제";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.lblPanTilt);
            this.Name = "Form1";
            this.Text = "TCP 컨트롤러";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        


        //private void InitializeComponent()
        //{
        //    this.lblConnectionStatus = new System.Windows.Forms.Label();
        //    this.btnConnect = new System.Windows.Forms.Button();
        //    this.btnDisconnect = new System.Windows.Forms.Button();
        //    this.lblPanTilt = new System.Windows.Forms.Label();
        //    this.lblZoom = new System.Windows.Forms.Label();
        //    this.lblVolume = new System.Windows.Forms.Label();
        //    this.btnUp = new System.Windows.Forms.Button();
        //    this.btnDown = new System.Windows.Forms.Button();
        //    this.btnLeft = new System.Windows.Forms.Button();
        //    this.btnRight = new System.Windows.Forms.Button();
        //    this.btnZoomIn = new System.Windows.Forms.Button();
        //    this.btnZoomOut = new System.Windows.Forms.Button();
        //    this.btnVolumeUp = new System.Windows.Forms.Button();
        //    this.btnVolumeDown = new System.Windows.Forms.Button();

        //    // TCP 연결 상태
        //    this.lblConnectionStatus.Text = "연결 상태: 끊어짐";
        //    this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
        //    this.lblConnectionStatus.Location = new System.Drawing.Point(10, 10);

        //    // 연결 버튼
        //    this.btnConnect.Text = "TCP 연결";
        //    this.btnConnect.Location = new System.Drawing.Point(10, 40);
        //    this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);

        //    this.btnDisconnect.Text = "TCP 해제";
        //    this.btnDisconnect.Location = new System.Drawing.Point(100, 40);
        //    this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);

        //    // UI 배치
        //    this.Controls.Add(this.lblConnectionStatus);
        //    this.Controls.Add(this.btnConnect);
        //    this.Controls.Add(this.btnDisconnect);

        //    // 폼 설정
        //    this.Text = "TCP 컨트롤러";
        //    this.ClientSize = new System.Drawing.Size(300, 250);
        //    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        //}
        
    }
}

