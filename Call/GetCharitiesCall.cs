// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetCharitiesCall
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
  public class GetCharitiesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetCharitiesCall() => this.ApiRequest = new GetCharitiesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetCharitiesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetCharitiesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The <b>GetCharities</b> call is used to search for nonprofit organizations that are registered with the eBay for Charity program. This call allows users to search for a specific nonprofit organization, or to search for multiple nonprofit organizations from a particular charitable domain, and/or geographical region, or by using a search string.
    /// </summary>
    /// <param name="CharityID">
    /// A unique identification number assigned to a nonprofit
    /// organization when that organization registers with the PayPal Giving Fund. If a <b>CharityID</b> value is used in the request, all other search filters set in the call request will be ignored, as the call will only search for the specified nonprofit organization.
    /// </param>
    /// <param name="CharityName">
    /// This field will accept the full or partial name of a registered nonprofit organization. For example, if you pass in a value of <b>heart</b>, all registered nonprofit organizations with "heart" in their name may be returned in the response. If the <b>MatchType</b> field is used and set to <code>StartsWith</code> (default value), or is not used at all, the phrase "heart" must come at the beginning of the nonprofit organization's name to be returned. However, if the <b>MatchType</b> field is used and set to <code>Contains</code>, all registered nonprofit organizations with "heart" in their name should be returned in the response. The string passed in this field is not case-sensitive.
    /// <br /><br />
    /// </param>
    /// <param name="Query">
    /// This field accept any string up to 350 characters in length. The functionality of this field is similar to the <b>CharityName</b> field, except that the call will also search for the supplied query string within the charity's mission statement (which is returned under the <b>Charity.Mission</b> field in the response). If you pass in a value of <b>heart</b>, all registered nonprofit organizations with "heart" in their name or in their mission statement may be returned in the response.
    /// <br /><br />
    /// The string passed in this field is not case-sensitive. The <b>MatchType</b> field will have no effect if the <b>Query</b> field is used, as the <b>MatchType</b> field will only have an effect if a <b>CharityName</b> string field is included.
    /// <br /><br />
    /// </param>
    /// <param name="CharityRegion">
    /// This field can be used to search for registered nonprofit organizations within a specified geographical region. Each geographical region will have an integer value associated with it. This integer value is what is passed in to this field.
    /// </param>
    /// <param name="CharityDomain">
    /// This field can be used to search for registered nonprofit organizations within a specified charitable domain. Each charitable domain will have an integer value associated with it. This integer value is what is passed in to this field. Nonprofit organizations can be associated with multiple charitable domains.
    /// </param>
    /// <param name="IncludeDescription">
    /// This field should be included and set to <code>true</code> if a user wants the charity's description to appear in the response. Note that not all charitable organizations will have defined descriptions.
    /// </param>
    /// <param name="MatchType">
    /// This filter is used if the user wants to specify where to look for the string specified in the <b>CharityName</b> field. The enumeration value input into this field controls the type of string matching to use when a value is submitted in the
    /// <b>CharityName</b> field. If this field is omitted, and a <b>CharityName</b> string is used, this parameter value defaults to <code>StartsWith</code>.
    /// <br /><br />
    /// This field is not applicable when a <b>Query</b> value is used.
    /// <br />
    /// </param>
    /// <param name="Featured">
    /// This boolean field is used and set to <code>true</code> if the user wants to search for nonprofit organizations currently featured on the eBay for Charity site.
    /// </param>
    /// <param name="CampaignID">Reserved for future use.</param>
    public CharityInfoTypeCollection GetCharities(
      string CharityID,
      string CharityName,
      string Query,
      int CharityRegion,
      int CharityDomain,
      bool IncludeDescription,
      StringMatchCodeType MatchType,
      bool Featured,
      long CampaignID)
    {
      this.CharityID = CharityID;
      this.CharityName = CharityName;
      this.Query = Query;
      this.CharityRegion = CharityRegion;
      this.CharityDomain = CharityDomain;
      this.IncludeDescription = IncludeDescription;
      this.MatchType = MatchType;
      this.Featured = Featured;
      this.CampaignID = CampaignID;
      this.Execute();
      return this.ApiResponse.Charity;
    }

    /// <summary>to support the call with out parameters.</summary>
    public CharityInfoTypeCollection GetCharities()
    {
      this.Execute();
      return this.ApiResponse.Charity;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetCharitiesRequestType" /> for this API call.
    /// </summary>
    public GetCharitiesRequestType ApiRequest
    {
      get => (GetCharitiesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetCharitiesResponseType" /> for this API call.
    /// </summary>
    public GetCharitiesResponseType ApiResponse => (GetCharitiesResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.CharityID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CharityID
    {
      get => this.ApiRequest.CharityID;
      set => this.ApiRequest.CharityID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.CharityName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CharityName
    {
      get => this.ApiRequest.CharityName;
      set => this.ApiRequest.CharityName = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.Query" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Query
    {
      get => this.ApiRequest.Query;
      set => this.ApiRequest.Query = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.CharityRegion" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int CharityRegion
    {
      get => this.ApiRequest.CharityRegion;
      set => this.ApiRequest.CharityRegion = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.CharityDomain" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int CharityDomain
    {
      get => this.ApiRequest.CharityDomain;
      set => this.ApiRequest.CharityDomain = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.IncludeDescription" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeDescription
    {
      get => this.ApiRequest.IncludeDescription;
      set => this.ApiRequest.IncludeDescription = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.MatchType" /> of type <see cref="T:eBay.Service.Core.Soap.StringMatchCodeType" />.
    /// </summary>
    public StringMatchCodeType MatchType
    {
      get => this.ApiRequest.MatchType;
      set => this.ApiRequest.MatchType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.Featured" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool Featured
    {
      get => this.ApiRequest.Featured;
      set => this.ApiRequest.Featured = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCharitiesRequestType.CampaignID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long CampaignID
    {
      get => this.ApiRequest.CampaignID;
      set => this.ApiRequest.CampaignID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCharitiesResponseType.Charity" /> of type <see cref="T:eBay.Service.Core.Soap.CharityInfoTypeCollection" />.
    /// </summary>
    public CharityInfoTypeCollection CharityList => this.ApiResponse.Charity;
  }
}
