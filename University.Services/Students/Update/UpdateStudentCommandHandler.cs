using MediatR;
using University.Domain.Models;
using University.Services.Interfaces;

namespace University.Services.Students.Update
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly IStudentRepository _repository;
        public UpdateStudentCommandHandler(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Student> Handle(UpdateStudentCommand command, CancellationToken token)
        {
            return await _repository.Update(command, token);
        }
    }
}
