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
            ((System.ComponentModel.ISupportInitialize)(this.tableDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSelectorListBox
            // 
            this.tableSelectorListBox.FormattingEnabled = true;
            this.tableSelectorListBox.ItemHeight = 20;
            this.tableSelectorListBox.Location = new System.Drawing.Point(28, 28);
            this.tableSelectorListBox.Name = "tableSelectorListBox";
            this.tableSelectorListBox.Size = new System.Drawing.Size(246, 524);
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
            this.tableDataView.Size = new System.Drawing.Size(759, 523);
            this.tableDataView.TabIndex = 1;
            // 
            // TableViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 629);
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
    }
}