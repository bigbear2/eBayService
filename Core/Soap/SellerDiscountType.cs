// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerDiscountType
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
  public class SellerDiscountType
  {
    private long mCampaignID;
    private bool mCampaignIDSpecified;
    private string mCampaignDisplayName;
    private AmountType mItemDiscountAmount;
    private AmountType mShippingDiscountAmount;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long CampaignID
    {
      get => this.mCampaignID;
      set
      {
        this.mCampaignID = value;
        this.mCampaignIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CampaignIDSpecified
    {
      get => this.mCampaignIDSpecified;
      set => this.mCampaignIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CampaignDisplayName
    {
      get => this.mCampaignDisplayName;
      set => this.mCampaignDisplayName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ItemDiscountAmount
    {
      get => this.mItemDiscountAmount;
      set => this.mItemDiscountAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ShippingDiscountAmount
    {
      get => this.mShippingDiscountAmount;
      set => this.mShippingDiscountAmount = value;
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
