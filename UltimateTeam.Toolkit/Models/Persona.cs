using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class Persona
    {
        public string PersonaId { get; set; }

        public string PersonaName { get; set; }

        public IEnumerable<UserClub> UserClubList { get; set; }

        public bool ReturningUser { get; set; }

        public bool Trial { get; set; }

        public string UserState { get; set; }

        public string TrialFree { get; set; }

        // Added for 2019
        public string onlineAccess { get; set; }
        public string returningUserTier { get; set; }


    }
}