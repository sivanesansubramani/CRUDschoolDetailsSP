using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDschoolDetails.Model
{
   public class SchoolDetailsModel
   {
            public int PrimaryKeyId { get; set; }
            public string SchoolName { get; set; }
            public string OwnerName { get; set; }
            public string address { get; set; }
            public String location { get; set; }
            public String NoofStudents { get; set; }
            

    }
}
