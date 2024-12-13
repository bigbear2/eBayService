// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetContextualKeywordsCall
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
  public class GetContextualKeywordsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetContextualKeywordsCall() => this.ApiRequest = new GetContextualKeywordsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetContextualKeywordsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetContextualKeywordsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves top-ranked contextual eBay keywords and categories
    /// for a specified web page.
    /// </summary>
    /// <param name="URL">
    /// The URL of the web page from which eBay is to extract keywords.
    /// </param>
    /// <param name="Encoding">
    /// Web page encoding by which the URL is to be handled, such as ISO-8859-1.
    /// </param>
    /// <param name="CategoryIDList">
    /// The ID of the category to which keywords are to be limited.
    /// Zero or more category IDs can be specified.
    /// </param>
    public ContextSearchAssetTypeCollection GetContextualKeywords(
      string URL,
      string Encoding,
      StringCollection CategoryIDList)
    {
      this.URL = URL;
      this.Encoding = Encoding;
      this.CategoryIDList = CategoryIDList;
      this.Execute();
      return this.ApiResponse.ContextSearchAsset;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetContextualKeywordsRequestType" /> for this API call.
    /// </summary>
    public GetContextualKeywordsRequestType ApiRequest
    {
      get => (GetContextualKeywordsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetContextualKeywordsResponseType" /> for this API call.
    /// </summary>
    public GetContextualKeywordsResponseType ApiResponse
    {
      get => (GetContextualKeywordsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetContextualKeywordsRequestType.URL" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string URL
    {
      get => this.ApiRequest.URL;
      set => this.ApiRequest.URL = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetContextualKeywordsRequestType.Encoding" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Encoding
    {
      get => this.ApiRequest.Encoding;
      set => this.ApiRequest.Encoding = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetContextualKeywordsRequestType.CategoryID" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection CategoryIDList
    {
      get => this.ApiRequest.CategoryID;
      set => this.ApiRequest.CategoryID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetContextualKeywordsResponseType.ContextSearchAsset" /> of type <see cref="T:eBay.Service.Core.Soap.ContextSearchAssetTypeCollection" />.
    /// </summary>
    public ContextSearchAssetTypeCollection ContextSearchAssetList
    {
      get => this.ApiResponse.ContextSearchAsset;
    }
  }
}
