using Microsoft.EntityFrameworkCore;
using StudentManagement.Application.Interfaces;
using StudentManagement.Domain.Entities;
using StudentManagement.Infrastructure.Data;

namespace StudentManagement.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Student>> GetAll()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetById(int id)
    {
        return await _context.Students.FindAsync(id);
    }

    public async Task<Student> Add(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
        return student;
    }

    public async Task<Student> Update(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
        return student;
    }

    public async Task<bool> Delete(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return false;

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
        return true;
    }
}