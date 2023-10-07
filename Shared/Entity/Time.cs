using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Entity
{
    public class Time
    {
        public int Hour { get; set; } = default;
        public int Minute { get; set; } = default;
        public int Second { get; set; } = default;
    }
}
