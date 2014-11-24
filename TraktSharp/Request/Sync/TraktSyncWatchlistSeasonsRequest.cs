﻿using System;
using System.Collections.Generic;
using System.Linq;
using TraktSharp.Entities.Response;

namespace TraktSharp.Request.Sync {

	public class TraktSyncWatchlistSeasonsRequest : TraktGetRequest<IEnumerable<TraktWatchlistSeasonsResponseItem>> {

		public TraktSyncWatchlistSeasonsRequest(TraktClient client) : base(client) { }

		protected override string PathTemplate { get { return "sync/watchlist/seasons"; } }

		protected override OAuthRequirement OAuthRequirement { get { return OAuthRequirement.Required; } }

	}

}