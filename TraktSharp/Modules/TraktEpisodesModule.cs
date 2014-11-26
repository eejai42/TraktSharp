﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraktSharp.Entities;
using TraktSharp.Request.Episodes;

namespace TraktSharp.Modules {

	public class TraktEpisodesModule {

		public TraktEpisodesModule(TraktClient client) { Client = client; }

		public TraktClient Client { get; private set; }

		public async Task<TraktEpisode> GetEpisodeAsync(TraktShow show, TraktEpisode episode, ExtendedOption extended = ExtendedOption.Unspecified) {
			return await GetEpisodeAsync(show.Ids.GetBestId(), episode.Season.GetValueOrDefault(), episode.Number.GetValueOrDefault(), extended);
		}

		public async Task<TraktEpisode> GetEpisodeAsync(string showId, int season, int episode, ExtendedOption extended = ExtendedOption.Unspecified) {
			return await new TraktEpisodesSummaryRequest(Client) {
				Id = showId,
				Season = season,
				Episode = episode,
				Extended = extended
			}.SendAsync();
		}

		public async Task<IEnumerable<TraktComment>> GetCommentsAsync(TraktShow show, TraktEpisode episode, int? page = null, int? limit = null) {
			return await GetCommentsAsync(show.Ids.GetBestId(), episode.Season.GetValueOrDefault(), episode.Number.GetValueOrDefault(), page, limit);
		}

		public async Task<IEnumerable<TraktComment>> GetCommentsAsync(string showId, int season, int episode, int? page = null, int? limit = null) {
			return await new TraktEpisodesCommentsRequest(Client) {
				Id = showId,
				Season = season,
				Episode = episode,
				Pagination = new PaginationOptions(page, limit)
			}.SendAsync();
		}

		public async Task<TraktRatings> GetRatingsAsync(TraktShow show, TraktEpisode episode) {
			return await GetRatingsAsync(show.Ids.GetBestId(), episode.Season.GetValueOrDefault(), episode.Number.GetValueOrDefault());
		}

		public async Task<TraktRatings> GetRatingsAsync(string showId, int season, int episode) {
			return await new TraktEpisodesRatingsRequest(Client) {
				Id = showId,
				Season = season,
				Episode = episode
			}.SendAsync();
		}

		public async Task<IEnumerable<TraktUser>> GetUsersWatchingEpisodeAsync(TraktShow show, TraktEpisode episode, ExtendedOption extended = ExtendedOption.Unspecified) {
			return await GetUsersWatchingEpisodeAsync(show.Ids.GetBestId(), episode.Season.GetValueOrDefault(), episode.Number.GetValueOrDefault(), extended);
		}

		public async Task<IEnumerable<TraktUser>> GetUsersWatchingEpisodeAsync(string showId, int season, int episode, ExtendedOption extended = ExtendedOption.Unspecified) {
			return await new TraktEpisodesWatchingRequest(Client) {
				Id = showId,
				Season = season,
				Episode = episode,
				Extended = extended
			}.SendAsync();
		}

	}

}