namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchupModel> Entries { get; set; } = new List<MatchupModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}