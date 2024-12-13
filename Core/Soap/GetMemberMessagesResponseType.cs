// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMemberMessagesResponseType
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
  public class GetMemberMessagesResponseType : AbstractResponseType
  {
    private MemberMessageExchangeTypeCollection mMemberMessage;
    private PaginationResultType mPaginationResult;
    private bool mHasMoreItems;
    private bool mHasMoreItemsSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("MemberMessageExchange", IsNullable = false)]
    public MemberMessageExchangeTypeCollection MemberMessage
    {
      get => this.mMemberMessage;
      set => this.mMemberMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginationResultType PaginationResult
    {
      get => this.mPaginationResult;
      set => this.mPaginationResult = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HasMoreItems
    {
      get => this.mHasMoreItems;
      set
      {
        this.mHasMoreItems = value;
        this.mHasMoreItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasMoreItemsSpecified
    {
      get => this.mHasMoreItemsSpecified;
      set => this.mHasMoreItemsSpecified = value;
    }
  }
}
