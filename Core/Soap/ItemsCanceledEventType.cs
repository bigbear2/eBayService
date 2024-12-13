// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemsCanceledEventType
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
  public class ItemsCanceledEventType : AbstractResponseType
  {
    private ItemIDArrayType mCanceledItemIDArray;
    private bool mEligibleForRelist;
    private bool mEligibleForRelistSpecified;
    private string mSellerID;

    /// <summary>
    /// 
    /// </summary>
    public ItemIDArrayType CanceledItemIDArray
    {
      get => this.mCanceledItemIDArray;
      set => this.mCanceledItemIDArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EligibleForRelist
    {
      get => this.mEligibleForRelist;
      set
      {
        this.mEligibleForRelist = value;
        this.mEligibleForRelistSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligibleForRelistSpecified
    {
      get => this.mEligibleForRelistSpecified;
      set => this.mEligibleForRelistSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerID
    {
      get => this.mSellerID;
      set => this.mSellerID = value;
    }
  }
}
