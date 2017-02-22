using System;
using MyAnimeListSharp.Auth;
using MyAnimeListSharp.Core;
using MyAnimeListSharp.Enums;
using MyAnimeListSharp.Facade;

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
            var persScore = 8;

            var methods = new AnimeListMethods(credential);

            AnimeValues animeValues = new AnimeValues
            {
                Episode = epsWatched,
                Score = (Score)persScore
            };

            var response = methods.UpdateAnime(animeId, animeValues);
            Console.WriteLine(response);
        }
    }
}
