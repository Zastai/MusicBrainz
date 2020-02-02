﻿using JetBrains.Annotations;

using MetaBrainz.MusicBrainz.Interfaces.Entities;

namespace MetaBrainz.MusicBrainz.Interfaces.Searches {

  /// <summary>An artist returned by a search request.</summary>
  [PublicAPI]
  public interface IFoundArtist : IArtist, ISearchResult { }

}
