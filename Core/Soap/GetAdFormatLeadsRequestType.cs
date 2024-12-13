// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetAdFormatLeadsRequestType
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
  public class GetAdFormatLeadsRequestType : AbstractRequestType
  {
    private string mItemID;
    private MessageStatusTypeCodeType mStatus;
    private bool mStatusSpecified;
    private bool mIncludeMemberMessages;
    private bool mIncludeMemberMessagesSpecified;
    private DateTime mStartCreationTime;
    private bool mStartCreationTimeSpecified;
    private DateTime mEndCreationTime;
    private bool mEndCreationTimeSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public MessageStatusTypeCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool IncludeMemberMessages
    {
      get => this.mIncludeMemberMessages;
      set
      {
        this.mIncludeMemberMessages = value;
        this.mIncludeMemberMessagesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeMemberMessagesSpecified
    {
      get => this.mIncludeMemberMessagesSpecified;
      set => this.mIncludeMemberMessagesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public DateTime StartCreationTime
    {
      get => this.mStartCreationTime;
      set
      {
        this.mStartCreationTime = value;
        this.mStartCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartCreationTimeSpecified
    {
      get => this.mStartCreationTimeSpecified;
      set => this.mStartCreationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public DateTime EndCreationTime
    {
      get => this.mEndCreationTime;
      set
      {
        this.mEndCreationTime = value;
        this.mEndCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndCreationTimeSpecified
    {
      get => this.mEndCreationTimeSpecified;
      set => this.mEndCreationTimeSpecified = value;
    }
  }
}
