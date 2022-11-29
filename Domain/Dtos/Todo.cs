using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class Todo
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string StatusName
        {
            get { return Status.ToString(); }
        }
        public Status Status { get; set; }
    }
}
public enum Status
    {
        Todo,
        InProgress,
        Complete
    }