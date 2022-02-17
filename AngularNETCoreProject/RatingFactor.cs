namespace AngularNETCoreProject
{
    public class RatingFactor
    {
        public string Rating { get; set; }

        public double Factor { get; set; }

    }

    public class OccupationRating
    {
        private OccupationRating() { }

        public static Dictionary<string, RatingFactor> OccupationRatingDict = new Dictionary<string, RatingFactor>
        {
            { "cleaner",new RatingFactor{Rating="Light Manual",Factor=1.5} },
            { "doctor",new RatingFactor{Rating="Professional",Factor=1.0} },
           { "author",new RatingFactor{Rating="White Collar",Factor=1.25} },
           { "farmer",new RatingFactor{Rating="Heavy Manual",Factor=1.75} },
           { "mechanic",new RatingFactor{Rating="Heavy Manual",Factor=1.75} },
           { "florist",new RatingFactor{Rating="Light Manual",Factor=1.5} }
        };
    }
}