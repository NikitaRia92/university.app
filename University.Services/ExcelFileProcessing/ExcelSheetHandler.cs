using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using University.Domain.Enums;
using University.Domain.Models;

namespace University.Services.ExcelFileProcessing;

public class ExcelSheetHandler
{
    public async Task<List<InvalidRowModel>> ExcelSheetValidation(IFormFile file)
    {
        byte[] bytes = await GetByteArrayFromExcelFile(file);

        ExcelPackage excelPackage = new ExcelPackage(new MemoryStream(bytes));//try catch
        var workSheet = excelPackage.Workbook.Worksheets[0];

        List<InvalidRowModel> invalidRows = new List<InvalidRowModel>();

        for (int row = 2; row <= workSheet.Dimension.End.Row; row++)
        {
            InvalidRowModel invalidRow = new InvalidRowModel();

            for (int column = 2; column <= workSheet.Dimension.End.Column; column++)
            {
                if (column == 9 || column == 10)
                {
                    continue;
                }

                var stringValue = workSheet.Cells[row, column].Value.ToString();


                if (column == 2)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = "Null or Empty: Applicant Code";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        foreach (char item in stringValue)
                        {
                            if (!char.IsLetterOrDigit(item) || stringValue.Length != 8)
                            {
                                string errorDescription = "Incorrect: ApplicantCode";
                                invalidRow.RowNumber = row;
                                invalidRow.Description += errorDescription;
                                invalidRows.Add(invalidRow);
                                break;
                            }
                        }
                    }
                }

                if (column == 3)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: FullNameofApplicant";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        foreach (char item in stringValue)
                        {
                            if (!char.IsLetter(item) && item != ' ' || stringValue.Length > 40)
                            {
                                string errorDescription = "Incorrect: FullNameofApplicant";
                                invalidRow.RowNumber = row;
                                invalidRow.Description += errorDescription;
                                invalidRows.Add(invalidRow);
                                break;
                            }
                        }
                    }
                }

                if (column == 4)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: FacultyCode";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        foreach (char item in stringValue)
                        {
                            if (!char.IsLetterOrDigit(item) || stringValue.Length != 5)
                            {
                                string errorDescription = "Incorrect: FacultyCode";
                                invalidRow.RowNumber = row;
                                invalidRow.Description += errorDescription;
                                invalidRows.Add(invalidRow);
                                break;
                            }
                        }
                    }
                }

                if (column == 5)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: SpecialtyCode";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        foreach (char item in stringValue)
                        {
                            if (!char.IsDigit(item) && item != '.' || stringValue.Length != 8)
                            {
                                string errorDescription = "Incorrect: SpecialtyCode";
                                invalidRow.RowNumber = row;
                                invalidRow.Description += errorDescription;
                                invalidRows.Add(invalidRow);
                                break;
                            }
                        }
                    }
                }

                if (column == 6)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: SchoolSertificat";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        if (stringValue.ToLower() != "yes" && stringValue.ToLower() != "no")
                        {
                            string errorDescription = "Incorrect: SchoolSertificat";
                            invalidRow.RowNumber = row;
                            invalidRow.Description += errorDescription;
                            invalidRows.Add(invalidRow);
                            continue;
                        }
                    }
                }

                if (column == 7)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: FormOfEducation";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        if (stringValue.ToLower() != "paid" && stringValue.ToLower() != "free")
                        {
                            string errorDescription = "Incorrect: FormOfEducation";
                            invalidRow.RowNumber = row;
                            invalidRow.Description += errorDescription;
                            invalidRows.Add(invalidRow);
                            continue;
                        }
                    }
                }

                if (column == 8)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: NumberOfPoint";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        foreach (char item in stringValue)
                        {
                            if (!char.IsDigit(item) || stringValue.Length != 3)
                            {
                                string errorDescription = " Incorrect: NumberOfPoint";
                                invalidRow.RowNumber = row;
                                invalidRow.Description += errorDescription;
                                invalidRows.Add(invalidRow);
                                break;
                            }
                        }
                    }
                }

                if (column == 11)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: DateSubmissionDocuments";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        if (DateTime.TryParse(stringValue, out _))
                        {
                            continue;
                        }
                        else
                        {
                            string errorDescription = " Incorrect: DateSubmissionDocuments";
                            invalidRow.RowNumber = row;
                            invalidRow.Description += errorDescription;
                            invalidRows.Add(invalidRow);
                            continue;
                        }
                    }
                }

                if (column == 12)
                {
                    if (String.IsNullOrEmpty(stringValue))
                    {
                        string errorDescription = " Null or Empty: EndDateAcceptanceDocuments";
                        invalidRow.RowNumber = row;
                        invalidRow.Description += errorDescription;
                        invalidRows.Add(invalidRow);
                        continue;
                    }
                    else
                    {
                        if (DateTime.TryParse(stringValue, out _))
                        {
                            continue;
                        }
                        else
                        {
                            string errorDescription = " Incorrect: EndDateAcceptanceDocuments";
                            invalidRow.RowNumber = row;
                            invalidRow.Description += errorDescription;
                            invalidRows.Add(invalidRow);
                            continue;
                        }
                    }
                }
            }
        }

        return invalidRows;
    }
    public async Task<List<Statement>> ExcelTableToModel(IFormFile file)
    {
        byte[] bytes = await GetByteArrayFromExcelFile(file);

        ExcelPackage excelPackage = new ExcelPackage(new MemoryStream(bytes));//try catch
        var workSheet = excelPackage.Workbook.Worksheets[0];


        List<Statement> statementsList = new List<Statement>();

        for (int row = 2; row <= workSheet.Dimension.End.Row; row++)
        {
            Statement statement = new Statement();
            for (int column = 2; column <= workSheet.Dimension.End.Column; column++)
            {
                var value = workSheet.Cells[row, column].Value;
                if (column == 9 || column == 10)
                {
                    continue;
                }

                if (column == 2)
                    statement.ApplicantCode = value.ToString();

                if (column == 3)
                    statement.FullNameOfApplicant = value.ToString();

                if (column == 4)
                    statement.FacultyCode = value.ToString();

                if (column == 5)
                    statement.SpecialtyCode = value.ToString();

                if (column == 6)
                {
                    if (value.ToString().ToLower() == "yes")
                        statement.SchoolCertificat = true;

                    if (value.ToString().ToLower() == "no")
                        statement.SchoolCertificat = false;
                }

                if (column == 7)
                {
                    if (value.ToString().ToLower() == "free")
                        statement.FormOfEducation = FormOfEducation.FreeOfCharge;

                    if (value.ToString().ToLower() == "paid")
                        statement.FormOfEducation = FormOfEducation.PaidBasis;
                }

                if (column == 8)
                    statement.NumberOfPointsScore = Convert.ToInt32(value);
                //statement.NumberOfPointsScore = int.Parse(value.ToString());

                if (column == 11)
                    statement.DateSubmissionDocuments = Convert.ToDateTime(value.ToString());//стринг или обьект

                if (column == 12)
                    statement.EndDateAcceptanceDocuments = Convert.ToDateTime(value);

            }

            statementsList.Add(statement);
            //foreach (var property in typeof(Statement).GetProperties())
            //{
            //    Console.WriteLine($"{property.Name} {property.GetValue(statement)}");
            //    Console.WriteLine("\n");

            //}
        }

        return statementsList;
    }

    private async Task<byte[]> GetByteArrayFromExcelFile(IFormFile file)
    {
        if (file != null)
        {
            if (!file.FileName.EndsWith(".xlsx"))
            {
                throw new Exception("Uploaded file is not in excel format");
            }
        }
        else
        {
            throw new Exception("Upload file is null");
        }
        using (var ms = new MemoryStream())
        {
            await file.CopyToAsync(ms);
            return ms.ToArray();
        }
    }
}
