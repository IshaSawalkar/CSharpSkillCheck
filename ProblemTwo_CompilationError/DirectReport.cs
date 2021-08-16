using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport: Employee 
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }
        public string V { get; }
        public object P { get; }

        //public DirectReport(Employee managerEmpObj, string pCode) : base (eID, eName, eLevel, eDoJ)
        /*public DirectReport(Employee managerEmpObj, string pCode) : base (eID, eName, eLevel, eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }*/
        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, Employee managerEmpObj, string pCode) : base(eID, eName, eLevel, eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;

        }
        /*public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, object p)
        {
            
        }

        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, object p, string v) : base (eID, eName, eLevel, eDoJ, p)
        {
            V = v;
        }

        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, object p) : base(eID, eName, eLevel, eDoJ)
        {
            P = p;
        }*/
    }
}
