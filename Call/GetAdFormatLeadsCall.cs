// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetAdFormatLeadsCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetAdFormatLeadsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetAdFormatLeadsCall() => this.ApiRequest = new GetAdFormatLeadsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetAdFormatLeadsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetAdFormatLeadsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves sales lead information for a lead generation listing.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of an item listed on the eBay site.
    /// Returned by eBay when the item is created. This ID must correspond
    /// to an ad format item.
    /// </param>
    /// <param name="Status">Filters the leads based on their status.</param>
    /// <param name="IncludeMemberMessages">
    /// Boolean which indicates whether to return mail messages for this lead in a MemberMessage node.
    /// </param>
    /// <param name="StartCreationTime">
    /// Used with EndCreationTime to limit the returned leads for a user to only
    /// those with a creation date greater than or equal to the specified date and
    /// time.
    /// </param>
    /// <param name="EndCreationTime">
    /// Used with StartCreationTime to limit the returned leads for a user to only
    /// those with a creation date less than or equal to the specified date and
    /// time.
    /// </param>
    public AdFormatLeadTypeCollection GetAdFormatLeads(
      string ItemID,
      MessageStatusTypeCodeType Status,
      bool IncludeMemberMessages,
      DateTime StartCreationTime,
      DateTime EndCreationTime)
    {
      this.ItemID = ItemID;
      this.Status = Status;
      this.IncludeMemberMessages = IncludeMemberMessages;
      this.StartCreationTime = StartCreationTime;
      this.EndCreationTime = EndCreationTime;
      this.Execute();
      return this.ApiResponse.AdFormatLead;
    }

    /// <summary>
    /// Retrieve sales lead information for a real estate advertisement listing.
    /// GetAdFormatLeadsRequest returns the number of leads for an ad and any contact
    /// information that the prospective buyer submitted.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of an item listed on the eBay site.
    /// Returned by eBay when the item is created. This ID must correspond
    /// to an ad format item.
    /// </param>
    public AdFormatLeadTypeCollection GetAdFormatLeads(string ItemID)
    {
      this.ItemID = ItemID;
      this.Execute();
      return this.ApiResponse.AdFormatLead;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetAdFormatLeadsRequestType" /> for this API call.
    /// </summary>
    public GetAdFormatLeadsRequestType ApiRequest
    {
      get => (GetAdFormatLeadsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetAdFormatLeadsResponseType" /> for this API call.
    /// </summary>
    public GetAdFormatLeadsResponseType ApiResponse
    {
      get => (GetAdFormatLeadsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsRequestType.Status" /> of type <see cref="T:eBay.Service.Core.Soap.MessageStatusTypeCodeType" />.
    /// </summary>
    public MessageStatusTypeCodeType Status
    {
      get => this.ApiRequest.Status;
      set => this.ApiRequest.Status = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsRequestType.IncludeMemberMessages" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeMemberMessages
    {
      get => this.ApiRequest.IncludeMemberMessages;
      set => this.ApiRequest.IncludeMemberMessages = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsRequestType.StartCreationTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartCreationTime
    {
      get => this.ApiRequest.StartCreationTime;
      set => this.ApiRequest.StartCreationTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsRequestType.EndCreationTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndCreationTime
    {
      get => this.ApiRequest.EndCreationTime;
      set => this.ApiRequest.EndCreationTime = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsResponseType.AdFormatLead" /> of type <see cref="T:eBay.Service.Core.Soap.AdFormatLeadTypeCollection" />.
    /// </summary>
    public AdFormatLeadTypeCollection AdFormatLeadList => this.ApiResponse.AdFormatLead;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAdFormatLeadsResponseType.AdFormatLeadCount" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int AdFormatLeadCount => this.ApiResponse.AdFormatLeadCount;
  }
}
