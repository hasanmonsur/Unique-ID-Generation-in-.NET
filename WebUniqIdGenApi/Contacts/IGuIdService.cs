namespace WebUniqIdGenApi.Contacts
{
    public interface IGuIdService
    {
        string GetGuIdValue();
        string GetGuIdValue(string guId);
    }
}