using System;
using System.Threading.Tasks;

namespace Assignment_3
{
        public interface IRepository
    {

    Task<Item> CreateItem(Guid playerId, Item item);
    Task<Item> GetItem(Guid playerId, Guid itemId);
    Task<Item[]> GetAllItems(Guid playerId);
    Task<Item> ModifyItem(Guid playerId, Guid itemid, ModifiedItem item);
    Task<Item> DeleteItem(Guid playerId, Guid itemid);
    Task<Player> UpdatePlayerName(Guid id, UpdatedPlayerName player);
    Task<Player[]> GetPlayerMoreScore(int minScore);
    Task<Player[]> GetPlayerByTag(string tag);

    Task<Player> GetPlayer(Guid id);
    Task<Player[]> GetAllPlayers();
    Task<Player> CreatePlayer(Player player);
    Task<Player> ModifyPlayer(Guid id, ModifiedPlayer player);
    Task<Player> DeletePlayer(Guid id);
    }
}