// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetAccountCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetAccountCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetAccountCall() => this.ApiRequest = new GetAccountRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetAccountCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetAccountRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Returns a seller's invoice data for their eBay account, including the account's
    /// summary data.
    /// </summary>
    /// <param name="AccountHistorySelection">
    /// Specifies the report format in which to return account entries.
    /// </param>
    /// <param name="InvoiceDate">
    /// This field is used to retrieve all account entries from a specific invoice, which is identified through this <b>InvoiceDate</b> field with the timestamp of the account invoice. This field is only applicable if the  <b>AccountHistorySelection</b> value is set to 'SpecifiedInvoice'; otherwise, this field will be ignored.
    /// </param>
    /// <param name="BeginDate">
    /// This field is used to retrieve all account entries dating back to the timestamp passed into this <b>BeginDate</b> field up until the timestamp passed into the <b>EndDate</b> field. The <b>BeginDate</b> value can not be set back any further than four months into the past.
    /// <br /><br />
    /// The allowed date formats are <em>YYYY-MM-DD</em> and <em>YYYY-MM-DD HH:mm:ss</em> The <b>BeginDate</b> value must be less than or equal to the <b>EndDate</b> value. The user might use the same values in both fields if that user wanted to retrieve all account entries from a specific day (if <em>YYYY-MM-DD</em> format used) or wanted to retrieve a specific account entry (if <em>YYYY-MM-DD HH:mm:ss</em> format used).
    /// <br /><br />
    /// This field is only applicable if the  <b>AccountHistorySelection</b> value is set to 'BetweenSpecifiedDates'; otherwise, this field will be ignored. fiedDates' is used, both the <b>BeginDate</b> and <b>EndDate</b> must be included.
    /// </param>
    /// <param name="EndDate">
    /// This field is used to retrieve all account entries dating up to the timestamp passed into this <b>EndDate</b> field dating back to the timestamp passed into the <b>BeginDate</b> field. The <b>EndDate</b> value can not be set for a future date.
    /// <br /><br />
    /// The allowed date formats are <em>YYYY-MM-DD</em> and <em>YYYY-MM-DD HH:mm:ss</em> The <b>EndDate</b> value must be more than or equal to the <b>BeginDate</b> value. The user might use the same values in both fields if that user wanted to retrieve all account entries from a specific day (if <em>YYYY-MM-DD</em> format used) or wanted to retrieve a specific account entry (if <em>YYYY-MM-DD HH:mm:ss</em> format used).
    /// <br /><br />
    /// This field is only applicable if the  <b>AccountHistorySelection</b> value is set to 'BetweenSpecifiedDates'; otherwise, this field will be ignored. If 'BetweenSpecifiedDates' is used, both the <b>BeginDate</b> and <b>EndDate</b> must be included.
    /// </param>
    /// <param name="Pagination">
    /// This container is used to control how many account entries are returned on each page of data in the response. <b>PaginationType</b> is used by numerous Trading API calls, and the default and maximum values for the <b>EntriesPerPage</b> field differs with each call. For the <b>GetAccount</b> call, the default value is 500 (account entries) per page, and maximum allowed value is 2000 (account entries) per page.
    /// </param>
    /// <param name="ExcludeBalance">
    /// By default, the current balance of the user's account will not be returned in the call response. To retrieve the current balance of their account, the user should include the <b>ExcludeBalance</b> flag in the request and set its value to 'false'. The current balance on the account will be shown in the <b>AccountSummary.CurrentBalance</b> field in the call response.
    /// </param>
    /// <param name="ExcludeSummary">
    /// Specifies whether to return account summary information in an
    /// AccountSummary node. Default is true, to return AccountSummary.
    /// </param>
    /// <param name="IncludeConversionRate">
    /// Specifies whether to retrieve the rate used for the currency conversion for usage transactions.
    /// </param>
    /// <param name="AccountEntrySortType">
    /// Specifies how account entries should be sorted in the response, by an
    /// element and then in ascending or descending order.
    /// </param>
    /// <param name="Currency">
    /// Specifies the currency used in the account report. Do not specify Currency
    /// in the request unless the following conditions are met. First, the user has
    /// or had multiple accounts under the same UserID. Second, the account
    /// identified in the request uses the currency you specify in the request. An
    /// error is returned if no account is found that uses the currency you specify
    /// in the request.
    /// </param>
    /// <param name="ItemID">
    /// Specifies the item ID for which to return account entries. If ItemID is
    /// used, all other filters in the request are ignored. If the specified item
    /// does not exist or if the requesting user is not the seller of the item, an
    /// error is returned.
    /// </param>
    /// <param name="OrderID">
    /// The unique identifier of an eBay order. This field must be included if the value of the <b>AccountHistorySelection</b> filter is set to <code>OrderId</code>. A user can filter by order ID to see if there specific account entries related to a specific eBay order.
    /// 
    /// It is possible that no account entries will be found directly related to the specified order ID, and if this is the case, no <b>AccountEntries</b> container will be returned, and the <b>ack</b> value will still be <code>Success</code>.
    /// 
    /// <span class="tablenote"><b>Note: </b> In June 2019, eBay introduced a new order ID format to both legacy (including Trading API) and REST-based APIs. At this time, both old and new format order IDs will be accepted in legacy API request payloads to identify orders. In legacy API response payloads, order IDs will appear in the new format if the user is using a Trading WSDL version of '1113' (or newer), or if the user sets the <code>X-EBAY-API-COMPATIBILITY-LEVEL</code> HTTP header to a value of '1113' (or newer). If the Trading WSDL version or compatibility level is less/older than '1113', old format order IDs will be returned in legacy API response payloads. Beginning as soon as March 2020, only new format order IDs will be returned regardless of version number.
    /// </span>
    /// </param>
    public AccountEntryTypeCollection GetAccount(
      AccountHistorySelectionCodeType AccountHistorySelection,
      DateTime InvoiceDate,
      DateTime BeginDate,
      DateTime EndDate,
      PaginationType Pagination,
      bool ExcludeBalance,
      bool ExcludeSummary,
      bool IncludeConversionRate,
      AccountEntrySortTypeCodeType AccountEntrySortType,
      CurrencyCodeType Currency,
      string ItemID,
      string OrderID)
    {
      this.AccountHistorySelection = AccountHistorySelection;
      this.InvoiceDate = InvoiceDate;
      this.BeginDate = BeginDate;
      this.EndDate = EndDate;
      this.Pagination = Pagination;
      this.ExcludeBalance = ExcludeBalance;
      this.ExcludeSummary = ExcludeSummary;
      this.IncludeConversionRate = IncludeConversionRate;
      this.AccountEntrySortType = AccountEntrySortType;
      this.Currency = Currency;
      this.ItemID = ItemID;
      this.OrderID = OrderID;
      this.Execute();
      return this.ApiResponse.AccountEntries.AccountEntry;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public AccountEntryTypeCollection GetAccount(
      AccountHistorySelectionCodeType AccountHistorySelection)
    {
      this.AccountHistorySelection = AccountHistorySelection;
      this.Execute();
      return this.AccountEntryList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetAccountRequestType" /> for this API call.
    /// </summary>
    public GetAccountRequestType ApiRequest
    {
      get => (GetAccountRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetAccountResponseType" /> for this API call.
    /// </summary>
    public GetAccountResponseType ApiResponse => (GetAccountResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.AccountHistorySelection" /> of type <see cref="T:eBay.Service.Core.Soap.AccountHistorySelectionCodeType" />.
    /// </summary>
    public AccountHistorySelectionCodeType AccountHistorySelection
    {
      get => this.ApiRequest.AccountHistorySelection;
      set => this.ApiRequest.AccountHistorySelection = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.InvoiceDate" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime InvoiceDate
    {
      get => this.ApiRequest.InvoiceDate;
      set => this.ApiRequest.InvoiceDate = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.BeginDate" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime BeginDate
    {
      get => this.ApiRequest.BeginDate;
      set => this.ApiRequest.BeginDate = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.EndDate" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndDate
    {
      get => this.ApiRequest.EndDate;
      set => this.ApiRequest.EndDate = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.ExcludeBalance" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ExcludeBalance
    {
      get => this.ApiRequest.ExcludeBalance;
      set => this.ApiRequest.ExcludeBalance = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.ExcludeSummary" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ExcludeSummary
    {
      get => this.ApiRequest.ExcludeSummary;
      set => this.ApiRequest.ExcludeSummary = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.IncludeConversionRate" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeConversionRate
    {
      get => this.ApiRequest.IncludeConversionRate;
      set => this.ApiRequest.IncludeConversionRate = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.AccountEntrySortType" /> of type <see cref="T:eBay.Service.Core.Soap.AccountEntrySortTypeCodeType" />.
    /// </summary>
    public AccountEntrySortTypeCodeType AccountEntrySortType
    {
      get => this.ApiRequest.AccountEntrySortType;
      set => this.ApiRequest.AccountEntrySortType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.Currency" /> of type <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.
    /// </summary>
    public CurrencyCodeType Currency
    {
      get => this.ApiRequest.Currency;
      set => this.ApiRequest.Currency = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.OrderID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderID
    {
      get => this.ApiRequest.OrderID;
      set => this.ApiRequest.OrderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.BeginDate" /> and <see cref="P:eBay.Service.Core.Soap.GetAccountRequestType.EndDate" /> of type <see cref="T:eBay.Service.Core.Soap.TimeFilter" />.
    /// </summary>
    public TimeFilter StartTimeFilter
    {
      get => new TimeFilter(this.ApiRequest.BeginDate, this.ApiRequest.EndDate);
      set
      {
        if (value.TimeFrom > DateTime.MinValue)
          this.ApiRequest.BeginDate = value.TimeFrom;
        if (!(value.TimeTo > DateTime.MinValue))
          return;
        this.ApiRequest.EndDate = value.TimeTo;
      }
    }

    /// <summary>
    /// Gets the <see cref="!:GetAccountResponseType.AccountEntries.AccountEntry" /> of type <see cref="P:eBay.Service.Call.GetAccountCall.AccountEntryList" />.
    /// </summary>
    public AccountEntryTypeCollection AccountEntryList
    {
      get
      {
        return this.ApiResponse.AccountEntries != null ? this.ApiResponse.AccountEntries.AccountEntry : (AccountEntryTypeCollection) null;
      }
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.AccountID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string AccountID => this.ApiResponse.AccountID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.AccountSummary" /> of type <see cref="T:eBay.Service.Core.Soap.AccountSummaryType" />.
    /// </summary>
    public AccountSummaryType AccountSummary => this.ApiResponse.AccountSummary;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.AccountEntries" /> of type <see cref="T:eBay.Service.Core.Soap.AccountEntriesType" />.
    /// </summary>
    public AccountEntriesType AccountEntries => this.ApiResponse.AccountEntries;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.HasMoreEntries" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HasMoreEntries => this.ApiResponse.HasMoreEntries;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.EntriesPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int EntriesPerPage => this.ApiResponse.EntriesPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAccountResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;
  }
}
