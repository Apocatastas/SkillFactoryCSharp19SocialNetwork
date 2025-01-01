using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        public AddFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddFriendData();

                Console.WriteLine("Введите емейл пользователя для добавления в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Друг добавлен успешно!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении в друзья");
            }

        }
    }
}