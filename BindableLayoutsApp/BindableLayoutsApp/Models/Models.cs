using System.Collections.Generic;
using Xamarin.Forms;

namespace BindableLayoutsApp
{
    class User
    {
        public IEnumerable<FavoriteSport> FavoriteSports { get; set; }
        public IEnumerable<Follower> TopFollowers { get; set; }
        public IEnumerable<string> FavoriteTech { get; set; }
    }

    class Follower
    {
        public ImageSource Avatar { get; set; }
    }

    class FavoriteSport
    {
        public Sport Sport { get; set; }
        public string Name { get; set; }
    }

    enum Sport
    {
        Swimming,
        Baskeball,
        Running
    }
}
