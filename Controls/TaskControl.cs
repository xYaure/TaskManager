using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManager.Controls
{
    public partial class TaskControl : UserControl
    {
        public int TaskId { get; }

        public TaskControl(int taskId, string title)
        {
            InitializeComponent();
            TaskId = taskId;
            lblTitle.Text = title;

            this.MouseDown += StartDrag;
            EnableDragOnChildren(this);
        }

        private void StartDrag(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var data = new DataObject();
            data.SetData(typeof(Control), this);     // <-- DODAJ TO
            data.SetData(typeof(TaskControl), this); // (opcjonalnie)

            DoDragDrop(data, DragDropEffects.Move);
        }

        private void EnableDragOnChildren(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseDown += StartDrag;
                if (c.HasChildren) EnableDragOnChildren(c);
            }
        }
    }
}
