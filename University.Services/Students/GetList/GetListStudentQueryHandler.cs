using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Students.GetList;

public class GetListStudentQueryHandler : IRequestHandler<GetListStudentQuery, IReadOnlyCollection<Student>>
{
    private readonly IStudentRepository _repository;
    public GetListStudentQueryHandler(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<Student>> Handle(GetListStudentQuery request, CancellationToken token)
    {
        return await _repository.GetAll(token);
    }
}
