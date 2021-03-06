﻿using System;
using System.Linq;
using Newtonsoft.Json;

namespace TraktSharp.Entities.Response.Shows {

	/// <summary>A structure representing the return data or part of the return data from one or more Trakt API methods</summary>
	[Serializable]
	public class TraktShowsUpdatesResponseItem {

		/// <summary>The number of users watching this item</summary>
		[JsonProperty(PropertyName = "watchers")]
		public int? Watchers { get; set; }

		/// <summary>The show</summary>
		[JsonProperty(PropertyName = "show")]
		public TraktShow Show { get; set; }

	}

}