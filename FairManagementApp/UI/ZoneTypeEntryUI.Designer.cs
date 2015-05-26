namespace FairManagementApp.UI
{
    partial class ZoneTypeEntryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoneTypeEntryUI));
            this.zoneTypeListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveZoneTypeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneTypeNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneTypeListView
            // 
            this.zoneTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.zoneTypeListView.GridLines = true;
            this.zoneTypeListView.Location = new System.Drawing.Point(120, 174);
            this.zoneTypeListView.Name = "zoneTypeListView";
            this.zoneTypeListView.Size = new System.Drawing.Size(396, 189);
            this.zoneTypeListView.TabIndex = 3;
            this.zoneTypeListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serial No.";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 79;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone Type";
            this.columnHeader1.Width = 206;
            // 
            // saveZoneTypeButton
            // 
            this.saveZoneTypeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveZoneTypeButton.Location = new System.Drawing.Point(292, 83);
            this.saveZoneTypeButton.Name = "saveZoneTypeButton";
            this.saveZoneTypeButton.Size = new System.Drawing.Size(75, 23);
            this.saveZoneTypeButton.TabIndex = 2;
            this.saveZoneTypeButton.Text = "Save";
            this.saveZoneTypeButton.UseVisualStyleBackColor = true;
            this.saveZoneTypeButton.Click += new System.EventHandler(this.saveZoneTypeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Name";
            // 
            // zoneTypeNameEntryTextBox
            // 
            this.zoneTypeNameEntryTextBox.Location = new System.Drawing.Point(148, 43);
            this.zoneTypeNameEntryTextBox.Name = "zoneTypeNameEntryTextBox";
            this.zoneTypeNameEntryTextBox.Size = new System.Drawing.Size(219, 20);
            this.zoneTypeNameEntryTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.saveZoneTypeButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zoneTypeNameEntryTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(120, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ZoneType";
            // 
            // ZoneTypeEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 409);
            this.Controls.Add(this.zoneTypeListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneTypeEntryUI";
            this.Text = "Zone Type Entry UI";
            this.Load += new System.EventHandler(this.ZoneTypeEntryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView zoneTypeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button saveZoneTypeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zoneTypeNameEntryTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}