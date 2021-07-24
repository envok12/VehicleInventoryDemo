namespace VheicleInventory
{
    partial class VehicleInventoryForm
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newVehicleFormTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.VINLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryListTab = new System.Windows.Forms.TabPage();
            this.inventorySummaryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.newVehicleFormTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.inventoryListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // newVehicleFormTab
            // 
            this.newVehicleFormTab.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.newVehicleFormTab.Controls.Add(this.tabPage1);
            this.newVehicleFormTab.Controls.Add(this.inventoryListTab);
            this.newVehicleFormTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.newVehicleFormTab.Location = new System.Drawing.Point(0, 0);
            this.newVehicleFormTab.Multiline = true;
            this.newVehicleFormTab.Name = "newVehicleFormTab";
            this.newVehicleFormTab.SelectedIndex = 0;
            this.newVehicleFormTab.Size = new System.Drawing.Size(800, 444);
            this.newVehicleFormTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.VINTextBox);
            this.tabPage1.Controls.Add(this.licensePlateTextBox);
            this.tabPage1.Controls.Add(this.cbType);
            this.tabPage1.Controls.Add(this.typeLabel);
            this.tabPage1.Controls.Add(this.VINLabel);
            this.tabPage1.Controls.Add(this.licenseLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Vehicle Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // VINTextBox
            // 
            this.VINTextBox.Location = new System.Drawing.Point(210, 167);
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(121, 22);
            this.VINTextBox.TabIndex = 6;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.Location = new System.Drawing.Point(210, 118);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(121, 22);
            this.licensePlateTextBox.TabIndex = 5;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cbType.Location = new System.Drawing.Point(210, 213);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 4;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(110, 220);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type";
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(110, 167);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(30, 17);
            this.VINLabel.TabIndex = 2;
            this.VINLabel.Text = "VIN";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(107, 118);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(57, 17);
            this.licenseLabel.TabIndex = 1;
            this.licenseLabel.Text = "License";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Vehicle Form";
            // 
            // inventoryListTab
            // 
            this.inventoryListTab.Controls.Add(this.inventorySummaryTextBox);
            this.inventoryListTab.Controls.Add(this.inventoryListBox);
            this.inventoryListTab.Location = new System.Drawing.Point(4, 4);
            this.inventoryListTab.Name = "inventoryListTab";
            this.inventoryListTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryListTab.Size = new System.Drawing.Size(771, 436);
            this.inventoryListTab.TabIndex = 1;
            this.inventoryListTab.Text = "Inventory List";
            this.inventoryListTab.UseVisualStyleBackColor = true;
            // 
            // inventorySummaryTextBox
            // 
            this.inventorySummaryTextBox.Location = new System.Drawing.Point(48, 313);
            this.inventorySummaryTextBox.Multiline = true;
            this.inventorySummaryTextBox.Name = "inventorySummaryTextBox";
            this.inventorySummaryTextBox.ReadOnly = true;
            this.inventorySummaryTextBox.Size = new System.Drawing.Size(299, 91);
            this.inventorySummaryTextBox.TabIndex = 1;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 16;
            this.inventoryListBox.Location = new System.Drawing.Point(48, 33);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(299, 212);
            this.inventoryListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(241, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 22);
            this.textBox3.TabIndex = 8;
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newVehicleFormTab);
            this.Name = "VehicleInventoryForm";
            this.Size = new System.Drawing.Size(800, 450);
            this.newVehicleFormTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.inventoryListTab.ResumeLayout(false);
            this.inventoryListTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl newVehicleFormTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage inventoryListTab;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VINTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox inventorySummaryTextBox;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addButton;
    }
}
