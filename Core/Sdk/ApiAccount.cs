// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.ApiAccount
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Optionally used to contain application ID, developer ID, and cert, formerly used by the API calls.
  /// This has now been replaced by the authorization (user) token stored in the
  /// <see cref="P:eBay.Service.Core.Sdk.ApiCredential.eBayToken" /> property. Note that if you use ApiCredential.eBayToken, the properties
  /// in the <see cref="P:eBay.Service.Core.Sdk.ApiCredential.ApiAccount" /> property are not automatically set with any ID or cert information derived
  /// from the token.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ApiAccount
  {
    private string mApplication = "";
    private string mCertificate = "";
    private string mDeveloper = "";

    /// <summary>
    /// 
    /// </summary>
    public ApiAccount()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Developer">The <see cref="P:eBay.Service.Core.Sdk.ApiAccount.Developer" /> credential.</param>
    /// <param name="Application">The <see cref="P:eBay.Service.Core.Sdk.ApiAccount.Application" /> credential.</param>
    /// <param name="Certificate">The <see cref="P:eBay.Service.Core.Sdk.ApiAccount.Certificate" /> credential.</param>
    public ApiAccount(string Developer, string Application, string Certificate)
    {
      this.mDeveloper = Developer;
      this.mApplication = Application;
      this.mCertificate = Certificate;
    }

    /// <summary>
    /// Gets or sets the Application ID to use. The application ID for a developer
    /// application is manually obtained from the eBay developer account.
    /// </summary>
    public string Application
    {
      get => this.mApplication;
      set => this.mApplication = value;
    }

    /// <summary>
    /// Gets or sets the Certificate credential to use. The Certificate for a developer
    /// application is manually obtained from the eBay developer account.
    /// </summary>
    public string Certificate
    {
      get => this.mCertificate;
      set => this.mCertificate = value;
    }

    /// <summary>
    /// Gets or sets the Developer ID to use. The Developer ID is manually obtained
    /// from the eBay developer account.
    /// </summary>
    public string Developer
    {
      get => this.mDeveloper;
      set => this.mDeveloper = value;
    }
  }
}
