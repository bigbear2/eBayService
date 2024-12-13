// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellingManagerInventoryFolderRequestType
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
  public class GetSellingManagerInventoryFolderRequestType : AbstractRequestType
  {
    private long mFolderID;
    private bool mFolderIDSpecified;
    private int mMaxDepth;
    private bool mMaxDepthSpecified;
    private bool mFullRecursion;
    private bool mFullRecursionSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public long FolderID
    {
      get => this.mFolderID;
      set
      {
        this.mFolderID = value;
        this.mFolderIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FolderIDSpecified
    {
      get => this.mFolderIDSpecified;
      set => this.mFolderIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public int MaxDepth
    {
      get => this.mMaxDepth;
      set
      {
        this.mMaxDepth = value;
        this.mMaxDepthSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxDepthSpecified
    {
      get => this.mMaxDepthSpecified;
      set => this.mMaxDepthSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool FullRecursion
    {
      get => this.mFullRecursion;
      set
      {
        this.mFullRecursion = value;
        this.mFullRecursionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FullRecursionSpecified
    {
      get => this.mFullRecursionSpecified;
      set => this.mFullRecursionSpecified = value;
    }
  }
}
