using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendDataView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Ваши друзья:");


            if (friends.Count() == 0)
            {
                Console.WriteLine("Пока никто не добавлен в друзья");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("{0} {1}, емейл: {2}", friend.FirstName, friend.LastName, friend.Email);
            });

        }

    }
}