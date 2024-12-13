// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseSellingManagerInventoryFolderCall
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
  public class ReviseSellingManagerInventoryFolderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ReviseSellingManagerInventoryFolderCall()
    {
      this.ApiRequest = new ReviseSellingManagerInventoryFolderRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseSellingManagerInventoryFolderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseSellingManagerInventoryFolderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is uses to rename and/or move a Selling Manager Inventory folder.
    /// This call is subject to change without notice; the deprecation process is
    /// inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="Folder">
    /// This container is used to identify the Selling Manager Inventory folder that will be renamed and/or moved.
    /// </param>
    public SellingManagerFolderDetailsType ReviseSellingManagerInventoryFolder(
      SellingManagerFolderDetailsType Folder)
    {
      this.Folder = Folder;
      this.Execute();
      return this.ApiResponse.Folder;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseSellingManagerInventoryFolderRequestType" /> for this API call.
    /// </summary>
    public ReviseSellingManagerInventoryFolderRequestType ApiRequest
    {
      get => (ReviseSellingManagerInventoryFolderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseSellingManagerInventoryFolderResponseType" /> for this API call.
    /// </summary>
    public ReviseSellingManagerInventoryFolderResponseType ApiResponse
    {
      get => (ReviseSellingManagerInventoryFolderResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerInventoryFolderRequestType.Folder" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerFolderDetailsType" />.
    /// </summary>
    public SellingManagerFolderDetailsType Folder
    {
      get => this.ApiRequest.Folder;
      set => this.ApiRequest.Folder = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerInventoryFolderResponseType.Folder" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerFolderDetailsType" />.
    /// </summary>
    public SellingManagerFolderDetailsType FolderReturn => this.ApiResponse.Folder;
  }
}
