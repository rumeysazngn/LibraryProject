using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Dtos
{
    public class MemberDto
    {
        public int MemberId { get; set; }
        public string MemberFullName { get; set; }
        public string MemberPhone { get; set; }
        public string MemberEmail { get; set; }
    }
}
