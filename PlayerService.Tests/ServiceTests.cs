using System.Diagnostics.CodeAnalysis;
using PlayerService_2._0;

namespace PlayerService.Tests
{

        [TestClass]
        [ExcludeFromCodeCoverage]
        public class ServiceTests
        {
            private NflPlayerService? _cut;

            [TestInitialize]
            public void Setup()
            {
                _cut = new NflPlayerService();
            }

            [TestMethod]
            public void PlayerService_CanRetrieveById()
            {
                var p = _cut?.GetById("JEFFJU01");
                Assert.IsNotNull(p);
                Console.WriteLine($"Plyr is {p.Name}");
            }

            [TestMethod]
            public void PlayerService_CanRetrieveYHowner()
            {
                var p = _cut?.GetById("MAHOPA01");
                Console.WriteLine($"YH owner is {p?.YH}");
                Assert.AreEqual("77", p?.YH);
            }

            [TestMethod]
            public void PlayerService_CanRetrieveAll()
            {
                var list = _cut?.GetAll();
                Assert.IsTrue(list?.Count > 1);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerCat()
            {
                var p = _cut?.GetById("MAHOPA01");
                Assert.AreEqual("1", p?.Cat);
            }

            [TestMethod]
            public void PlayerService_CanReadFilter()
            {
                var list = _cut?.Search((NflPlayerState p) => p.CurrTeam == "SF");
                Assert.IsTrue(list?.Count > 1);
            }

            [TestMethod]
            public void PlayerService_CanReadFilter2()
            {
                var list = _cut?
                    .Search((NflPlayerState p) => p.CurrTeam == "SF"
                        && p.Pos.Contains("RB"));
                Assert.IsTrue(list?.Count > 1);
            }

            [TestMethod]
            public void PlayerService_CanFindDistinctTeams()
            {
                var list = _cut?.DistinctTeams();
                Assert.IsTrue(list?.Count > 1);
                list.ForEach(t => Console.WriteLine(t));

            }

            [TestMethod]
            public void PlayerService_CanReadPlayerCurScores()
            {
                var p = _cut?.GetById("RODGAA01");
                Assert.AreEqual("0", p?.CurScores);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerScores()
            {
                var p = _cut?.GetById("RODGAA01");
                Assert.AreEqual("549", p?.Scores);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerAvg()
            {
                var p = _cut?.GetById("RODGAA01");
                Assert.AreEqual("30.5", p?.Avg);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerInjury()
            {
                var p = _cut?.GetById("RODGAA01");
                Assert.AreEqual("3", p?.Injury);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerFP()
            {
                var p = _cut?.GetById("STAFMA01");
                Assert.AreEqual("14.46", p?.FP01);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerJerseyNumber()
            {
                var p = _cut?.GetById("STAFMA01");
                Assert.AreEqual("9", p?.JerseyNo);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerAdp()
            {
                var p = _cut?.GetById("STAFMA01");
                Assert.AreEqual("13.03", p?.Adp);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerCollege()
            {
                var p = _cut?.GetById("MAHOPA01");
                Assert.AreEqual("TexasTech", p?.College.Trim());
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerContractYear()
            {
                var p = _cut?.GetById("JACOJO01");
                Assert.AreEqual("$", p?.ContractYr);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerScoringForm()
            {
                var p = _cut?.GetById("JACOJO01");
                Assert.AreEqual("+", p?.ScoreForm);
            }

            [TestMethod]
            public void PlayerService_CanReadPlayerNextOpponent()
            {
                var p = _cut?.GetById("MAHOPA01");
                Assert.AreEqual(
                    "Mon 09 Oct 07:30  @ Minnesota Vikings  -5  E  ( 1 - 3)    B D C - C C E - 25",
                    p?.NextOpp.Trim());
            }

            [TestMethod]
            public void PlayerService_CanReadStats()
            {
                var p = _cut?.GetById("STAFMA01");
                Assert.AreEqual("2", p?.TDp);
            }

            [TestMethod]
            public void PlayerService_CanReadGurrDooz()
            {
                var p = _cut?.GetById("KITTGE01");
                Assert.AreEqual("1", p?.CurrDooz);
            }

        [TestMethod]
        public void PlayerService_CanReadMyRank()
        {
            var p = _cut?.GetById("MAHOPA01");
            Assert.AreEqual("3", p?.MyRank);
            Console.WriteLine(p?.MyRank);
        }

        [TestMethod]
        public void PlayerService_CanReadMyPosRank()
        {
            var p = _cut?.GetById("MAHOPA01");
            Assert.AreEqual("3", p?.MyPosRank);
            Console.WriteLine(p?.MyPosRank);
        }
    }
}