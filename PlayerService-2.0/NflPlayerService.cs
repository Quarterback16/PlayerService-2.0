using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PlayerService_2._0
{
    public class NflPlayerService : INflPlayerService
    {
        public List<NflPlayerState> Players { get; set; }

        public NflPlayerService(
            string csvFile = "d:\\dropbox\\csv\\Starters-PlayerCsv.csv")
        {
            Players = ReadCsv(csvFile);
        }

        public NflPlayerState GetById(string id) =>
            Players.First(p => p.ID == id);


        //  needs to be in sync with structure
        private static List<NflPlayerState> ReadCsv(
            string inputFile)
        {
            var retval = new List<NflPlayerState>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };
            var classMap = new PlayerCsvInputClassMap2();

            using (var reader = new StreamReader(inputFile))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap(classMap);
                retval.AddRange(csv.GetRecords<NflPlayerState>());
            }
            return retval;
        }

        public List<NflPlayerState> GetAll() => Players;

        public List<NflPlayerState> Search(
            Func<NflPlayerState, bool> searchFn)
        {
            return Players.Where(searchFn)
                .ToList();
        }

        public List<string> DistinctTeams()
        {
            return Players
                .GroupBy(p => p.CurrTeam)
                .Select(g => g.First().CurrTeam)
                .OrderBy(x => x)
                .ToList();
        }
    }
}
