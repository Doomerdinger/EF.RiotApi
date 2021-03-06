﻿using EF.RiotApi.Dto.Stats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.WebRequestResults
{
    /// <summary>
    /// The result of a player stat summary api request
    /// </summary>
    public class PlayerStatsSummaryResult
    {
        /// <summary>
        /// List of player stats summaries associated with the summoner.
        /// </summary>
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatsSummaryDto> PlayerStatSummaries;

        /// <summary>
        /// Summoner ID
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId;
    }
}
