// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.ApiCredential
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Used to store credentials needed to make API calls to the eBay API server. Normally,
  /// <see cref="P:eBay.Service.Core.Sdk.ApiCredential.eBayToken" /> (which stores the authorization token) is used rather than the older
  /// <see cref="P:eBay.Service.Core.Sdk.ApiCredential.ApiAccount" />.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ApiCredential
  {
    private ApiAccount mApiAccount = new ApiAccount();
    private eBayAccount meBayAccount = new eBayAccount();
    private string meBayToken = "";
    private string moAuthToken = "";

    /// <summary>
    /// 
    /// </summary>
    public ApiCredential()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="eBayToken">The token to use when making API calls.</param>
    public ApiCredential(string eBayToken) => this.meBayToken = eBayToken;

    /// <summary>
    /// Authorization (user) tokens are valid for about 18 months, after which time they
    /// expire. This property can be read to determine when the token expires.
    /// </summary>
    /// <param name="expirationDate"></param>
    public void TokenHardExpirationWarning(DateTime expirationDate)
    {
      if (this.OnTokenHardExpirationWarning == null)
        return;
      this.OnTokenHardExpirationWarning((object) this, new TokenHardExpirationEventArgs(expirationDate));
    }

    /// <summary>
    /// Gets or sets the ApiAccount object used to store program credentials (Application, Developer,
    /// and Certificate IDs) if ApiAccount is used to supply these. This property is ignored if
    /// eBayToken is set. (Normally, eBayToken should be
    /// used instead of ApiAccount.) Type <see cref="P:eBay.Service.Core.Sdk.ApiCredential.ApiAccount" />.
    /// </summary>
    public ApiAccount ApiAccount
    {
      get => this.mApiAccount;
      set => this.mApiAccount = value;
    }

    /// <summary>
    /// Gets or sets the eBayAccount object used to store user credentials (eBay user id,
    /// password). This property is ignored if eBayToken is set. (Normally, eBayToken should be
    /// used instead.) Type <see cref="P:eBay.Service.Core.Sdk.ApiCredential.eBayAccount" />.
    /// </summary>
    public eBayAccount eBayAccount
    {
      get => this.meBayAccount;
      set => this.meBayAccount = value;
    }

    /// <summary>
    /// Gets or sets the eBayToken object used to store the authorization (user) token. Type <see cref="T:System.String" />.
    /// This token is required in order to make API calls, as it represents the user's authorization of your
    /// application to access eBay on behalf of that user. For more information on eBay authorization tokens,
    /// see <see href="http://developer.ebay.com/DevZone/XML/docs/WebHelp/GettingTokens-.html">Getting Tokens.</see>
    /// </summary>
    public string eBayToken
    {
      get => this.meBayToken;
      set => this.meBayToken = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string oAuthToken
    {
      get => this.moAuthToken;
      set => this.moAuthToken = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public event TokenHardExpirationWarningEventHandler OnTokenHardExpirationWarning;
  }
}
