namespace Code.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> errors = new()
    {
        {"AlreadyExistException","This record already exists"},
        {"NotFoundException","This record was not found"},
        {"InvalidDataException","Invalid data"},
        {"NotImplementedException","This method is not implemented"},
        {"Exception","An error occurred"},
        {"SizeException","Size don't match" }
    };

}
