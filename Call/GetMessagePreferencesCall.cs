// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetMessagePreferencesCall
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
  public class GetMessagePreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetMessagePreferencesCall() => this.ApiRequest = new GetMessagePreferencesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetMessagePreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetMessagePreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Returns a seller's Ask Seller a Question (ASQ) subjects, each in
    /// its own <b>Subject</b> field.
    /// </summary>
    /// <param name="SellerID">
    /// The eBay user ID of the seller to retrieve ASQ subjects for. A user can retrieve their own ASQ subjects or those of another eBay user with a seller account.
    /// </param>
    /// <param name="IncludeASQPreferences">
    /// This field must be included and set to <code>true</code> to retrieve the ASQ subjects for the specified eBay user.
    /// </param>
    public ASQPreferencesType GetMessagePreferences(string SellerID, bool IncludeASQPreferences)
    {
      this.SellerID = SellerID;
      this.IncludeASQPreferences = IncludeASQPreferences;
      this.Execute();
      return this.ApiResponse.ASQPreferences;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetMessagePreferencesRequestType" /> for this API call.
    /// </summary>
    public GetMessagePreferencesRequestType ApiRequest
    {
      get => (GetMessagePreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetMessagePreferencesResponseType" /> for this API call.
    /// </summary>
    public GetMessagePreferencesResponseType ApiResponse
    {
      get => (GetMessagePreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMessagePreferencesRequestType.SellerID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SellerID
    {
      get => this.ApiRequest.SellerID;
      set => this.ApiRequest.SellerID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMessagePreferencesRequestType.IncludeASQPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeASQPreferences
    {
      get => this.ApiRequest.IncludeASQPreferences;
      set => this.ApiRequest.IncludeASQPreferences = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMessagePreferencesResponseType.ASQPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.ASQPreferencesType" />.
    /// </summary>
    public ASQPreferencesType ASQPreferences => this.ApiResponse.ASQPreferences;
  }
}
