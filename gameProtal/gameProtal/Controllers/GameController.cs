using gameProtal.Models;
using gameProtal.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameProtal.Controllers
{
    public class GameController : Controller
    {
        private readonly GameRepository _gameRepository = null;

        public GameController()
        {
            _gameRepository = new GameRepository();
        }

        public List<GameModel> GetAllGames()
        {
            return _gameRepository.GetAllGames(); 
        }

        public GameModel GetGame(int id)
        {
            return _gameRepository.GetGameById(id);
        }

        public List<GameModel> SerachGames(string title, string developer)
        {
            return _gameRepository.SearchGames(title, developer);
        }
    }
}
