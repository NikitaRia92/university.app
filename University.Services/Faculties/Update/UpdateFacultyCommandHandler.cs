using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Faculties.Update
{
    public class UpdateFacultyCommandHandler : IRequestHandler<UpdateFacultyCommand, Faculty>
    {
        private readonly IFacultyRepository _repository;
        public UpdateFacultyCommandHandler(IFacultyRepository repository)
        {
            _repository = repository;
        }

        public async Task<Faculty> Handle(UpdateFacultyCommand command, CancellationToken token)
        {
            return await _repository.Update(command, token);
        }
    }
}
