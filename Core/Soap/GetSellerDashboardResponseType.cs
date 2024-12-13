// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellerDashboardResponseType
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
  public class GetSellerDashboardResponseType : AbstractResponseType
  {
    private SearchStandingDashboardType mSearchStanding;
    private SellerFeeDiscountDashboardType mSellerFeeDiscount;
    private PowerSellerDashboardType mPowerSellerStatus;
    private PolicyComplianceDashboardType mPolicyCompliance;
    private BuyerSatisfactionDashboardType mBuyerSatisfaction;
    private SellerAccountDashboardType mSellerAccount;
    private PerformanceDashboardTypeCollection mPerformance;

    /// <summary>
    /// 
    /// </summary>
    public SearchStandingDashboardType SearchStanding
    {
      get => this.mSearchStanding;
      set => this.mSearchStanding = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerFeeDiscountDashboardType SellerFeeDiscount
    {
      get => this.mSellerFeeDiscount;
      set => this.mSellerFeeDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PowerSellerDashboardType PowerSellerStatus
    {
      get => this.mPowerSellerStatus;
      set => this.mPowerSellerStatus = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PolicyComplianceDashboardType PolicyCompliance
    {
      get => this.mPolicyCompliance;
      set => this.mPolicyCompliance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerSatisfactionDashboardType BuyerSatisfaction
    {
      get => this.mBuyerSatisfaction;
      set => this.mBuyerSatisfaction = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerAccountDashboardType SellerAccount
    {
      get => this.mSellerAccount;
      set => this.mSellerAccount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Performance")]
    public PerformanceDashboardTypeCollection Performance
    {
      get => this.mPerformance;
      set => this.mPerformance = value;
    }
  }
}
