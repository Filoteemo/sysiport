using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysiportData.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public required Project Project { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
    }
}
