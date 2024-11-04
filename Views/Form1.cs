using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBobr
{
    public partial class Form1 : Form
    {
        int taskNumber = 0;
        public List<Task> tasks = new List<Task>();
        public Form1()
        {
            this.tasks = TaskContext.Instance.Tasks.ToList();
            InitializeComponent();
            this.showTasks(tasks);
        }

        public void showTasks(List<Task> tasks)
        {
            taskNumber = 0;
            TaskContainer.Controls.Clear();
            foreach (Task task in tasks)
            {
                TaskView taskElement = new TaskView(task, tasks, this.showTasks)
                {
                    Location = new Point(0, 120 * taskNumber),
                };
                TaskContainer.Controls.Add(taskElement);
                taskNumber++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this.tasks, this.showTasks);
            addForm.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            showTasks(this.tasks);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = this.dateTimePicker1.Value.Date;
            List<Task> filtredTasks = this.tasks.FindAll(item => item.Date == dateTime);
            this.showTasks(filtredTasks);
        }
    }
}
