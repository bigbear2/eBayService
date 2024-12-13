// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetStoreCategoryUpdateStatusCall
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
  public class GetStoreCategoryUpdateStatusCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetStoreCategoryUpdateStatusCall()
    {
      this.ApiRequest = new GetStoreCategoryUpdateStatusRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetStoreCategoryUpdateStatusCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetStoreCategoryUpdateStatusRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to retrieve the status of an eBay Store Category hierarchy change that was made with a <b>SetStoreCategories</b> call.
    /// </summary>
    /// <param name="TaskID">
    /// The unique identifier of an eBay Store Category hierarchy change task. A <b>TaskID</b> value is returned in the response of a successful <b>SetStoreCategories</b> call.
    /// <br /><br />
    /// <span class="tablenote"><b>Note: </b> Depending on the breadth of changes being made to an eBay Store Category hierarchy, it is is possible that the <b>SetStoreCategories</b> call will complete the task simultaneously with the call response. A seller will know if an eBay Store Category hierarchy task was completed simultaneously if the <b>TaskID</b> value is returned as <code>0</code>, and the <b>Status</b> field is returned with a value of <code>Complete</code>. If the task was not completely simultaneously, the <b>TaskID</b> value will be a positive integer, and the <b>Status</b> field will show a value of <code>InProgress</code> or <code>Pending</code>.
    /// </span>
    /// </param>
    public TaskStatusCodeType GetStoreCategoryUpdateStatus(long TaskID)
    {
      this.TaskID = TaskID;
      this.Execute();
      return this.ApiResponse.Status;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetStoreCategoryUpdateStatusRequestType" /> for this API call.
    /// </summary>
    public GetStoreCategoryUpdateStatusRequestType ApiRequest
    {
      get => (GetStoreCategoryUpdateStatusRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetStoreCategoryUpdateStatusResponseType" /> for this API call.
    /// </summary>
    public GetStoreCategoryUpdateStatusResponseType ApiResponse
    {
      get => (GetStoreCategoryUpdateStatusResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetStoreCategoryUpdateStatusRequestType.TaskID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long TaskID
    {
      get => this.ApiRequest.TaskID;
      set => this.ApiRequest.TaskID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreCategoryUpdateStatusResponseType.Status" /> of type <see cref="T:eBay.Service.Core.Soap.TaskStatusCodeType" />.
    /// </summary>
    public TaskStatusCodeType Status => this.ApiResponse.Status;
  }
}
