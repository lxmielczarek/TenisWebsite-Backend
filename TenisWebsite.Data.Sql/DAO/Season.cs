using System;
using System.Collections.Generic;
using System.Text;

namespace TenisWebsite.Data.Sql.DAO
{
    public class Season
    {
        public Season()
        {
            LeagueTables = new List<LeagueTable>();
            active_bit = false;
        }
        public int SeasonId { get; set; }
        public string Name { get; set; }
        public bool active_bit { get; set; }
        public virtual ICollection<LeagueTable> LeagueTables { get; set; }
    }
}
