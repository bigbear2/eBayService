// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BusinessSellerDetailsType
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
  public class BusinessSellerDetailsType
  {
    private AddressType mAddress;
    private string mFax;
    private string mEmail;
    private string mAdditionalContactInformation;
    private string mTradeRegistrationNumber;
    private bool mLegalInvoice;
    private bool mLegalInvoiceSpecified;
    private string mTermsAndConditions;
    private VATDetailsType mVATDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AddressType Address
    {
      get => this.mAddress;
      set => this.mAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Fax
    {
      get => this.mFax;
      set => this.mFax = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Email
    {
      get => this.mEmail;
      set => this.mEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AdditionalContactInformation
    {
      get => this.mAdditionalContactInformation;
      set => this.mAdditionalContactInformation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TradeRegistrationNumber
    {
      get => this.mTradeRegistrationNumber;
      set => this.mTradeRegistrationNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LegalInvoice
    {
      get => this.mLegalInvoice;
      set
      {
        this.mLegalInvoice = value;
        this.mLegalInvoiceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LegalInvoiceSpecified
    {
      get => this.mLegalInvoiceSpecified;
      set => this.mLegalInvoiceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TermsAndConditions
    {
      get => this.mTermsAndConditions;
      set => this.mTermsAndConditions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VATDetailsType VATDetails
    {
      get => this.mVATDetails;
      set => this.mVATDetails = value;
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
