// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.SiteUtility
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
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class SiteUtility
  {
    /// <summary>Gets the Site associated with the numeric site id.</summary>
    /// <param name="SiteID">The numeric site id.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.</returns>
    public static SiteCodeType GetSiteCodeType(int SiteID)
    {
      return !Enum.IsDefined(typeof (SiteUtility.SiteValueEnum), (object) SiteID) ? SiteCodeType.CustomCode : (SiteCodeType) Enum.Parse(typeof (SiteCodeType), Enum.GetName(typeof (SiteUtility.SiteValueEnum), (object) SiteID));
    }

    /// <summary>Gets the numeric id associated with a site.</summary>
    /// <param name="SiteCodeType">The <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.</param>
    /// <returns>The numeric id associated with the <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.</returns>
    public static int GetSiteID(SiteCodeType SiteCodeType)
    {
      return !Enum.IsDefined(typeof (SiteUtility.SiteValueEnum), (object) SiteCodeType.ToString()) ? 0 : (int) Enum.Parse(typeof (SiteUtility.SiteValueEnum), Enum.GetName(typeof (SiteCodeType), (object) SiteCodeType));
    }

    /// <summary>Gets the CountryCodeType associated with a site.</summary>
    /// <param name="SiteCodeType">The <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.</param>
    /// <returns>CountryCodeType associted with the <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.</returns>
    public static CountryCodeType GetCountryCodeType(SiteCodeType SiteCodeType)
    {
      CountryCodeType countryCodeType;
      switch (SiteCodeType)
      {
        case SiteCodeType.US:
        case SiteCodeType.eBayMotors:
          countryCodeType = CountryCodeType.US;
          break;
        case SiteCodeType.Canada:
          countryCodeType = CountryCodeType.CA;
          break;
        case SiteCodeType.UK:
          countryCodeType = CountryCodeType.GB;
          break;
        case SiteCodeType.Australia:
          countryCodeType = CountryCodeType.AU;
          break;
        case SiteCodeType.Austria:
          countryCodeType = CountryCodeType.AT;
          break;
        case SiteCodeType.Belgium_French:
        case SiteCodeType.Belgium_Dutch:
          countryCodeType = CountryCodeType.BE;
          break;
        case SiteCodeType.France:
          countryCodeType = CountryCodeType.FR;
          break;
        case SiteCodeType.Germany:
          countryCodeType = CountryCodeType.DE;
          break;
        case SiteCodeType.Italy:
          countryCodeType = CountryCodeType.IT;
          break;
        case SiteCodeType.Netherlands:
          countryCodeType = CountryCodeType.NL;
          break;
        case SiteCodeType.Spain:
          countryCodeType = CountryCodeType.ES;
          break;
        case SiteCodeType.Switzerland:
          countryCodeType = CountryCodeType.CH;
          break;
        case SiteCodeType.Taiwan:
          countryCodeType = CountryCodeType.TW;
          break;
        case SiteCodeType.HongKong:
          countryCodeType = CountryCodeType.HK;
          break;
        case SiteCodeType.Singapore:
          countryCodeType = CountryCodeType.SG;
          break;
        case SiteCodeType.India:
          countryCodeType = CountryCodeType.IN;
          break;
        case SiteCodeType.China:
          countryCodeType = CountryCodeType.CN;
          break;
        case SiteCodeType.Malaysia:
          countryCodeType = CountryCodeType.MY;
          break;
        case SiteCodeType.Philippines:
          countryCodeType = CountryCodeType.PH;
          break;
        default:
          countryCodeType = CountryCodeType.US;
          break;
      }
      return countryCodeType;
    }

    /// <summary>
    /// 
    /// </summary>
    private enum SiteValueEnum
    {
      US = 0,
      Canada = 2,
      UK = 3,
      Australia = 15, // 0x0000000F
      Austria = 16, // 0x00000010
      Belgium_French = 23, // 0x00000017
      France = 71, // 0x00000047
      Germany = 77, // 0x0000004D
      eBayMotors = 100, // 0x00000064
      Italy = 101, // 0x00000065
      Belgium_Dutch = 123, // 0x0000007B
      Netherlands = 146, // 0x00000092
      Spain = 186, // 0x000000BA
      Switzerland = 193, // 0x000000C1
      Taiwan = 196, // 0x000000C4
      HongKong = 201, // 0x000000C9
      India = 203, // 0x000000CB
      Ireland = 205, // 0x000000CD
      Malaysia = 207, // 0x000000CF
      NewZealand = 208, // 0x000000D0
      CanadaFrench = 210, // 0x000000D2
      Philippines = 211, // 0x000000D3
      Poland = 212, // 0x000000D4
      Singapore = 216, // 0x000000D8
      Sweden = 218, // 0x000000DA
      China = 223, // 0x000000DF
    }
  }
}
