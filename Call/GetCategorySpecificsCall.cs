// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetCategorySpecificsCall
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
  public class GetCategorySpecificsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetCategorySpecificsCall() => this.ApiRequest = new GetCategorySpecificsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetCategorySpecificsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetCategorySpecificsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GetCategorySpecifics</b> call. This call is used to retrieve recommended Item Specifics names and values for one or multiple eBay Categories.
    /// </summary>
    /// <param name="CategoryIDList">
    /// A unique identifer for an eBay leaf-level category. Recommended Item Specifics names and values will be retrieved for each eBay category that is specified. Up to 100 <b>CategoryID</b> values may be specified in one call.
    /// 
    /// A <b>GetCategorySpecifics</b> call request requires at least one of the following: a <b>CategoryID</b> value, a <b>CategorySpecifics.CategoryID</b> value, or the
    /// <b>CategorySpecificsFileInfo</b> field with its value set to <code>true</code>. <b>CategoryID</b> values and
    /// <b>CategorySpecific.CategoryID</b> values can both be used in the same request.
    /// 
    /// Keep in mind that a high number of specified categories can result in
    /// longer response times and larger result sets. If your call request happens to time out, you might want specify fewer categories. If any
    /// <b>CategoryID</b> values are specified more than once, only the first instance will be used.
    /// </param>
    /// <param name="LastUpdateTime">
    /// This dateTime filter can be included and used if the user only wants to check for recently-added Item Specifics names and values for one or more categories. If this filter is used, the Item Specifics recommendation engine will only check for Item Specifics names and values that have been added/changed since the date that was passed in to this field. If this field is used, the call will not return any Item Specifics data; it will only return the <b>Recommendations.Updated</b> boolean field for each specified eBay category. A <code>true</code> value in this field will indicate that the recommended Item Specifics names/values for the eBay category have changed since the timestamp passed in the <b>LastUpdateTime</b> field, and a <code>false</code> value in this field will indicate that the recommended Item Specifics names/values for the eBay category have not changed since the timestamp passed in the <b>LastUpdateTime</b> field.
    /// 
    /// Typically, you will pass in the timestamp value that was returned the last time you refreshed the list of Item Specifics names and values for the same categories. If the <b>Recommendations.Updated</b> flag returns <code>true</code> for any eBay categories in the response, you will want to call <b>GetCategorySpecifics</b> again for those eBay categories to get the latest names and values. As downloading all the data may affect your application's performance, it may help to only download Item Specifics data for an eBay category if the data has changed since you last checked.
    /// </param>
    /// <param name="MaxNames">
    /// This field can be used if you want to control the number of Item Specifics that are returned for each specified eBay category. If you only wanted to retrieve the 10 most popular Item Specifics per category, you would include this field and set its value to <code>10</code>. Note that mandatory Item Specifics are always returned first in the response. If this field is omitted, all available Item Specifics names for each specified category are returned. If this field's value is set to a value that is higher than the number of Item Specific names available, all Item Specific names are still returned.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b>
    /// In October 2019, eBay has updated the <b>GetCategorySpecifics</b> call to retrieve all available Item Specifics name-value pairs for each specified category by default. Previously, 30 Item Specifics names would be returned by default (if the <b>MaxNames</b> filter wasn't used) and 25 corresponding Item Specifics values would be returned by default (if the <b>MaxValuesPerName</b> filter wasn't used). However, if a user wants to limit the number of Item Specifics names and corresponding values that are returned, they can still use the <b>MaxNames</b> and/or <b>MaxValuesPerName</b> filters to do this.
    /// </span>
    /// 
    /// </param>
    /// <param name="MaxValuesPerName">
    /// This field can be used if you want to control the number of corresponding values that are returned for each returned Item Specific name in each specified eBay category. If you only wanted to retrieve the 10 most popular values/options for each returned Item Specific name in each category, you would include this field and set its value to <code>10</code>. If this field is omitted, all available values for the corresponding Item Specifics name for each category are returned. If this field's value is set to a value that is higher than the number of Item Specific values available for any Item Specific name, all Item Specific values are still returned.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b>
    /// In October 2019, eBay has updated the <b>GetCategorySpecifics</b> call to retrieve all available Item Specifics name-value pairs for each specified category by default. Previously, 30 Item Specifics names would be returned by default (if the <b>MaxNames</b> filter wasn't used) and 25 corresponding Item Specifics values would be returned by default (if the <b>MaxValuesPerName</b> filter wasn't used). However, if a user wants to limit the number of Item Specifics names and corresponding values that are returned, they can still use the <b>MaxNames</b> and/or <b>MaxValuesPerName</b> filters to do this.
    /// </span>
    /// 
    /// </param>
    /// <param name="Name">
    /// This field can be used if you already have an Item Specific name in mind, and you only want the recommended values for this Item Specifics name.
    /// If you specify multiple eBay categories in the request, the recommendation engine may find a matching Item Specifics name for some categories, but not for others. For eBay categories where the Item Specifics name is not found, recommended Item Specifics names and values will be returned. The Item Specifics name passed in this field is case-sensitive, and wildcards are not supported.
    /// 
    /// </param>
    /// <param name="CategorySpecificList">
    /// This container can be used instead of, or in conjunction with <b>CategoryID</b> values specified at the call request root level. The <b>CategorySpecific</b> container can actually be more powerful since you can pass in multiple Category ID and Item Specifics name combinations, and if you specify <b>CategoryID</b> values at the root level, only one (Item Specifics) <b>Name</b> value can be used.
    /// 
    /// A <b>GetCategorySpecifics</b> call request requires at least one of the following: a <b>CategoryID</b> value, a <b>CategorySpecifics.CategoryID</b> value, or the
    /// <b>CategorySpecificsFileInfo</b> field with its value set to <code>true</code>. <b>CategoryID</b> values and
    /// <b>CategorySpecific.CategoryID</b> values can both be used in the same request.
    /// 
    /// Keep in mind that a high number of specified categories can result in
    /// longer response times and larger result sets. If your call request happens to time out, you might want specify fewer categories. If any
    /// <b>CategorySpecifics.CategoryID</b> values are specified more than once, only the first instance will be used.
    /// </param>
    /// <param name="ExcludeRelationships">
    /// If this boolean field is included and set to <code>true</code>, the <b>Relationship</b> container will not be returned for any Item Specifics name or value recommendations. Relationship recommendations tell you whether an Item Specific has a logical dependency another Item Specific.
    /// 
    /// For example, in a clothing category, Size Type could be
    /// recommended as a parent of Size, because Size=Small would
    /// mean something different to buyers depending on whether
    /// Size Type=Petite or Size Type=Plus.
    /// 
    /// In general, it is a good idea to retrieve and use relationship
    /// recommendations, as this data can help buyers find the items
    /// they want more easily.
    /// </param>
    /// <param name="IncludeConfidence">
    /// If this boolean field is included and set to <code>true</code>, eBay's level of confidence in the popularity of each Item Specific name and value for the specified category is returned in the response. Some sellers may find this useful when choosing whether to use eBay's recommendation or their own Item Specifics names or values.
    /// 
    /// If this field is used, either one or more <b>CategoryID</b> values and/or one or more <b>CategorySpecific.CategoryID</b> values must be specified. If you try to use this field solely with the <b>CategorySpecificsFileInfo</b> field, the request fails and no <b>TaskReferenceID</b> or <b>FileReferenceID</b> values are returned.
    /// </param>
    /// <param name="CategorySpecificsFileInfo">
    /// If this boolean field is included and set to <code>true</code>, the response includes a <b>FileReferenceID</b> and
    /// <b>TaskReferenceID</b> value. Use these identifiers as inputs to the <b>downloadFile</b>
    /// call in the eBay File Transfer API. That API lets you retrieve
    /// a single (bulk) <b>GetCategorySpecifics</b> response with all the Item
    /// Specifics recommendations available for the requested site ID.
    /// (The <b>downloadFile</b> call downloads a .zip file as an
    /// attachment.)
    /// 
    /// Either the <b>CategorySpecificsFileInfo</b> field or one or more <b>CategoryID</b> and/or <b>CategorySpecific.CategoryID</b> values are required
    /// in a <b>GetCategorySpecifics</b> call.
    /// 
    /// <span class="tablenote"><b>Note:</b>
    /// You can use the File Transfer API without using or learning
    /// about the Bulk Data Exchange API or other
    /// Large Merchant Services APIs.
    /// </span>
    /// </param>
    public RecommendationsTypeCollection GetCategorySpecifics(
      StringCollection CategoryIDList,
      DateTime LastUpdateTime,
      int MaxNames,
      int MaxValuesPerName,
      string Name,
      CategoryItemSpecificsTypeCollection CategorySpecificList,
      bool ExcludeRelationships,
      bool IncludeConfidence,
      bool CategorySpecificsFileInfo)
    {
      this.CategoryIDList = CategoryIDList;
      this.LastUpdateTime = LastUpdateTime;
      this.MaxNames = MaxNames;
      this.MaxValuesPerName = MaxValuesPerName;
      this.Name = Name;
      this.CategorySpecificList = CategorySpecificList;
      this.ExcludeRelationships = ExcludeRelationships;
      this.IncludeConfidence = IncludeConfidence;
      this.CategorySpecificsFileInfo = CategorySpecificsFileInfo;
      this.Execute();
      return this.ApiResponse.Recommendations;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public RecommendationsTypeCollection GetCategorySpecifics(StringCollection CategoryIDList)
    {
      this.CategoryIDList = CategoryIDList;
      this.Execute();
      return this.ApiResponse.Recommendations;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetCategorySpecificsRequestType" /> for this API call.
    /// </summary>
    public GetCategorySpecificsRequestType ApiRequest
    {
      get => (GetCategorySpecificsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetCategorySpecificsResponseType" /> for this API call.
    /// </summary>
    public GetCategorySpecificsResponseType ApiResponse
    {
      get => (GetCategorySpecificsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.CategoryID" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection CategoryIDList
    {
      get => this.ApiRequest.CategoryID;
      set => this.ApiRequest.CategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.LastUpdateTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime LastUpdateTime
    {
      get => this.ApiRequest.LastUpdateTime;
      set => this.ApiRequest.LastUpdateTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.MaxNames" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int MaxNames
    {
      get => this.ApiRequest.MaxNames;
      set => this.ApiRequest.MaxNames = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.MaxValuesPerName" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int MaxValuesPerName
    {
      get => this.ApiRequest.MaxValuesPerName;
      set => this.ApiRequest.MaxValuesPerName = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.Name" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Name
    {
      get => this.ApiRequest.Name;
      set => this.ApiRequest.Name = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.CategorySpecific" /> of type <see cref="T:eBay.Service.Core.Soap.CategoryItemSpecificsTypeCollection" />.
    /// </summary>
    public CategoryItemSpecificsTypeCollection CategorySpecificList
    {
      get => this.ApiRequest.CategorySpecific;
      set => this.ApiRequest.CategorySpecific = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.ExcludeRelationships" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ExcludeRelationships
    {
      get => this.ApiRequest.ExcludeRelationships;
      set => this.ApiRequest.ExcludeRelationships = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.IncludeConfidence" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeConfidence
    {
      get => this.ApiRequest.IncludeConfidence;
      set => this.ApiRequest.IncludeConfidence = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsRequestType.CategorySpecificsFileInfo" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool CategorySpecificsFileInfo
    {
      get => this.ApiRequest.CategorySpecificsFileInfo;
      set => this.ApiRequest.CategorySpecificsFileInfo = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsResponseType.Recommendations" /> of type <see cref="T:eBay.Service.Core.Soap.RecommendationsTypeCollection" />.
    /// </summary>
    public RecommendationsTypeCollection RecommendationList => this.ApiResponse.Recommendations;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsResponseType.TaskReferenceID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TaskReferenceID => this.ApiResponse.TaskReferenceID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategorySpecificsResponseType.FileReferenceID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string FileReferenceID => this.ApiResponse.FileReferenceID;
  }
}
