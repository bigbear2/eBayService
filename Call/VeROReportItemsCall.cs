// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.VeROReportItemsCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class VeROReportItemsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public VeROReportItemsCall() => this.ApiRequest = new VeROReportItemsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public VeROReportItemsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new VeROReportItemsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Reports items that allegedly infringe your copyright, trademark, or other
    /// intellectual property rights. You can report one or more items at a time with this
    /// call. You must be a member of the Verified Rights Owner (VeRO) Program to use this
    /// call.
    /// </summary>
    /// <param name="RightsOwnerID">
    /// User ID of the VeRO member reporting the items.
    /// </param>
    /// <param name="ReportItemList">
    /// Container (packet) for items being reported. You can report the same item
    /// more than once in a packet if a different reason code is used each time.
    /// </param>
    public long VeROReportItems(string RightsOwnerID, VeROReportItemTypeCollection ReportItemList)
    {
      this.RightsOwnerID = RightsOwnerID;
      this.ReportItemList = ReportItemList;
      this.Execute();
      return this.ApiResponse.VeROReportPacketID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.VeROReportItemsRequestType" /> for this API call.
    /// </summary>
    public VeROReportItemsRequestType ApiRequest
    {
      get => (VeROReportItemsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.VeROReportItemsResponseType" /> for this API call.
    /// </summary>
    public VeROReportItemsResponseType ApiResponse
    {
      get => (VeROReportItemsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VeROReportItemsRequestType.RightsOwnerID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RightsOwnerID
    {
      get => this.ApiRequest.RightsOwnerID;
      set => this.ApiRequest.RightsOwnerID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VeROReportItemsRequestType.ReportItems" /> of type <see cref="T:eBay.Service.Core.Soap.VeROReportItemTypeCollection" />.
    /// </summary>
    public VeROReportItemTypeCollection ReportItemList
    {
      get => this.ApiRequest.ReportItems;
      set => this.ApiRequest.ReportItems = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VeROReportItemsResponseType.VeROReportPacketID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long VeROReportPacketID => this.ApiResponse.VeROReportPacketID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VeROReportItemsResponseType.VeROReportPacketStatus" /> of type <see cref="T:eBay.Service.Core.Soap.VeROReportPacketStatusCodeType" />.
    /// </summary>
    public VeROReportPacketStatusCodeType VeROReportPacketStatus
    {
      get => this.ApiResponse.VeROReportPacketStatus;
    }
  }
}
