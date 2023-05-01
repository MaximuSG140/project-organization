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
            tableSelectorListBox = new ListBox();
            tableDataView = new DataGridView();
            entityPropertiesRedactor = new PropertyGrid();
            addRecordButton = new Button();
            removeSelectedRowButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tableDataView).BeginInit();
            SuspendLayout();
            // 
            // tableSelectorListBox
            // 
            tableSelectorListBox.FormattingEnabled = true;
            tableSelectorListBox.ItemHeight = 15;
            tableSelectorListBox.Location = new Point(12, 21);
            tableSelectorListBox.Margin = new Padding(3, 2, 3, 2);
            tableSelectorListBox.Name = "tableSelectorListBox";
            tableSelectorListBox.Size = new Size(228, 289);
            tableSelectorListBox.TabIndex = 0;
            tableSelectorListBox.SelectedIndexChanged += tableSelectorListBox_SelectedIndexChanged;
            // 
            // tableDataView
            // 
            tableDataView.AllowUserToAddRows = false;
            tableDataView.AllowUserToDeleteRows = false;
            tableDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDataView.Location = new Point(245, 22);
            tableDataView.Margin = new Padding(3, 2, 3, 2);
            tableDataView.Name = "tableDataView";
            tableDataView.RowHeadersWidth = 51;
            tableDataView.RowTemplate.Height = 29;
            tableDataView.Size = new Size(664, 393);
            tableDataView.TabIndex = 1;
            // 
            // entityPropertiesRedactor
            // 
            entityPropertiesRedactor.Location = new Point(915, 21);
            entityPropertiesRedactor.Name = "entityPropertiesRedactor";
            entityPropertiesRedactor.Size = new Size(241, 293);
            entityPropertiesRedactor.TabIndex = 2;
            // 
            // addRecordButton
            // 
            addRecordButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addRecordButton.Location = new Point(915, 320);
            addRecordButton.Name = "addRecordButton";
            addRecordButton.Size = new Size(241, 95);
            addRecordButton.TabIndex = 3;
            addRecordButton.Text = "Add record";
            addRecordButton.UseVisualStyleBackColor = true;
            addRecordButton.Click += addRecordButton_Click;
            // 
            // removeSelectedRowButton
            // 
            removeSelectedRowButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeSelectedRowButton.Location = new Point(12, 320);
            removeSelectedRowButton.Name = "removeSelectedRowButton";
            removeSelectedRowButton.Size = new Size(228, 95);
            removeSelectedRowButton.TabIndex = 4;
            removeSelectedRowButton.Text = "Remove selected";
            removeSelectedRowButton.UseVisualStyleBackColor = true;
            removeSelectedRowButton.Click += removeSelectedRowButton_Click;
            // 
            // TableViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 429);
            Controls.Add(removeSelectedRowButton);
            Controls.Add(addRecordButton);
            Controls.Add(entityPropertiesRedactor);
            Controls.Add(tableDataView);
            Controls.Add(tableSelectorListBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TableViewForm";
            Text = "TableViewForm";
            FormClosed += TableViewForm_FormClosed;
            Load += TableViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)tableDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox tableSelectorListBox;
        private DataGridView tableDataView;
        private PropertyGrid entityPropertiesRedactor;
        private Button addRecordButton;
        private Button removeSelectedRowButton;
    }
}