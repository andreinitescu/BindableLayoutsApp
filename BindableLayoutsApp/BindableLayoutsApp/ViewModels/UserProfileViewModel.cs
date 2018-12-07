using System;
using Xamarin.Forms;

namespace BindableLayoutsApp
{
    class UserProfileViewModel
    {
        public User User { get; }

        public UserProfileViewModel()
        {
            User = GetUser();
        }

        static User GetUser()
        {
            return new User()
            {
                FavoriteSports = new FavoriteSport[]
                {
                    new FavoriteSport() { Name = "Basketball", Sport = Sport.Baskeball },
                    new FavoriteSport() { Name = "Running", Sport = Sport.Running },
                    new FavoriteSport() { Name = "Swimming", Sport = Sport.Swimming },
                },
                TopFollowers = new Follower[] {
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars0.githubusercontent.com/u/36863?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars1.githubusercontent.com/u/56260?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars1.githubusercontent.com/u/41873?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars2.githubusercontent.com/u/30443?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars0.githubusercontent.com/u/313003?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars0.githubusercontent.com/u/538025?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars2.githubusercontent.com/u/5375137?s=400&v=4") }},
                    new Follower() { Avatar = new UriImageSource() { Uri = new Uri("https://avatars3.githubusercontent.com/u/1235097?s=400&v=4") }},
                },
                FavoriteTech = new string[]
                {
                    ".NET", "C#", "F#", "Azure", "Xamarin", "Xamarin Forms", "XAML"
                }
            };
        }
    }
}
