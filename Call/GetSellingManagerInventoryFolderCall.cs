// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellingManagerInventoryFolderCall
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
  public class GetSellingManagerInventoryFolderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellingManagerInventoryFolderCall()
    {
      this.ApiRequest = new GetSellingManagerInventoryFolderRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellingManagerInventoryFolderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellingManagerInventoryFolderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves Selling Manager Inventory folders.
    /// This call is subject to change without notice; the deprecation process is
    /// inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="FolderID">
    /// A unique identifier for a Selling Manager Inventory folder. The <b>FolderID</b> is used if the seller wants to retrieve a specific folder.
    /// </param>
    /// <param name="MaxDepth">
    /// This field is used to specify the number of levels of subfolders to be returned in the response. If 0, the parent folder is returned. If 1, the parent and child folders are returned. If 2, the parent and two levels of child folders are returned. Ignored if the <b>FullRecursion</b> field is included and set to <code>True</code>.
    /// <br />
    /// </param>
    /// <param name="FullRecursion">
    /// Displays the entire tree of a user's Selling Manager Inventory folders. If this is provided, the <b>FolderID</b> and <b>MaxDepth</b> fields are no longer applicable.
    /// </param>
    public SellingManagerFolderDetailsType GetSellingManagerInventoryFolder(
      long FolderID,
      int MaxDepth,
      bool FullRecursion)
    {
      this.FolderID = FolderID;
      this.MaxDepth = MaxDepth;
      this.FullRecursion = FullRecursion;
      this.Execute();
      return this.ApiResponse.Folder;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerInventoryFolderRequestType" /> for this API call.
    /// </summary>
    public GetSellingManagerInventoryFolderRequestType ApiRequest
    {
      get => (GetSellingManagerInventoryFolderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerInventoryFolderResponseType" /> for this API call.
    /// </summary>
    public GetSellingManagerInventoryFolderResponseType ApiResponse
    {
      get => (GetSellingManagerInventoryFolderResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryFolderRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryFolderRequestType.MaxDepth" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int MaxDepth
    {
      get => this.ApiRequest.MaxDepth;
      set => this.ApiRequest.MaxDepth = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryFolderRequestType.FullRecursion" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool FullRecursion
    {
      get => this.ApiRequest.FullRecursion;
      set => this.ApiRequest.FullRecursion = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryFolderResponseType.Folder" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerFolderDetailsType" />.
    /// </summary>
    public SellingManagerFolderDetailsType Folder => this.ApiResponse.Folder;
  }
}
