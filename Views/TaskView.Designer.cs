namespace OOPBobr
{
    partial class TaskView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StatusCheckbox = new System.Windows.Forms.CheckBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(30, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(90, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Заголовок";
            // 
            // StatusCheckbox
            // 
            this.StatusCheckbox.AutoSize = true;
            this.StatusCheckbox.Location = new System.Drawing.Point(994, 16);
            this.StatusCheckbox.Name = "StatusCheckbox";
            this.StatusCheckbox.Size = new System.Drawing.Size(103, 24);
            this.StatusCheckbox.TabIndex = 1;
            this.StatusCheckbox.Text = "Сделано";
            this.StatusCheckbox.UseVisualStyleBackColor = true;
            this.StatusCheckbox.CheckedChanged += new System.EventHandler(this.StatusCheckbox_CheckedChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(888, 16);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(89, 20);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "01.01.2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Срок выполнения задачи:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextbox.Enabled = false;
            this.DescriptionTextbox.Location = new System.Drawing.Point(35, 61);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(938, 99);
            this.DescriptionTextbox.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(994, 61);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 47);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(994, 111);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(103, 47);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.StatusCheckbox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "TaskView";
            this.Size = new System.Drawing.Size(1118, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckBox StatusCheckbox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
    }
}
