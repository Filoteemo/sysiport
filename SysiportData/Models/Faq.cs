using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysiportData.Models
{
    public class Faq
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public required Project Project { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public bool AIGenerated { get; set; }
    }
}
