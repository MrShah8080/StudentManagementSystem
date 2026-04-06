using Mapster;
using StudentManagement.Application.DTOs;
using StudentManagement.Domain.Entities;

namespace StudentManagement.Application.Mappings
{
    public static class MappingConfig
    {
        public static void RegisterMappings()
        {
            // DTO  to Entity
            TypeAdapterConfig<StudentDTO, Student>.NewConfig();

            // Entity to DTO
            TypeAdapterConfig<Student, StudentDTO>.NewConfig();
        }
    }
}