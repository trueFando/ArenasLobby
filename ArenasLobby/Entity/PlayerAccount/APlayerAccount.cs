using Microsoft.AspNetCore.Mvc;

namespace ArenasLobby.Entity;

/**
 * Базовый класс аккаунта игрока
 */
public abstract class APlayerAccount
{
    public string Nickname { get; set; }
    
}