using MediatR;
using Microsoft.Extensions.DependencyInjection;
using University.Domain.Models;
using University.Services.ConfirmationEnrollments.Create;
using University.Services.ConfirmationEnrollments.Delete;
using University.Services.ConfirmationEnrollments.GetList;
using University.Services.ConfirmationEnrollments.Update;
using University.Services.ExcelFileProcessing;
using University.Services.Faculties.Create;
using University.Services.Faculties.Delete;
using University.Services.Faculties.GetList;
using University.Services.Faculties.Update;
using University.Services.FormedGroups.Create;
using University.Services.FormedGroups.Delete;
using University.Services.FormedGroups.GetList;
using University.Services.FormedGroups.Update;
using University.Services.Groups.Create;
using University.Services.Groups.Delete;
using University.Services.Groups.GetList;
using University.Services.Groups.Update;
using University.Services.Specialities.Create;
using University.Services.Specialities.Delete;
using University.Services.Specialities.GetList;
using University.Services.Specialities.Update;
using University.Services.Statements.AddFromFile;
using University.Services.Statements.Create;
using University.Services.Statements.Delete;
using University.Services.Statements.GetList;
using University.Services.Statements.Update;
using University.Services.Students.Create;
using University.Services.Students.Delete;
using University.Services.Students.GetList;
using University.Services.Students.Update;

namespace University.Services;

public static class ServicesInstallerExtention
{
    public static IServiceCollection AddUniversityServices(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<GetListFacultyQuery, IReadOnlyCollection<Faculty>>
            , GetListFacultyQueryHandler>();
        services.AddScoped<IRequestHandler<CreateFacultyCommand, Faculty>, CreateFacultyCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteFacultyCommand, Unit>, DeleteFacultyCommandHandler>();
        services.AddScoped<IRequestHandler<UpdateFacultyCommand, Faculty>, UpdateFacultyCommandHandler>();


        services.AddScoped<IRequestHandler<CreateSpecialityCommand, Speciality>, CreateSpecialityCommandHandler>();
        services.AddScoped<IRequestHandler<GetListSpecialityQuery, IReadOnlyCollection<Speciality>>
            , GetListSpecialityQueryHandler>();
        services.AddScoped<IRequestHandler<UpdateSpecialityCommand, Speciality>, UpdateSpecialityCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteSpecialityCommand, Unit>, DeleteSpecialityCommandHandler>();


        services.AddScoped<IRequestHandler<CreateConfirmationEnrollmentCommand, ConfirmationEnrollment>
            ,CreateConfirmationEnrollmentCommandHandler>();
        services.AddScoped<IRequestHandler<GetListConfirmationEnrollmentQuery, IReadOnlyCollection<ConfirmationEnrollment>>
            , GetListConfirmationEnrollmentQueryHandler>();
        services.AddScoped<IRequestHandler<UpdateConfirmationEnrollmentCommand, ConfirmationEnrollment>
            , UpdateConfirmationEnrollmentCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteConfirmationEnrollmentCommand, Unit>
            , DeleteConfirmationEnrollmentCommandHandler>();


        services.AddScoped<IRequestHandler<CreateFormedGroupCommand, FormedGroup>, CreateFormedGroupCommandHandler>();
        services.AddScoped<IRequestHandler<GetListFormedGroupQuery, IReadOnlyCollection<FormedGroup>>
            , GetListFormedGroupQueryHandler>();
        services.AddScoped<IRequestHandler<UpdateFormedGroupCommand, FormedGroup>, UpdateFormedGroupCommannHandler>();
        services.AddScoped<IRequestHandler<DeleteFormedGroupCommand, Unit>, DeleteFormedGroupCommandHandler>();


        services.AddScoped<IRequestHandler<CreateGroupCommand, Group>, CreateGroupCommandHandler>();
        services.AddScoped<IRequestHandler<GetListGroupQuery, IReadOnlyCollection<Group>>
            , GetListGroupQueryHandler>();
        services.AddScoped<IRequestHandler<UpdateGroupCommand, Group>, UpdateGroupCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteGroupCommand, Unit>, DeleteGroupCommandHandler>();


        services.AddScoped<IRequestHandler<CreateStatementCommand, Statement>, CreateStatementCommandHandler>();
        services.AddScoped<IRequestHandler<GetListStatementQuery, IReadOnlyCollection<Statement>>
            , GetListStatementQueryHandler>();
        services.AddScoped<IRequestHandler<UpdateStatementCommand, Statement>, UpdateStatementCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteStatementCommand, Unit>, DeleteStatementCommandHandler>();
        services.AddScoped<IRequestHandler<AddListStatementCommand, IReadOnlyCollection<InvalidRowModel>>, AddListStatementCommandHandler>();


        services.AddScoped<IRequestHandler<CreateStudentCommand, Student>, CreateStudentCommandHandler>();
        services.AddScoped<IRequestHandler<GetListStudentQuery, IReadOnlyCollection<Student>>
            , GetListStudentQueryHandler>();
        services.AddScoped<IRequestHandler<UpdateStudentCommand, Student>, UpdateStudentCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteStudentCommand, Unit>, DeleteStudentCommandHandler>();



        return services;
    }
}
