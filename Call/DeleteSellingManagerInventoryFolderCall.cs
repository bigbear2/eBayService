// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DeleteSellingManagerInventoryFolderCall
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
  public class DeleteSellingManagerInventoryFolderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DeleteSellingManagerInventoryFolderCall()
    {
      this.ApiRequest = new DeleteSellingManagerInventoryFolderRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DeleteSellingManagerInventoryFolderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DeleteSellingManagerInventoryFolderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Removes an inventory folder when a user deletes it in My eBay. This call is subject to change without notice; the deprecation process is inapplicable to this call.
    /// </summary>
    /// <param name="FolderID">
    /// Unique ID of the Selling Manager Inventory folder to be deleted.
    /// </param>
    public void DeleteSellingManagerInventoryFolder(long FolderID)
    {
      this.FolderID = FolderID;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerInventoryFolderRequestType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerInventoryFolderRequestType ApiRequest
    {
      get => (DeleteSellingManagerInventoryFolderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerInventoryFolderResponseType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerInventoryFolderResponseType ApiResponse
    {
      get => (DeleteSellingManagerInventoryFolderResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerInventoryFolderRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }
  }
}
