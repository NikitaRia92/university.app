using MediatR;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using University.Domain.Models;
using University.Services.ExcelFileProcessing;

namespace University.Services.Statements.AddFromFile;

public record AddListStatementCommand(IFormFile file) : IRequest<IReadOnlyCollection<InvalidRowModel>>
{

}
