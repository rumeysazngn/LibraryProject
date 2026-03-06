using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Dtos
{
    public class OverdueDto
    {
        public int LoanId { get; set; }
        public string MemberFullName { get; set; }
        public string BookTitle { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public int DaysLate { get; set; }
    }
}
