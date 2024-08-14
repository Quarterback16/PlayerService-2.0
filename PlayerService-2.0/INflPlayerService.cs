using System;
using System.Collections.Generic;

namespace PlayerService_2._0
{
    public interface INflPlayerService
    {
        NflPlayerState GetById(string id);

        List<NflPlayerState> GetAll();

        List<NflPlayerState> Search(
            Func<NflPlayerState, bool> searchFn);

        List<string> DistinctTeams();
    }
}
