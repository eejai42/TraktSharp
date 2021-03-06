﻿using System;
using System.Collections.Generic;
using System.Linq;
using TraktSharp.Entities;
using TraktSharp.Enums;

namespace TraktSharp.Request.Movies {

	internal class TraktMoviesRelatedRequest : TraktGetByIdRequest<IEnumerable<TraktMovie>> {

		internal TraktMoviesRelatedRequest(TraktClient client) : base(client) { }

		protected override string PathTemplate { get { return "movies/{id}/related"; } }

		protected override TraktAuthenticationRequirement AuthenticationRequirement { get { return TraktAuthenticationRequirement.NotRequired; } }

	}

}