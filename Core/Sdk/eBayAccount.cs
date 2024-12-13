// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.eBayAccount
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Used to store eBay user ID and password, normally as credentials needed for some
  /// API calls. Normally, <see cref="P:eBay.Service.Core.Sdk.ApiCredential.eBayToken" /> is used instead for
  /// API call access.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class eBayAccount
  {
    private string mPassword = "";
    private string mUserName = "";

    /// <summary>
    /// 
    /// </summary>
    public eBayAccount()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="UserName">The eBay UserId to use.</param>
    /// <param name="Password">The user's password.</param>
    public eBayAccount(string UserName, string Password)
    {
      this.mUserName = UserName;
      this.mPassword = Password;
    }

    /// <summary>
    /// Gets or sets the user's password of type <see cref="T:System.String" />.
    /// </summary>
    public string Password
    {
      get => this.mPassword;
      set => this.mPassword = value;
    }

    /// <summary>
    /// Gets or sets the user's id of type <see cref="T:System.String" />.
    /// </summary>
    public string UserName
    {
      get => this.mUserName;
      set => this.mUserName = value;
    }

    /// <summary>this will return the UserName only</summary>
    /// <returns></returns>
    public override string ToString() => this.mUserName;
  }
}
