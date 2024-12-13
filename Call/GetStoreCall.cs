// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetStoreCall
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
  public class GetStoreCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetStoreCall() => this.ApiRequest = new GetStoreRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetStoreCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetStoreRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to retrieve detailed information on a seller's eBay Store, including store theme information and eBay Store category hierarchy.
    /// </summary>
    /// <param name="CategoryStructureOnly">
    /// Include this field and set its value to <code>true</code> if you wish to restrict the call response to only the store category hierarchy data. If this field is not included or set to <code>false</code>, store category hierarchy and all store configuration data is returned.
    /// </param>
    /// <param name="RootCategoryID">
    /// The unique identifier of an eBay Store category. This field is used if the user wants to isolate the category hierarchy data to one particular eBay category (and its subcategories if applicable). The <b>LevelLimit</b> value will determine how many additional levels of categories are returned.
    /// </param>
    /// <param name="LevelLimit">
    /// This field allows the seller to limit the number of levels of eBay Store categories that are returned. To return only top-level eBay Store categories, the user can include this field and set its value to <code>1</code> (and not use a <b>RootCategoryID</b> value). To retrieve a specific eBay Store Category and that category's child categories, the user could specify the unique eBay Store Category ID in the <b>RootCategoryID</b> field and then set the <b>LevelLimit</b> value to <code>2</code>.
    /// <br /><br />
    /// If <b>LevelLimit</b> is omitted, the complete eBay Store Category hierarchy is returned, or all of specified store category's child categories. Currently, eBay Stores support only three levels of store categories.
    /// </param>
    /// <param name="UserID">
    /// The unique identifier for an eBay Store owner. This field is only required if the user wants to view the eBay Store theme and category information for a different eBay Store owner. If this field is omitted, eBay Store theme and category information is returned for the eBay Store owner that is making the call.
    /// </param>
    public StoreType GetStore(
      bool CategoryStructureOnly,
      long RootCategoryID,
      int LevelLimit,
      string UserID)
    {
      this.CategoryStructureOnly = CategoryStructureOnly;
      this.RootCategoryID = RootCategoryID;
      this.LevelLimit = LevelLimit;
      this.UserID = UserID;
      this.Execute();
      return this.ApiResponse.Store;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public StoreType GetStore()
    {
      this.Execute();
      return this.ApiResponse.Store;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public StoreType GetStore(bool CategoryStructureOnly, long RootCategoryID, int LevelLimit)
    {
      this.CategoryStructureOnly = CategoryStructureOnly;
      this.RootCategoryID = RootCategoryID;
      this.LevelLimit = LevelLimit;
      this.Execute();
      return this.ApiResponse.Store;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetStoreRequestType" /> for this API call.
    /// </summary>
    public GetStoreRequestType ApiRequest
    {
      get => (GetStoreRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetStoreResponseType" /> for this API call.
    /// </summary>
    public GetStoreResponseType ApiResponse => (GetStoreResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetStoreRequestType.CategoryStructureOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool CategoryStructureOnly
    {
      get => this.ApiRequest.CategoryStructureOnly;
      set => this.ApiRequest.CategoryStructureOnly = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetStoreRequestType.RootCategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long RootCategoryID
    {
      get => this.ApiRequest.RootCategoryID;
      set => this.ApiRequest.RootCategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetStoreRequestType.LevelLimit" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int LevelLimit
    {
      get => this.ApiRequest.LevelLimit;
      set => this.ApiRequest.LevelLimit = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetStoreRequestType.UserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserID
    {
      get => this.ApiRequest.UserID;
      set => this.ApiRequest.UserID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreResponseType.Store" /> of type <see cref="T:eBay.Service.Core.Soap.StoreType" />.
    /// </summary>
    public StoreType Store => this.ApiResponse.Store;
  }
}
