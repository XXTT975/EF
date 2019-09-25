using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EF;
using System.Linq.Expressions;

namespace DAO
{
    public class StudentDAO : BaseDao<Student>, IStudentDAO<StudentModel>
    {
        public int Add(StudentModel t)
        {
            Student stu = new Student()
            {
                Name = t.Name
            };
            return Add(stu);
        }

        public int Delete(StudentModel t)
        {
            Student stu = new Student()
            {
                Id = t.Id
            };
            return Delete(stu);
        }

        public List<StudentModel> FenYe<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int currentPage, int PageSize, out int rows, out int page)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> SelectBy(Expression<Func<StudentModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Update(StudentModel t)
        {
            Student stu = new Student()
            {
                Id = t.Id,
                Name = t.Name
            };
            return Update(stu);
        }

        List<StudentModel> IDAO<StudentModel>.Select()
        {
            List<Student> list = Select();
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel sm = new StudentModel()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
