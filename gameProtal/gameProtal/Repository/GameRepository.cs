using gameProtal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameProtal.Repository
{
    public class GameRepository
    {
        public List<GameModel> GetAllGames()
        {
            return DataSource();
        }

        public GameModel GetGameById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<GameModel> SearchGames(string title, string developer)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.developer.Contains(developer)).ToList();
        }

        private List<GameModel> DataSource()
        {
            return new List<GameModel>()
            { 
                new GameModel(){Id=1, Title="BATTERFEILD", developer="sinec" },
                new GameModel(){Id=2, Title="MVC", developer="sinec" },
                new GameModel(){Id=3, Title="MMW", developer="sinec" },
                new GameModel(){Id=4, Title="WWE", developer="sinec" },
            };
        }
    }
}
