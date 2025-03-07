using StudentDetailsExcersie.Model;

namespace StudentDetailsExcersie.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student?>GetById(int id);
        Task<Student> CreateStudent(Student student);
        Task<Student> UpdateStudent(int id,Student student);
    }
}
