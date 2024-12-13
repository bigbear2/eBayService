// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetUserCall
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
  public class GetUserCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetUserCall() => this.ApiRequest = new GetUserRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetUserCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetUserRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves data pertaining to a single eBay user. Callers can use this call to return their own user data or the data of another eBay user. Unless the caller passes in an <strong>ItemID</strong> value that identifies a current or past common order, not all data (like email addresses) will be returned in the response.
    /// </summary>
    /// <param name="ItemID">
    /// Specify the <strong>ItemID</strong> value for a successfully concluded listing in which the
    /// requestor and target user were participants (one as seller and the other
    /// as buyer). Necessary to return certain data (like an email address). Not
    /// necessary if the requestor is retrieving their own data.
    /// </param>
    /// <param name="UserID">
    /// Specify the user whose data you want returned by the call. If not specified, eBay returns data pertaining to the
    /// requesting user (as specified with the <strong>eBayAuthToken</strong> value).
    /// </param>
    /// <param name="IncludeExpressRequirements">
    /// This field is deprecated.
    /// </param>
    /// <param name="IncludeFeatureEligibility">
    /// If the <b>IncludeFeatureEligibility</b> flag is included and set to 'true', the call response will include a <b>QualifiesForSelling</b> flag which indicates if the eBay user is eligible to sell on eBay, and a <b>IncludeFeatureEligibility</b> container which indicates which selling features are available to the user.
    /// </param>
    public UserType GetUser(
      string ItemID,
      string UserID,
      bool IncludeExpressRequirements,
      bool IncludeFeatureEligibility)
    {
      this.ItemID = ItemID;
      this.UserID = UserID;
      this.IncludeExpressRequirements = IncludeExpressRequirements;
      this.IncludeFeatureEligibility = IncludeFeatureEligibility;
      this.Execute();
      return this.ApiResponse.User;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public UserType GetUser(string UserID)
    {
      this.UserID = UserID;
      this.Execute();
      return this.User;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public UserType GetUser()
    {
      this.Execute();
      return this.User;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public UserType GetUser(string UserID, string ItemID)
    {
      this.ItemID = ItemID;
      this.UserID = UserID;
      this.Execute();
      return this.ApiResponse.User;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetUserRequestType" /> for this API call.
    /// </summary>
    public GetUserRequestType ApiRequest
    {
      get => (GetUserRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetUserResponseType" /> for this API call.
    /// </summary>
    public GetUserResponseType ApiResponse => (GetUserResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserRequestType.UserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserID
    {
      get => this.ApiRequest.UserID;
      set => this.ApiRequest.UserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserRequestType.IncludeExpressRequirements" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeExpressRequirements
    {
      get => this.ApiRequest.IncludeExpressRequirements;
      set => this.ApiRequest.IncludeExpressRequirements = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserRequestType.IncludeFeatureEligibility" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeFeatureEligibility
    {
      get => this.ApiRequest.IncludeFeatureEligibility;
      set => this.ApiRequest.IncludeFeatureEligibility = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserResponseType.User" /> of type <see cref="T:eBay.Service.Core.Soap.UserType" />.
    /// </summary>
    public UserType User => this.ApiResponse.User;
  }
}
