namespace Target
{          
    [System.ComponentModel.ToolboxItem(true)]
    partial class Template1
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
			GrapeCity.Win.MultiRow.Border border1 = new GrapeCity.Win.MultiRow.Border();
			this.columnHeaderSection1 = new GrapeCity.Win.MultiRow.ColumnHeaderSection();
			this.columnHeaderCell1 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
			this.columnHeaderCell2 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
			this.columnHeaderCell3 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
			this.columnHeaderCell4 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
			this.columnHeaderCell5 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
			this.textBoxCell1 = new GrapeCity.Win.MultiRow.TextBoxCell();
			this.textBoxCell3 = new GrapeCity.Win.MultiRow.TextBoxCell();
			this.textBoxCell4 = new GrapeCity.Win.MultiRow.TextBoxCell();
			this.rowHeaderCell1 = new GrapeCity.Win.MultiRow.RowHeaderCell();
			this.comboBoxCell1 = new GrapeCity.Win.MultiRow.ComboBoxCell();
			this.labelCell1 = new GrapeCity.Win.MultiRow.LabelCell();
			// 
			// Row
			// 
			border1.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Black);
			this.Row.Border = border1;
			this.Row.Cells.Add(this.textBoxCell1);
			this.Row.Cells.Add( this.comboBoxCell1 );
			this.Row.Cells.Add( this.labelCell1 );
			this.Row.Cells.Add( this.textBoxCell3 );
			this.Row.Cells.Add(this.textBoxCell4);
			this.Row.Cells.Add(this.rowHeaderCell1);
			this.Row.Height = 42;
			this.Row.Width = 276;
			// 
			// columnHeaderSection1
			// 
			this.columnHeaderSection1.Cells.Add(this.columnHeaderCell1);
			this.columnHeaderSection1.Cells.Add(this.columnHeaderCell2);
			this.columnHeaderSection1.Cells.Add(this.columnHeaderCell3);
			this.columnHeaderSection1.Cells.Add(this.columnHeaderCell4);
			this.columnHeaderSection1.Cells.Add(this.columnHeaderCell5);
			this.columnHeaderSection1.Height = 40;
			this.columnHeaderSection1.Name = "columnHeaderSection1";
			this.columnHeaderSection1.Width = 276;
			// 
			// columnHeaderCell1
			// 
			this.columnHeaderCell1.HoverDirection = GrapeCity.Win.MultiRow.HoverDirection.None;
			this.columnHeaderCell1.Location = new System.Drawing.Point(36, 0);
			this.columnHeaderCell1.Name = "columnHeaderCell1";
			this.columnHeaderCell1.TabIndex = 0;
			// 
			// columnHeaderCell2
			// 
			this.columnHeaderCell2.HoverDirection = GrapeCity.Win.MultiRow.HoverDirection.None;
			this.columnHeaderCell2.Location = new System.Drawing.Point(116, 0);
			this.columnHeaderCell2.Name = "columnHeaderCell2";
			this.columnHeaderCell2.TabIndex = 1;
			// 
			// columnHeaderCell3
			// 
			this.columnHeaderCell3.Location = new System.Drawing.Point(36, 20);
			this.columnHeaderCell3.Name = "columnHeaderCell3";
			this.columnHeaderCell3.TabIndex = 2;
			// 
			// columnHeaderCell4
			// 
			this.columnHeaderCell4.Location = new System.Drawing.Point(116, 20);
			this.columnHeaderCell4.Name = "columnHeaderCell4";
			this.columnHeaderCell4.TabIndex = 3;
			// 
			// columnHeaderCell5
			// 
			this.columnHeaderCell5.HoverDirection = GrapeCity.Win.MultiRow.HoverDirection.None;
			this.columnHeaderCell5.Location = new System.Drawing.Point(0, 0);
			this.columnHeaderCell5.Name = "columnHeaderCell5";
			this.columnHeaderCell5.ResizeMode = GrapeCity.Win.MultiRow.ResizeMode.None;
			this.columnHeaderCell5.SelectionMode = GrapeCity.Win.MultiRow.MultiRowSelectionMode.AllRows;
			this.columnHeaderCell5.Size = new System.Drawing.Size(36, 40);
			this.columnHeaderCell5.TabIndex = 4;
			// 
			// textBoxCell1
			// 
			this.textBoxCell1.Location = new System.Drawing.Point(36, 0);
			this.textBoxCell1.Name = "textBoxCell1";
			this.textBoxCell1.TabIndex = 0;
			// 
			// textBoxCell3
			// 
			this.textBoxCell3.Location = new System.Drawing.Point(36, 21);
			this.textBoxCell3.Name = "textBoxCell3";
			this.textBoxCell3.TabIndex = 2;
			// 
			// textBoxCell4
			// 
			this.textBoxCell4.Location = new System.Drawing.Point(116, 21);
			this.textBoxCell4.Name = "textBoxCell4";
			this.textBoxCell4.TabIndex = 3;
			// 
			// rowHeaderCell1
			// 
			this.rowHeaderCell1.Location = new System.Drawing.Point(0, 0);
			this.rowHeaderCell1.Name = "rowHeaderCell1";
			this.rowHeaderCell1.Size = new System.Drawing.Size(36, 42);
			this.rowHeaderCell1.TabIndex = 4;
			// 
			// comboBoxCell1
			// 
			this.comboBoxCell1.DropDownStyle = GrapeCity.Win.MultiRow.MultiRowComboBoxStyle.DropDown;
			this.comboBoxCell1.Items.AddRange(new object[] {
            "AAA",
            "BBB",
            "CCC",
            "DDD"});
			this.comboBoxCell1.Location = new System.Drawing.Point(116, 0);
			this.comboBoxCell1.Name = "comboBoxCell1";
			this.comboBoxCell1.TabIndex = 5;
			// 
			// labelCell1
			// 
			this.labelCell1.Location = new System.Drawing.Point(196, 0);
			this.labelCell1.Name = "labelCell1";
			this.labelCell1.TabIndex = 6;
			// 
			// Template1
			// 
			this.ColumnHeaders.AddRange(new GrapeCity.Win.MultiRow.ColumnHeaderSection[] {
            this.columnHeaderSection1});
			this.Height = 82;
			this.Width = 276;

        }
        

        #endregion

        private GrapeCity.Win.MultiRow.ColumnHeaderSection columnHeaderSection1;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell1;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell2;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell3;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell4;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell5;
		private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell1;
		private GrapeCity.Win.MultiRow.ComboBoxCell comboBoxCell1;
		private GrapeCity.Win.MultiRow.LabelCell labelCell1;
		private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell3;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell4;
        private GrapeCity.Win.MultiRow.RowHeaderCell rowHeaderCell1;
        
    }
}
