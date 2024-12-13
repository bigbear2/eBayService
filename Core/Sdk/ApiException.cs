// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.ApiException
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using eBay.Service.Util;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.XPath;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Wraps errors which can be either client-side (e.g. validation) errors, SOAP faults, API errors, or nested
  /// <see cref="T:eBay.Service.Core.Sdk.HttpException" />s. <see cref="T:eBay.Service.Core.Sdk.ApiException" />  extends
  /// <see cref="T:eBay.Service.Core.Sdk.SdkException" />, and is primarily used for exceptions from the API call
  /// wrapper layer (Api payload data-related). For example, you would get an ApiException if you supplied an
  /// invalid category ID in an AddItem call. You can check the <see cref="P:eBay.Service.Core.Sdk.ApiCall.HasError" />
  /// property of the API call wrapper to determine whether there is an ApiException, then use the call wrapper's
  /// <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiException" /> property to return the exception
  /// object. You can then use the ApiException object properties to determine the error count, the error
  /// message, the error list, and so forth. You can also use the ApiException to trigger a call retry; for more
  /// information, see <see cref="T:eBay.Service.Core.Sdk.CallRetry" />
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [Serializable]
  public class ApiException : SdkException, ISerializable
  {
    private ErrorTypeCollection mErrors = new ErrorTypeCollection();

    /// <summary>Default constructor.</summary>
    public ApiException()
    {
    }

    /// <summary>
    /// Construct an ApiException described by the specified message.
    /// </summary>
    /// <param name="message">A message that describes the error.</param>
    public ApiException(string message)
      : base(message)
    {
    }

    /// <summary>
    /// Construct an ApiException wrapping the given exception, and described by the specified message.
    /// </summary>
    /// <param name="message">A message that describes the error.</param>
    /// <param name="inner">The exception that is the cause of the current exception.</param>
    public ApiException(string message, Exception inner)
      : base(message, inner)
    {
    }

    /// <summary>
    /// Construct an ApiException from the specified API error set (ErrorTypeCollection).
    /// </summary>
    /// <param name="errors">The errors for this exception of type <see cref="T:eBay.Service.Core.Soap.ErrorTypeCollection" />.</param>
    public ApiException(ErrorTypeCollection errors) => this.mErrors = errors;

    /// <summary>
    /// Deserialize an ApiException from serialized state information.
    /// </summary>
    /// <param name="info">The object that holds the serialized object data.</param>
    /// <param name="context">The contextual information about the source or destination.</param>
    protected ApiException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.mErrors = (ErrorTypeCollection) info.GetValue(nameof (mErrors), typeof (ErrorTypeCollection));
    }

    /// <summary>Serialize an ApiException.</summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue("mErrors", (object) this.mErrors, typeof (ErrorTypeCollection));
      base.GetObjectData(info, context);
    }

    /// <summary>Parses a failed xml request into an ApiException.</summary>
    /// <param name="nav">The XPath navigator for the XML response.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Sdk.ApiException" />.</returns>
    public static ApiException FromXmlErrors(XPathNavigator nav)
    {
      ApiException apiException = new ApiException();
      XPathNodeIterator xpathNodeIterator = nav.Select("/eBay/Errors/Error");
      while (xpathNodeIterator.MoveNext())
        apiException.Errors.Add(new ErrorType()
        {
          ErrorCode = XmlUtility.GetString(xpathNodeIterator.Current, "Code"),
          LongMessage = XmlUtility.GetString(xpathNodeIterator.Current, "LongMessage"),
          ShortMessage = XmlUtility.GetString(xpathNodeIterator.Current, "ShortMessage"),
          SeverityCode = !(XmlUtility.GetString(xpathNodeIterator.Current, "Severity") == "Warning") ? SeverityCodeType.Error : SeverityCodeType.Warning
        });
      return apiException;
    }

    /// <summary>Parses a soap fault into an ApiException.</summary>
    /// <param name="soapex">The <see cref="T:System.Web.Services.Protocols.SoapException" />.</param>
    /// <returns>The <see cref="T:eBay.Service.Core.Sdk.ApiException" />.</returns>
    public static ApiException FromSoapException(SoapException soapex)
    {
      ErrorType errorType = new ErrorType();
      XmlNode detail = soapex.Detail;
      XPathNavigator navigator1 = detail.CreateNavigator();
      XmlNamespaceManager nsManager = new XmlNamespaceManager(detail.OwnerDocument.NameTable);
      XPathExpression XPath1 = navigator1.Compile("/FaultDetail");
      XPath1.SetContext(nsManager);
      XmlNode childNode = XmlUtility.GetChildNode(navigator1, XPath1);
      if (childNode != null)
      {
        XPathNavigator navigator2 = childNode.CreateNavigator();
        errorType.ShortMessage = soapex.Message.Trim();
        XPathExpression XPath2 = navigator2.Compile("Severity");
        XPath2.SetContext(nsManager);
        errorType.SeverityCode = !(XmlUtility.GetString(navigator2, XPath2).Trim() == "Warning") ? SeverityCodeType.Error : SeverityCodeType.Warning;
        XPathExpression XPath3 = navigator2.Compile("DetailedMessage");
        XPath3.SetContext(nsManager);
        errorType.LongMessage = XmlUtility.GetString(navigator2, XPath3).Trim();
        XPathExpression XPath4 = navigator2.Compile("ErrorCode");
        XPath4.SetContext(nsManager);
        errorType.ErrorCode = XmlUtility.GetString(navigator2, XPath4).Trim();
      }
      else
      {
        errorType.SeverityCode = SeverityCodeType.Error;
        errorType.ShortMessage = soapex.Code.Name.Trim();
        errorType.LongMessage = soapex.Message.Trim();
        errorType.ErrorCode = "0";
      }
      return new ApiException(new ErrorTypeCollection()
      {
        errorType
      });
    }

    /// <summary>
    /// Gets the list of errors associated with this exception of type <see cref="T:eBay.Service.Core.Soap.ErrorTypeCollection" />.
    /// </summary>
    public ErrorTypeCollection Errors => this.mErrors;

    /// <summary>
    /// Gets the formatted message of this exception of type <see cref="T:System.String" />.
    /// </summary>
    public override string Message
    {
      get
      {
        string str = "";
        if (this.mErrors.Count > 0)
        {
          foreach (ErrorType mError in (CollectionBase) this.mErrors)
          {
            if (this.mErrors.IndexOf(mError) > 0)
              str += "\r\n";
            str = mError.LongMessage == null || mError.LongMessage.Length <= 0 ? (mError.ShortMessage == null || mError.ShortMessage.Length <= 0 ? str + string.Format("{0}\r\n", (object) mError.ErrorCode) : str + string.Format("{0}", (object) mError.ShortMessage)) : str + string.Format("{0}", (object) mError.LongMessage);
          }
        }
        else
          str = base.Message;
        return str.Trim();
      }
    }

    /// <summary>
    /// Gets the number of errors associated with this exception with <see cref="F:eBay.Service.Core.Soap.SeverityCodeType.Error" />.
    /// </summary>
    public int SeverityErrorCount
    {
      get => this.InnerException == null ? this.CountErrors(SeverityCodeType.Error) : 1;
    }

    /// <summary>
    /// Returns true if the specified error code is one of the error codes belonging to this exception instance.
    /// </summary>
    public bool containsErrorCode(string errorcode)
    {
      if (errorcode == null || errorcode == string.Empty)
        return false;
      foreach (ErrorType error in (CollectionBase) this.Errors)
      {
        if (errorcode.Equals(error.ErrorCode))
          return true;
      }
      return false;
    }

    /// <summary>
    /// Gets the number of errors associated with this exception with <see cref="F:eBay.Service.Core.Soap.SeverityCodeType.Warning" />.
    /// </summary>
    public int SeverityWarningCount => this.CountErrors(SeverityCodeType.Warning);

    private int CountErrors(SeverityCodeType type)
    {
      IEnumerator enumerator = this.mErrors.GetEnumerator();
      int num = 0;
      while (enumerator.MoveNext())
      {
        if (((ErrorType) enumerator.Current).SeverityCode == type)
          ++num;
      }
      return num;
    }
  }
}
