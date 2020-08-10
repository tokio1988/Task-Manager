using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerWorking
{
    public class TaskModel
    {
        public string _description { get; set; }
        public DateTime _startDate { get; set; }
        public DateTime? _endDate { get; set; }
        public bool _isAllDay { get; set; }
        public bool _isImportant { get; set; }

        public TaskModel()
        {
            _description = null;
            _startDate = DateTime.Now;
            _endDate = null;
            _isAllDay = false;
            _isImportant = false;
        }
    }
}
