﻿namespace CryptoMarketClient {
    partial class TickerInfo {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet2 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet2 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon5 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon6 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.colHighestBid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowestAsk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLast = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHr24High = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHr24Low = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpread = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBidChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAskChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colHighestBid
            // 
            this.colHighestBid.Caption = "Bid";
            this.colHighestBid.ColumnEdit = this.repositoryItemTextEdit1;
            this.colHighestBid.FieldName = "HighestBidString";
            this.colHighestBid.Name = "colHighestBid";
            this.colHighestBid.OptionsColumn.ReadOnly = true;
            this.colHighestBid.Visible = true;
            this.colHighestBid.VisibleIndex = 2;
            this.colHighestBid.Width = 245;
            // 
            // colLowestAsk
            // 
            this.colLowestAsk.Caption = "Ask";
            this.colLowestAsk.ColumnEdit = this.repositoryItemTextEdit1;
            this.colLowestAsk.FieldName = "LowestAskString";
            this.colLowestAsk.Name = "colLowestAsk";
            this.colLowestAsk.OptionsColumn.ReadOnly = true;
            this.colLowestAsk.Visible = true;
            this.colLowestAsk.VisibleIndex = 3;
            this.colLowestAsk.Width = 249;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(924, 308);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.PaintEx += new DevExpress.XtraGrid.PaintExEventHandler(this.gridControl1_PaintEx);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(CryptoMarketClient.TickerBase);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colHighestBid,
            this.colLowestAsk,
            this.colLast,
            this.colBaseVolume,
            this.colVolume,
            this.colHr24High,
            this.colHr24Low,
            this.colChange,
            this.colSpread,
            this.colBidChange,
            this.colAskChange,
            this.colLastUpdateTime});
            gridFormatRule1.Column = this.colHighestBid;
            gridFormatRule1.ColumnApplyTo = this.colHighestBid;
            gridFormatRule1.Name = "HighestBidRule";
            formatConditionIconSet1.CategoryName = "Positive/Negative";
            formatConditionIconSetIcon1.PredefinedName = "Arrows3_3.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Arrows3_2.png";
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Arrows3_1.png";
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "PositiveNegativeArrows";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            gridFormatRule2.Column = this.colLowestAsk;
            gridFormatRule2.ColumnApplyTo = this.colLowestAsk;
            gridFormatRule2.Name = "LowestAskRule";
            formatConditionIconSet2.CategoryName = "Positive/Negative";
            formatConditionIconSetIcon4.PredefinedName = "Arrows3_3.png";
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon5.PredefinedName = "Arrows3_2.png";
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon6.PredefinedName = "Arrows3_1.png";
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon5);
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon6);
            formatConditionIconSet2.Name = "PositiveNegativeArrows";
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2;
            gridFormatRule2.Rule = formatConditionRuleIconSet2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 207;
            // 
            // colLast
            // 
            this.colLast.Caption = "Last";
            this.colLast.ColumnEdit = this.repositoryItemTextEdit1;
            this.colLast.FieldName = "LastString";
            this.colLast.Name = "colLast";
            this.colLast.OptionsColumn.ReadOnly = true;
            this.colLast.Visible = true;
            this.colLast.VisibleIndex = 1;
            this.colLast.Width = 214;
            // 
            // colBaseVolume
            // 
            this.colBaseVolume.FieldName = "BaseVolume";
            this.colBaseVolume.Name = "colBaseVolume";
            this.colBaseVolume.OptionsColumn.ReadOnly = true;
            this.colBaseVolume.Visible = true;
            this.colBaseVolume.VisibleIndex = 6;
            this.colBaseVolume.Width = 279;
            // 
            // colVolume
            // 
            this.colVolume.FieldName = "Volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.OptionsColumn.ReadOnly = true;
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 7;
            this.colVolume.Width = 383;
            // 
            // colHr24High
            // 
            this.colHr24High.FieldName = "Hr24High";
            this.colHr24High.Name = "colHr24High";
            this.colHr24High.OptionsColumn.ReadOnly = true;
            this.colHr24High.Visible = true;
            this.colHr24High.VisibleIndex = 4;
            this.colHr24High.Width = 302;
            // 
            // colHr24Low
            // 
            this.colHr24Low.FieldName = "Hr24Low";
            this.colHr24Low.Name = "colHr24Low";
            this.colHr24Low.OptionsColumn.ReadOnly = true;
            this.colHr24Low.Visible = true;
            this.colHr24Low.VisibleIndex = 5;
            this.colHr24Low.Width = 284;
            // 
            // colChange
            // 
            this.colChange.DisplayFormat.FormatString = "F3";
            this.colChange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colChange.FieldName = "Change";
            this.colChange.Name = "colChange";
            this.colChange.OptionsColumn.ReadOnly = true;
            this.colChange.Width = 119;
            // 
            // colSpread
            // 
            this.colSpread.Caption = "Spread";
            this.colSpread.FieldName = "Spread";
            this.colSpread.Name = "colSpread";
            this.colSpread.Width = 124;
            // 
            // colBidChange
            // 
            this.colBidChange.Caption = "Bid Change";
            this.colBidChange.DisplayFormat.FormatString = "F3";
            this.colBidChange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBidChange.FieldName = "BidChange";
            this.colBidChange.Name = "colBidChange";
            this.colBidChange.Width = 119;
            // 
            // colAskChange
            // 
            this.colAskChange.Caption = "Ask Change";
            this.colAskChange.DisplayFormat.FormatString = "F3";
            this.colAskChange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAskChange.FieldName = "AskChange";
            this.colAskChange.Name = "colAskChange";
            this.colAskChange.Width = 119;
            // 
            // colLastUpdateTime
            // 
            this.colLastUpdateTime.FieldName = "LastUpdateTime";
            this.colLastUpdateTime.Name = "colLastUpdateTime";
            this.colLastUpdateTime.Visible = true;
            this.colLastUpdateTime.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            // 
            // TickerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "TickerInfo";
            this.Size = new System.Drawing.Size(924, 308);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestBid;
        private DevExpress.XtraGrid.Columns.GridColumn colLowestAsk;
        private DevExpress.XtraGrid.Columns.GridColumn colLast;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colHr24High;
        private DevExpress.XtraGrid.Columns.GridColumn colHr24Low;
        private DevExpress.XtraGrid.Columns.GridColumn colChange;
        private DevExpress.XtraGrid.Columns.GridColumn colSpread;
        private DevExpress.XtraGrid.Columns.GridColumn colBidChange;
        private DevExpress.XtraGrid.Columns.GridColumn colAskChange;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdateTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
