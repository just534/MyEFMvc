using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class StudentService
    {
        /// <summary>
        /// 根据班级Id获取学生列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Students> GetStuListByClassId(string id)
        {
            SMDBEntities SMDB = new SMDBEntities();
            int classid = Convert.ToInt32(id);
            var list = from s in SMDB.Students
                       where s.ClassId == classid
                       select s;
            List<Students> stulist = new List<Students>();
            foreach (var item in list)
            {
                stulist.Add(new Students()
                {
                    Age = item.Age,
                    Birthday = item.Birthday,
                    CardNo = item.CardNo,
                    ClassId = item.ClassId,
                    Gender = item.Gender,
                    PhoneNumber = item.PhoneNumber,
                    StudentAddress = item.StudentAddress,
                    StudentId = item.StudentId,
                    StudentIdNo = item.StudentIdNo,
                    StudentName = item.StudentName,
                    StuImage = item.StuImage
                });
            }
            return stulist;
        }

        public int GetStuCounts(string wheresql)
        {

            string sql = "select count(*) from Students";
            if (wheresql != null)
            {
                sql += " where " + wheresql;
            }
            try
            {
                using (SMDBEntities SMDB = new SMDBEntities())
                {
                    int stucount = SMDB.Database.SqlQuery<int>(sql).ToList()[0];
                    return stucount;
                };
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
