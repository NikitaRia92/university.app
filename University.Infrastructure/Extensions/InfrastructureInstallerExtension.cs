using Microsoft.Extensions.DependencyInjection;
using University.Services.Interfaces;
using University.Infrastructure.Repositories;

namespace University.Infrastructure.Extensions;

public static class InfrastructureInstallerExtension
{

    public static IServiceCollection AddUniversityInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IFacultyRepository, FacultyRepository>();
        services.AddScoped<IConfirmationEnrollmentRepository, ConfirmationEnrollmentRepository>();
        services.AddScoped<IFormedGroupRepository, FormedGroupRepository>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        services.AddScoped<ISpecialityRepository, SpecialityRepository>();
        services.AddScoped<IStatementRepository, StatementRepository>();
        services.AddScoped<IStudentRepository, StudentRepository>();

        return services;
    }
}
