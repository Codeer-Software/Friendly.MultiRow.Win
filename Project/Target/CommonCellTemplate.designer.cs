namespace Target
{          
    [System.ComponentModel.ToolboxItem(true)]
    partial class CommonCellTemplate
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
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

        #region MultiRow Template Designer generated code

		/// <summary> 
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
        private void InitializeComponent()
        {
            this._columnHeaderSection = new GrapeCity.Win.MultiRow.ColumnHeaderSection();
            this._buttonCell = new GrapeCity.Win.MultiRow.ButtonCell();
            this._checkBoxCell = new GrapeCity.Win.MultiRow.CheckBoxCell();
            this._columnHeaderCell = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this._comboBoxCell = new GrapeCity.Win.MultiRow.ComboBoxCell();
            this._cornerHeaderCell = new GrapeCity.Win.MultiRow.CornerHeaderCell();
            this._dateTimePickerCell = new GrapeCity.Win.MultiRow.DateTimePickerCell();
            this._domainUpDownCell = new GrapeCity.Win.MultiRow.DomainUpDownCell();
            this._filteringTextBoxCell = new GrapeCity.Win.MultiRow.FilteringTextBoxCell();
            this._headerCell = new GrapeCity.Win.MultiRow.HeaderCell();
            this._imageCell = new GrapeCity.Win.MultiRow.ImageCell();
            this._labelCell = new GrapeCity.Win.MultiRow.LabelCell();
            this._linkLabelCell = new GrapeCity.Win.MultiRow.LinkLabelCell();
            this._listBoxCell = new GrapeCity.Win.MultiRow.ListBoxCell();
            this._listLabelCell = new GrapeCity.Win.MultiRow.ListLabelCell();
            this._maskedTextBoxCell = new GrapeCity.Win.MultiRow.MaskedTextBoxCell();
            this._numericUpDownCell = new GrapeCity.Win.MultiRow.NumericUpDownCell();
            this.popupCell = new GrapeCity.Win.MultiRow.PopupCell();
            this._printInfoCell = new GrapeCity.Win.MultiRow.PrintInfoCell();
            this._progressBarCell = new GrapeCity.Win.MultiRow.ProgressBarCell();
            this._radioGroupCell = new GrapeCity.Win.MultiRow.RadioGroupCell();
            this._richTextBoxCell = new GrapeCity.Win.MultiRow.RichTextBoxCell();
            this._rowHeaderCell = new GrapeCity.Win.MultiRow.RowHeaderCell();
            this._shapeCell = new GrapeCity.Win.MultiRow.ShapeCell();
            this._stickyCell = new GrapeCity.Win.MultiRow.StickyCell();
            this._summaryCell = new GrapeCity.Win.MultiRow.SummaryCell();
            this._textBoxCell = new GrapeCity.Win.MultiRow.TextBoxCell();
            this._trackBarCell = new GrapeCity.Win.MultiRow.TrackBarCell();
            // 
            // Row
            // 
            this.Row.Cells.Add(this._buttonCell);
            this.Row.Cells.Add(this._checkBoxCell);
            this.Row.Cells.Add(this._comboBoxCell);
            this.Row.Cells.Add(this._dateTimePickerCell);
            this.Row.Cells.Add(this._domainUpDownCell);
            this.Row.Cells.Add(this._headerCell);
            this.Row.Cells.Add(this._imageCell);
            this.Row.Cells.Add(this._labelCell);
            this.Row.Cells.Add(this._linkLabelCell);
            this.Row.Cells.Add(this._listBoxCell);
            this.Row.Cells.Add(this._listLabelCell);
            this.Row.Cells.Add(this._maskedTextBoxCell);
            this.Row.Cells.Add(this._numericUpDownCell);
            this.Row.Cells.Add(this.popupCell);
            this.Row.Cells.Add(this._printInfoCell);
            this.Row.Cells.Add(this._progressBarCell);
            this.Row.Cells.Add(this._radioGroupCell);
            this.Row.Cells.Add(this._richTextBoxCell);
            this.Row.Cells.Add(this._rowHeaderCell);
            this.Row.Cells.Add(this._shapeCell);
            this.Row.Cells.Add(this._stickyCell);
            this.Row.Cells.Add(this._summaryCell);
            this.Row.Cells.Add(this._textBoxCell);
            this.Row.Cells.Add(this._trackBarCell);
            this.Row.Height = 130;
            this.Row.Width = 1000;
            // 
            // _columnHeaderSection
            // 
            this._columnHeaderSection.Cells.Add(this._columnHeaderCell);
            this._columnHeaderSection.Cells.Add(this._cornerHeaderCell);
            this._columnHeaderSection.Cells.Add(this._filteringTextBoxCell);
            this._columnHeaderSection.Height = 40;
            this._columnHeaderSection.Name = "_columnHeaderSection";
            this._columnHeaderSection.Width = 1000;
            // 
            // buttonCell1
            // 
            this._buttonCell.Location = new System.Drawing.Point(0, 0);
            this._buttonCell.Name = "buttonCell1";
            this._buttonCell.TabIndex = 0;
            // 
            // checkBoxCell1
            // 
            this._checkBoxCell.Location = new System.Drawing.Point(0, 21);
            this._checkBoxCell.Name = "checkBoxCell1";
            this._checkBoxCell.TabIndex = 1;
            // 
            // columnHeaderCell1
            // 
            this._columnHeaderCell.Location = new System.Drawing.Point(8, 0);
            this._columnHeaderCell.Name = "columnHeaderCell1";
            this._columnHeaderCell.TabIndex = 0;
            // 
            // comboBoxCell1
            // 
            this._comboBoxCell.Location = new System.Drawing.Point(0, 42);
            this._comboBoxCell.Name = "comboBoxCell1";
            this._comboBoxCell.TabIndex = 2;
            // 
            // cornerHeaderCell1
            // 
            this._cornerHeaderCell.Location = new System.Drawing.Point(101, 0);
            this._cornerHeaderCell.Name = "cornerHeaderCell1";
            this._cornerHeaderCell.TabIndex = 1;
            // 
            // dateTimePickerCell1
            // 
            this._dateTimePickerCell.Location = new System.Drawing.Point(0, 63);
            this._dateTimePickerCell.Name = "dateTimePickerCell1";
            this._dateTimePickerCell.TabIndex = 3;
            // 
            // domainUpDownCell1
            // 
            this._domainUpDownCell.Location = new System.Drawing.Point(0, 94);
            this._domainUpDownCell.Name = "domainUpDownCell1";
            this._domainUpDownCell.TabIndex = 4;
            // 
            // filteringTextBoxCell1
            // 
            this._filteringTextBoxCell.CustomComparisonOperator = null;
            this._filteringTextBoxCell.Location = new System.Drawing.Point(195, 0);
            this._filteringTextBoxCell.Name = "filteringTextBoxCell1";
            this._filteringTextBoxCell.TabIndex = 2;
            // 
            // headerCell1
            // 
            this._headerCell.Location = new System.Drawing.Point(101, 0);
            this._headerCell.Name = "headerCell1";
            this._headerCell.TabIndex = 5;
            // 
            // imageCell1
            // 
            this._imageCell.Location = new System.Drawing.Point(101, 34);
            this._imageCell.Name = "imageCell1";
            this._imageCell.TabIndex = 6;
            // 
            // labelCell1
            // 
            this._labelCell.Location = new System.Drawing.Point(101, 63);
            this._labelCell.Name = "labelCell1";
            this._labelCell.TabIndex = 7;
            // 
            // linkLabelCell1
            // 
            this._linkLabelCell.Location = new System.Drawing.Point(101, 94);
            this._linkLabelCell.Name = "linkLabelCell1";
            this._linkLabelCell.TabIndex = 8;
            // 
            // listBoxCell1
            // 
            this._listBoxCell.Location = new System.Drawing.Point(209, 0);
            this._listBoxCell.Name = "listBoxCell1";
            this._listBoxCell.TabIndex = 9;
            // 
            // listLabelCell1
            // 
            this._listLabelCell.Location = new System.Drawing.Point(303, 0);
            this._listLabelCell.Name = "listLabelCell1";
            this._listLabelCell.TabIndex = 10;
            // 
            // maskedTextBoxCell1
            // 
            this._maskedTextBoxCell.Location = new System.Drawing.Point(303, 34);
            this._maskedTextBoxCell.Name = "maskedTextBoxCell1";
            this._maskedTextBoxCell.TabIndex = 11;
            // 
            // numericUpDownCell1
            // 
            this._numericUpDownCell.Location = new System.Drawing.Point(303, 73);
            this._numericUpDownCell.Name = "numericUpDownCell1";
            this._numericUpDownCell.TabIndex = 12;
            // 
            // popupCell1
            // 
            this.popupCell.Location = new System.Drawing.Point(303, 109);
            this.popupCell.Name = "popupCell1";
            this.popupCell.TabIndex = 13;
            // 
            // printInfoCell1
            // 
            this._printInfoCell.Location = new System.Drawing.Point(409, 0);
            this._printInfoCell.Name = "printInfoCell1";
            this._printInfoCell.TabIndex = 14;
            // 
            // progressBarCell1
            // 
            this._progressBarCell.Location = new System.Drawing.Point(409, 34);
            this._progressBarCell.Name = "progressBarCell1";
            this._progressBarCell.TabIndex = 15;
            // 
            // radioGroupCell1
            // 
            this._radioGroupCell.Location = new System.Drawing.Point(409, 63);
            this._radioGroupCell.Name = "radioGroupCell1";
            this._radioGroupCell.TabIndex = 16;
            // 
            // richTextBoxCell1
            // 
            this._richTextBoxCell.Location = new System.Drawing.Point(409, 109);
            this._richTextBoxCell.Name = "richTextBoxCell1";
            this._richTextBoxCell.TabIndex = 17;
            // 
            // rowHeaderCell1
            // 
            this._rowHeaderCell.Location = new System.Drawing.Point(508, 0);
            this._rowHeaderCell.Name = "rowHeaderCell1";
            this._rowHeaderCell.TabIndex = 18;
            // 
            // shapeCell1
            // 
            this._shapeCell.Location = new System.Drawing.Point(508, 34);
            this._shapeCell.Name = "shapeCell1";
            this._shapeCell.TabIndex = 19;
            // 
            // stickyCell1
            // 
            this._stickyCell.Location = new System.Drawing.Point(508, 73);
            this._stickyCell.Name = "stickyCell1";
            this._stickyCell.TabIndex = 20;
            // 
            // summaryCell1
            // 
            this._summaryCell.Location = new System.Drawing.Point(508, 109);
            this._summaryCell.Name = "summaryCell1";
            this._summaryCell.TabIndex = 21;
            // 
            // textBoxCell1
            // 
            this._textBoxCell.Location = new System.Drawing.Point(608, 0);
            this._textBoxCell.Name = "textBoxCell1";
            this._textBoxCell.TabIndex = 22;
            // 
            // trackBarCell1
            // 
            this._trackBarCell.Location = new System.Drawing.Point(608, 34);
            this._trackBarCell.Name = "trackBarCell1";
            this._trackBarCell.TabIndex = 23;
            // 
            // CommonCellTemplate
            // 
            this.ColumnHeaders.AddRange(new GrapeCity.Win.MultiRow.ColumnHeaderSection[] {
            this._columnHeaderSection});
            this.Height = 170;
            this.Width = 1000;

        }
        

        #endregion

        private GrapeCity.Win.MultiRow.ColumnHeaderSection _columnHeaderSection;
        private GrapeCity.Win.MultiRow.ButtonCell _buttonCell;
        private GrapeCity.Win.MultiRow.CheckBoxCell _checkBoxCell;
        private GrapeCity.Win.MultiRow.ComboBoxCell _comboBoxCell;
        private GrapeCity.Win.MultiRow.DateTimePickerCell _dateTimePickerCell;
        private GrapeCity.Win.MultiRow.DomainUpDownCell _domainUpDownCell;
        private GrapeCity.Win.MultiRow.HeaderCell _headerCell;
        private GrapeCity.Win.MultiRow.ImageCell _imageCell;
        private GrapeCity.Win.MultiRow.LabelCell _labelCell;
        private GrapeCity.Win.MultiRow.LinkLabelCell _linkLabelCell;
        private GrapeCity.Win.MultiRow.ListBoxCell _listBoxCell;
        private GrapeCity.Win.MultiRow.ListLabelCell _listLabelCell;
        private GrapeCity.Win.MultiRow.MaskedTextBoxCell _maskedTextBoxCell;
        private GrapeCity.Win.MultiRow.NumericUpDownCell _numericUpDownCell;
        private GrapeCity.Win.MultiRow.PopupCell popupCell;
        private GrapeCity.Win.MultiRow.PrintInfoCell _printInfoCell;
        private GrapeCity.Win.MultiRow.ProgressBarCell _progressBarCell;
        private GrapeCity.Win.MultiRow.RadioGroupCell _radioGroupCell;
        private GrapeCity.Win.MultiRow.RichTextBoxCell _richTextBoxCell;
        private GrapeCity.Win.MultiRow.RowHeaderCell _rowHeaderCell;
        private GrapeCity.Win.MultiRow.ShapeCell _shapeCell;
        private GrapeCity.Win.MultiRow.StickyCell _stickyCell;
        private GrapeCity.Win.MultiRow.SummaryCell _summaryCell;
        private GrapeCity.Win.MultiRow.TextBoxCell _textBoxCell;
        private GrapeCity.Win.MultiRow.TrackBarCell _trackBarCell;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell _columnHeaderCell;
        private GrapeCity.Win.MultiRow.CornerHeaderCell _cornerHeaderCell;
        private GrapeCity.Win.MultiRow.FilteringTextBoxCell _filteringTextBoxCell;
        
    }
}
