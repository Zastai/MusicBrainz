﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using MetaBrainz.MusicBrainz.Interfaces.Entities;

using Newtonsoft.Json;

namespace MetaBrainz.MusicBrainz.Objects.Entities {

  [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
  [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
  [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
  [JsonObject(MemberSerialization.OptIn)]
  internal sealed class Disc : IDisc {

    [JsonProperty("id", Required = Required.Always)]
    public string Id { get; private set; }

    [JsonProperty("offset-count", Required = Required.Always)]
    public int OffsetCount { get; private set; }

    [JsonProperty("offsets", Required = Required.Default)]
    public IReadOnlyList<int> Offsets { get; private set; }

    public IReadOnlyList<IRelease> Releases => this._releases;

    [JsonProperty("releases", Required = Required.Default)]
    private Release[] _releases = null;

    [JsonProperty("sectors", Required = Required.Always)]
    public int Sectors { get; private set; }

    public override string ToString() => $"{this.Id} ({this.OffsetCount} track(s), {new TimeSpan(0, 0, 0, 0, (int) ((double) this.Sectors / 75 * 1000)),2})";

  }

}
