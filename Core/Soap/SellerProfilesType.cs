// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerProfilesType
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
  public class SellerProfilesType
  {
    private SellerShippingProfileType mSellerShippingProfile;
    private SellerReturnProfileType mSellerReturnProfile;
    private SellerPaymentProfileType mSellerPaymentProfile;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public SellerShippingProfileType SellerShippingProfile
    {
      get => this.mSellerShippingProfile;
      set => this.mSellerShippingProfile = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerReturnProfileType SellerReturnProfile
    {
      get => this.mSellerReturnProfile;
      set => this.mSellerReturnProfile = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerPaymentProfileType SellerPaymentProfile
    {
      get => this.mSellerPaymentProfile;
      set => this.mSellerPaymentProfile = value;
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
