namespace OOPBobr
{
    partial class EditForm
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
            this.SuspendLayout();
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DescriptionTextbox.Size = new System.Drawing.Size(210, 65);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightGreen;
            this.SubmitButton.Location = new System.Drawing.Point(22, 201);
            this.SubmitButton.Size = new System.Drawing.Size(266, 43);
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 268);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "EditForm";
            this.Text = "Изменить задачу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}