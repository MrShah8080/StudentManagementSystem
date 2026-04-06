using StudentManagement.Application.DTOs;

namespace StudentManagement.Application.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentDTO>> GetAll();
        Task<StudentDTO> Add(StudentDTO dto);
        Task<StudentDTO> Update(int id, StudentDTO dto);
        Task<bool> Delete(int id);
    }
}