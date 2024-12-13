// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddSellingManagerInventoryFolderRequestType
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
  public class AddSellingManagerInventoryFolderRequestType : AbstractRequestType
  {
    private string mFolderName;
    private long mParentFolderID;
    private bool mParentFolderIDSpecified;
    private string mComment;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string FolderName
    {
      get => this.mFolderName;
      set => this.mFolderName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public long ParentFolderID
    {
      get => this.mParentFolderID;
      set
      {
        this.mParentFolderID = value;
        this.mParentFolderIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ParentFolderIDSpecified
    {
      get => this.mParentFolderIDSpecified;
      set => this.mParentFolderIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string Comment
    {
      get => this.mComment;
      set => this.mComment = value;
    }
  }
}
