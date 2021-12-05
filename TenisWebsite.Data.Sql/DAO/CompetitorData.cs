using System;
using System.Collections.Generic;
using System.Text;

namespace TenisWebsite.Data.Sql.DAO
{
    public class CompetitorData
    {
        public CompetitorData()
        {
            LeagueTables = new List<LeagueTable>();
            MatchesPlayers1 = new List<Match>();
            MatchesPlayers2 = new List<Match>();
            Winners = new List<Match>();
            RankingTables = new List<RankingTable>();
            Deleted = false;
        }

        public int CompetitorDataId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public int LeagueId { get; set; }

        public bool Deleted { get; set; }

        public virtual League League { get; set; }
        public virtual ICollection<LeagueTable> LeagueTables{get;set;}
        public virtual ICollection<Match> MatchesPlayers1 { get; set; }
        public virtual ICollection<Match> MatchesPlayers2 { get; set; }
        public virtual ICollection<Match> Winners { get; set; }
        public virtual ICollection<RankingTable> RankingTables { get; set; }
    }
}
