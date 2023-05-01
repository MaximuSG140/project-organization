namespace ProjectOrganization
{
    partial class ExecutePredefinedQueriesForm
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
            descriptionHeader = new Label();
            dataGridView = new DataGridView();
            descriptionTextBox = new TextBox();
            executeSelectedQueryButton = new Button();
            queryNumberSelector = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // descriptionHeader
            // 
            descriptionHeader.AutoSize = true;
            descriptionHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionHeader.Location = new Point(104, 9);
            descriptionHeader.Name = "descriptionHeader";
            descriptionHeader.Size = new Size(77, 17);
            descriptionHeader.TabIndex = 0;
            descriptionHeader.Text = "Description:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(107, 91);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(685, 352);
            dataGridView.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(107, 29);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new Size(684, 58);
            descriptionTextBox.TabIndex = 2;
            // 
            // executeSelectedQueryButton
            // 
            executeSelectedQueryButton.Location = new Point(6, 351);
            executeSelectedQueryButton.Name = "executeSelectedQueryButton";
            executeSelectedQueryButton.Size = new Size(95, 87);
            executeSelectedQueryButton.TabIndex = 4;
            executeSelectedQueryButton.Text = "Execute";
            executeSelectedQueryButton.UseVisualStyleBackColor = true;
            executeSelectedQueryButton.Click += executeSelectedQueryButton_Click;
            // 
            // queryNumberSelector
            // 
            queryNumberSelector.FormattingEnabled = true;
            queryNumberSelector.ItemHeight = 15;
            queryNumberSelector.Location = new Point(6, 31);
            queryNumberSelector.Name = "queryNumberSelector";
            queryNumberSelector.Size = new Size(95, 319);
            queryNumberSelector.TabIndex = 5;
            queryNumberSelector.SelectedIndexChanged += queryNumberSelector_SelectedIndexChanged;
            // 
            // ExecutePredefinedQueriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(queryNumberSelector);
            Controls.Add(executeSelectedQueryButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(dataGridView);
            Controls.Add(descriptionHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ExecutePredefinedQueriesForm";
            Text = "ExecutePredefinedQueriesForm";
            FormClosed += ExecutePredefinedQueriesForm_FormClosed;
            Load += ExecutePredefinedQueriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionHeader;
        private DataGridView dataGridView;
        private TextBox descriptionTextBox;
        private Button executeSelectedQueryButton;
        private ListBox queryNumberSelector;
    }
}