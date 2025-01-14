﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IGameRepository : IRepository<Game>
    {
        IEnumerable<Game> GetAllGames(string userid);
        void AddGame(Game game);
        GameDetails GetGame(int id, string userid);
        int? GetGameId(string userId);
        void UpdateGame(Game game);
    }
}
