﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TraktSharp.Entities {

	[Serializable]
	public class TraktShowWithWatchedMetadata : TraktShow {

		[JsonProperty(PropertyName = "watched_at")]
		public DateTime? WatchedAt { get; set; }

		[JsonProperty(PropertyName = "seasons")]
		public new IEnumerable<TraktSeasonWithWatchedMetadata> Seasons { get; set; }

	}

}