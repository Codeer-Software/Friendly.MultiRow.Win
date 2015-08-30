namespace Target
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonNormal = new System.Windows.Forms.Button();
            this._buttonTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonNormal
            // 
            this._buttonNormal.Location = new System.Drawing.Point(13, 25);
            this._buttonNormal.Name = "_buttonNormal";
            this._buttonNormal.Size = new System.Drawing.Size(75, 23);
            this._buttonNormal.TabIndex = 0;
            this._buttonNormal.Text = "Normal";
            this._buttonNormal.UseVisualStyleBackColor = true;
            // 
            // _buttonTemplate
            // 
            this._buttonTemplate.Location = new System.Drawing.Point(13, 55);
            this._buttonTemplate.Name = "_buttonTemplate";
            this._buttonTemplate.Size = new System.Drawing.Size(75, 23);
            this._buttonTemplate.TabIndex = 1;
            this._buttonTemplate.Text = "Template";
            this._buttonTemplate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._buttonTemplate);
            this.Controls.Add(this._buttonNormal);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonNormal;
        private System.Windows.Forms.Button _buttonTemplate;
    }
}

