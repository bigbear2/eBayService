// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class ValidateTestUserRegistrationRequestType : AbstractRequestType
  {
    private int mFeedbackScore;
    private bool mFeedbackScoreSpecified;
    private DateTime mRegistrationDate;
    private bool mRegistrationDateSpecified;
    private bool mSubscribeSA;
    private bool mSubscribeSASpecified;
    private bool mSubscribeSAPro;
    private bool mSubscribeSAProSpecified;
    private bool mSubscribeSM;
    private bool mSubscribeSMSpecified;
    private bool mSubscribeSMPro;
    private bool mSubscribeSMProSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public int FeedbackScore
    {
      get => this.mFeedbackScore;
      set
      {
        this.mFeedbackScore = value;
        this.mFeedbackScoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackScoreSpecified
    {
      get => this.mFeedbackScoreSpecified;
      set => this.mFeedbackScoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DateTime RegistrationDate
    {
      get => this.mRegistrationDate;
      set
      {
        this.mRegistrationDate = value;
        this.mRegistrationDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RegistrationDateSpecified
    {
      get => this.mRegistrationDateSpecified;
      set => this.mRegistrationDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool SubscribeSA
    {
      get => this.mSubscribeSA;
      set
      {
        this.mSubscribeSA = value;
        this.mSubscribeSASpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SubscribeSASpecified
    {
      get => this.mSubscribeSASpecified;
      set => this.mSubscribeSASpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool SubscribeSAPro
    {
      get => this.mSubscribeSAPro;
      set
      {
        this.mSubscribeSAPro = value;
        this.mSubscribeSAProSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SubscribeSAProSpecified
    {
      get => this.mSubscribeSAProSpecified;
      set => this.mSubscribeSAProSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public bool SubscribeSM
    {
      get => this.mSubscribeSM;
      set
      {
        this.mSubscribeSM = value;
        this.mSubscribeSMSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SubscribeSMSpecified
    {
      get => this.mSubscribeSMSpecified;
      set => this.mSubscribeSMSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public bool SubscribeSMPro
    {
      get => this.mSubscribeSMPro;
      set
      {
        this.mSubscribeSMPro = value;
        this.mSubscribeSMProSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SubscribeSMProSpecified
    {
      get => this.mSubscribeSMProSpecified;
      set => this.mSubscribeSMProSpecified = value;
    }
  }
}
