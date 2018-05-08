using System.Collections.Generic;
using FriendOrganizer.Domain;

namespace FriendOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}