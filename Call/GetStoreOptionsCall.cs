// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetStoreOptionsCall
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
  public class GetStoreOptionsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetStoreOptionsCall() => this.ApiRequest = new GetStoreOptionsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetStoreOptionsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetStoreOptionsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to retrieve the current list of eBay Store configuration settings.
    /// </summary>
    public StoreThemeTypeCollection GetStoreOptions()
    {
      this.Execute();
      return this.ApiResponse.BasicThemeArray.Theme;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetStoreOptionsRequestType" /> for this API call.
    /// </summary>
    public GetStoreOptionsRequestType ApiRequest
    {
      get => (GetStoreOptionsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetStoreOptionsResponseType" /> for this API call.
    /// </summary>
    public GetStoreOptionsResponseType ApiResponse
    {
      get => (GetStoreOptionsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreOptionsResponseType.BasicThemeArray" /> of type <see cref="T:eBay.Service.Core.Soap.StoreThemeArrayType" />.
    /// </summary>
    public StoreThemeArrayType BasicThemeArray => this.ApiResponse.BasicThemeArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreOptionsResponseType.AdvancedThemeArray" /> of type <see cref="T:eBay.Service.Core.Soap.StoreThemeArrayType" />.
    /// </summary>
    public StoreThemeArrayType AdvancedThemeArray => this.ApiResponse.AdvancedThemeArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreOptionsResponseType.LogoArray" /> of type <see cref="T:eBay.Service.Core.Soap.StoreLogoTypeCollection" />.
    /// </summary>
    public StoreLogoTypeCollection LogoList => this.ApiResponse.LogoArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreOptionsResponseType.SubscriptionArray" /> of type <see cref="T:eBay.Service.Core.Soap.StoreSubscriptionTypeCollection" />.
    /// </summary>
    public StoreSubscriptionTypeCollection SubscriptionList => this.ApiResponse.SubscriptionArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreOptionsResponseType.MaxCategories" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int MaxCategories => this.ApiResponse.MaxCategories;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreOptionsResponseType.MaxCategoryLevels" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int MaxCategoryLevels => this.ApiResponse.MaxCategoryLevels;
  }
}
