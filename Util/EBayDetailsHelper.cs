// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.EBayDetailsHelper
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Collections;


namespace eBay.Service.Util
{
  /// <summary>Summary description for EBayDetailsHelper.</summary>
  public class EBayDetailsHelper
  {
    private static EBayDetailsHelper _helper;
    private ApiContext _apiContext;
    private SiteCodeType _site;
    private DetailNameCodeTypeCollection _siteIndependentDetailNames = new DetailNameCodeTypeCollection(new DetailNameCodeType[6]
    {
      DetailNameCodeType.CountryDetails,
      DetailNameCodeType.CurrencyDetails,
      DetailNameCodeType.DispatchTimeMaxDetails,
      DetailNameCodeType.ShippingLocationDetails,
      DetailNameCodeType.SiteDetails,
      DetailNameCodeType.TimeZoneDetails
    });
    private DetailNameCodeTypeCollection _siteRelatedDetailNames = new DetailNameCodeTypeCollection(new DetailNameCodeType[5]
    {
      DetailNameCodeType.PaymentOptionDetails,
      DetailNameCodeType.RegionDetails,
      DetailNameCodeType.ShippingServiceDetails,
      DetailNameCodeType.TaxJurisdiction,
      DetailNameCodeType.URLDetails
    });
    private static Hashtable _SiteRelatedDetailsByName = new Hashtable(5);
    private static Hashtable _SiteRelatedDetailsMapsByName = new Hashtable(5);
    private static Hashtable _CountryDetailsByCountry = new Hashtable();
    private CountryDetailsTypeCollection _countryDetails;
    private static Hashtable _CurrencyDetailsByCurrency = new Hashtable();
    private CurrencyDetailsTypeCollection _currencyDetails;
    private static Hashtable _DispatchTimeMaxDetailsByDispatchTimeMax = new Hashtable();
    private DispatchTimeMaxDetailsTypeCollection _dispatchTimeMaxDetails;
    private static Hashtable _ShippingLocationDetailsByShippingLocation = new Hashtable();
    private ShippingLocationDetailsTypeCollection _shippingLocationDetails;
    private static Hashtable _SiteDetailsBySite = new Hashtable();
    private SiteDetailsTypeCollection _siteDetails;
    private static Hashtable _TimeZoneDetails = new Hashtable();
    private TimeZoneDetailsTypeCollection _timeZoneDetails;
    private static Hashtable _PaymentOptionDetailsMapsBySite = new Hashtable();
    private static Hashtable _PaymentOptionDetailsBySite = new Hashtable();
    private static Hashtable _RegionDetailsMapsBySite = new Hashtable();
    private static Hashtable _RegionDetailsBySite = new Hashtable();
    private RegionDetailsTypeCollection _regionDetails;
    private static Hashtable _ShippingServiceDetailsMapsBySite = new Hashtable();
    private static Hashtable _ShippingServiceDetailsBySite = new Hashtable();
    private ShippingServiceDetailsTypeCollection _shippingServiceDetails;
    private static Hashtable _TaxJurisdictionDetailsMapsBySite = new Hashtable();
    private static Hashtable _TaxJurisdictionDetailsBySite = new Hashtable();
    private TaxJurisdictionTypeCollection _taxJurisdictionDetails;
    private static Hashtable _URLDetailsMapsBySite = new Hashtable();
    private static Hashtable _URLDetailsBySite = new Hashtable();

    /// <summary>
    /// 
    /// </summary>
    private EBayDetailsHelper(ApiContext context)
    {
      this._apiContext = context;
      this._site = this._apiContext.Site;
      this.loadSiteIndependentDetails();
      this.initializeHashMaps();
      this.loadSiteRelatedDetailsForSite(this._site);
    }

    private EBayDetailsHelper()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public static EBayDetailsHelper getInstance(ApiContext context)
    {
      if (EBayDetailsHelper._helper == null)
        EBayDetailsHelper._helper = new EBayDetailsHelper(context);
      return EBayDetailsHelper._helper;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentOptionDetailsTypeCollection getPaymentOptionDetailsForSite(SiteCodeType site)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsByName[(object) DetailNameCodeType.PaymentOptionDetails];
      if (!hashtable.ContainsKey((object) site))
      {
        DetailNameCodeTypeCollection codeTypeCollection = new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.PaymentOptionDetails
        });
        this.loadPaymentOptionsDetailsForSite(site);
      }
      return (PaymentOptionDetailsTypeCollection) hashtable[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentOptionDetailsType getPaymentOptionDetailsBySiteAndPaymentMethod(
      SiteCodeType site,
      BuyerPaymentMethodCodeType paymentMethod)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsMapsByName[(object) DetailNameCodeType.PaymentOptionDetails];
      if (!hashtable.ContainsKey((object) site))
        this.loadPaymentOptionsDetailsForSite(site);
      return (PaymentOptionDetailsType) ((Hashtable) hashtable[(object) site])[(object) paymentMethod];
    }

    /// <summary>
    /// 
    /// </summary>
    public RegionDetailsTypeCollection getRegionDetailsForSite(SiteCodeType site)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsByName[(object) DetailNameCodeType.RegionDetails];
      if (!hashtable.ContainsKey((object) site))
      {
        DetailNameCodeTypeCollection codeTypeCollection = new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.RegionDetails
        });
        this.loadRegionDetailsForSite(site);
      }
      return (RegionDetailsTypeCollection) hashtable[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public RegionDetailsType getRegionDetailsBySiteAndRegionID(SiteCodeType site, string regionId)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsMapsByName[(object) DetailNameCodeType.RegionDetails];
      if (!hashtable.ContainsKey((object) site))
        this.loadRegionDetailsForSite(site);
      return (RegionDetailsType) ((Hashtable) hashtable[(object) site])[(object) regionId];
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingServiceDetailsTypeCollection getShippingServiceDetailsForSite(SiteCodeType site)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsByName[(object) DetailNameCodeType.ShippingServiceDetails];
      if (!hashtable.ContainsKey((object) site))
      {
        DetailNameCodeTypeCollection codeTypeCollection = new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.ShippingServiceDetails
        });
        this.loadShippingServiceDetailsForSite(site);
      }
      return (ShippingServiceDetailsTypeCollection) hashtable[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingServiceDetailsType getShippingServiceDetailsBySiteAndShippingServiceID(
      SiteCodeType site,
      int shippingServiceID)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsMapsByName[(object) DetailNameCodeType.ShippingServiceDetails];
      if (!hashtable.ContainsKey((object) site))
        this.loadShippingServiceDetailsForSite(site);
      return (ShippingServiceDetailsType) ((Hashtable) hashtable[(object) site])[(object) shippingServiceID];
    }

    /// <summary>
    /// 
    /// </summary>
    public TaxJurisdictionTypeCollection getTaxJurisdictionDetailsForSite(SiteCodeType site)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsByName[(object) DetailNameCodeType.TaxJurisdiction];
      if (!hashtable.ContainsKey((object) site))
      {
        DetailNameCodeTypeCollection codeTypeCollection = new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.TaxJurisdiction
        });
        this.loadTaxJurisdictionDetailsForSite(site);
      }
      return (TaxJurisdictionTypeCollection) hashtable[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public TaxJurisdictionType getTaxJurisdictionDetailsBySiteAndJurisdictionID(
      SiteCodeType site,
      string jurisdictionID)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsMapsByName[(object) DetailNameCodeType.TaxJurisdiction];
      if (!hashtable.ContainsKey((object) site))
        this.loadTaxJurisdictionDetailsForSite(site);
      return (TaxJurisdictionType) ((Hashtable) hashtable[(object) site])[(object) jurisdictionID];
    }

    /// <summary>
    /// 
    /// </summary>
    public URLDetailsTypeCollection getURLDetailsForSite(SiteCodeType site)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsByName[(object) DetailNameCodeType.URLDetails];
      if (!hashtable.ContainsKey((object) site))
        this.loadURLDetailsForSite(site);
      return (URLDetailsTypeCollection) hashtable[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public URLDetailsType getURLDetailsBySiteAndURLType(SiteCodeType site, URLTypeCodeType URLType)
    {
      Hashtable hashtable = (Hashtable) EBayDetailsHelper._SiteRelatedDetailsMapsByName[(object) DetailNameCodeType.URLDetails];
      if (!hashtable.ContainsKey((object) site))
        this.loadURLDetailsForSite(site);
      return (URLDetailsType) ((Hashtable) hashtable[(object) site])[(object) URLType];
    }

    /// <summary>
    /// 
    /// </summary>
    public CountryDetailsType getTimeZoneDetailsByZone(string zoneId)
    {
      return (CountryDetailsType) EBayDetailsHelper._TimeZoneDetails[(object) zoneId];
    }

    /// <summary>
    /// 
    /// </summary>
    public TimeZoneDetailsTypeCollection getTimeZoneDetails() => this._timeZoneDetails;

    /// <summary>
    /// 
    /// </summary>
    public ShippingLocationDetailsType getShippingLocationDetailsByShipingLocation(
      string shippingLocation)
    {
      return (ShippingLocationDetailsType) EBayDetailsHelper._ShippingLocationDetailsByShippingLocation[(object) shippingLocation];
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingLocationDetailsTypeCollection getShippingLocationDetails()
    {
      return this._shippingLocationDetails;
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteDetailsType getSiteDetailsBySite(SiteCodeType site)
    {
      return (SiteDetailsType) EBayDetailsHelper._SiteDetailsBySite[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteDetailsTypeCollection getSiteDetails() => this._siteDetails;

    /// <summary>
    /// 
    /// </summary>
    public DispatchTimeMaxDetailsType getDispatchTimeMaxDetailsByDispatchTimeMax(int dispatchTimeMax)
    {
      return (DispatchTimeMaxDetailsType) EBayDetailsHelper._DispatchTimeMaxDetailsByDispatchTimeMax[(object) dispatchTimeMax];
    }

    /// <summary>
    /// 
    /// </summary>
    public DispatchTimeMaxDetailsTypeCollection getDispatchTimeMaxDetails()
    {
      return this._dispatchTimeMaxDetails;
    }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyDetailsType getCurrencyDetailsByCurrencyCode(CurrencyCodeType currencyCode)
    {
      return (CurrencyDetailsType) EBayDetailsHelper._CurrencyDetailsByCurrency[(object) currencyCode];
    }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyDetailsTypeCollection getCurrencyDetails() => this._currencyDetails;

    /// <summary>
    /// 
    /// </summary>
    public CountryDetailsType getCountryDetailsByCountryCode(CountryCodeType countryCode)
    {
      return (CountryDetailsType) EBayDetailsHelper._CountryDetailsByCountry[(object) countryCode];
    }

    /// <summary>
    /// 
    /// </summary>
    public CountryDetailsTypeCollection getCountryDetails() => this._countryDetails;

    private void loadPaymentOptionsDetailsForSite(
      GeteBayDetailsResponseType resp,
      SiteCodeType site)
    {
      if (resp == null)
        resp = this.makeApiCall(new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.PaymentOptionDetails
        }), site);
      PaymentOptionDetailsTypeCollection paymentOptionDetails = resp.PaymentOptionDetails;
      if (paymentOptionDetails == null)
        return;
      EBayDetailsHelper._PaymentOptionDetailsBySite.Add((object) site, (object) paymentOptionDetails);
      Hashtable hashtable = new Hashtable();
      for (int index = 0; index < paymentOptionDetails.Count; ++index)
      {
        PaymentOptionDetailsType optionDetailsType = paymentOptionDetails[index];
        hashtable.Add((object) optionDetailsType.PaymentOption, (object) optionDetailsType);
      }
      EBayDetailsHelper._PaymentOptionDetailsMapsBySite.Add((object) site, (object) hashtable);
    }

    private void loadPaymentOptionsDetailsForSite(SiteCodeType site)
    {
      this.loadPaymentOptionsDetailsForSite((GeteBayDetailsResponseType) null, site);
    }

    private void loadURLDetailsForSite(GeteBayDetailsResponseType resp, SiteCodeType site)
    {
      if (resp == null)
        resp = this.makeApiCall(new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.URLDetails
        }), site);
      URLDetailsTypeCollection urlDetails = resp.URLDetails;
      if (urlDetails == null)
        return;
      EBayDetailsHelper._URLDetailsBySite.Add((object) site, (object) urlDetails);
      Hashtable hashtable = new Hashtable();
      for (int index = 0; index < urlDetails.Count; ++index)
      {
        URLDetailsType urlDetailsType = urlDetails[index];
        hashtable.Add((object) urlDetailsType.URLType, (object) urlDetailsType);
      }
      EBayDetailsHelper._URLDetailsMapsBySite.Add((object) site, (object) hashtable);
    }

    private void loadURLDetailsForSite(SiteCodeType site)
    {
      this.loadURLDetailsForSite((GeteBayDetailsResponseType) null, site);
    }

    private void loadSiteRelatedDetailsForSite(SiteCodeType site)
    {
      GeteBayDetailsResponseType resp = this.makeApiCall(this._siteRelatedDetailNames, site);
      this._taxJurisdictionDetails = resp.TaxJurisdiction;
      this._shippingServiceDetails = resp.ShippingServiceDetails;
      this._regionDetails = resp.RegionDetails;
      this.loadPaymentOptionsDetailsForSite(resp, site);
      this.loadURLDetailsForSite(resp, site);
      this.loadTaxJurisdictionDetailsForSite(resp, site);
      this.loadShippingServiceDetailsForSite(resp, site);
      this.loadRegionDetailsForSite(resp, site);
    }

    private void loadTaxJurisdictionDetailsForSite(
      GeteBayDetailsResponseType resp,
      SiteCodeType site)
    {
      if (resp == null)
        resp = this.makeApiCall(new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.TaxJurisdiction
        }), site);
      TaxJurisdictionTypeCollection taxJurisdiction = resp.TaxJurisdiction;
      if (taxJurisdiction == null)
        return;
      EBayDetailsHelper._TaxJurisdictionDetailsBySite.Add((object) site, (object) taxJurisdiction);
      Hashtable hashtable = new Hashtable();
      for (int index = 0; index < taxJurisdiction.Count; ++index)
      {
        TaxJurisdictionType jurisdictionType = taxJurisdiction[index];
        hashtable.Add((object) jurisdictionType.JurisdictionID, (object) jurisdictionType);
      }
      EBayDetailsHelper._TaxJurisdictionDetailsMapsBySite.Add((object) site, (object) hashtable);
    }

    private void loadTaxJurisdictionDetailsForSite(SiteCodeType site)
    {
      this.loadTaxJurisdictionDetailsForSite((GeteBayDetailsResponseType) null, site);
    }

    private void loadShippingServiceDetailsForSite(
      GeteBayDetailsResponseType resp,
      SiteCodeType site)
    {
      if (resp == null)
        resp = this.makeApiCall(new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.ShippingServiceDetails
        }), site);
      ShippingServiceDetailsTypeCollection shippingServiceDetails = resp.ShippingServiceDetails;
      if (shippingServiceDetails == null)
        return;
      EBayDetailsHelper._ShippingServiceDetailsBySite.Add((object) site, (object) shippingServiceDetails);
      Hashtable hashtable = new Hashtable();
      for (int index = 0; index < shippingServiceDetails.Count; ++index)
      {
        ShippingServiceDetailsType serviceDetailsType = shippingServiceDetails[index];
        hashtable.Add((object) serviceDetailsType.ShippingServiceID, (object) serviceDetailsType);
      }
      EBayDetailsHelper._ShippingServiceDetailsMapsBySite.Add((object) site, (object) hashtable);
    }

    private void loadShippingServiceDetailsForSite(SiteCodeType site)
    {
      this.loadShippingServiceDetailsForSite((GeteBayDetailsResponseType) null, site);
    }

    private void loadRegionDetailsForSite(GeteBayDetailsResponseType resp, SiteCodeType site)
    {
      if (resp == null)
        resp = this.makeApiCall(new DetailNameCodeTypeCollection(new DetailNameCodeType[1]
        {
          DetailNameCodeType.RegionDetails
        }), site);
      RegionDetailsTypeCollection regionDetails = resp.RegionDetails;
      if (regionDetails == null)
        return;
      EBayDetailsHelper._RegionDetailsBySite.Add((object) site, (object) regionDetails);
      Hashtable hashtable = new Hashtable();
      for (int index = 0; index < regionDetails.Count; ++index)
      {
        RegionDetailsType regionDetailsType = regionDetails[index];
        hashtable.Add((object) regionDetailsType.RegionID, (object) regionDetailsType);
      }
      EBayDetailsHelper._RegionDetailsMapsBySite.Add((object) site, (object) hashtable);
    }

    private void loadRegionDetailsForSite(SiteCodeType site)
    {
      this.loadRegionDetailsForSite((GeteBayDetailsResponseType) null, site);
    }

    private GeteBayDetailsResponseType makeApiCall(
      DetailNameCodeTypeCollection detailNames,
      SiteCodeType site)
    {
      SiteCodeType site1 = this._site;
      this._apiContext.Site = site;
      GeteBayDetailsCall geteBayDetailsCall = new GeteBayDetailsCall(this._apiContext);
      DetailLevelCodeTypeCollection codeTypeCollection = new DetailLevelCodeTypeCollection(new DetailLevelCodeType[1]);
      geteBayDetailsCall.DetailLevelList = codeTypeCollection;
      geteBayDetailsCall.GeteBayDetails(detailNames);
      this._apiContext.Site = site1;
      return geteBayDetailsCall.ApiResponse;
    }

    private void loadSiteIndependentDetails()
    {
      GeteBayDetailsResponseType detailsResponseType = this.makeApiCall(this._siteIndependentDetailNames, this._apiContext.Site);
      this._countryDetails = detailsResponseType.CountryDetails;
      this.loadCountryDetails(this._countryDetails);
      this._currencyDetails = detailsResponseType.CurrencyDetails;
      this.loadCurrencyDetails(this._currencyDetails);
      this._dispatchTimeMaxDetails = detailsResponseType.DispatchTimeMaxDetails;
      this.loadDispatchTimeMaxDetails(this._dispatchTimeMaxDetails);
      this._shippingLocationDetails = detailsResponseType.ShippingLocationDetails;
      this.loadShippingLocationDetails(this._shippingLocationDetails);
      this._siteDetails = detailsResponseType.SiteDetails;
      this.loadSiteDetails(this._siteDetails);
      this._timeZoneDetails = detailsResponseType.TimeZoneDetails;
      this.loadTimeZoneDetails(this._timeZoneDetails);
    }

    private void loadTimeZoneDetails(TimeZoneDetailsTypeCollection details)
    {
      if (EBayDetailsHelper._TimeZoneDetails.Count != 0)
        return;
      for (int index = 0; index < details.Count; ++index)
      {
        TimeZoneDetailsType detail = details[index];
        EBayDetailsHelper._TimeZoneDetails.Add((object) detail.TimeZoneID, (object) detail);
      }
    }

    private void loadCountryDetails(CountryDetailsTypeCollection details)
    {
      if (EBayDetailsHelper._CountryDetailsByCountry.Count != 0)
        return;
      for (int index = 0; index < details.Count; ++index)
      {
        CountryDetailsType detail = details[index];
        EBayDetailsHelper._CountryDetailsByCountry.Add((object) detail.Country, (object) detail);
      }
    }

    private void initializeHashMaps()
    {
      EBayDetailsHelper._SiteRelatedDetailsByName.Add((object) DetailNameCodeType.PaymentOptionDetails, (object) EBayDetailsHelper._PaymentOptionDetailsBySite);
      EBayDetailsHelper._SiteRelatedDetailsMapsByName.Add((object) DetailNameCodeType.PaymentOptionDetails, (object) EBayDetailsHelper._PaymentOptionDetailsMapsBySite);
      EBayDetailsHelper._SiteRelatedDetailsByName.Add((object) DetailNameCodeType.RegionDetails, (object) EBayDetailsHelper._RegionDetailsBySite);
      EBayDetailsHelper._SiteRelatedDetailsMapsByName.Add((object) DetailNameCodeType.RegionDetails, (object) EBayDetailsHelper._RegionDetailsMapsBySite);
      EBayDetailsHelper._SiteRelatedDetailsByName.Add((object) DetailNameCodeType.ShippingServiceDetails, (object) EBayDetailsHelper._ShippingServiceDetailsBySite);
      EBayDetailsHelper._SiteRelatedDetailsMapsByName.Add((object) DetailNameCodeType.ShippingServiceDetails, (object) EBayDetailsHelper._ShippingServiceDetailsMapsBySite);
      EBayDetailsHelper._SiteRelatedDetailsByName.Add((object) DetailNameCodeType.TaxJurisdiction, (object) EBayDetailsHelper._TaxJurisdictionDetailsBySite);
      EBayDetailsHelper._SiteRelatedDetailsMapsByName.Add((object) DetailNameCodeType.TaxJurisdiction, (object) EBayDetailsHelper._TaxJurisdictionDetailsMapsBySite);
      EBayDetailsHelper._SiteRelatedDetailsByName.Add((object) DetailNameCodeType.URLDetails, (object) EBayDetailsHelper._URLDetailsBySite);
      EBayDetailsHelper._SiteRelatedDetailsMapsByName.Add((object) DetailNameCodeType.URLDetails, (object) EBayDetailsHelper._URLDetailsMapsBySite);
    }

    private void loadCurrencyDetails(CurrencyDetailsTypeCollection details)
    {
      if (EBayDetailsHelper._CurrencyDetailsByCurrency.Count != 0)
        return;
      for (int index = 0; index < details.Count; ++index)
      {
        CurrencyDetailsType detail = details[index];
        EBayDetailsHelper._CurrencyDetailsByCurrency.Add((object) detail.Currency, (object) detail);
      }
    }

    private void loadDispatchTimeMaxDetails(DispatchTimeMaxDetailsTypeCollection details)
    {
      if (EBayDetailsHelper._DispatchTimeMaxDetailsByDispatchTimeMax.Count != 0)
        return;
      for (int index = 0; index < details.Count; ++index)
      {
        DispatchTimeMaxDetailsType detail = details[index];
        EBayDetailsHelper._DispatchTimeMaxDetailsByDispatchTimeMax.Add((object) detail.DispatchTimeMax, (object) detail);
      }
    }

    private void loadSiteDetails(SiteDetailsTypeCollection details)
    {
      if (EBayDetailsHelper._SiteDetailsBySite.Count != 0)
        return;
      for (int index = 0; index < details.Count; ++index)
      {
        SiteDetailsType detail = details[index];
        EBayDetailsHelper._SiteDetailsBySite.Add((object) detail.Site, (object) detail);
      }
    }

    private void loadShippingLocationDetails(ShippingLocationDetailsTypeCollection details)
    {
      if (EBayDetailsHelper._ShippingLocationDetailsByShippingLocation.Count != 0)
        return;
      for (int index = 0; index < details.Count; ++index)
      {
        ShippingLocationDetailsType detail = details[index];
        EBayDetailsHelper._ShippingLocationDetailsByShippingLocation.Add((object) detail.ShippingLocation, (object) detail);
      }
    }
  }
}
