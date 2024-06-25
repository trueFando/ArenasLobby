using System.Net;

namespace ArenasLobby.Controller;

public class CreateLobbyController
{
    public HttpResponseMessage GetData()
    {
        
        return new HttpResponseMessage(HttpStatusCode.OK);
    }
}