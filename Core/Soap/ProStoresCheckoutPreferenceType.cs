// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ProStoresCheckoutPreferenceType
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
  public class ProStoresCheckoutPreferenceType
  {
    private bool mCheckoutRedirectProStores;
    private bool mCheckoutRedirectProStoresSpecified;
    private ProStoresDetailsType mProStoresDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool CheckoutRedirectProStores
    {
      get => this.mCheckoutRedirectProStores;
      set
      {
        this.mCheckoutRedirectProStores = value;
        this.mCheckoutRedirectProStoresSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CheckoutRedirectProStoresSpecified
    {
      get => this.mCheckoutRedirectProStoresSpecified;
      set => this.mCheckoutRedirectProStoresSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProStoresDetailsType ProStoresDetails
    {
      get => this.mProStoresDetails;
      set => this.mProStoresDetails = value;
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
