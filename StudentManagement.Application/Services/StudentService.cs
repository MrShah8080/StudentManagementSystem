using Mapster;
using StudentManagement.Application.DTOs;
using StudentManagement.Application.Interfaces;
using StudentManagement.Domain.Entities;

namespace StudentManagement.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<StudentDTO>> GetAll()
        {
            var students = await _repo.GetAll();

            return students.Adapt<List<StudentDTO>>();
        }

        public async Task<StudentDTO> Add(StudentDTO dto)
        {
            var student = dto.Adapt<Student>();

            var result = await _repo.Add(student);

            return result.Adapt<StudentDTO>();
        }

        public async Task<StudentDTO> Update(int id, StudentDTO dto)
        {
            var existing = await _repo.GetById(id);
            if (existing == null) return null;

            existing.Name = dto.Name;
            existing.Email = dto.Email;
            existing.Age = dto.Age;
            existing.Course = dto.Course;

            var updated = await _repo.Update(existing);

            return updated.Adapt<StudentDTO>();
        }

        public async Task<bool> Delete(int id)
        {
            return await _repo.Delete(id);
        }
    }
}