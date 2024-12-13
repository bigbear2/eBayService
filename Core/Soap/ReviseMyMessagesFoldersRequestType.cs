// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseMyMessagesFoldersRequestType
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
  public class ReviseMyMessagesFoldersRequestType : AbstractRequestType
  {
    private MyMessagesFolderOperationCodeType mOperation;
    private bool mOperationSpecified;
    private Int64Collection mFolderID;
    private StringCollection mFolderName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public MyMessagesFolderOperationCodeType Operation
    {
      get => this.mOperation;
      set
      {
        this.mOperation = value;
        this.mOperationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OperationSpecified
    {
      get => this.mOperationSpecified;
      set => this.mOperationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FolderID", Order = 1)]
    public Int64Collection FolderID
    {
      get => this.mFolderID;
      set => this.mFolderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FolderName", Order = 2)]
    public StringCollection FolderName
    {
      get => this.mFolderName;
      set => this.mFolderName = value;
    }
  }
}
