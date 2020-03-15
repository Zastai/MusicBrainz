﻿using JetBrains.Annotations;

namespace MetaBrainz.MusicBrainz.Interfaces.Entities {

  /// <summary>A collection of MusicBrainz entities.</summary>
  [PublicAPI]
  public interface ICollection : ITypedEntity {

    /// <summary>The name of the editor who created the collection.</summary>
    string? Editor { get; }

    /// <summary>The type of entity stored in the collection (as an enumeration value).</summary>
    EntityType ContentType { get; }

    /// <summary>The type of entity stored in the collection (as text).</summary>
    string? ContentTypeText { get; }

    /// <summary>The number of items in the collection.</summary>
    int ItemCount { get; }

    /// <summary>The name of the collection.</summary>
    string? Name { get; }

  }

}
