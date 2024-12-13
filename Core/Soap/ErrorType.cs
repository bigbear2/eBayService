// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ErrorType
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
  public class ErrorType
  {
    private string mShortMessage;
    private string mLongMessage;
    private string mErrorCode;
    private bool mUserDisplayHint;
    private bool mUserDisplayHintSpecified;
    private SeverityCodeType mSeverityCode;
    private bool mSeverityCodeSpecified;
    private ErrorParameterTypeCollection mErrorParameters;
    private ErrorClassificationCodeType mErrorClassification;
    private bool mErrorClassificationSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ShortMessage
    {
      get => this.mShortMessage;
      set => this.mShortMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LongMessage
    {
      get => this.mLongMessage;
      set => this.mLongMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ErrorCode
    {
      get => this.mErrorCode;
      set => this.mErrorCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UserDisplayHint
    {
      get => this.mUserDisplayHint;
      set
      {
        this.mUserDisplayHint = value;
        this.mUserDisplayHintSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserDisplayHintSpecified
    {
      get => this.mUserDisplayHintSpecified;
      set => this.mUserDisplayHintSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SeverityCodeType SeverityCode
    {
      get => this.mSeverityCode;
      set
      {
        this.mSeverityCode = value;
        this.mSeverityCodeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SeverityCodeSpecified
    {
      get => this.mSeverityCodeSpecified;
      set => this.mSeverityCodeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ErrorParameters")]
    public ErrorParameterTypeCollection ErrorParameters
    {
      get => this.mErrorParameters;
      set => this.mErrorParameters = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ErrorClassificationCodeType ErrorClassification
    {
      get => this.mErrorClassification;
      set
      {
        this.mErrorClassification = value;
        this.mErrorClassificationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ErrorClassificationSpecified
    {
      get => this.mErrorClassificationSpecified;
      set => this.mErrorClassificationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
