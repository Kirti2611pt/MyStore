using Microsoft.Extensions.Primitives;

namespace MyStore.Pages.Clients
{
    public class ClientInfo
    {
        internal StringValues name;
        internal StringValues email;
        internal StringValues phone;
        internal StringValues address;
        internal int name_Length;
        internal int email_Length;
        internal int phone_Length;
        internal int address_Length;
    }
}