using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.Students.Create;
using University.Services.Students.Delete;
using Microsoft.EntityFrameworkCore;
using University.Services.Students.Update;

namespace University.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationContext _context;
    public StudentRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<Student> Create(CreateStudentCommand command, CancellationToken token)
    {  
        var student = new Student()
        {
            StudentCode = command.StudentCode,
            FacultyCode = command.FacultyCode,
            FormOfEducation = command.FormOfEducation,
            SpecialtyCode = command.SpecialtyCode,
            GroupNumber = command.GroupNumber,
            FullNameOfStudent = command.FullNameOfStudent,
            StudentEnrollmentDate = command.StudentEnrollmentDate,
            GraduationDate = command.GraduationDate,
            TuitionPayment = command.TuitionPayment

        };
        _context.Students.Add(student);
        await _context.SaveChangesAsync(token);
        return student;
    }

    public async Task<IReadOnlyCollection<Student>> GetAll(CancellationToken token)
    {
        return await _context.Students.ToListAsync(token);
    }

    public async Task<Student> Update(UpdateStudentCommand command, CancellationToken token)
    {
        var student = await _context.Students.FindAsync(command.StudentCode);

        if(student != null)
        {
            student.FacultyCode = command.FacultyCode;
            student.FormOfEducation = command.FormOfEducation;
            student.SpecialtyCode = command.SpecialtyCode;
            student.GroupNumber = command.GroupNumber;
            student.FullNameOfStudent = command.FullNameOfStudent;
            student.StudentEnrollmentDate = command.StudentEnrollmentDate;
            student.GraduationDate = command.GraduationDate;
            student.TuitionPayment = command.TuitionPayment;

            _context.Students.Update(student);
            await _context.SaveChangesAsync(token);
            return student;
        }
        else
        {
            throw new Exception("NOT FOUND");
        }
    }

    public async Task Delete(DeleteStudentCommand command, CancellationToken token)
    {
        var student = await _context.Students.FindAsync(command.StudentCode);
        if(student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync(token);
        }
    }
}
