using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL; 

namespace BLL
{
    public class StudentManager
    {
        public List<Students> GetStudentsListByclassId(string id)
        {
            return new StudentService().GetStuListByClassId(id);
        }
        public int GetStuCount(string wheresql)
        {
            return new StudentService().GetStuCounts(wheresql);
        }
    }
}
