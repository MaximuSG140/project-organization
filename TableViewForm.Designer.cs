namespace ProjectOrganization
{
    partial class TableViewForm
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
            this.tableSelectorListBox = new System.Windows.Forms.ListBox();
            this.tableDataView = new System.Windows.Forms.DataGridView();
            this.entityPropertiesRedactor = new System.Windows.Forms.PropertyGrid();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.removeSelectedRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSelectorListBox
            // 
            this.tableSelectorListBox.FormattingEnabled = true;
            this.tableSelectorListBox.ItemHeight = 20;
            this.tableSelectorListBox.Location = new System.Drawing.Point(14, 28);
            this.tableSelectorListBox.Name = "tableSelectorListBox";
            this.tableSelectorListBox.Size = new System.Drawing.Size(260, 364);
            this.tableSelectorListBox.TabIndex = 0;
            this.tableSelectorListBox.SelectedIndexChanged += new System.EventHandler(this.tableSelectorListBox_SelectedIndexChanged);
            // 
            // tableDataView
            // 
            this.tableDataView.AllowUserToAddRows = false;
            this.tableDataView.AllowUserToDeleteRows = false;
            this.tableDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataView.Location = new System.Drawing.Point(280, 29);
            this.tableDataView.Name = "tableDataView";
            this.tableDataView.RowHeadersWidth = 51;
            this.tableDataView.RowTemplate.Height = 29;
            this.tableDataView.Size = new System.Drawing.Size(759, 483);
            this.tableDataView.TabIndex = 1;
            // 
            // entityPropertiesRedactor
            // 
            this.entityPropertiesRedactor.Location = new System.Drawing.Point(1046, 28);
            this.entityPropertiesRedactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entityPropertiesRedactor.Name = "entityPropertiesRedactor";
            this.entityPropertiesRedactor.Size = new System.Drawing.Size(275, 364);
            this.entityPropertiesRedactor.TabIndex = 2;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRecordButton.Location = new System.Drawing.Point(1046, 399);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(275, 113);
            this.addRecordButton.TabIndex = 3;
            this.addRecordButton.Text = "Add record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // removeSelectedRowButton
            // 
            this.removeSelectedRowButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedRowButton.Location = new System.Drawing.Point(14, 399);
            this.removeSelectedRowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeSelectedRowButton.Name = "removeSelectedRowButton";
            this.removeSelectedRowButton.Size = new System.Drawing.Size(261, 113);
            this.removeSelectedRowButton.TabIndex = 4;
            this.removeSelectedRowButton.Text = "Remove selected";
            this.removeSelectedRowButton.UseVisualStyleBackColor = true;
            this.removeSelectedRowButton.Click += new System.EventHandler(this.removeSelectedRowButton_Click);
            // 
            // TableViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 522);
            this.Controls.Add(this.removeSelectedRowButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.entityPropertiesRedactor);
            this.Controls.Add(this.tableDataView);
            this.Controls.Add(this.tableSelectorListBox);
            this.Name = "TableViewForm";
            this.Text = "TableViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableViewForm_FormClosed);
            this.Load += new System.EventHandler(this.TableViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox tableSelectorListBox;
        private DataGridView tableDataView;
        private PropertyGrid entityPropertiesRedactor;
        private Button addRecordButton;
        private Button removeSelectedRowButton;
    }
}