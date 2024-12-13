// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.ApiCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using eBay.Service.Util;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Services.Protocols;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Base class for all <see cref="N:eBay.Service.Call" /> API call classes, such as AddItemCall, GetOrderCall, GeteBayDetailsCall, and so forth.
  /// Each API call object requires an ApiContext object, which is used to contain the context information needed to communicate with eBay,
  /// such as the URL, user token, and so forth. Other useful ApiCall properties and objects include Site, which you use to specify the eBay
  /// site you are using, CallRetry, which you use for retrying failed calls, and CallMetricsEntry, which you can use during development and
  /// testing to determine call performance.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ApiCall
  {
    private Type mServiceType = typeof (eBayAPIInterfaceService2);
    private bool mEnableCompression = true;
    private AbstractRequestType mRequest;
    private AbstractResponseType mResponse;
    private CallMetricsEntry mCallMetrics = new CallMetricsEntry();
    private ApiContext mApiContext = new ApiContext();
    private bool mDetailLevelOverride;
    private ApiException mApiException;
    private CallRetry mCallRetry;
    private int mTimeout = int.MinValue;
    private string mVersion;
    private TimeSpan mResponseTime;
    private SiteCodeType mSite = SiteCodeType.CustomCode;
    private DetailLevelCodeTypeCollection mDetailLevelList = new DetailLevelCodeTypeCollection();
    private string mSoapRequest;
    private string mSoapResponse;
    private string mOAuth;
    private string[] mOutputSelector = new string[0];

    /// <summary>
    /// Constructor. If you use this constructor, you must subsequently set the context for this object by creating and setting properties
    /// in an <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> object, then set that object in the ApiCall object so it has the required context data.
    /// </summary>
    public ApiCall()
    {
    }

    /// <summary>
    /// Constructor. Use this constructor to set the ApiContext object in the new ApiCall object.
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call. This object properties must be set to the ebay URL
    /// used for the Trading API, the user token, and the eBay site.</param>
    public ApiCall(ApiContext ApiContext) => this.ApiContext = ApiContext;

    /// <summary>
    /// Sends the Request and returns the Response.
    /// In most cases, you would use the <see cref="M:eBay.Service.Core.Sdk.ApiCall.Execute" /> method to send the call request to eBay. The
    /// ExecuteRequest method is only used if you need to directly use the actual SOAP request object
    /// that underlies the ApiCall object to make the call (and use the actual underlying SOAP response
    /// object to receive the response). For more information, see
    /// <see href="http://ebay.custhelp.com/cgi-bin/ebay.cfg/php/enduser/std_adp.php?p_faqid=616" />
    /// What is the difference between Execute and ExecuteRequest.
    /// </summary>
    /// <param name="Request">The <see cref="T:eBay.Service.Core.Soap.AbstractRequestType" />.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Soap.AbstractResponseType" />.</returns>
    public AbstractResponseType ExecuteRequest(AbstractRequestType Request)
    {
      this.AbstractRequest = Request;
      this.SendRequest();
      return this.AbstractResponse;
    }

    /// <summary>
    /// Sends the Api call request <see cref="P:eBay.Service.Core.Sdk.ApiCall.AbstractRequest" /> to eBay.
    /// </summary>
    /// <returns>Returns the response appropriate to
    /// the specific API call that is being Executed.</returns>
    public virtual void Execute() => this.SendRequest();

    /// <summary>
    /// Constructs a security header from values in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" />.
    /// </summary>
    /// <returns>Security information of type <see cref="T:eBay.Service.Core.Soap.CustomSecurityHeaderType" />.</returns>
    protected virtual CustomSecurityHeaderType GetSecurityHeader()
    {
      CustomSecurityHeaderType securityHeader = new CustomSecurityHeaderType();
      if (this.ApiContext.ApiCredential.oAuthToken != null && this.ApiContext.ApiCredential.oAuthToken.Length > 0)
      {
        if (this.ApiContext.ApiCredential.eBayToken != null && this.ApiContext.ApiCredential.eBayToken.Length > 0)
          securityHeader.eBayAuthToken = this.ApiContext.ApiCredential.eBayToken;
      }
      else if (this.ApiContext.ApiCredential.eBayToken != null && this.ApiContext.ApiCredential.eBayToken.Length > 0)
        securityHeader.eBayAuthToken = this.ApiContext.ApiCredential.eBayToken;
      return securityHeader;
    }

    /// <summary>
    /// 
    /// </summary>
    internal void SendRequest()
    {
      try
      {
        if (this.AbstractRequest == null)
          throw new ApiException("RequestType reference not set to an instance of an object.", (Exception) new ArgumentNullException());
        if (this.ApiContext == null)
          throw new ApiException("ApiContext reference not set to an instance of an object.", (Exception) new ArgumentNullException());
        if (this.ApiContext.ApiCredential == null)
          throw new ApiException("Credentials reference in ApiContext object not set to an instance of an object.", (Exception) new ArgumentNullException());
        string str1 = this.AbstractRequest.GetType().Name.Replace("RequestType", "");
        if (this.ApiContext.EnableMetrics)
        {
          this.mCallMetrics = this.ApiContext.CallMetricsTable.GetNewEntry(str1);
          this.mCallMetrics.ApiCallStarted = DateTime.Now;
        }
        CustomSecurityHeaderType securityHeader = this.GetSecurityHeader();
        object obj = this.mServiceType.GetConstructor(new Type[0]).Invoke((object[]) null);
        PropertyInfo property1 = this.mServiceType.GetProperty("ApiLogManager");
        if (property1 == (PropertyInfo) null)
          throw new SdkException("ApiLogManager was not found in InterfaceServiceType");
        property1.SetValue(obj, (object) this.mApiContext.ApiLogManager, (object[]) null);
        PropertyInfo property2 = this.mServiceType.GetProperty("EnableComression");
        if (property2 == (PropertyInfo) null)
          throw new SdkException("EnableComression was not found in InterfaceServiceType");
        property2.SetValue(obj, (object) this.mEnableCompression, (object[]) null);
        if (string.IsNullOrEmpty(this.ApiContext.ApiCredential.oAuthToken))
        {
          PropertyInfo property3 = this.mServiceType.GetProperty("RequesterCredentials");
          if (property3 == (PropertyInfo) null)
            throw new SdkException("RequesterCredentials was not found in InterfaceServiceType");
          property3.SetValue(obj, (object) securityHeader, (object[]) null);
        }
        PropertyInfo property4 = this.mServiceType.GetProperty("WebProxy");
        if (property4 == (PropertyInfo) null)
          throw new SdkException("WebProxy was not found in InterfaceServiceType");
        property4.SetValue(obj, (object) this.mApiContext.WebProxy, (object[]) null);
        if (this.mApiContext.WebProxy != null)
          this.LogMessage("Proxy Server is Set", MessageType.Information, MessageSeverity.Informational);
        PropertyInfo property5 = this.mServiceType.GetProperty("CallMetricsEntry");
        if (property5 == (PropertyInfo) null)
          throw new SdkException("CallMetricsEntry was not found in InterfaceServiceType");
        if (this.ApiContext.EnableMetrics)
          property5.SetValue(obj, (object) this.mCallMetrics, (object[]) null);
        else
          property5.SetValue(obj, (object) null, (object[]) null);
        PropertyInfo property6 = this.mServiceType.GetProperty("OAuthToken");
        if (!string.IsNullOrEmpty(this.ApiContext.ApiCredential.oAuthToken))
        {
          this.mOAuth = this.ApiContext.ApiCredential.oAuthToken;
          property6.SetValue(obj, (object) this.OAuth, (object[]) null);
        }
        string Message;
        try
        {
          if (this.ApiContext.SoapApiServerUrl != null && this.ApiContext.SoapApiServerUrl.Length > 0)
            Message = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}?callname={1}&siteid={2}&client=netsoap", (object) this.ApiContext.SoapApiServerUrl, (object) str1, (object) SiteUtility.GetSiteID(this.Site).ToString((IFormatProvider) CultureInfo.InvariantCulture));
          else
            Message = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}?callname={1}&siteid={2}&client=netsoap", (object) (string) this.mServiceType.GetProperty("Url").GetValue(obj, (object[]) null), (object) str1, (object) SiteUtility.GetSiteID(this.Site).ToString((IFormatProvider) CultureInfo.InvariantCulture));
          this.mServiceType.GetProperty("Url").SetValue(obj, (object) Message, (object[]) null);
        }
        catch (Exception ex)
        {
          throw new ApiException(ex.Message, ex);
        }
        this.LogMessage(Message, MessageType.Information, MessageSeverity.Informational);
        this.mServiceType.GetProperty("Timeout").SetValue(obj, (object) this.Timeout, (object[]) null);
        this.AbstractRequest.Version = this.Version;
        if (!this.mDetailLevelOverride && this.AbstractRequest.DetailLevel == null)
        {
          this.AbstractRequest.DetailLevel = new DetailLevelCodeTypeCollection();
          this.AbstractRequest.DetailLevel.AddRange(this.mDetailLevelList);
        }
        this.AbstractRequest.OutputSelector = new StringCollection();
        this.AbstractRequest.OutputSelector.AddRange(this.mOutputSelector);
        if (this.ApiContext.ErrorLanguage != ErrorLanguageCodeType.CustomCode)
          this.AbstractRequest.ErrorLanguage = this.ApiContext.ErrorLanguage.ToString();
        this.AbstractRequest.MessageID = Guid.NewGuid().ToString();
        Type type = obj.GetType();
        object[] parameters = new object[1]
        {
          (object) this.AbstractRequest
        };
        int num1 = 0;
        int num2 = 0;
        bool flag = false;
        CallRetry callRetry = (CallRetry) null;
        if (this.mCallRetry != null)
        {
          callRetry = this.mCallRetry;
          num2 = callRetry.MaximumRetries;
        }
        else if (this.ApiContext.CallRetry != null)
        {
          callRetry = this.ApiContext.CallRetry;
          num2 = callRetry.MaximumRetries;
        }
        do
        {
          Exception Ex = (Exception) null;
          try
          {
            this.mResponse = (AbstractResponseType) null;
            this.mApiException = (ApiException) null;
            if (num1 > 0)
            {
              this.LogMessage("Invoking Call Retry", MessageType.Information, MessageSeverity.Informational);
              Thread.Sleep(callRetry.DelayTime);
            }
            if (this.BeforeRequest != null)
              this.BeforeRequest((object) this, new BeforeRequestEventArgs(this.AbstractRequest));
            DateTime now = DateTime.Now;
            this.mResponse = (AbstractResponseType) type.GetMethod(str1).Invoke(obj, parameters);
            this.mResponseTime = DateTime.Now - now;
            if (this.AfterRequest != null)
              this.AfterRequest((object) this, new AfterRequestEventArgs(this.mResponse));
            if (this.mResponse != null && securityHeader.HardExpirationWarning != null)
              this.ApiContext.ApiCredential.TokenHardExpirationWarning(Convert.ToDateTime(securityHeader.HardExpirationWarning, (IFormatProvider) CultureInfo.CurrentUICulture));
            if (this.mResponse != null)
            {
              if (this.mResponse.Errors != null)
              {
                if (this.mResponse.Errors.Count > 0)
                  throw new ApiException(new ErrorTypeCollection(this.mResponse.Errors));
              }
            }
          }
          catch (Exception ex)
          {
            Exception exception = ex;
            if (exception.GetType() == typeof (TargetInvocationException))
            {
              Exception innerException = exception.InnerException;
              if (innerException.GetType() == typeof (SoapException))
                exception = (Exception) ApiException.FromSoapException((SoapException) innerException);
              else if (innerException.GetType() == typeof (InvalidOperationException))
              {
                while (innerException.InnerException != null)
                  innerException = innerException.InnerException;
                exception = (Exception) new ApiException(innerException.Message, innerException);
              }
              else
                exception = !(innerException.GetType() == typeof (HttpException)) ? (Exception) new ApiException(innerException.Message, innerException) : (Exception) new ApiException("HTTP Error Code: " + (object) ((HttpException) innerException).StatusCode, innerException);
            }
            Ex = exception;
            if (callRetry != null)
              flag = callRetry.ShouldRetry(exception);
            if (!flag || num1 == num2)
              throw exception;
            this.LogMessagePayload((string) this.mServiceType.GetProperty("SoapRequest").GetValue(obj, (object[]) null) + "\r\n\r\n" + (string) this.mServiceType.GetProperty("SoapResponse").GetValue(obj, (object[]) null), MessageSeverity.Informational, exception);
            MessageSeverity Severity = ((ApiException) exception).SeverityErrorCount > 0 ? MessageSeverity.Error : MessageSeverity.Warning;
            this.LogMessage(exception.Message, MessageType.Exception, Severity);
          }
          finally
          {
            string str2 = (string) this.mServiceType.GetProperty("SoapRequest").GetValue(obj, (object[]) null);
            string str3 = (string) this.mServiceType.GetProperty("SoapResponse").GetValue(obj, (object[]) null);
            if (!flag || num1 == num2)
              this.LogMessagePayload(str2 + "\r\n\r\n" + str3, MessageSeverity.Informational, Ex);
            if (this.mResponse != null && this.mResponse.TimestampSpecified)
              this.ApiContext.CallUpdate(this.mResponse.Timestamp);
            else
              this.ApiContext.CallUpdate(new DateTime(0L));
            this.mSoapRequest = str2;
            this.mSoapResponse = str3;
            ++num1;
          }
        }
        while (flag && num1 <= num2);
      }
      catch (Exception ex)
      {
        this.mApiException = !(ex is ApiException apiException) ? new ApiException(ex.Message, ex) : apiException;
        this.LogMessage(this.mApiException.Message, MessageType.Exception, this.mApiException.SeverityErrorCount > 0 ? MessageSeverity.Error : MessageSeverity.Warning);
        if (this.mApiException.SeverityErrorCount > 0)
          throw this.mApiException;
      }
      finally
      {
        if (this.ApiContext.EnableMetrics)
          this.mCallMetrics.ApiCallEnded = DateTime.Now;
      }
    }

    /// <summary>
    /// Log the message information under the specified type and severity.
    /// </summary>
    /// <param name="Message">The content to log of type <see cref="T:System.String" />.</param>
    /// <param name="Type">The type of message to log of type <see cref="T:eBay.Service.Util.MessageType" />.</param>
    /// <param name="Severity">The severity of the message of type <see cref="T:eBay.Service.Util.MessageSeverity" />/</param>
    protected internal void LogMessage(string Message, MessageType Type, MessageSeverity Severity)
    {
      if (Message == null || this.ApiContext == null || this.ApiContext.ApiLogManager == null || this.ApiContext.ApiLogManager.ApiLoggerList == null || this.ApiContext.ApiLogManager.ApiLoggerList.Count == 0)
        return;
      if (Type == MessageType.ApiMessage)
        Message = this.MaskPrivateInfo(Message);
      this.ApiContext.ApiLogManager.RecordMessage(Message, Type, Severity);
    }

    /// <summary>
    /// Log the message information under the specified type and severity, in the context of an exception - used for exception-based
    /// payload logging.
    /// Message type is always assumed to be ApiMessage.
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Severity"></param>
    /// <param name="Ex"></param>
    protected internal void LogMessagePayload(
      string Message,
      MessageSeverity Severity,
      Exception Ex)
    {
      if (Message == null || this.ApiContext == null || this.ApiContext.ApiLogManager == null || this.ApiContext.ApiLogManager.ApiLoggerList == null || this.ApiContext.ApiLogManager.ApiLoggerList.Count == 0)
        return;
      Message = this.MaskPrivateInfo(Message);
      this.ApiContext.ApiLogManager.RecordPayloadOnException(Message, MessageType.ApiMessage, Severity, Ex);
    }

    private string MaskPrivateInfo(string Message)
    {
      Message = Regex.Replace(Message, "<AuthCert>.+</AuthCert>", "<AuthCert>******</AuthCert>");
      Message = Regex.Replace(Message, "<Password>.+</Password>", "<Password>******</Password>");
      Message = Regex.Replace(Message, "<eBayAuthToken>.+</eBayAuthToken>", "<eBayAuthToken>******</eBayAuthToken>");
      return Message;
    }

    /// <summary>
    /// Reserved for eBay internal use. The type to be used to create the Web Service service instance.
    /// </summary>
    public Type InterfaceServiceType
    {
      get => this.mServiceType;
      set => this.mServiceType = value;
    }

    /// <summary>
    /// Returns the ApiException object that is created if an error occured during the API call request to the eBay API server.
    /// (If there was no error, this returns null.) The ApiException object is used for exceptions
    /// from the API call wrapper layer, which means it is API payload data-related. For example, you could get one of
    /// these exceptions if you supplied an invalid category ID in an AddItem call. In this case, the server returns a response
    /// indicating an error with an error severity of ‘Failure’,  wrapped by the SDK as an ApiException object.
    /// </summary>
    public ApiException ApiException => this.mApiException;

    /// <summary>
    /// Indicates whether the API call resulted in an ApiException indicating that an error occured. If an
    /// error occurred, use the ApiException property to get the ApiException object and examine the error.
    /// </summary>
    /// <returns>Returns <b>true</b> if the API call resulted in an ApiException.
    /// Returns <b>false</b> if there was no error. </returns>
    public bool HasError => this.mApiException != null && this.mApiException.SeverityErrorCount > 0;

    /// <summary>
    /// An API call can result in a request sent successfully to the eBay API server, but yet contain an API warning in the response about some
    /// non critical issue. (You can use the ApiException property to examine the warning.)
    /// </summary>
    /// <returns>Returns <b>true</b> after an API call if the response contained one or more warnings.
    /// Returns <b>false</b> if there are no warnings.
    /// </returns>
    public bool HasWarning
    {
      get => this.mApiException != null && this.mApiException.SeverityWarningCount > 0;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> of the API call object. The API call object must be set with an
    /// ApiContext object containing valid URL, user token, site data, and other optional properties, such as logging
    /// and call metrics.
    /// </summary>
    public ApiContext ApiContext
    {
      get => this.mApiContext;
      set => this.mApiContext = value;
    }

    /// <summary>
    /// Gets or sets the Request of the call of type <see cref="T:eBay.Service.Core.Soap.AbstractRequestType" />.
    /// The AbstractRequest is the abstract base class for all API call requests.
    /// </summary>
    public AbstractRequestType AbstractRequest
    {
      get => this.mRequest;
      set => this.mRequest = value;
    }

    /// <summary>
    /// Gets the Response of the call of type <see cref="T:eBay.Service.Core.Soap.AbstractResponseType" />.
    /// The AbstractResponse is the abstract base class for all API call responses.
    /// </summary>
    public AbstractResponseType AbstractResponse => this.mResponse;

    /// <summary>
    /// Gets or sets call retry of type <see cref="P:eBay.Service.Core.Sdk.ApiCall.CallRetry" />.
    /// The optional CallRetry object controls the behavior of failure-retry.
    /// Notice that call retry can be set in the ApiContext object to apply to all API calls,
    /// or it can be set in the API call wrapper object instead. The CallRetry object used by
    /// the API call wrapper overrides the CallRetry set in ApiContext.
    /// </summary>
    public CallRetry CallRetry
    {
      get => this.mCallRetry;
      set => this.mCallRetry = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AbstractRequestType.DetailLevel" /> of type <see cref="T:eBay.Service.Core.Soap.DetailLevelCodeTypeCollection" />.
    /// The DetailLevel is used in some API calls that query eBay, for example, GetUserCall. The detail level specifies which
    /// data is to be returned in the query. For information on which detail levels are supported for a particular API call,
    /// refer to the eBay Trading API Call Reference
    /// <see href="http://www.developer.ebay.com/DevZone/XML/docs/Reference/eBay/index.html" />
    /// </summary>
    public DetailLevelCodeTypeCollection DetailLevelList
    {
      get => this.mDetailLevelList;
      set => this.mDetailLevelList = value;
    }

    /// <summary>
    /// Prevents <see cref="P:eBay.Service.Core.Sdk.ApiCall.DetailLevelList" /> from being sent if set to <b>true</b>.
    /// </summary>
    /// <remarks>This property is set to <b>true</b> for <see cref="M:eBay.Service.Call.GetCategoriesCall.GetCategoriesVersion" />.</remarks>
    protected internal bool DetailLevelOverride
    {
      get => this.mDetailLevelOverride;
      set => this.mDetailLevelOverride = value;
    }

    /// <summary>
    /// Gets or sets the Timeout value for the HTTP connection used in the API call.
    /// Time is expressed in milliseconds.
    /// </summary>
    /// <remarks>This property allows you to override the value set in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /></remarks>
    public int Timeout
    {
      get => this.mTimeout != int.MinValue ? this.mTimeout : this.ApiContext.Timeout;
      set => this.mTimeout = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AbstractRequestType.Version" /> for the API call. This specifies which
    /// Trading API WSDL version is to be used for the call.
    /// </summary>
    /// <remarks>This property allows you to override the value set in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /></remarks>
    public string Version
    {
      get
      {
        return this.mVersion != null && this.mVersion.Length != 0 ? this.mVersion : this.ApiContext.Version;
      }
      set => this.mVersion = value;
    }

    public string OAuth
    {
      get => this.mOAuth != null && this.mOAuth.Length != 0 ? this.mOAuth : this.ApiContext.Version;
      set => this.mOAuth = value;
    }

    /// <summary>
    /// Gets or sets the eBay site (<see cref="T:eBay.Service.Core.Soap.SiteCodeType" />)to be used in the API call. The site is
    /// important because the different sites support different API features, so data validation and returned
    /// data can be affected by the site value specified.
    /// </summary>
    /// <remarks>This property allows you to override the value set in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /></remarks>
    public SiteCodeType Site
    {
      get => this.mSite != SiteCodeType.CustomCode ? this.mSite : this.ApiContext.Site;
      set => this.mSite = value;
    }

    /// <summary>
    /// Gets the time the API Call took to respond of type <see cref="T:System.TimeSpan" />
    /// </summary>
    public TimeSpan ResponseTime => this.mResponseTime;

    /// <summary>
    /// Gets the last raw web service request of type <see cref="T:System.String" />
    /// </summary>
    public string SoapRequest => this.MaskPrivateInfo(this.mSoapRequest);

    /// <summary>
    /// Gets the last raw web service response of type <see cref="T:System.String" />
    /// </summary>
    public string SoapResponse => this.MaskPrivateInfo(this.mSoapResponse);

    /// <summary>
    /// Set to true to ask the server to compress the response data to reduce the transfer size.
    /// By default HTTP compression is enabled to improve the performance.
    /// </summary>
    public bool EnableCompression
    {
      get => this.mEnableCompression;
      set => this.mEnableCompression = value;
    }

    /// <summary>
    /// Holds the call metrics object used to optionally track client and server side latencies.
    /// </summary>
    public CallMetricsEntry CallMetricsEntry
    {
      get => this.mCallMetrics;
      set => this.mCallMetrics = value;
    }

    /// <summary>OutputSelector to filter the response</summary>
    public string[] OutputSelector
    {
      get => this.mOutputSelector;
      set => this.mOutputSelector = value;
    }

    /// <summary>Occurs before the API call is sent.</summary>
    public event BeforeRequestEventHandler BeforeRequest;

    /// <summary>Occurs after the API call returns the response.</summary>
    public event AfterRequestEventHandler AfterRequest;
  }
}
