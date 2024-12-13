// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddSellingManagerInventoryFolderCall
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
  public class AddSellingManagerInventoryFolderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddSellingManagerInventoryFolderCall()
    {
      this.ApiRequest = new AddSellingManagerInventoryFolderRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddSellingManagerInventoryFolderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddSellingManagerInventoryFolderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Adds a new product folder to a user's Selling Manager account.
    /// </summary>
    /// <param name="FolderName">
    /// Name of the new Selling Manager inventory folder.
    /// </param>
    /// <param name="ParentFolderID">
    /// Unique identifier of the parent Selling Manager inventory folder. If no <b>ParentFolderID</b> is submitted, the folder
    /// is added at the root level.
    /// </param>
    /// <param name="Comment">
    /// Contains comments that will be associated with this folder.
    /// </param>
    public long AddSellingManagerInventoryFolder(
      string FolderName,
      long ParentFolderID,
      string Comment)
    {
      this.FolderName = FolderName;
      this.ParentFolderID = ParentFolderID;
      this.Comment = Comment;
      this.Execute();
      return this.ApiResponse.FolderID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddSellingManagerInventoryFolderRequestType" /> for this API call.
    /// </summary>
    public AddSellingManagerInventoryFolderRequestType ApiRequest
    {
      get => (AddSellingManagerInventoryFolderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddSellingManagerInventoryFolderResponseType" /> for this API call.
    /// </summary>
    public AddSellingManagerInventoryFolderResponseType ApiResponse
    {
      get => (AddSellingManagerInventoryFolderResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerInventoryFolderRequestType.FolderName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string FolderName
    {
      get => this.ApiRequest.FolderName;
      set => this.ApiRequest.FolderName = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerInventoryFolderRequestType.ParentFolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ParentFolderID
    {
      get => this.ApiRequest.ParentFolderID;
      set => this.ApiRequest.ParentFolderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerInventoryFolderRequestType.Comment" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Comment
    {
      get => this.ApiRequest.Comment;
      set => this.ApiRequest.Comment = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerInventoryFolderResponseType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID => this.ApiResponse.FolderID;
  }
}
