﻿using System;
using System.Xml.Serialization;

using MetaBrainz.MusicBrainz.Resources;

namespace MetaBrainz.MusicBrainz.Model {

  [Serializable]
  public class ReleaseEvent : Item, IReleaseEvent {

    #region XML Elements

    [XmlElement("area")] public Area   Area;
    [XmlElement("date")] public string Date;

    #endregion

    #region IReleaseEvent

    IArea IReleaseEvent.Area => this.Area;

    string IReleaseEvent.Date => this.Date;

    #endregion

  }

}
