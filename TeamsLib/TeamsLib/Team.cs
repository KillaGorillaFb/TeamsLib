using System;

namespace TeamsLib
{
    public abstract class Team
    {
        #region Class Fields
        private string coachName;
        private string teamName;
        private string sportName;
        #endregion Class Fields

        #region Getters/Setters
        public string CoachName { get => coachName; set => coachName = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public string Sportname { get => sportName; set => sportName = value; }
        #endregion Getters/Setters

        #region Constructors
        /// <summary>
        /// Default No Arg Constructor
        /// </summary>
        public Team() { }

        /// <summary>
        /// Creates Full Team
        /// </summary>
        /// <param name="cName"></param>
        /// <param name="tName"></param>
        /// <param name="sName"></param>
        public Team(string cName, string tName, string sName)
        {
            coachName = cName;
            teamName = tName;
            sportName = sName;
        }
        #endregion Constructors

        #region Methods
        public override string ToString()
        {
            return sportName + " " + coachName;
        }

        //Required num of palyers will change according to sport
        public virtual int reqPlayers()   //Virtual means this can be overridden.
        {
            return 11;
        }
        #endregion
    }
}
