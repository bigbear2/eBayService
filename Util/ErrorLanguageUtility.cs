// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.ErrorLanguageUtility
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Util
{
  /// <summary>
  /// The default error language is the one used on the site being accessed in the
  /// API call. You can change the default to any language, so that the error messages
  /// are displayed in the language of your choice.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ErrorLanguageUtility
  {
    /// <summary>
    /// Gets the default numeric error language id associated with a <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.
    /// </summary>
    /// <param name="SiteCodeType">The <see cref="T:eBay.Service.Core.Soap.SiteCodeType" /> to resolve.</param>
    /// <returns>The numeric language id.</returns>
    public static int GetDefaultErrorLanguageID(SiteCodeType SiteCodeType)
    {
      int siteId = SiteUtility.GetSiteID(SiteCodeType);
      return !Enum.IsDefined(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), (object) siteId) ? 0 : siteId;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ErrorLanguageCodeType" /> associated with a <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.
    /// </summary>
    /// <param name="SiteCodeType">The <see cref="T:eBay.Service.Core.Soap.SiteCodeType" /> to resolve.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Soap.ErrorLanguageCodeType" />.</returns>
    public static ErrorLanguageCodeType GetDefaultErrorLanguageCodeType(SiteCodeType SiteCodeType)
    {
      int siteId = SiteUtility.GetSiteID(SiteCodeType);
      if (siteId == 100)
        return ErrorLanguageCodeType.en_US;
      return !Enum.IsDefined(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), (object) siteId) ? ErrorLanguageCodeType.CustomCode : (ErrorLanguageCodeType) Enum.Parse(typeof (ErrorLanguageCodeType), Enum.GetName(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), (object) siteId));
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ErrorLanguageCodeType" /> associated with the numeric error language id.
    /// </summary>
    /// <param name="ErrorLanguageID">The numeric language id to resolve.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Soap.ErrorLanguageCodeType" />.</returns>
    public static ErrorLanguageCodeType GetErrorLanguageCodeType(int ErrorLanguageID)
    {
      return !Enum.IsDefined(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), (object) ErrorLanguageID) ? ErrorLanguageCodeType.CustomCode : (ErrorLanguageCodeType) Enum.Parse(typeof (ErrorLanguageCodeType), Enum.GetName(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), (object) ErrorLanguageID));
    }

    /// <summary>
    /// Gets the numeric error language id from the <see cref="T:eBay.Service.Core.Soap.ErrorLanguageCodeType" />.
    /// </summary>
    /// <param name="ErrorLanguageCodeType">The <see cref="T:eBay.Service.Core.Soap.ErrorLanguageCodeType" /> to resolve.</param>
    /// <returns>The numeric error language id.</returns>
    public static int GetErrorLanguageID(ErrorLanguageCodeType ErrorLanguageCodeType)
    {
      return !Enum.IsDefined(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), (object) ErrorLanguageCodeType.ToString()) ? 0 : (int) Enum.Parse(typeof (ErrorLanguageUtility.ErrorLanguageValueEnum), Enum.GetName(typeof (ErrorLanguageCodeType), (object) ErrorLanguageCodeType));
    }

    /// <summary>
    /// 
    /// </summary>
    private enum ErrorLanguageValueEnum
    {
      en_US = 0,
      en_CA = 2,
      en_GB = 3,
      en_AU = 15, // 0x0000000F
      de_AT = 16, // 0x00000010
      fr_BE = 23, // 0x00000017
      fr_FR = 71, // 0x00000047
      de_DE = 77, // 0x0000004D
      it_IT = 101, // 0x00000065
      nl_BE = 123, // 0x0000007B
      nl_NL = 146, // 0x00000092
      es_ES = 186, // 0x000000BA
      de_CH = 193, // 0x000000C1
      zh_TW = 196, // 0x000000C4
      en_HK = 201, // 0x000000C9
      en_IN = 203, // 0x000000CB
      en_MY = 207, // 0x000000CF
      en_PH = 211, // 0x000000D3
      en_SG = 216, // 0x000000D8
      zh_CN = 223, // 0x000000DF
    }
  }
}
