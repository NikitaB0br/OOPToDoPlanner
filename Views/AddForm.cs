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
    public partial class AddForm : OOPBobr.ActionForm
    {
        List<Task> tasks;
        Action<List<Task>> show;
        public AddForm(List<Task> tasks, Action<List<Task>> func)
        {
            this.tasks = tasks;
            this.show = func;
            InitializeComponent();
            
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
            Task task = new Task();
            task.Title = this.TitleTextbox.Text;
            task.Description = this.DescriptionTextbox.Text;
            task.Date = this.dateTimePicker1.Value.Date;
            task.Status = false;
            TaskContext.Instance.Tasks.Add(task);
            TaskContext.Instance.SaveChanges();
            this.tasks.Add(task);
            this.show(tasks);
            this.Close();
            
        }
    }
}