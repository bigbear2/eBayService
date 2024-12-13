// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetStoreCategoriesCall
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
  public class SetStoreCategoriesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetStoreCategoriesCall() => this.ApiRequest = new SetStoreCategoriesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetStoreCategoriesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetStoreCategoriesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call allows you to set or modify the category structure of an eBay Store. Sellers must have an eBay Store subscription in order to use this call.
    /// </summary>
    /// <param name="Action">
    /// Specifies the type of action (Add, Move, Delete, or Rename) to carry out
    /// for the specified eBay Store categories.
    /// </param>
    /// <param name="ItemDestinationCategoryID">
    /// Items can only be contained within child categories. A parent category
    /// cannot contain items. If adding, moving, or deleting categories displaces
    /// items, you must specify a destination child category under which the
    /// displaced items will be moved. The destination category must have no
    /// child categories.
    /// </param>
    /// <param name="DestinationParentCategoryID">
    /// When adding or moving store categories, specifies the category under
    /// which the listed categories will be located. To add or move categories to
    /// the top level, set the value to -999.
    /// </param>
    /// <param name="StoreCategoryList">
    /// Specifies the store categories on which to act.
    /// </param>
    public long SetStoreCategories(
      StoreCategoryUpdateActionCodeType Action,
      long ItemDestinationCategoryID,
      long DestinationParentCategoryID,
      StoreCustomCategoryTypeCollection StoreCategoryList)
    {
      this.Action = Action;
      this.ItemDestinationCategoryID = ItemDestinationCategoryID;
      this.DestinationParentCategoryID = DestinationParentCategoryID;
      this.StoreCategoryList = StoreCategoryList;
      this.Execute();
      return this.ApiResponse.TaskID;
    }

    public long SetStoreCategories(
      StoreCategoryUpdateActionCodeType Action,
      StoreCustomCategoryTypeCollection StoreCategoryList)
    {
      this.Action = Action;
      this.StoreCategoryList = StoreCategoryList;
      this.Execute();
      return this.ApiResponse.TaskID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetStoreCategoriesRequestType" /> for this API call.
    /// </summary>
    public SetStoreCategoriesRequestType ApiRequest
    {
      get => (SetStoreCategoriesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetStoreCategoriesResponseType" /> for this API call.
    /// </summary>
    public SetStoreCategoriesResponseType ApiResponse
    {
      get => (SetStoreCategoriesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesRequestType.Action" /> of type <see cref="T:eBay.Service.Core.Soap.StoreCategoryUpdateActionCodeType" />.
    /// </summary>
    public StoreCategoryUpdateActionCodeType Action
    {
      get => this.ApiRequest.Action;
      set => this.ApiRequest.Action = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesRequestType.ItemDestinationCategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ItemDestinationCategoryID
    {
      get => this.ApiRequest.ItemDestinationCategoryID;
      set => this.ApiRequest.ItemDestinationCategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesRequestType.DestinationParentCategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long DestinationParentCategoryID
    {
      get => this.ApiRequest.DestinationParentCategoryID;
      set => this.ApiRequest.DestinationParentCategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesRequestType.StoreCategories" /> of type <see cref="T:eBay.Service.Core.Soap.StoreCustomCategoryTypeCollection" />.
    /// </summary>
    public StoreCustomCategoryTypeCollection StoreCategoryList
    {
      get => this.ApiRequest.StoreCategories;
      set => this.ApiRequest.StoreCategories = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesResponseType.TaskID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long TaskID => this.ApiResponse.TaskID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesResponseType.Status" /> of type <see cref="T:eBay.Service.Core.Soap.TaskStatusCodeType" />.
    /// </summary>
    public TaskStatusCodeType Status => this.ApiResponse.Status;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetStoreCategoriesResponseType.CustomCategory" /> of type <see cref="T:eBay.Service.Core.Soap.StoreCustomCategoryTypeCollection" />.
    /// </summary>
    public StoreCustomCategoryTypeCollection CustomCategoryList => this.ApiResponse.CustomCategory;
  }
}
