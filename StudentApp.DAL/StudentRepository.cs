using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace StudentApp.DAL
{
    public class StudentRepository
    {
        private readonly string _filePath = "students.json";

        public virtual void Save(List<Student> students)
        {
            var json = JsonSerializer.Serialize(students);
            File.WriteAllText(_filePath, json);
        }

        public virtual List<Student> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Student>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Student>>(json);
        }
    }
}

