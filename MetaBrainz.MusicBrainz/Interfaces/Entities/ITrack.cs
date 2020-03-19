﻿using System;
using System.Collections.Generic;

using JetBrains.Annotations;

namespace MetaBrainz.MusicBrainz.Interfaces.Entities {

  /// <summary>A track on a medium.</summary>
  [PublicAPI]
  public interface ITrack : IJsonBasedObject {

    /// <summary>The MBID for the track.</summary>
    Guid MbId { get; }

    /// <summary>The artist credit for the track.</summary>
    IReadOnlyList<INameCredit>? ArtistCredit { get; }

    /// <summary>The length of the track, in milliseconds.</summary>
    int? Length { get; }

    /// <summary>The number of the track on its medium.</summary>
    string? Number { get; }

    /// <summary>The position of the track within its medium.</summary>
    int? Position { get; }

    /// <summary>The recording associated with the track.</summary>
    IRecording? Recording { get; }

    /// <summary>The track title.</summary>
    string? Title { get; }

  }

}
