﻿using System;
using System.Diagnostics.CodeAnalysis;

using MetaBrainz.MusicBrainz.Interfaces.Entities;

using Newtonsoft.Json;

namespace MetaBrainz.MusicBrainz.Objects.Entities {

  [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
  [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
  [JsonObject(MemberSerialization.OptIn)]
  internal sealed class SimpleTrack : ISimpleTrack {

    [JsonProperty("artist", Required = Required.Default)]
    public string Artist { get; private set; }

    [JsonProperty("length", Required = Required.Always)]
    public int Length { get; private set; }

    [JsonProperty("title", Required = Required.Always)]
    public string Title { get; private set; }

    public override string ToString() {
      var text = string.Empty;
      if (this.Artist != null)
        text += this.Artist + " / ";
      text += this.Title + " (" + new TimeSpan(0, 0, 0, 0, this.Length) + ")";
      return text;
    }

  }

}
