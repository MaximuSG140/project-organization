namespace ProjectOrganization
{
    partial class AskForQueryParameterValueForm
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
            parameterValueEdit = new TextBox();
            parameterNameLabel = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // parameterValueEdit
            // 
            parameterValueEdit.Location = new Point(42, 59);
            parameterValueEdit.Name = "parameterValueEdit";
            parameterValueEdit.Size = new Size(267, 23);
            parameterValueEdit.TabIndex = 0;
            // 
            // parameterNameLabel
            // 
            parameterNameLabel.AutoSize = true;
            parameterNameLabel.Location = new Point(42, 31);
            parameterNameLabel.Name = "parameterNameLabel";
            parameterNameLabel.Size = new Size(38, 15);
            parameterNameLabel.TabIndex = 1;
            parameterNameLabel.Text = "label1";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(65, 110);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(218, 48);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // AskForQueryParameterValueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 183);
            Controls.Add(confirmButton);
            Controls.Add(parameterNameLabel);
            Controls.Add(parameterValueEdit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AskForQueryParameterValueForm";
            Text = "Enter parameter value";
            FormClosed += AskForQueryParameterValueForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox parameterValueEdit;
        private Label parameterNameLabel;
        private Button confirmButton;
    }
}