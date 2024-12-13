// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetStoreCategoriesResponseType
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
  public class SetStoreCategoriesResponseType : AbstractResponseType
  {
    private long mTaskID;
    private bool mTaskIDSpecified;
    private TaskStatusCodeType mStatus;
    private bool mStatusSpecified;
    private StoreCustomCategoryTypeCollection mCustomCategory;

    /// <summary>
    /// 
    /// </summary>
    public long TaskID
    {
      get => this.mTaskID;
      set
      {
        this.mTaskID = value;
        this.mTaskIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TaskIDSpecified
    {
      get => this.mTaskIDSpecified;
      set => this.mTaskIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TaskStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("CustomCategory", IsNullable = false)]
    public StoreCustomCategoryTypeCollection CustomCategory
    {
      get => this.mCustomCategory;
      set => this.mCustomCategory = value;
    }
  }
}
