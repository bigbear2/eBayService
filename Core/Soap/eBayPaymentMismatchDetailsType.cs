// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.eBayPaymentMismatchDetailsType
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
  public class eBayPaymentMismatchDetailsType
  {
    private MismatchTypeCodeType mMismatchType;
    private bool mMismatchTypeSpecified;
    private DateTime mActionRequiredBy;
    private bool mActionRequiredBySpecified;
    private AmountType mMismatchAmount;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public MismatchTypeCodeType MismatchType
    {
      get => this.mMismatchType;
      set
      {
        this.mMismatchType = value;
        this.mMismatchTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MismatchTypeSpecified
    {
      get => this.mMismatchTypeSpecified;
      set => this.mMismatchTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ActionRequiredBy
    {
      get => this.mActionRequiredBy;
      set
      {
        this.mActionRequiredBy = value;
        this.mActionRequiredBySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActionRequiredBySpecified
    {
      get => this.mActionRequiredBySpecified;
      set => this.mActionRequiredBySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MismatchAmount
    {
      get => this.mMismatchAmount;
      set => this.mMismatchAmount = value;
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
