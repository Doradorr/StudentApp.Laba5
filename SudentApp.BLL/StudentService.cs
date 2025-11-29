using System.Collections.Generic;
using System.Linq;
using StudentApp.DAL;

namespace StudentApp.BLL
{
    public class StudentService
    {
        private readonly StudentRepository _repository;

        public StudentService(StudentRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetIdealWeightStudents()
        {
            var list = _repository.Load();

            return list.Where(s => s.HasIdealWeight).ToList();
        }
    }
}

