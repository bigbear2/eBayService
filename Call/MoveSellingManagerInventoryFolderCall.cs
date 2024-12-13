// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.MoveSellingManagerInventoryFolderCall
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
  public class MoveSellingManagerInventoryFolderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public MoveSellingManagerInventoryFolderCall()
    {
      this.ApiRequest = new MoveSellingManagerInventoryFolderRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public MoveSellingManagerInventoryFolderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new MoveSellingManagerInventoryFolderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Moves a Selling Manager inventory folder.
    /// 
    /// This call is subject to change without notice; the deprecation process is
    /// inapplicable to this call. This call is only applicable and accessible by eBay sellers with a Selling Manager Pro subscription.
    /// </summary>
    /// <param name="FolderID">
    /// Unique ID of the Selling Manager Inventory folder that will be moved. A user can retrieve <b>FolderID</b> values by using <b>GetSellingManagerInventoryFolder</b>.
    /// </param>
    /// <param name="NewParentFolderID">
    /// Unique ID of the Selling Manager Inventory folder that will be the new parent folder of the Selling Manager Inventory folder specified in the <b>FolderID</b> field. A user can retrieve <b>FolderID</b> values by using <b>GetSellingManagerInventoryFolder</b>. If this field is omitted, the Selling Manager Inventory folder specified in the <b>FolderID</b> field will be moved to the root level.
    /// </param>
    public void MoveSellingManagerInventoryFolder(long FolderID, long NewParentFolderID)
    {
      this.FolderID = FolderID;
      this.NewParentFolderID = NewParentFolderID;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.MoveSellingManagerInventoryFolderRequestType" /> for this API call.
    /// </summary>
    public MoveSellingManagerInventoryFolderRequestType ApiRequest
    {
      get => (MoveSellingManagerInventoryFolderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.MoveSellingManagerInventoryFolderResponseType" /> for this API call.
    /// </summary>
    public MoveSellingManagerInventoryFolderResponseType ApiResponse
    {
      get => (MoveSellingManagerInventoryFolderResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.MoveSellingManagerInventoryFolderRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.MoveSellingManagerInventoryFolderRequestType.NewParentFolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long NewParentFolderID
    {
      get => this.ApiRequest.NewParentFolderID;
      set => this.ApiRequest.NewParentFolderID = value;
    }
  }
}
