namespace ScrollGrid_v15
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.panel = new System.Windows.Forms.Panel();
            this.dgAuswertung = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuswertung)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(867, 520);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(75, 23);
            this.ultraButton1.TabIndex = 0;
            this.ultraButton1.Text = "ultraButton1";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dgAuswertung);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(10);
            this.panel.Size = new System.Drawing.Size(930, 502);
            this.panel.TabIndex = 13;
            // 
            // dgAuswertung
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.dgAuswertung.DisplayLayout.Appearance = appearance1;
            this.dgAuswertung.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.dgAuswertung.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgAuswertung.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.dgAuswertung.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.dgAuswertung.DisplayLayout.GroupByBox.Hidden = true;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgAuswertung.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.dgAuswertung.DisplayLayout.InterBandSpacing = 0;
            this.dgAuswertung.DisplayLayout.MaxColScrollRegions = 1;
            this.dgAuswertung.DisplayLayout.MaxRowScrollRegions = 1;
            this.dgAuswertung.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.dgAuswertung.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            this.dgAuswertung.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            appearance5.BorderColor = System.Drawing.Color.Silver;
            appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.dgAuswertung.DisplayLayout.Override.CellAppearance = appearance5;
            this.dgAuswertung.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.dgAuswertung.DisplayLayout.Override.CellPadding = 0;
            this.dgAuswertung.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            this.dgAuswertung.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.dgAuswertung.DisplayLayout.Override.GroupByRowAppearance = appearance6;
            this.dgAuswertung.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.OncePerRowIsland;
            this.dgAuswertung.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.dgAuswertung.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.dgAuswertung.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.dgAuswertung.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.dgAuswertung.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.dgAuswertung.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.dgAuswertung.DisplayLayout.UseFixedHeaders = true;
            this.dgAuswertung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAuswertung.Location = new System.Drawing.Point(10, 10);
            this.dgAuswertung.Name = "dgAuswertung";
            this.dgAuswertung.Size = new System.Drawing.Size(910, 482);
            this.dgAuswertung.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 555);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ultraButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAuswertung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private System.Windows.Forms.Panel panel;
        private Infragistics.Win.UltraWinGrid.UltraGrid dgAuswertung;
    }
}

