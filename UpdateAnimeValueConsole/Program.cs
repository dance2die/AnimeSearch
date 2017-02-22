using System;
using MyAnimeListSharp.Auth;
using MyAnimeListSharp.Core;
using MyAnimeListSharp.Enums;
using MyAnimeListSharp.Facade;
using MyAnimeListSharp.Util;

namespace UpdateAnimeValueConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var credential = new CredentialContext();
            UpdateAnimeValue(credential);
        }

        private static void UpdateAnimeValue(CredentialContext credential)
        {
            var animeId = 32615;    // Youjo Senki (TV)
            short epsWatched = 6;
            var persScore = 10;

            var methods = new AnimeListMethods(credential);

            AnimeValues animeValues = new AnimeValues {Episode = epsWatched};

            if (persScore == 0 || persScore == 1)
            {
                animeValues.Score = Score.Appalling;
            }
            else if (persScore == 2)
            {
                animeValues.Score = Score.Horrible;
            }
            else if (persScore == 3)
            {
                animeValues.Score = Score.VeryBad;
            }
            else if (persScore == 4)
            {
                animeValues.Score = Score.Bad;
            }
            else if (persScore == 5)
            {
                animeValues.Score = Score.Average;
            }
            else if (persScore == 6)
            {
                animeValues.Score = Score.Fine;
            }
            else if (persScore == 7)
            {
                animeValues.Score = Score.Good;
            }
            else if (persScore == 8)
            {
                animeValues.Score = Score.VeryGood;
            }
            else if (persScore == 9)
            {
                animeValues.Score = Score.Great;
            }
            else if (persScore == 10)
            {
                animeValues.Score = Score.MasterPiece;
            }

            var response = methods.UpdateAnime(animeId, animeValues);
            Console.WriteLine(response);
        }
    }
}
