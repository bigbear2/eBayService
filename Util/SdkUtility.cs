// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.SdkUtility
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Web;


namespace eBay.Service.Util
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class SdkUtility
  {
    /// <summary>
    /// Launches the sign in page for using the  Authentication &amp; Authorization feature.
    /// </summary>
    /// <param name="Context">The <see cref="T:eBay.Service.Core.Sdk.ApiContext" /> which defines the SignInUrl and RuName.</param>
    /// <param name="SessionID">The SessionID which is used by <see cref="T:eBay.Service.Call.FetchTokenCall" /> to retrieve the token.</param>
    public static void LaunchSignInPage(ApiContext Context, string SessionID)
    {
      if (Context == null)
        throw new SdkException("Please specify the Context.", (Exception) new ArgumentNullException());
      if (Context.SignInUrl == null || Context.SignInUrl.ToString().Length == 0)
        throw new SdkException("Please specify the SignInUrl in the Context object.", (Exception) new ArgumentNullException());
      if (Context.RuName == null || Context.RuName.Length == 0)
        throw new SdkException("Please specify a RuName.", (Exception) new ArgumentNullException());
      string fileName = Context.SignInUrl + "&RuName=" + Context.RuName;
      if (SessionID != null && SessionID.Length > 0)
        fileName = fileName + "&SessID=" + HttpUtility.UrlEncode(SessionID);
      Process.Start(fileName);
    }
  }
}
