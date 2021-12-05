using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using TenisWebsite.Data.Sql.DAO;

namespace TenisWebsite.Data.Sql.Migrations
{
   
    public class DatabaseSeed
    {
        private readonly TenisWebsiteDbContext _context;
        private readonly UserManager<IdentityUser> _userManger;

        public DatabaseSeed(TenisWebsiteDbContext context, UserManager<IdentityUser> userManger)
        {
            _context = context;
            _userManger = userManger;
        }
        public async void Seed()
        {
            League league1 = new League
            {
                LeagueId = 1,
                Name = "Pierwsza Liga"
            };
            League league2 = new League
            {
                LeagueId = 2,
                Name = "Druga Liga"
            };
            League league3 = new League
            {
                LeagueId = 3,
                Name = "Trzecia Liga"
            };
            League league4 = new League
            {
                LeagueId = 4,
                Name = "Czwarta Liga"
            };
            await _context.AddAsync(league1);
            await _context.AddAsync(league2);
            await _context.AddAsync(league3);
            await _context.AddAsync(league4);

            Season season1 = new Season
            {
                SeasonId = 1,
                Name = "2019/2020",
                active_bit = false
            };

            Season season2 = new Season
            {
                SeasonId = 2,
                Name = "2020/2021",
                active_bit = true
            };

            Season season3 = new Season
            {
                SeasonId = 3,
                Name = "2021/2022",
            };
           
            await _context.AddAsync(league1);
            await _context.AddAsync(league2);
            await _context.AddAsync(league3);
            await _context.AddAsync(league4);

            await _context.AddAsync(season1);
            await _context.AddAsync(season2);
            await _context.AddAsync(season3);

            await _context.SaveChangesAsync();



        }
    }
}
