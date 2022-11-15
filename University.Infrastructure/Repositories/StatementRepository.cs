using University.Services.Interfaces;
using University.Domain.Models;
using University.Services.Statements.Create;
using University.Services.Statements.Delete;
using Microsoft.EntityFrameworkCore;
using University.Services.Statements.Update;
using University.Domain.Enums;
using University.Services.Statements.AddFromFile;
using University.Services.ExcelFileProcessing;
using OfficeOpenXml;

namespace University.Infrastructure.Repositories;

public class StatementRepository : IStatementRepository
{
    private readonly ApplicationContext _context;
    public StatementRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<Statement> Create(CreateStatementCommand command, CancellationToken token)
    {
        var statement = new Statement()
        {
            ApplicantCode = command.ApplicantCode,
            FullNameOfApplicant = command.FullNameOfApplicant,
            FormOfEducation = command.FormOfEducation,
            SchoolCertificat = command.SchoolCertificat,
            NumberOfPointsScore = command.NumberOfPointsScore,
            FacultyCode = command.FacultyCode,
            SpecialtyCode = command.SpecialtyCode,
            DateSubmissionDocuments = command.DateSubmissionDocuments,
            EndDateAcceptanceDocuments = command.EndDateAcceptanceDocuments,
            Confirmation = command.Confirmation
        };
        _context.Statements.Add(statement);
        await _context.SaveChangesAsync(token);
        return statement;
    }

    public async Task<IReadOnlyCollection<Statement>> GetAll(CancellationToken token)
    {
        return await _context.Statements.ToListAsync(token);
    }

    public async Task<Statement> Update(UpdateStatementCommand command, CancellationToken token)
    {
        var statement = await _context.Statements.FindAsync(command.ApplicantCode);

        if(statement != null)
        {
            statement.FullNameOfApplicant = command.FullNameOfApplicant;
            statement.FormOfEducation = command.FormOfEducation;
            statement.SchoolCertificat = command.SchoolCertificat;
            statement.NumberOfPointsScore = command.NumberOfPointsScore;
            statement.FacultyCode = command.FacultyCode;
            statement.SpecialtyCode = command.SpecialtyCode;
            statement.DateSubmissionDocuments = command.DateSubmissionDocuments;
            statement.Confirmation = command.Confirmation;
            statement.EndDateAcceptanceDocuments = command.EndDateAcceptanceDocuments;

            _context.Statements.Update(statement);
            await _context.SaveChangesAsync(token);
            return statement;
        }
        else
        {
            throw new Exception("Statement.Update -record NOT FOUND");
        }
    }

    public async Task Delete(DeleteStatementCommand command, CancellationToken token)
    {
        var statement = await _context.Statements.FindAsync(command.ApplicantCode);
        if(statement != null)
        {
            _context.Statements.Remove(statement);
            await _context.SaveChangesAsync(token);
        }
    }

    public async Task<IReadOnlyCollection<InvalidRowModel>> Import(AddListStatementCommand file, CancellationToken token)
    {
        ExcelSheetHandler sheetHandler = new ExcelSheetHandler();
        List<InvalidRowModel> errorRows = await sheetHandler.ExcelSheetValidation(file.file);
        if (errorRows.Count > 0)
        {
            return errorRows;
        }
        
        List<Statement> statementsList = await sheetHandler.ExcelTableToModel(file.file);
        _context.Statements.AddRange(statementsList);
        await _context.SaveChangesAsync(token);
        return errorRows;
    }
}
