﻿namespace ClassLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double  Score{ get; set; }
        public MatchupModel ParentMatchup { get; set; }

    }
}