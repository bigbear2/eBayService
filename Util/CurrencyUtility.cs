// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.CurrencyUtility
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
  public class CurrencyUtility
  {
    /// <summary>Gets the currency symbol from the CurrencyCodeType</summary>
    /// <param name="currency">a CurrencyCodeType to get symbol from</param>
    /// <returns>a currency symbol</returns>
    public static string GetCurrencySymbol(CurrencyCodeType currency)
    {
      return currency == CurrencyCodeType.USD ? "$" : "(" + Enum.GetName(typeof (CurrencyCodeType), (object) currency) + ")";
    }

    /// <summary>return the string representation of the AmountType</summary>
    /// <param name="amt">amount</param>
    /// <returns>string representation of the amount</returns>
    public static string GetAmountString(AmountType amt)
    {
      return amt == null ? "" : CurrencyUtility.GetCurrencySymbol(amt.currencyID) + (object) amt.Value;
    }

    /// <summary>
    /// return the AmountType object from an amount string in following format:
    /// 	$amt or (LBP)amt
    /// </summary>
    /// <param name="amtStr">an amount string</param>
    /// <returns>an AmountType</returns>
    public static AmountType GetAmountType(string amtStr)
    {
      if (amtStr == null || amtStr.Trim().Length == 0)
        return (AmountType) null;
      if (amtStr.StartsWith("$"))
      {
        string str = amtStr.Substring(1, amtStr.Length - 1);
        return new AmountType()
        {
          currencyID = CurrencyCodeType.USD,
          Value = Convert.ToDouble(str)
        };
      }
      int num = amtStr.IndexOf(")");
      if (num > 0)
      {
        string str = amtStr.Substring(num + 1, amtStr.Length - num - 1);
        return new AmountType()
        {
          currencyID = (CurrencyCodeType) Enum.Parse(typeof (CurrencyCodeType), amtStr.Substring(1, num - 1)),
          Value = Convert.ToDouble(str)
        };
      }
      return new AmountType()
      {
        currencyID = CurrencyCodeType.USD,
        Value = Convert.ToDouble(amtStr)
      };
    }

    /// <summary>
    /// Gets the default <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" /> associated with a site.
    /// </summary>
    /// <param name="SiteCodeType">The <see cref="T:eBay.Service.Core.Soap.SiteCodeType" />.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.</returns>
    public static CurrencyCodeType GetDefaultCurrencyCodeType(SiteCodeType SiteCodeType)
    {
      CurrencyCodeType currencyCodeType;
      switch (SiteCodeType)
      {
        case SiteCodeType.US:
        case SiteCodeType.eBayMotors:
          currencyCodeType = CurrencyCodeType.USD;
          break;
        case SiteCodeType.Canada:
          currencyCodeType = CurrencyCodeType.CAD;
          break;
        case SiteCodeType.UK:
          currencyCodeType = CurrencyCodeType.GBP;
          break;
        case SiteCodeType.Australia:
          currencyCodeType = CurrencyCodeType.AUD;
          break;
        case SiteCodeType.Austria:
        case SiteCodeType.Belgium_French:
        case SiteCodeType.France:
        case SiteCodeType.Germany:
        case SiteCodeType.Italy:
        case SiteCodeType.Belgium_Dutch:
        case SiteCodeType.Netherlands:
        case SiteCodeType.Spain:
        case SiteCodeType.Ireland:
          currencyCodeType = CurrencyCodeType.EUR;
          break;
        case SiteCodeType.Switzerland:
          currencyCodeType = CurrencyCodeType.CHF;
          break;
        case SiteCodeType.Taiwan:
          currencyCodeType = CurrencyCodeType.TWD;
          break;
        case SiteCodeType.HongKong:
          currencyCodeType = CurrencyCodeType.HKD;
          break;
        case SiteCodeType.Singapore:
          currencyCodeType = CurrencyCodeType.SGD;
          break;
        case SiteCodeType.India:
          currencyCodeType = CurrencyCodeType.INR;
          break;
        case SiteCodeType.China:
          currencyCodeType = CurrencyCodeType.CNY;
          break;
        case SiteCodeType.Malaysia:
          currencyCodeType = CurrencyCodeType.MYR;
          break;
        case SiteCodeType.Philippines:
          currencyCodeType = CurrencyCodeType.PHP;
          break;
        case SiteCodeType.Poland:
          currencyCodeType = CurrencyCodeType.PLN;
          break;
        default:
          currencyCodeType = CurrencyCodeType.USD;
          break;
      }
      return currencyCodeType;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" /> associated with a numeric currency id.
    /// </summary>
    /// <param name="CurrencyID">The numeric currency id.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.</returns>
    public static CurrencyCodeType GetCurrencyCodeType(int CurrencyID)
    {
      return !Enum.IsDefined(typeof (CurrencyUtility.CurrencyValueEnum), (object) CurrencyID) ? CurrencyCodeType.CustomCode : (CurrencyCodeType) Enum.Parse(typeof (CurrencyCodeType), Enum.GetName(typeof (CurrencyUtility.CurrencyValueEnum), (object) CurrencyID));
    }

    /// <summary>
    /// Gets the numeric currency id of a <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.
    /// </summary>
    /// <param name="CurrencyCodeType">The <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.</param>
    /// <returns>The numeric id associated with the <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.</returns>
    public static int GetCurrencyID(CurrencyCodeType CurrencyCodeType)
    {
      return !Enum.IsDefined(typeof (CurrencyUtility.CurrencyValueEnum), (object) CurrencyCodeType.ToString()) ? -1 : (int) Enum.Parse(typeof (CurrencyUtility.CurrencyValueEnum), Enum.GetName(typeof (CurrencyCodeType), (object) CurrencyCodeType));
    }

    /// <summary>
    /// 
    /// </summary>
    private enum CurrencyValueEnum
    {
      USD = 1,
      CAD = 2,
      GBP = 3,
      AUD = 5,
      EUR = 7,
      CHF = 13, // 0x0000000D
      CNY = 14, // 0x0000000E
      SGD = 22, // 0x00000016
      PHP = 34, // 0x00000022
      HKD = 39, // 0x00000027
      TWD = 41, // 0x00000029
      INR = 44, // 0x0000002C
      MYR = 46, // 0x0000002E
    }
  }
}
