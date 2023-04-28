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
            this.editTablesButton = new System.Windows.Forms.Button();
            this.executeQueriesButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editTablesButton
            // 
            this.editTablesButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editTablesButton.Location = new System.Drawing.Point(37, 233);
            this.editTablesButton.Name = "editTablesButton";
            this.editTablesButton.Size = new System.Drawing.Size(378, 85);
            this.editTablesButton.TabIndex = 0;
            this.editTablesButton.Text = "Edit tables";
            this.editTablesButton.UseVisualStyleBackColor = true;
            this.editTablesButton.Click += new System.EventHandler(this.editTablesButton_Click);
            // 
            // executeQueriesButton
            // 
            this.executeQueriesButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executeQueriesButton.Location = new System.Drawing.Point(37, 356);
            this.executeQueriesButton.Name = "executeQueriesButton";
            this.executeQueriesButton.Size = new System.Drawing.Size(378, 83);
            this.executeQueriesButton.TabIndex = 1;
            this.executeQueriesButton.Text = "Execute queries";
            this.executeQueriesButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(37, 157);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(378, 39);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(37, 81);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(378, 39);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "Username";
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 473);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.executeQueriesButton);
            this.Controls.Add(this.editTablesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartMenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.StartMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editTablesButton;
        private Button executeQueriesButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}