using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBobr
{
    public partial class EditForm : OOPBobr.ActionForm
    {
        Task task;
        Action<List<Task>> show;
        public EditForm(Task task, Action<List<Task>> func)
        {
            InitializeComponent();
            this.task = task;
            this.show = func;
            this.TitleTextbox.Text = task.Title;
            this.DescriptionTextbox.Text = task.Description;
            this.dateTimePicker1.Value = task.Date;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DateTime datenow = dateTimePicker1.Value;
            if (datenow < DateTime.Today)
            {
                MessageBox.Show("Выберите дату, которая либо сегодняшняя, либо будущая.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TitleTextbox.Text))
            {
                MessageBox.Show("Ошибка: поле заголовка пустое или содержит только пробелы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Task task = TaskContext.Instance.Tasks.Find(this.task.TaskId);
            task.Title = this.TitleTextbox.Text;
            task.Description = this.DescriptionTextbox.Text;
            task.Date = this.dateTimePicker1.Value.Date;
            TaskContext.Instance.SaveChanges();
            List < Task > tasks = TaskContext.Instance.Tasks.ToList();
            this.show(tasks);
            this.Close();

        }
    }
}
