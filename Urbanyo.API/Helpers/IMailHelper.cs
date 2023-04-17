using Sales.shared.Responses;

namespace Urbanyo.API.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }

}
