namespace FairManagementApp.UI
{
    partial class VisitorDetailsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorDetailsUI));
            this.loadVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadVisitorListView
            // 
            this.loadVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.loadVisitorListView.GridLines = true;
            this.loadVisitorListView.Location = new System.Drawing.Point(130, 106);
            this.loadVisitorListView.Name = "loadVisitorListView";
            this.loadVisitorListView.Size = new System.Drawing.Size(381, 194);
            this.loadVisitorListView.TabIndex = 10;
            this.loadVisitorListView.UseCompatibleStateImageBehavior = false;
            this.loadVisitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Visitor Name";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 125;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showButton.Location = new System.Drawing.Point(398, 55);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Zone";
            // 
            // selectZoneComboBox
            // 
            this.selectZoneComboBox.FormattingEnabled = true;
            this.selectZoneComboBox.Location = new System.Drawing.Point(199, 55);
            this.selectZoneComboBox.Name = "selectZoneComboBox";
            this.selectZoneComboBox.Size = new System.Drawing.Size(181, 21);
            this.selectZoneComboBox.TabIndex = 14;
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportToExcelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportToExcelButton.Location = new System.Drawing.Point(412, 318);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(99, 23);
            this.exportToExcelButton.TabIndex = 13;
            this.exportToExcelButton.Text = "Export to Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = false;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(280, 320);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total";
            // 
            // VisitorDetailsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 389);
            this.Controls.Add(this.loadVisitorListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectZoneComboBox);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.Name = "VisitorDetailsUI";
            this.Text = "Zone Type Wise Visitor Information Report";
            this.Load += new System.EventHandler(this.VisitorDetailsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView loadVisitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectZoneComboBox;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label2;
    }
}