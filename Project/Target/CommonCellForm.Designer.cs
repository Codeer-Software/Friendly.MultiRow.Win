﻿namespace Target
{
    partial class CommonCellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._multiRow = new GrapeCity.Win.MultiRow.GcMultiRow();
            this._commonCellTemplate = new Target.CommonCellTemplate();
            ((System.ComponentModel.ISupportInitialize)(this._multiRow)).BeginInit();
            this.SuspendLayout();
            // 
            // _multiRow
            // 
            this._multiRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._multiRow.Location = new System.Drawing.Point(0, 0);
            this._multiRow.Name = "_multiRow";
            this._multiRow.Size = new System.Drawing.Size(284, 261);
            this._multiRow.TabIndex = 0;
            this._multiRow.Template = this._commonCellTemplate;
            this._multiRow.Text = "gcMultiRow1";
            // 
            // CommonCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._multiRow);
            this.Name = "CommonCellForm";
            this.Text = "TemplateForm";
            ((System.ComponentModel.ISupportInitialize)(this._multiRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.MultiRow.GcMultiRow _multiRow;
        private CommonCellTemplate _commonCellTemplate;

    }
}