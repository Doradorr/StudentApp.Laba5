using Xunit;
using StudentApp.BLL;
using StudentApp.DAL;
using System.Collections.Generic;

namespace StudentApp.Tests
{
    public class FakeRepository : StudentRepository
    {
        public List<Student> Data = new();

        public override List<Student> Load() => Data;
        public override void Save(List<Student> students) => Data = students;
    }

    public class StudentServiceTests
    {
        [Fact]
        public void Should_ReturnStudentsWithIdealWeight()
        {
            
            var repo = new FakeRepository();
            repo.Data = new List<Student>
            {
                new Student { Height=180, Weight=70 },   
                new Student { Height=165, Weight=60 },   
                new Student { Height=150, Weight=40 }    
            };

            var service = new StudentService(repo);

            
            var result = service.GetIdealWeightStudents();

            
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void LoseWeight_ShouldTriggerIdealWeight()
        {
            var student = new Student { Height = 180, Weight = 75 };

            bool isIdeal = student.LoseWeight(5);

            Assert.True(isIdeal);
        }
    }
}
