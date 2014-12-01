﻿using System;
using System.Collections.Generic;
using System.Linq;
using TraktSharp.Entities.Response.Genres;
using TraktSharp.Enums;
using TraktSharp.Helpers;

namespace TraktSharp.Request.Genres {

	public class TraktGenresListRequest : TraktGetRequest<IEnumerable<TraktGenresListResponseItem>> {

		public TraktGenresListRequest(TraktClient client) : base(client) { }

		protected override string PathTemplate { get { return "genres/{type}"; } }

		protected override OAuthRequirement OAuthRequirement { get { return OAuthRequirement.NotRequired; } }

		public GenreTypeOptions Type { get; set; }

		protected override IEnumerable<KeyValuePair<string, string>> GetPathParameters(IEnumerable<KeyValuePair<string, string>> pathParameters) {
			return new Dictionary<string, string> {
				{"type", EnumsHelper.GetDescription(Type)}
			};
		}

	}

}