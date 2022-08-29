using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticeCoolStuff.Models;

namespace PracticeCoolStuff
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Racquets> GetRacquets()
        {
            var _db = new PracticeCoolStuff.Models.PeopleContext();
            IQueryable<Racquets> query = _db.Racquets;
            return query;
        }
    }
}