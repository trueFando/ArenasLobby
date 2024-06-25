namespace ArenasLobby.Entity.LobbyRoom;

public class LobbyRoom
{
    public APlayerAccount[] Players;

    private const int _maxPlayers = 4;
    private int _currentSlotIndex;

    public LobbyRoom(APlayerAccount roomCreator)
    {
        Players = new APlayerAccount[_maxPlayers];
        Players[0] = roomCreator;
        _currentSlotIndex = 1;
    }

    public void AddPlayer(APlayerAccount player)
    {
        if (_currentSlotIndex == _maxPlayers)
        {
            // return error
        }
        
        
    }
}