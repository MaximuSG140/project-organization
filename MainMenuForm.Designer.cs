namespace ProjectOrganization
{
    partial class StartMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            editTablesButton = new Button();
            executeQueriesButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // editTablesButton
            // 
            editTablesButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            editTablesButton.Location = new Point(32, 175);
            editTablesButton.Margin = new Padding(3, 2, 3, 2);
            editTablesButton.Name = "editTablesButton";
            editTablesButton.Size = new Size(331, 64);
            editTablesButton.TabIndex = 0;
            editTablesButton.Text = "Edit tables";
            editTablesButton.UseVisualStyleBackColor = true;
            editTablesButton.Click += editTablesButton_Click;
            // 
            // executeQueriesButton
            // 
            executeQueriesButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            executeQueriesButton.Location = new Point(32, 267);
            executeQueriesButton.Margin = new Padding(3, 2, 3, 2);
            executeQueriesButton.Name = "executeQueriesButton";
            executeQueriesButton.Size = new Size(331, 62);
            executeQueriesButton.TabIndex = 1;
            executeQueriesButton.Text = "Execute queries";
            executeQueriesButton.UseVisualStyleBackColor = true;
            executeQueriesButton.Click += executeQueriesButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(32, 118);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(331, 32);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(32, 61);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(331, 32);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.Text = "Username";
            // 
            // StartMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 355);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(executeQueriesButton);
            Controls.Add(editTablesButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StartMenuForm";
            Text = "Menu";
            FormClosed += StartMenuForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editTablesButton;
        private Button executeQueriesButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}