﻿using System;
using System.Xml.Serialization;

using MetaBrainz.MusicBrainz.Resources;

namespace MetaBrainz.MusicBrainz.Model {

  [Serializable]
  public class EditInformation : Item, IEditInformation {

    #region XML Elements

    [XmlElement("auto-edits-accepted")] public uint AutoEditsAccepted;
    [XmlElement("edits-accepted")]      public uint EditsAccepted;
    [XmlElement("edits-failed")]        public uint EditsFailed;
    [XmlElement("edits-rejected")]      public uint EditsRejected;

    #endregion

    #region IEditInformation

    uint IEditInformation.AutoEditsAccepted => this.AutoEditsAccepted;

    uint IEditInformation.EditsAccepted => this.EditsAccepted;

    uint IEditInformation.EditsFailed => this.EditsFailed;

    uint IEditInformation.EditsRejected => this.EditsRejected;

    #endregion

  }

}
