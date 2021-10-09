namespace WindowsFormsApp1
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
            this.firstParam = new System.Windows.Forms.TextBox();
            this.secondParam = new System.Windows.Forms.TextBox();
            this.Textresult = new System.Windows.Forms.TextBox();
            this.CalcMode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excuteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstParam
            // 
            this.firstParam.Location = new System.Drawing.Point(69, 29);
            this.firstParam.Name = "firstParam";
            this.firstParam.Size = new System.Drawing.Size(100, 21);
            this.firstParam.TabIndex = 0;
            // 
            // secondParam
            // 
            this.secondParam.Location = new System.Drawing.Point(175, 29);
            this.secondParam.Name = "secondParam";
            this.secondParam.Size = new System.Drawing.Size(100, 21);
            this.secondParam.TabIndex = 1;
            // 
            // Textresult
            // 
            this.Textresult.Location = new System.Drawing.Point(316, 29);
            this.Textresult.Name = "Textresult";
            this.Textresult.Size = new System.Drawing.Size(100, 21);
            this.Textresult.TabIndex = 2;
            // 
            // CalcMode
            // 
            this.CalcMode.AutoSize = true;
            this.CalcMode.Location = new System.Drawing.Point(473, 34);
            this.CalcMode.Name = "CalcMode";
            this.CalcMode.Size = new System.Drawing.Size(48, 16);
            this.CalcMode.TabIndex = 3;
            this.CalcMode.Text = "plus";
            this.CalcMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "->";
            // 
            // excuteButton
            // 
            this.excuteButton.Location = new System.Drawing.Point(435, 102);
            this.excuteButton.Name = "excuteButton";
            this.excuteButton.Size = new System.Drawing.Size(75, 23);
            this.excuteButton.TabIndex = 5;
            this.excuteButton.Text = "실행";
            this.excuteButton.UseVisualStyleBackColor = true;
            this.excuteButton.Click += new System.EventHandler(this.excuteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.excuteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcMode);
            this.Controls.Add(this.Textresult);
            this.Controls.Add(this.secondParam);
            this.Controls.Add(this.firstParam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstParam;
        private System.Windows.Forms.TextBox secondParam;
        private System.Windows.Forms.TextBox Textresult;
        private System.Windows.Forms.CheckBox CalcMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excuteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

