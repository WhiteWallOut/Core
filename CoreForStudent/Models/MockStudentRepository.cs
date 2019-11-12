using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreForStudent.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;
        public MockStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student(){Id=1,Name="张三",ClassName="一年级",Email="Tonyzhang@163.com"},
                new Student(){Id=2,Name="李四",ClassName="二年级",Email="Liaypeng@163.com"},
                new Student(){Id=3,Name="王五",ClassName="三年级",Email="JackSon@163.com"}
            };
          
        }
      
        public  Student GetStudent(int id)
        {
           return _students.FirstOrDefault(x => x.Id == id);
        }
    }
}
