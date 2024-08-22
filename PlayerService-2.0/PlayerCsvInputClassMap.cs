using CsvHelper.Configuration;

namespace PlayerService_2._0
{
    public class PlayerCsvInputClassMap2 : ClassMap<NflPlayerState>
    {
        public PlayerCsvInputClassMap2()
        {
            // map for stru 2023-09-23 (more cols)
            // Fields must match Header Names Exactly!
            // The you need to get the order right
            Map(p => p.ID);
            Map(p => p.Name);
            Map(p => p.JerseyNo);
            Map(p => p.Pos);
            Map(p => p.Role);
            Map(p => p.RookieYr);
            Map(p => p.College);
            Map(p => p.Age);
            Map(p => p.CurrTeam);
            Map(p => p.FT);
            Map(p => p.Cat);
            Map(p => p.ScoreMod);
            Map(p => p.Seasons);
            Map(p => p.NewTeam);
            Map(p => p.CurScores);
            Map(p => p.Scores);
            Map(p => p.Avg);
            Map(p => p.ScoreForm);
            Map(p => p.NextOpp);
            Map(p => p.Injury);
            Map(p => p.TDp);
            Map(p => p.YDp);
            Map(p => p.TDr);
            Map(p => p.TDc);
            Map(p => p.YDr);
            Map(p => p.YDc);
            Map(p => p.FG);
            Map(p => p.Pat);
            Map(p => p.Rushes);
            Map(p => p.Completed);
            Map(p => p.PassAtts);
            Map(p => p.PassInt);
            Map(p => p.Catches);
            Map(p => p.Ints);
            Map(p => p.Sacks);
            Map(p => p.ProjYDp);
            Map(p => p.ProjTDp);
            Map(p => p.ProjYDr);
            Map(p => p.ProjTDr);
            Map(p => p.ProjYDc);
            Map(p => p.ProjTDc);
            Map(p => p.ProjFG);
            Map(p => p.ProjPat);
            Map(p => p.ProjFp);
            Map(p => p.Health);
            Map(p => p.Newbie);
            Map(p => p.AdjProj);
            Map(p => p.AgeRate);
            Map(p => p.ProjW01);
            Map(p => p.ProjW02);
            Map(p => p.ProjW03);
            Map(p => p.ProjW04);
            Map(p => p.ProjW05);
            Map(p => p.ProjW06);
            Map(p => p.ProjW07);
            Map(p => p.ProjW08);
            Map(p => p.ProjW09);
            Map(p => p.ProjW10);
            Map(p => p.ProjW11);
            Map(p => p.ProjW12);
            Map(p => p.ProjW13);
            Map(p => p.ProjW14);
            Map(p => p.ProjW15);
            Map(p => p.ProjW15);
            Map(p => p.ProjW16);
            Map(p => p.ProjW17);
            Map(p => p.ProjW18);
            Map(p => p.ProjQ1);
            Map(p => p.ProjQ2);
            Map(p => p.ProjQ3);
            Map(p => p.ProjQ4);
            Map(p => p.CurrDooz);
            Map(p => p.PrevDooz0);
            Map(p => p.PrevDooz1);
            Map(p => p.PrevDooz2);
            Map(p => p.ContractYr);
            Map(p => p.Note);
            Map(p => p.GS1);
            Map(p => p.YH);
            Map(p => p.Game1Proj);
            Map(p => p.Points);
            Map(p => p.Adp);
            Map(p => p.FP01);
            Map(p => p.FP02);
            Map(p => p.FP03);
            Map(p => p.FP04);
            Map(p => p.FP05);
            Map(p => p.FP06);
            Map(p => p.FP07);
            Map(p => p.FP08);
            Map(p => p.FP09);
            Map(p => p.FP10);
            Map(p => p.FP11);
            Map(p => p.FP12);
            Map(p => p.FP13);
            Map(p => p.FP14);
            Map(p => p.FP15);
            Map(p => p.FP15);
            Map(p => p.FP16);
            Map(p => p.FP17);
            Map(p => p.FP18);
            Map(p => p.MyRank);
            Map(p => p.MyPosRank);
            Map(p => p.RunApproach);
        }
    }
}
