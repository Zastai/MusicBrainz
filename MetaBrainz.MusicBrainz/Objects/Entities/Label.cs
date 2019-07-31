﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using MetaBrainz.MusicBrainz.Interfaces.Entities;
using MetaBrainz.MusicBrainz.Interfaces.Searches;
using MetaBrainz.MusicBrainz.Objects.Searches;

using Newtonsoft.Json;

namespace MetaBrainz.MusicBrainz.Objects.Entities {

  [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
  [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
  [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
  [JsonObject(MemberSerialization.OptIn)]
  internal sealed class Label : SearchResult, IFoundLabel {

    public EntityType EntityType => EntityType.Label;

    [JsonProperty("id", Required = Required.Always)]
    public Guid MbId { get; private set; }

    public IReadOnlyList<IAlias> Aliases => this._aliases;

    [JsonProperty("aliases", Required = Required.Default)]
    private Alias[] _aliases = null;

    [JsonProperty("annotation", Required = Required.Default)]
    public string Annotation { get; private set; }

    public IArea Area => this._area;

    [JsonProperty("area", Required = Required.Default)]
    private Area _area = null;

    [JsonProperty("country", Required = Required.Default)]
    public string Country { get; private set; }

    [JsonProperty("disambiguation", Required = Required.Default)]
    public string Disambiguation { get; private set; }

    public IReadOnlyList<ITag> Genres => this._genres;

    [JsonProperty("genres", Required = Required.DisallowNull)]
    private Tag[] _genres = null;

    [JsonProperty("ipis", Required = Required.Default)]
    public IReadOnlyList<string> Ipis { get; private set; }

    [JsonProperty("isnis", Required = Required.Default)]
    public IReadOnlyList<string> Isnis { get; private set; }

    [JsonProperty("label-code", Required = Required.Default)]
    public int? LabelCode { get; private set; }

    public ILifeSpan LifeSpan => this._lifeSpan;

    [JsonProperty("life-span", Required = Required.Default)]
    private LifeSpan _lifeSpan = null;

    [JsonProperty("name", Required = Required.Always)]
    public string Name { get; private set; }

    public IRating Rating => this._rating;

    [JsonProperty("rating", Required = Required.Default)]
    private Rating _rating = null;

    public IReadOnlyList<IRelationship> Relationships => this._relationships;

    [JsonProperty("relations", Required = Required.Default)]
    private Relationship[] _relationships = null;

    public IReadOnlyList<IRelease> Releases => this._releases;

    [JsonProperty("releases", Required = Required.Default)]
    private Release[] _releases = null;

    public IReadOnlyList<ITag> Tags => this._tags;

    [JsonProperty("tags", Required = Required.Default)]
    private Tag[] _tags = null;

    [JsonProperty("type", Required = Required.Default)]
    public string Type { get; private set; }

    [JsonProperty("type-id", Required = Required.Default)]
    public Guid? TypeId { get; private set; }

    public IReadOnlyList<IUserTag> UserGenres => this._userGenres;

    [JsonProperty("user-genres", Required = Required.Default)]
    private UserTag[] _userGenres = null;

    public IUserRating UserRating => this._userRating;

    [JsonProperty("user-rating", Required = Required.Default)]
    private UserRating _userRating = null;

    public IReadOnlyList<IUserTag> UserTags => this._userTags;

    [JsonProperty("user-tags", Required = Required.Default)]
    private UserTag[] _userTags = null;

    #region Search Server Compatibility

    // The search server's serialization differs in the following ways:
    // - the label code is not serialized when not set (instead of being serialized as null)
    // - the disambiguation comment is not serialized when not set (instead of being serialized as an empty string)
    // => Adjusted the Required flags for affected properties (to allow their omission).

    #endregion

    public override string ToString() {
      var text = this.Name ?? string.Empty;
      if (!string.IsNullOrEmpty(this.Disambiguation))
        text += " (" + this.Disambiguation + ")";
      if (this.Type != null)
        text += " (" + this.Type + ")";
      return text;
    }

    // The name is serialized as 'sort-name' too, probably for historical reasons. Ignore it.
    #pragma warning disable 169
    [JsonProperty("sort-name")] private string _sortName;
    #pragma warning restore 169

  }

}
