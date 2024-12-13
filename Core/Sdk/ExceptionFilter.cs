// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.ExceptionFilter
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Exception filters are used to filter the exceptions that are to be logged
  /// using the <see cref="T:eBay.Service.Core.Sdk.ApiLogManager" /> object, which is set in the
  /// <see cref="T:eBay.Service.Core.Sdk.ApiContext" /> for the application. Only those exceptions specified
  /// in this filter will be logged. If the filter is not used, then all exceptions
  /// are logged.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ExceptionFilter
  {
    private StringCollection mTriggerErrorCodes = new StringCollection();
    private Int32Collection mTriggerHttpStatusCodes = new Int32Collection();
    private TypeCollection mTriggerExceptions = new TypeCollection();
    private static char[] SEPS = new char[1]{ ';' };

    /// <summary>
    /// 
    /// </summary>
    public ExceptionFilter()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="errorCodes"></param>
    /// <param name="exceptions"></param>
    /// <param name="httpStatusCodes"></param>
    public ExceptionFilter(string errorCodes, string exceptions, string httpStatusCodes)
    {
      this.mTriggerErrorCodes = ExceptionFilter.ParseTriggerErrorCodes(errorCodes);
      this.mTriggerHttpStatusCodes = ExceptionFilter.ParseTriggerHttpStatusCodes(httpStatusCodes);
      this.mTriggerExceptions = ExceptionFilter.ParseTriggerExceptions(exceptions);
    }

    /// <summary>
    /// Determines if an exception matches the criteria that have been set up for matching.
    /// 1. If no exceptions or codes have been configured to match, then the exception does not match the filter.  (Empty filters do not
    ///    match any exception.)
    /// 2. If the exception is an <see cref="T:eBay.Service.Core.Sdk.ApiException" /> and has an error code configured in the CallRetry
    ///    <see cref="P:eBay.Service.Core.Sdk.CallRetry.TriggerErrorCodes" />, the exception matches.
    ///    (See <see href="http://www.developer.ebay.com/DevZone/XML/docs/Reference/eBay/Errors/ErrorMessages.htm">
    ///     Errors by Number</see> in the Trading API Call Reference for a list of possible errors.)
    /// 3. If the exception is an ApiException containing (wrapping) an <see cref="T:eBay.Service.Core.Sdk.HttpException" />
    ///    with a code configured in <see cref="P:eBay.Service.Core.Sdk.CallRetry.TriggerHttpStatusCodes" />,
    ///    the exception matches.
    /// 4. If the exception is one of the types (classes) configured in TriggerExceptions, the exception matches.  HttpException is
    ///    supported for matching even though it arrives wrapped in an ApiException, because we unwrap the outer exception and match
    ///    on the inner HttpException type.
    /// 5. Otherwise, the exception does not match the filter.
    /// </summary>
    /// <param name="ex">The <see cref="T:System.Exception" /> to test for retry.</param>
    /// <returns>Returns <b>true</b> if retry should be invoked, else <b>false</b></returns>
    public bool Matches(Exception ex)
    {
      if (ex == null || (this.mTriggerErrorCodes == null || this.mTriggerErrorCodes.Count == 0) && (this.mTriggerExceptions == null || this.mTriggerExceptions.Count == 0) && (this.mTriggerHttpStatusCodes == null || this.mTriggerHttpStatusCodes.Count == 0))
        return false;
      if (this.mTriggerErrorCodes != null && this.mTriggerErrorCodes.Count > 0 && ex.GetType() == typeof (ApiException))
      {
        IEnumerator enumerator = ((ApiException) ex).Errors.GetEnumerator();
        while (enumerator.MoveNext())
        {
          if (((ErrorType) enumerator.Current).SeverityCode == SeverityCodeType.Error && this.InTriggerErrorCodes((ErrorType) enumerator.Current))
            return true;
        }
      }
      if (ex.GetType() == typeof (ApiException) && ex.InnerException != null && ex.InnerException.GetType() == typeof (HttpException))
        ex = ex.InnerException;
      return this.mTriggerHttpStatusCodes != null && this.mTriggerHttpStatusCodes.Count > 0 && ex.GetType() == typeof (HttpException) && this.InTriggerHttpStatusCodes(((HttpException) ex).StatusCode) || this.mTriggerExceptions != null && this.mTriggerExceptions.Count > 0 && this.InTriggerExceptions(ex);
    }

    /// <summary>
    /// Converts comma-separated list of error codes into the appropriate StringCollection ready to set into the filter.
    /// </summary>
    /// <param name="configString"></param>
    /// <returns></returns>
    public static StringCollection ParseTriggerErrorCodes(string configString)
    {
      if (configString == null || configString.Length == 0)
        return (StringCollection) null;
      StringCollection triggerErrorCodes = new StringCollection();
      foreach (string str in configString.Split(ExceptionFilter.SEPS))
        triggerErrorCodes.Add(str);
      return triggerErrorCodes;
    }

    /// <summary>
    /// Converts comma-separated list of integer status codes into the appropriate Int32Collection ready to set into the filter.
    /// </summary>
    /// <param name="configString"></param>
    /// <returns></returns>
    public static Int32Collection ParseTriggerHttpStatusCodes(string configString)
    {
      if (configString == null || configString.Length == 0)
        return (Int32Collection) null;
      Int32Collection triggerHttpStatusCodes = new Int32Collection();
      foreach (string s in configString.Split(ExceptionFilter.SEPS))
        triggerHttpStatusCodes.Add(int.Parse(s));
      return triggerHttpStatusCodes;
    }

    /// <summary>
    /// Converts comma-separated list of exception type names into the appropriate TypeCollection ready to set into the filter.
    /// </summary>
    /// <param name="configString"></param>
    /// <returns></returns>
    public static TypeCollection ParseTriggerExceptions(string configString)
    {
      if (configString == null || configString.Length == 0)
        return (TypeCollection) null;
      TypeCollection triggerExceptions = new TypeCollection();
      string[] strArray = configString.Split(ExceptionFilter.SEPS);
      for (int index = 0; index < strArray.Length; ++index)
      {
        string str = strArray[index];
        Type type = !strArray[index].ToLower(CultureInfo.InvariantCulture).Equals("apiexception") ? (!strArray[index].ToLower(CultureInfo.InvariantCulture).Equals("httpexception") ? (!strArray[index].ToLower(CultureInfo.InvariantCulture).Equals("sdkexception") ? Type.GetType(strArray[index]) : typeof (SdkException)) : typeof (HttpException)) : typeof (ApiException);
        triggerExceptions.Add(type);
      }
      return triggerExceptions;
    }

    private bool InTriggerErrorCodes(ErrorType error)
    {
      foreach (string triggerErrorCode in (CollectionBase) this.mTriggerErrorCodes)
      {
        if (error.ErrorCode == triggerErrorCode)
          return true;
      }
      return false;
    }

    private bool InTriggerHttpStatusCodes(int code)
    {
      foreach (int triggerHttpStatusCode in (CollectionBase) this.mTriggerHttpStatusCodes)
      {
        if (code == triggerHttpStatusCode)
          return true;
      }
      return false;
    }

    private bool InTriggerExceptions(Exception ex)
    {
      foreach (Type triggerException in (CollectionBase) this.mTriggerExceptions)
      {
        if (ex.GetType() == triggerException)
          return true;
        if (ex.InnerException != null)
          return this.InTriggerExceptions(ex.InnerException);
      }
      return false;
    }

    /// <summary>
    /// Gets or sets the error codes that retry should occur for of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection TriggerErrorCodes
    {
      get => this.mTriggerErrorCodes;
      set => this.mTriggerErrorCodes = value;
    }

    /// <summary>
    /// Gets or sets the error codes that retry should occur for of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public Int32Collection TriggerHttpStatusCodes
    {
      get => this.mTriggerHttpStatusCodes;
      set => this.mTriggerHttpStatusCodes = value;
    }

    /// <summary>
    /// Gets or sets the exception types that retry should occur for of type <see cref="T:eBay.Service.Core.Soap.TypeCollection" />.
    /// </summary>
    public TypeCollection TriggerExceptions
    {
      get => this.mTriggerExceptions;
      set => this.mTriggerExceptions = value;
    }
  }
}
