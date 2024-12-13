// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ExtendSiteHostedPicturesCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class ExtendSiteHostedPicturesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ExtendSiteHostedPicturesCall()
    {
      this.ApiRequest = new ExtendSiteHostedPicturesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ExtendSiteHostedPicturesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ExtendSiteHostedPicturesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// By default, unpublished pictures uploaded to eBay Picture Services (EPS) via the <b>UploadSiteHostedPictures</b> call will be kept on the server for five days before being purged. The <b>ExtendSiteHostedPictures</b> call is used to extend this expiration date by the number of days specified in the call. This restricted call gives approved sellers the ability to extend the default expiration date of pictures uploaded to EPS but not immediately published in an eBay listing.
    /// </summary>
    /// <param name="PictureURLList">
    /// The URL of the image hosted by eBay Picture Services. This URL is returned in the <b>SiteHostedPictureDetails.FullURL</b> field of the <b>UploadSiteHostedPictures</b> response.
    /// </param>
    /// <param name="ExtensionInDays">
    /// The number of days by which to extend the expiration date for the
    /// specified image.
    /// </param>
    public StringCollection ExtendSiteHostedPictures(
      StringCollection PictureURLList,
      int ExtensionInDays)
    {
      this.PictureURLList = PictureURLList;
      this.ExtensionInDays = ExtensionInDays;
      this.Execute();
      return this.ApiResponse.PictureURL;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ExtendSiteHostedPicturesRequestType" /> for this API call.
    /// </summary>
    public ExtendSiteHostedPicturesRequestType ApiRequest
    {
      get => (ExtendSiteHostedPicturesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ExtendSiteHostedPicturesResponseType" /> for this API call.
    /// </summary>
    public ExtendSiteHostedPicturesResponseType ApiResponse
    {
      get => (ExtendSiteHostedPicturesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ExtendSiteHostedPicturesRequestType.PictureURL" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection PictureURLList
    {
      get => this.ApiRequest.PictureURL;
      set => this.ApiRequest.PictureURL = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ExtendSiteHostedPicturesRequestType.ExtensionInDays" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ExtensionInDays
    {
      get => this.ApiRequest.ExtensionInDays;
      set => this.ApiRequest.ExtensionInDays = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ExtendSiteHostedPicturesResponseType.PictureURL" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection PictureURLListReturn => this.ApiResponse.PictureURL;
  }
}
