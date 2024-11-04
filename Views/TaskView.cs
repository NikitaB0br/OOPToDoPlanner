using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBobr
{
    public partial class TaskView : UserControl
    {
        Task task;
        List<Task> tasks;
        Action<List<Task>> show;
        public TaskView(Task task, List<Task> tasks, Action<List<Task>> func)
        {
            InitializeComponent();
            this.tasks = tasks;
            this.show = func;
            this.task = task;
            this.TitleLabel.Text = task.Title;
            this.DescriptionTextbox.Text = task.Description;
            this.DateLabel.Text = task.Date.ToShortDateString();
            this.StatusCheckbox.Checked = task.Status;
        }

        private void StatusCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Task taskModel = TaskContext.Instance.Tasks.Find(this.task.TaskId);
            taskModel.Status = this.StatusCheckbox.Checked;
            TaskContext.Instance.SaveChanges();
            //int idx = this.tasks.IndexOf(this.task);
            //this.tasks[idx].Status = this.StatusCheckbox.Checked;
            //this.show(this.tasks);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TaskContext.Instance.Tasks.Remove(task);
            TaskContext.Instance.SaveChanges();
            int idx = this.tasks.IndexOf(this.task);
            this.tasks.RemoveAt(idx);
            this.show(this.tasks);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm taskEditor = new EditForm(task, this.show);
            taskEditor.Show();
        }
    }
}
