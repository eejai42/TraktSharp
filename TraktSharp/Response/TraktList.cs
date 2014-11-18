﻿using System;
using System.Linq;
using Newtonsoft.Json;

namespace TraktSharp.Response {

	[Serializable]
	public class TraktList {

		public TraktList() {
			Ids = new TraktListIds();
		}

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "privacy")]
		public string Privacy { get; set; }

		[JsonProperty(PropertyName = "display_numbers")]
		public bool? DisplayNumbers { get; set; }

		[JsonProperty(PropertyName = "allow_comments")]
		public bool? AllowComments { get; set; }

		[JsonProperty(PropertyName = "updated_at")]
		public DateTime? UpdatedAt { get; set; }

		[JsonProperty(PropertyName = "item_count")]
		public int? ItemCount { get; set; }

		[JsonProperty(PropertyName = "likes")]
		public int? Likes { get; set; }

		[JsonProperty(PropertyName = "ids")]
		public TraktListIds Ids { get; set; }

	}

}