// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetDescriptionTemplatesCall
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
  public class GetDescriptionTemplatesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetDescriptionTemplatesCall()
    {
      this.ApiRequest = new GetDescriptionTemplatesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetDescriptionTemplatesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetDescriptionTemplatesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GetDescriptionTemplates</b> call. This call retrieves detailed information on the Listing Designer templates that are available for use by the seller.
    /// </summary>
    /// <param name="CategoryID">
    /// A <b>CategoryID</b> value can be specified if the seller would like to only see the Listing Designer templates that are available for that eBay category. This field will be ignored if the <b>MotorVehicles</b> boolean field is also included in the call request and set to <code>true</code>.
    /// </param>
    /// <param name="LastModifiedTime">
    /// This dateTime filter can be included and used if the user only wants to check for recently-added Listing Designer templates. If this filter is used, only the Listing Designer templates that have been added/modified after the specified timestamp will be returned in the response.
    /// <br /><br />
    /// Typically, you will pass in the timestamp value that was returned the last time you refreshed the list of Listing Designer templates.
    /// </param>
    /// <param name="MotorVehicles">
    /// This boolean field should be included and set to <code>true</code> if the user would only like to see the Listing Designer templates that are available for motor vehicle categories. This field will override any <b>CategoryID</b> value that is specified in the call request.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b>
    /// Motor vehicle-related Listing Designer templates are only available for eBay Motors on the US and Canada (English) marketplaces. To retrieve eBay US Motors Listing Designer templates, the <b>SITEID</b> HTTP header value must be set to <code>100</code>, which is the identifier of the eBay US Motors vertical (ebay.com/motors).
    /// </span>
    /// </param>
    public DescriptionTemplateTypeCollection GetDescriptionTemplates(
      string CategoryID,
      DateTime LastModifiedTime,
      bool MotorVehicles)
    {
      this.CategoryID = CategoryID;
      this.LastModifiedTime = LastModifiedTime;
      this.MotorVehicles = MotorVehicles;
      this.Execute();
      return this.ApiResponse.DescriptionTemplate;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetDescriptionTemplatesRequestType" /> for this API call.
    /// </summary>
    public GetDescriptionTemplatesRequestType ApiRequest
    {
      get => (GetDescriptionTemplatesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType" /> for this API call.
    /// </summary>
    public GetDescriptionTemplatesResponseType ApiResponse
    {
      get => (GetDescriptionTemplatesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesRequestType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID
    {
      get => this.ApiRequest.CategoryID;
      set => this.ApiRequest.CategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesRequestType.LastModifiedTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime LastModifiedTime
    {
      get => this.ApiRequest.LastModifiedTime;
      set => this.ApiRequest.LastModifiedTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesRequestType.MotorVehicles" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool MotorVehicles
    {
      get => this.ApiRequest.MotorVehicles;
      set => this.ApiRequest.MotorVehicles = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType.DescriptionTemplate" /> of type <see cref="T:eBay.Service.Core.Soap.DescriptionTemplateTypeCollection" />.
    /// </summary>
    public DescriptionTemplateTypeCollection DescriptionTemplateList
    {
      get => this.ApiResponse.DescriptionTemplate;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType.LayoutTotal" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int LayoutTotal => this.ApiResponse.LayoutTotal;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType.ObsoleteLayoutID" /> of type <see cref="T:eBay.Service.Core.Soap.Int32Collection" />.
    /// </summary>
    public Int32Collection ObsoleteLayoutIDList => this.ApiResponse.ObsoleteLayoutID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType.ObsoleteThemeID" /> of type <see cref="T:eBay.Service.Core.Soap.Int32Collection" />.
    /// </summary>
    public Int32Collection ObsoleteThemeIDList => this.ApiResponse.ObsoleteThemeID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType.ThemeGroup" /> of type <see cref="T:eBay.Service.Core.Soap.ThemeGroupTypeCollection" />.
    /// </summary>
    public ThemeGroupTypeCollection ThemeGroupList => this.ApiResponse.ThemeGroup;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType.ThemeTotal" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ThemeTotal => this.ApiResponse.ThemeTotal;
  }
}
