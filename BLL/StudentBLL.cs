using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using IBLL;
using DAO;
using System.Linq.Expressions;

namespace BLL
{
    public class StudentBLL : IStudentBLL<StudentModel>
    {
        IStudentDAO<StudentModel> sd = new StudentDAO();
        public int Add(StudentModel t)
        {
            return sd.Add(t);
        }

        public int Delete(StudentModel t)
        {
            return sd.Delete(t);
        }

        public List<StudentModel> FenYe<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int currentPage, int PageSize, out int rows, out int page)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> Select()
        {
            return sd.Select();
        }

        public List<StudentModel> SelectBy(Expression<Func<StudentModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Update(StudentModel t)
        {
            return sd.Update(t);
        }
    }
}
