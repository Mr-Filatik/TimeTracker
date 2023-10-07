using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Entity
{
    public class Case
    {
        public string Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = null;
        public Time Time { get; set; } = new Time();
    }
}
