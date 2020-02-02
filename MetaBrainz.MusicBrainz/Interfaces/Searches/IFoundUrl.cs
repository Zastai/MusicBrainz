﻿using JetBrains.Annotations;

using MetaBrainz.MusicBrainz.Interfaces.Entities;

namespace MetaBrainz.MusicBrainz.Interfaces.Searches {

  /// <summary>A URL returned by a search request.</summary>
  [PublicAPI]
  public interface IFoundUrl : IUrl, ISearchResult { }

}
