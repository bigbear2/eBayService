// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.eBayAPIInterfaceService
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "eBayAPISoapBinding", Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [XmlInclude(typeof (AbstractResponseType))]
  [XmlInclude(typeof (AbstractRequestType))]
  public class eBayAPIInterfaceService : SoapHttpClientProtocolEx
  {
    private CustomSecurityHeaderType mRequesterCredentials;

    /// <remarks />
    public eBayAPIInterfaceService() => this.Url = "https://api.ebay.com/wsapi";

    /// <summary>
    /// 
    /// </summary>
    public CustomSecurityHeaderType RequesterCredentials
    {
      get => this.mRequesterCredentials;
      set => this.mRequesterCredentials = value;
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddDisputeResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddDisputeResponseType AddDispute([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddDisputeRequestType AddDisputeRequest)
    {
      return (AddDisputeResponseType) this.Invoke(nameof (AddDispute), new object[1]
      {
        (object) AddDisputeRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddDispute(
      AddDisputeRequestType AddDisputeRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddDispute", new object[1]
      {
        (object) AddDisputeRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddDisputeResponseType EndAddDispute(IAsyncResult asyncResult)
    {
      return (AddDisputeResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddDisputeResponseResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddDisputeResponseResponseType AddDisputeResponse(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddDisputeResponseRequestType AddDisputeResponseRequest)
    {
      return (AddDisputeResponseResponseType) this.Invoke(nameof (AddDisputeResponse), new object[1]
      {
        (object) AddDisputeResponseRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddDisputeResponse(
      AddDisputeResponseRequestType AddDisputeResponseRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddDisputeResponse", new object[1]
      {
        (object) AddDisputeResponseRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddDisputeResponseResponseType EndAddDisputeResponse(IAsyncResult asyncResult)
    {
      return (AddDisputeResponseResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddFixedPriceItemResponseType AddFixedPriceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddFixedPriceItemRequestType AddFixedPriceItemRequest)
    {
      return (AddFixedPriceItemResponseType) this.Invoke(nameof (AddFixedPriceItem), new object[1]
      {
        (object) AddFixedPriceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddFixedPriceItem(
      AddFixedPriceItemRequestType AddFixedPriceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddFixedPriceItem", new object[1]
      {
        (object) AddFixedPriceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddFixedPriceItemResponseType EndAddFixedPriceItem(IAsyncResult asyncResult)
    {
      return (AddFixedPriceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddItemResponseType AddItem([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddItemRequestType AddItemRequest)
    {
      return (AddItemResponseType) this.Invoke(nameof (AddItem), new object[1]
      {
        (object) AddItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddItem(
      AddItemRequestType AddItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddItem", new object[1]
      {
        (object) AddItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddItemResponseType EndAddItem(IAsyncResult asyncResult)
    {
      return (AddItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddItemFromSellingManagerTemplateResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddItemFromSellingManagerTemplateResponseType AddItemFromSellingManagerTemplate(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddItemFromSellingManagerTemplateRequestType AddItemFromSellingManagerTemplateRequest)
    {
      return (AddItemFromSellingManagerTemplateResponseType) this.Invoke(nameof (AddItemFromSellingManagerTemplate), new object[1]
      {
        (object) AddItemFromSellingManagerTemplateRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddItemFromSellingManagerTemplate(
      AddItemFromSellingManagerTemplateRequestType AddItemFromSellingManagerTemplateRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddItemFromSellingManagerTemplate", new object[1]
      {
        (object) AddItemFromSellingManagerTemplateRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddItemFromSellingManagerTemplateResponseType EndAddItemFromSellingManagerTemplate(
      IAsyncResult asyncResult)
    {
      return (AddItemFromSellingManagerTemplateResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddItemsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddItemsResponseType AddItems([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddItemsRequestType AddItemsRequest)
    {
      return (AddItemsResponseType) this.Invoke(nameof (AddItems), new object[1]
      {
        (object) AddItemsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddItems(
      AddItemsRequestType AddItemsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddItems", new object[1]
      {
        (object) AddItemsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddItemsResponseType EndAddItems(IAsyncResult asyncResult)
    {
      return (AddItemsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddMemberMessageAAQToPartnerResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddMemberMessageAAQToPartnerResponseType AddMemberMessageAAQToPartner(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddMemberMessageAAQToPartnerRequestType AddMemberMessageAAQToPartnerRequest)
    {
      return (AddMemberMessageAAQToPartnerResponseType) this.Invoke(nameof (AddMemberMessageAAQToPartner), new object[1]
      {
        (object) AddMemberMessageAAQToPartnerRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddMemberMessageAAQToPartner(
      AddMemberMessageAAQToPartnerRequestType AddMemberMessageAAQToPartnerRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddMemberMessageAAQToPartner", new object[1]
      {
        (object) AddMemberMessageAAQToPartnerRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddMemberMessageAAQToPartnerResponseType EndAddMemberMessageAAQToPartner(
      IAsyncResult asyncResult)
    {
      return (AddMemberMessageAAQToPartnerResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddMemberMessageRTQResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddMemberMessageRTQResponseType AddMemberMessageRTQ(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddMemberMessageRTQRequestType AddMemberMessageRTQRequest)
    {
      return (AddMemberMessageRTQResponseType) this.Invoke(nameof (AddMemberMessageRTQ), new object[1]
      {
        (object) AddMemberMessageRTQRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddMemberMessageRTQ(
      AddMemberMessageRTQRequestType AddMemberMessageRTQRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddMemberMessageRTQ", new object[1]
      {
        (object) AddMemberMessageRTQRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddMemberMessageRTQResponseType EndAddMemberMessageRTQ(IAsyncResult asyncResult)
    {
      return (AddMemberMessageRTQResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddMemberMessagesAAQToBidderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddMemberMessagesAAQToBidderResponseType AddMemberMessagesAAQToBidder(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddMemberMessagesAAQToBidderRequestType AddMemberMessagesAAQToBidderRequest)
    {
      return (AddMemberMessagesAAQToBidderResponseType) this.Invoke(nameof (AddMemberMessagesAAQToBidder), new object[1]
      {
        (object) AddMemberMessagesAAQToBidderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddMemberMessagesAAQToBidder(
      AddMemberMessagesAAQToBidderRequestType AddMemberMessagesAAQToBidderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddMemberMessagesAAQToBidder", new object[1]
      {
        (object) AddMemberMessagesAAQToBidderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddMemberMessagesAAQToBidderResponseType EndAddMemberMessagesAAQToBidder(
      IAsyncResult asyncResult)
    {
      return (AddMemberMessagesAAQToBidderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddOrderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddOrderResponseType AddOrder([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddOrderRequestType AddOrderRequest)
    {
      return (AddOrderResponseType) this.Invoke(nameof (AddOrder), new object[1]
      {
        (object) AddOrderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddOrder(
      AddOrderRequestType AddOrderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddOrder", new object[1]
      {
        (object) AddOrderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddOrderResponseType EndAddOrder(IAsyncResult asyncResult)
    {
      return (AddOrderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddSecondChanceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddSecondChanceItemResponseType AddSecondChanceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddSecondChanceItemRequestType AddSecondChanceItemRequest)
    {
      return (AddSecondChanceItemResponseType) this.Invoke(nameof (AddSecondChanceItem), new object[1]
      {
        (object) AddSecondChanceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddSecondChanceItem(
      AddSecondChanceItemRequestType AddSecondChanceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddSecondChanceItem", new object[1]
      {
        (object) AddSecondChanceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddSecondChanceItemResponseType EndAddSecondChanceItem(IAsyncResult asyncResult)
    {
      return (AddSecondChanceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddSellingManagerInventoryFolderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddSellingManagerInventoryFolderResponseType AddSellingManagerInventoryFolder(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddSellingManagerInventoryFolderRequestType AddSellingManagerInventoryFolderRequest)
    {
      return (AddSellingManagerInventoryFolderResponseType) this.Invoke(nameof (AddSellingManagerInventoryFolder), new object[1]
      {
        (object) AddSellingManagerInventoryFolderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddSellingManagerInventoryFolder(
      AddSellingManagerInventoryFolderRequestType AddSellingManagerInventoryFolderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddSellingManagerInventoryFolder", new object[1]
      {
        (object) AddSellingManagerInventoryFolderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddSellingManagerInventoryFolderResponseType EndAddSellingManagerInventoryFolder(
      IAsyncResult asyncResult)
    {
      return (AddSellingManagerInventoryFolderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddSellingManagerProductResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddSellingManagerProductResponseType AddSellingManagerProduct(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddSellingManagerProductRequestType AddSellingManagerProductRequest)
    {
      return (AddSellingManagerProductResponseType) this.Invoke(nameof (AddSellingManagerProduct), new object[1]
      {
        (object) AddSellingManagerProductRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddSellingManagerProduct(
      AddSellingManagerProductRequestType AddSellingManagerProductRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddSellingManagerProduct", new object[1]
      {
        (object) AddSellingManagerProductRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddSellingManagerProductResponseType EndAddSellingManagerProduct(IAsyncResult asyncResult)
    {
      return (AddSellingManagerProductResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddSellingManagerTemplateResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddSellingManagerTemplateResponseType AddSellingManagerTemplate(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddSellingManagerTemplateRequestType AddSellingManagerTemplateRequest)
    {
      return (AddSellingManagerTemplateResponseType) this.Invoke(nameof (AddSellingManagerTemplate), new object[1]
      {
        (object) AddSellingManagerTemplateRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddSellingManagerTemplate(
      AddSellingManagerTemplateRequestType AddSellingManagerTemplateRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddSellingManagerTemplate", new object[1]
      {
        (object) AddSellingManagerTemplateRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddSellingManagerTemplateResponseType EndAddSellingManagerTemplate(
      IAsyncResult asyncResult)
    {
      return (AddSellingManagerTemplateResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddToItemDescriptionResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddToItemDescriptionResponseType AddToItemDescription(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddToItemDescriptionRequestType AddToItemDescriptionRequest)
    {
      return (AddToItemDescriptionResponseType) this.Invoke(nameof (AddToItemDescription), new object[1]
      {
        (object) AddToItemDescriptionRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddToItemDescription(
      AddToItemDescriptionRequestType AddToItemDescriptionRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddToItemDescription", new object[1]
      {
        (object) AddToItemDescriptionRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddToItemDescriptionResponseType EndAddToItemDescription(IAsyncResult asyncResult)
    {
      return (AddToItemDescriptionResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddToWatchListResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddToWatchListResponseType AddToWatchList([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddToWatchListRequestType AddToWatchListRequest)
    {
      return (AddToWatchListResponseType) this.Invoke(nameof (AddToWatchList), new object[1]
      {
        (object) AddToWatchListRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddToWatchList(
      AddToWatchListRequestType AddToWatchListRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddToWatchList", new object[1]
      {
        (object) AddToWatchListRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddToWatchListResponseType EndAddToWatchList(IAsyncResult asyncResult)
    {
      return (AddToWatchListResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("AddTransactionConfirmationItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public AddTransactionConfirmationItemResponseType AddTransactionConfirmationItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] AddTransactionConfirmationItemRequestType AddTransactionConfirmationItemRequest)
    {
      return (AddTransactionConfirmationItemResponseType) this.Invoke(nameof (AddTransactionConfirmationItem), new object[1]
      {
        (object) AddTransactionConfirmationItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginAddTransactionConfirmationItem(
      AddTransactionConfirmationItemRequestType AddTransactionConfirmationItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("AddTransactionConfirmationItem", new object[1]
      {
        (object) AddTransactionConfirmationItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public AddTransactionConfirmationItemResponseType EndAddTransactionConfirmationItem(
      IAsyncResult asyncResult)
    {
      return (AddTransactionConfirmationItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("CompleteSaleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public CompleteSaleResponseType CompleteSale([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] CompleteSaleRequestType CompleteSaleRequest)
    {
      return (CompleteSaleResponseType) this.Invoke(nameof (CompleteSale), new object[1]
      {
        (object) CompleteSaleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginCompleteSale(
      CompleteSaleRequestType CompleteSaleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("CompleteSale", new object[1]
      {
        (object) CompleteSaleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public CompleteSaleResponseType EndCompleteSale(IAsyncResult asyncResult)
    {
      return (CompleteSaleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ConfirmIdentityResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ConfirmIdentityResponseType ConfirmIdentity(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ConfirmIdentityRequestType ConfirmIdentityRequest)
    {
      return (ConfirmIdentityResponseType) this.Invoke(nameof (ConfirmIdentity), new object[1]
      {
        (object) ConfirmIdentityRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginConfirmIdentity(
      ConfirmIdentityRequestType ConfirmIdentityRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ConfirmIdentity", new object[1]
      {
        (object) ConfirmIdentityRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ConfirmIdentityResponseType EndConfirmIdentity(IAsyncResult asyncResult)
    {
      return (ConfirmIdentityResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DeleteMyMessagesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DeleteMyMessagesResponseType DeleteMyMessages(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DeleteMyMessagesRequestType DeleteMyMessagesRequest)
    {
      return (DeleteMyMessagesResponseType) this.Invoke(nameof (DeleteMyMessages), new object[1]
      {
        (object) DeleteMyMessagesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDeleteMyMessages(
      DeleteMyMessagesRequestType DeleteMyMessagesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DeleteMyMessages", new object[1]
      {
        (object) DeleteMyMessagesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DeleteMyMessagesResponseType EndDeleteMyMessages(IAsyncResult asyncResult)
    {
      return (DeleteMyMessagesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DeleteSellingManagerInventoryFolderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DeleteSellingManagerInventoryFolderResponseType DeleteSellingManagerInventoryFolder(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DeleteSellingManagerInventoryFolderRequestType DeleteSellingManagerInventoryFolderRequest)
    {
      return (DeleteSellingManagerInventoryFolderResponseType) this.Invoke(nameof (DeleteSellingManagerInventoryFolder), new object[1]
      {
        (object) DeleteSellingManagerInventoryFolderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDeleteSellingManagerInventoryFolder(
      DeleteSellingManagerInventoryFolderRequestType DeleteSellingManagerInventoryFolderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DeleteSellingManagerInventoryFolder", new object[1]
      {
        (object) DeleteSellingManagerInventoryFolderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DeleteSellingManagerInventoryFolderResponseType EndDeleteSellingManagerInventoryFolder(
      IAsyncResult asyncResult)
    {
      return (DeleteSellingManagerInventoryFolderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DeleteSellingManagerItemAutomationRuleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DeleteSellingManagerItemAutomationRuleResponseType DeleteSellingManagerItemAutomationRule(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DeleteSellingManagerItemAutomationRuleRequestType DeleteSellingManagerItemAutomationRuleRequest)
    {
      return (DeleteSellingManagerItemAutomationRuleResponseType) this.Invoke(nameof (DeleteSellingManagerItemAutomationRule), new object[1]
      {
        (object) DeleteSellingManagerItemAutomationRuleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDeleteSellingManagerItemAutomationRule(
      DeleteSellingManagerItemAutomationRuleRequestType DeleteSellingManagerItemAutomationRuleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DeleteSellingManagerItemAutomationRule", new object[1]
      {
        (object) DeleteSellingManagerItemAutomationRuleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DeleteSellingManagerItemAutomationRuleResponseType EndDeleteSellingManagerItemAutomationRule(
      IAsyncResult asyncResult)
    {
      return (DeleteSellingManagerItemAutomationRuleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DeleteSellingManagerProductResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DeleteSellingManagerProductResponseType DeleteSellingManagerProduct(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DeleteSellingManagerProductRequestType DeleteSellingManagerProductRequest)
    {
      return (DeleteSellingManagerProductResponseType) this.Invoke(nameof (DeleteSellingManagerProduct), new object[1]
      {
        (object) DeleteSellingManagerProductRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDeleteSellingManagerProduct(
      DeleteSellingManagerProductRequestType DeleteSellingManagerProductRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DeleteSellingManagerProduct", new object[1]
      {
        (object) DeleteSellingManagerProductRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DeleteSellingManagerProductResponseType EndDeleteSellingManagerProduct(
      IAsyncResult asyncResult)
    {
      return (DeleteSellingManagerProductResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DeleteSellingManagerTemplateResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DeleteSellingManagerTemplateResponseType DeleteSellingManagerTemplate(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DeleteSellingManagerTemplateRequestType DeleteSellingManagerTemplateRequest)
    {
      return (DeleteSellingManagerTemplateResponseType) this.Invoke(nameof (DeleteSellingManagerTemplate), new object[1]
      {
        (object) DeleteSellingManagerTemplateRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDeleteSellingManagerTemplate(
      DeleteSellingManagerTemplateRequestType DeleteSellingManagerTemplateRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DeleteSellingManagerTemplate", new object[1]
      {
        (object) DeleteSellingManagerTemplateRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DeleteSellingManagerTemplateResponseType EndDeleteSellingManagerTemplate(
      IAsyncResult asyncResult)
    {
      return (DeleteSellingManagerTemplateResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DeleteSellingManagerTemplateAutomationRuleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DeleteSellingManagerTemplateAutomationRuleResponseType DeleteSellingManagerTemplateAutomationRule(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DeleteSellingManagerTemplateAutomationRuleRequestType DeleteSellingManagerTemplateAutomationRuleRequest)
    {
      return (DeleteSellingManagerTemplateAutomationRuleResponseType) this.Invoke(nameof (DeleteSellingManagerTemplateAutomationRule), new object[1]
      {
        (object) DeleteSellingManagerTemplateAutomationRuleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDeleteSellingManagerTemplateAutomationRule(
      DeleteSellingManagerTemplateAutomationRuleRequestType DeleteSellingManagerTemplateAutomationRuleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DeleteSellingManagerTemplateAutomationRule", new object[1]
      {
        (object) DeleteSellingManagerTemplateAutomationRuleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DeleteSellingManagerTemplateAutomationRuleResponseType EndDeleteSellingManagerTemplateAutomationRule(
      IAsyncResult asyncResult)
    {
      return (DeleteSellingManagerTemplateAutomationRuleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("DisableUnpaidItemAssistanceResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public DisableUnpaidItemAssistanceResponseType DisableUnpaidItemAssistance(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] DisableUnpaidItemAssistanceRequestType DisableUnpaidItemAssistanceRequest)
    {
      return (DisableUnpaidItemAssistanceResponseType) this.Invoke(nameof (DisableUnpaidItemAssistance), new object[1]
      {
        (object) DisableUnpaidItemAssistanceRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginDisableUnpaidItemAssistance(
      DisableUnpaidItemAssistanceRequestType DisableUnpaidItemAssistanceRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("DisableUnpaidItemAssistance", new object[1]
      {
        (object) DisableUnpaidItemAssistanceRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public DisableUnpaidItemAssistanceResponseType EndDisableUnpaidItemAssistance(
      IAsyncResult asyncResult)
    {
      return (DisableUnpaidItemAssistanceResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("EndFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public EndFixedPriceItemResponseType EndFixedPriceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] EndFixedPriceItemRequestType EndFixedPriceItemRequest)
    {
      return (EndFixedPriceItemResponseType) this.Invoke(nameof (EndFixedPriceItem), new object[1]
      {
        (object) EndFixedPriceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginEndFixedPriceItem(
      EndFixedPriceItemRequestType EndFixedPriceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("EndFixedPriceItem", new object[1]
      {
        (object) EndFixedPriceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public EndFixedPriceItemResponseType EndEndFixedPriceItem(IAsyncResult asyncResult)
    {
      return (EndFixedPriceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("EndItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public EndItemResponseType EndItem([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] EndItemRequestType EndItemRequest)
    {
      return (EndItemResponseType) this.Invoke(nameof (EndItem), new object[1]
      {
        (object) EndItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginEndItem(
      EndItemRequestType EndItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("EndItem", new object[1]
      {
        (object) EndItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public EndItemResponseType EndEndItem(IAsyncResult asyncResult)
    {
      return (EndItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("EndItemsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public EndItemsResponseType EndItems([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] EndItemsRequestType EndItemsRequest)
    {
      return (EndItemsResponseType) this.Invoke(nameof (EndItems), new object[1]
      {
        (object) EndItemsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginEndItems(
      EndItemsRequestType EndItemsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("EndItems", new object[1]
      {
        (object) EndItemsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public EndItemsResponseType EndEndItems(IAsyncResult asyncResult)
    {
      return (EndItemsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ExtendSiteHostedPicturesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ExtendSiteHostedPicturesResponseType ExtendSiteHostedPictures(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ExtendSiteHostedPicturesRequestType ExtendSiteHostedPicturesRequest)
    {
      return (ExtendSiteHostedPicturesResponseType) this.Invoke(nameof (ExtendSiteHostedPictures), new object[1]
      {
        (object) ExtendSiteHostedPicturesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginExtendSiteHostedPictures(
      ExtendSiteHostedPicturesRequestType ExtendSiteHostedPicturesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ExtendSiteHostedPictures", new object[1]
      {
        (object) ExtendSiteHostedPicturesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ExtendSiteHostedPicturesResponseType EndExtendSiteHostedPictures(IAsyncResult asyncResult)
    {
      return (ExtendSiteHostedPicturesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("FetchTokenResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public FetchTokenResponseType FetchToken([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] FetchTokenRequestType FetchTokenRequest)
    {
      return (FetchTokenResponseType) this.Invoke(nameof (FetchToken), new object[1]
      {
        (object) FetchTokenRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginFetchToken(
      FetchTokenRequestType FetchTokenRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("FetchToken", new object[1]
      {
        (object) FetchTokenRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public FetchTokenResponseType EndFetchToken(IAsyncResult asyncResult)
    {
      return (FetchTokenResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetAccountResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetAccountResponseType GetAccount([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetAccountRequestType GetAccountRequest)
    {
      return (GetAccountResponseType) this.Invoke(nameof (GetAccount), new object[1]
      {
        (object) GetAccountRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetAccount(
      GetAccountRequestType GetAccountRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetAccount", new object[1]
      {
        (object) GetAccountRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetAccountResponseType EndGetAccount(IAsyncResult asyncResult)
    {
      return (GetAccountResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetAdFormatLeadsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetAdFormatLeadsResponseType GetAdFormatLeads(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetAdFormatLeadsRequestType GetAdFormatLeadsRequest)
    {
      return (GetAdFormatLeadsResponseType) this.Invoke(nameof (GetAdFormatLeads), new object[1]
      {
        (object) GetAdFormatLeadsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetAdFormatLeads(
      GetAdFormatLeadsRequestType GetAdFormatLeadsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetAdFormatLeads", new object[1]
      {
        (object) GetAdFormatLeadsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetAdFormatLeadsResponseType EndGetAdFormatLeads(IAsyncResult asyncResult)
    {
      return (GetAdFormatLeadsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetAllBiddersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetAllBiddersResponseType GetAllBidders([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetAllBiddersRequestType GetAllBiddersRequest)
    {
      return (GetAllBiddersResponseType) this.Invoke(nameof (GetAllBidders), new object[1]
      {
        (object) GetAllBiddersRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetAllBidders(
      GetAllBiddersRequestType GetAllBiddersRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetAllBidders", new object[1]
      {
        (object) GetAllBiddersRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetAllBiddersResponseType EndGetAllBidders(IAsyncResult asyncResult)
    {
      return (GetAllBiddersResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetApiAccessRulesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetApiAccessRulesResponseType GetApiAccessRules(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetApiAccessRulesRequestType GetApiAccessRulesRequest)
    {
      return (GetApiAccessRulesResponseType) this.Invoke(nameof (GetApiAccessRules), new object[1]
      {
        (object) GetApiAccessRulesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetApiAccessRules(
      GetApiAccessRulesRequestType GetApiAccessRulesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetApiAccessRules", new object[1]
      {
        (object) GetApiAccessRulesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetApiAccessRulesResponseType EndGetApiAccessRules(IAsyncResult asyncResult)
    {
      return (GetApiAccessRulesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetBestOffersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetBestOffersResponseType GetBestOffers([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetBestOffersRequestType GetBestOffersRequest)
    {
      return (GetBestOffersResponseType) this.Invoke(nameof (GetBestOffers), new object[1]
      {
        (object) GetBestOffersRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetBestOffers(
      GetBestOffersRequestType GetBestOffersRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetBestOffers", new object[1]
      {
        (object) GetBestOffersRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetBestOffersResponseType EndGetBestOffers(IAsyncResult asyncResult)
    {
      return (GetBestOffersResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetBidderListResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetBidderListResponseType GetBidderList([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetBidderListRequestType GetBidderListRequest)
    {
      return (GetBidderListResponseType) this.Invoke(nameof (GetBidderList), new object[1]
      {
        (object) GetBidderListRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetBidderList(
      GetBidderListRequestType GetBidderListRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetBidderList", new object[1]
      {
        (object) GetBidderListRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetBidderListResponseType EndGetBidderList(IAsyncResult asyncResult)
    {
      return (GetBidderListResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetCategoriesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetCategoriesResponseType GetCategories([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetCategoriesRequestType GetCategoriesRequest)
    {
      return (GetCategoriesResponseType) this.Invoke(nameof (GetCategories), new object[1]
      {
        (object) GetCategoriesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetCategories(
      GetCategoriesRequestType GetCategoriesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetCategories", new object[1]
      {
        (object) GetCategoriesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetCategoriesResponseType EndGetCategories(IAsyncResult asyncResult)
    {
      return (GetCategoriesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetCategoryFeaturesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetCategoryFeaturesResponseType GetCategoryFeatures(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetCategoryFeaturesRequestType GetCategoryFeaturesRequest)
    {
      return (GetCategoryFeaturesResponseType) this.Invoke(nameof (GetCategoryFeatures), new object[1]
      {
        (object) GetCategoryFeaturesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetCategoryFeatures(
      GetCategoryFeaturesRequestType GetCategoryFeaturesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetCategoryFeatures", new object[1]
      {
        (object) GetCategoryFeaturesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetCategoryFeaturesResponseType EndGetCategoryFeatures(IAsyncResult asyncResult)
    {
      return (GetCategoryFeaturesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetCategoryMappingsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetCategoryMappingsResponseType GetCategoryMappings(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetCategoryMappingsRequestType GetCategoryMappingsRequest)
    {
      return (GetCategoryMappingsResponseType) this.Invoke(nameof (GetCategoryMappings), new object[1]
      {
        (object) GetCategoryMappingsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetCategoryMappings(
      GetCategoryMappingsRequestType GetCategoryMappingsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetCategoryMappings", new object[1]
      {
        (object) GetCategoryMappingsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetCategoryMappingsResponseType EndGetCategoryMappings(IAsyncResult asyncResult)
    {
      return (GetCategoryMappingsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetCategorySpecificsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetCategorySpecificsResponseType GetCategorySpecifics(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetCategorySpecificsRequestType GetCategorySpecificsRequest)
    {
      return (GetCategorySpecificsResponseType) this.Invoke(nameof (GetCategorySpecifics), new object[1]
      {
        (object) GetCategorySpecificsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetCategorySpecifics(
      GetCategorySpecificsRequestType GetCategorySpecificsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetCategorySpecifics", new object[1]
      {
        (object) GetCategorySpecificsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetCategorySpecificsResponseType EndGetCategorySpecifics(IAsyncResult asyncResult)
    {
      return (GetCategorySpecificsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetChallengeTokenResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetChallengeTokenResponseType GetChallengeToken(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetChallengeTokenRequestType GetChallengeTokenRequest)
    {
      return (GetChallengeTokenResponseType) this.Invoke(nameof (GetChallengeToken), new object[1]
      {
        (object) GetChallengeTokenRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetChallengeToken(
      GetChallengeTokenRequestType GetChallengeTokenRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetChallengeToken", new object[1]
      {
        (object) GetChallengeTokenRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetChallengeTokenResponseType EndGetChallengeToken(IAsyncResult asyncResult)
    {
      return (GetChallengeTokenResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetCharitiesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetCharitiesResponseType GetCharities([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetCharitiesRequestType GetCharitiesRequest)
    {
      return (GetCharitiesResponseType) this.Invoke(nameof (GetCharities), new object[1]
      {
        (object) GetCharitiesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetCharities(
      GetCharitiesRequestType GetCharitiesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetCharities", new object[1]
      {
        (object) GetCharitiesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetCharitiesResponseType EndGetCharities(IAsyncResult asyncResult)
    {
      return (GetCharitiesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetClientAlertsAuthTokenResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetClientAlertsAuthTokenResponseType GetClientAlertsAuthToken(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetClientAlertsAuthTokenRequestType GetClientAlertsAuthTokenRequest)
    {
      return (GetClientAlertsAuthTokenResponseType) this.Invoke(nameof (GetClientAlertsAuthToken), new object[1]
      {
        (object) GetClientAlertsAuthTokenRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetClientAlertsAuthToken(
      GetClientAlertsAuthTokenRequestType GetClientAlertsAuthTokenRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetClientAlertsAuthToken", new object[1]
      {
        (object) GetClientAlertsAuthTokenRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetClientAlertsAuthTokenResponseType EndGetClientAlertsAuthToken(IAsyncResult asyncResult)
    {
      return (GetClientAlertsAuthTokenResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetContextualKeywordsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetContextualKeywordsResponseType GetContextualKeywords(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetContextualKeywordsRequestType GetContextualKeywordsRequest)
    {
      return (GetContextualKeywordsResponseType) this.Invoke(nameof (GetContextualKeywords), new object[1]
      {
        (object) GetContextualKeywordsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetContextualKeywords(
      GetContextualKeywordsRequestType GetContextualKeywordsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetContextualKeywords", new object[1]
      {
        (object) GetContextualKeywordsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetContextualKeywordsResponseType EndGetContextualKeywords(IAsyncResult asyncResult)
    {
      return (GetContextualKeywordsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetDescriptionTemplatesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetDescriptionTemplatesResponseType GetDescriptionTemplates(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetDescriptionTemplatesRequestType GetDescriptionTemplatesRequest)
    {
      return (GetDescriptionTemplatesResponseType) this.Invoke(nameof (GetDescriptionTemplates), new object[1]
      {
        (object) GetDescriptionTemplatesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetDescriptionTemplates(
      GetDescriptionTemplatesRequestType GetDescriptionTemplatesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetDescriptionTemplates", new object[1]
      {
        (object) GetDescriptionTemplatesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetDescriptionTemplatesResponseType EndGetDescriptionTemplates(IAsyncResult asyncResult)
    {
      return (GetDescriptionTemplatesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetDisputeResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetDisputeResponseType GetDispute([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetDisputeRequestType GetDisputeRequest)
    {
      return (GetDisputeResponseType) this.Invoke(nameof (GetDispute), new object[1]
      {
        (object) GetDisputeRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetDispute(
      GetDisputeRequestType GetDisputeRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetDispute", new object[1]
      {
        (object) GetDisputeRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetDisputeResponseType EndGetDispute(IAsyncResult asyncResult)
    {
      return (GetDisputeResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetFeedbackResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetFeedbackResponseType GetFeedback([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetFeedbackRequestType GetFeedbackRequest)
    {
      return (GetFeedbackResponseType) this.Invoke(nameof (GetFeedback), new object[1]
      {
        (object) GetFeedbackRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetFeedback(
      GetFeedbackRequestType GetFeedbackRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetFeedback", new object[1]
      {
        (object) GetFeedbackRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetFeedbackResponseType EndGetFeedback(IAsyncResult asyncResult)
    {
      return (GetFeedbackResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetItemResponseType GetItem([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetItemRequestType GetItemRequest)
    {
      return (GetItemResponseType) this.Invoke(nameof (GetItem), new object[1]
      {
        (object) GetItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetItem(
      GetItemRequestType GetItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetItem", new object[1]
      {
        (object) GetItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetItemResponseType EndGetItem(IAsyncResult asyncResult)
    {
      return (GetItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetItemShippingResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetItemShippingResponseType GetItemShipping(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetItemShippingRequestType GetItemShippingRequest)
    {
      return (GetItemShippingResponseType) this.Invoke(nameof (GetItemShipping), new object[1]
      {
        (object) GetItemShippingRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetItemShipping(
      GetItemShippingRequestType GetItemShippingRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetItemShipping", new object[1]
      {
        (object) GetItemShippingRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetItemShippingResponseType EndGetItemShipping(IAsyncResult asyncResult)
    {
      return (GetItemShippingResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetItemTransactionsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetItemTransactionsResponseType GetItemTransactions(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetItemTransactionsRequestType GetItemTransactionsRequest)
    {
      return (GetItemTransactionsResponseType) this.Invoke(nameof (GetItemTransactions), new object[1]
      {
        (object) GetItemTransactionsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetItemTransactions(
      GetItemTransactionsRequestType GetItemTransactionsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetItemTransactions", new object[1]
      {
        (object) GetItemTransactionsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetItemTransactionsResponseType EndGetItemTransactions(IAsyncResult asyncResult)
    {
      return (GetItemTransactionsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetItemsAwaitingFeedbackResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetItemsAwaitingFeedbackResponseType GetItemsAwaitingFeedback(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetItemsAwaitingFeedbackRequestType GetItemsAwaitingFeedbackRequest)
    {
      return (GetItemsAwaitingFeedbackResponseType) this.Invoke(nameof (GetItemsAwaitingFeedback), new object[1]
      {
        (object) GetItemsAwaitingFeedbackRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetItemsAwaitingFeedback(
      GetItemsAwaitingFeedbackRequestType GetItemsAwaitingFeedbackRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetItemsAwaitingFeedback", new object[1]
      {
        (object) GetItemsAwaitingFeedbackRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetItemsAwaitingFeedbackResponseType EndGetItemsAwaitingFeedback(IAsyncResult asyncResult)
    {
      return (GetItemsAwaitingFeedbackResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetMemberMessagesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetMemberMessagesResponseType GetMemberMessages(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetMemberMessagesRequestType GetMemberMessagesRequest)
    {
      return (GetMemberMessagesResponseType) this.Invoke(nameof (GetMemberMessages), new object[1]
      {
        (object) GetMemberMessagesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetMemberMessages(
      GetMemberMessagesRequestType GetMemberMessagesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetMemberMessages", new object[1]
      {
        (object) GetMemberMessagesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetMemberMessagesResponseType EndGetMemberMessages(IAsyncResult asyncResult)
    {
      return (GetMemberMessagesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetMessagePreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetMessagePreferencesResponseType GetMessagePreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetMessagePreferencesRequestType GetMessagePreferencesRequest)
    {
      return (GetMessagePreferencesResponseType) this.Invoke(nameof (GetMessagePreferences), new object[1]
      {
        (object) GetMessagePreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetMessagePreferences(
      GetMessagePreferencesRequestType GetMessagePreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetMessagePreferences", new object[1]
      {
        (object) GetMessagePreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetMessagePreferencesResponseType EndGetMessagePreferences(IAsyncResult asyncResult)
    {
      return (GetMessagePreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetMyMessagesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetMyMessagesResponseType GetMyMessages([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetMyMessagesRequestType GetMyMessagesRequest)
    {
      return (GetMyMessagesResponseType) this.Invoke(nameof (GetMyMessages), new object[1]
      {
        (object) GetMyMessagesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetMyMessages(
      GetMyMessagesRequestType GetMyMessagesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetMyMessages", new object[1]
      {
        (object) GetMyMessagesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetMyMessagesResponseType EndGetMyMessages(IAsyncResult asyncResult)
    {
      return (GetMyMessagesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetMyeBayBuyingResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetMyeBayBuyingResponseType GetMyeBayBuying(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetMyeBayBuyingRequestType GetMyeBayBuyingRequest)
    {
      return (GetMyeBayBuyingResponseType) this.Invoke(nameof (GetMyeBayBuying), new object[1]
      {
        (object) GetMyeBayBuyingRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetMyeBayBuying(
      GetMyeBayBuyingRequestType GetMyeBayBuyingRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetMyeBayBuying", new object[1]
      {
        (object) GetMyeBayBuyingRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetMyeBayBuyingResponseType EndGetMyeBayBuying(IAsyncResult asyncResult)
    {
      return (GetMyeBayBuyingResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetMyeBayRemindersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetMyeBayRemindersResponseType GetMyeBayReminders(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetMyeBayRemindersRequestType GetMyeBayRemindersRequest)
    {
      return (GetMyeBayRemindersResponseType) this.Invoke(nameof (GetMyeBayReminders), new object[1]
      {
        (object) GetMyeBayRemindersRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetMyeBayReminders(
      GetMyeBayRemindersRequestType GetMyeBayRemindersRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetMyeBayReminders", new object[1]
      {
        (object) GetMyeBayRemindersRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetMyeBayRemindersResponseType EndGetMyeBayReminders(IAsyncResult asyncResult)
    {
      return (GetMyeBayRemindersResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetMyeBaySellingResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetMyeBaySellingResponseType GetMyeBaySelling(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetMyeBaySellingRequestType GetMyeBaySellingRequest)
    {
      return (GetMyeBaySellingResponseType) this.Invoke(nameof (GetMyeBaySelling), new object[1]
      {
        (object) GetMyeBaySellingRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetMyeBaySelling(
      GetMyeBaySellingRequestType GetMyeBaySellingRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetMyeBaySelling", new object[1]
      {
        (object) GetMyeBaySellingRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetMyeBaySellingResponseType EndGetMyeBaySelling(IAsyncResult asyncResult)
    {
      return (GetMyeBaySellingResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetNotificationPreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetNotificationPreferencesResponseType GetNotificationPreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetNotificationPreferencesRequestType GetNotificationPreferencesRequest)
    {
      return (GetNotificationPreferencesResponseType) this.Invoke(nameof (GetNotificationPreferences), new object[1]
      {
        (object) GetNotificationPreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetNotificationPreferences(
      GetNotificationPreferencesRequestType GetNotificationPreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetNotificationPreferences", new object[1]
      {
        (object) GetNotificationPreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetNotificationPreferencesResponseType EndGetNotificationPreferences(
      IAsyncResult asyncResult)
    {
      return (GetNotificationPreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetNotificationsUsageResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetNotificationsUsageResponseType GetNotificationsUsage(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetNotificationsUsageRequestType GetNotificationsUsageRequest)
    {
      return (GetNotificationsUsageResponseType) this.Invoke(nameof (GetNotificationsUsage), new object[1]
      {
        (object) GetNotificationsUsageRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetNotificationsUsage(
      GetNotificationsUsageRequestType GetNotificationsUsageRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetNotificationsUsage", new object[1]
      {
        (object) GetNotificationsUsageRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetNotificationsUsageResponseType EndGetNotificationsUsage(IAsyncResult asyncResult)
    {
      return (GetNotificationsUsageResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetOrderTransactionsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetOrderTransactionsResponseType GetOrderTransactions(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetOrderTransactionsRequestType GetOrderTransactionsRequest)
    {
      return (GetOrderTransactionsResponseType) this.Invoke(nameof (GetOrderTransactions), new object[1]
      {
        (object) GetOrderTransactionsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetOrderTransactions(
      GetOrderTransactionsRequestType GetOrderTransactionsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetOrderTransactions", new object[1]
      {
        (object) GetOrderTransactionsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetOrderTransactionsResponseType EndGetOrderTransactions(IAsyncResult asyncResult)
    {
      return (GetOrderTransactionsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetOrdersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetOrdersResponseType GetOrders([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetOrdersRequestType GetOrdersRequest)
    {
      return (GetOrdersResponseType) this.Invoke(nameof (GetOrders), new object[1]
      {
        (object) GetOrdersRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetOrders(
      GetOrdersRequestType GetOrdersRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetOrders", new object[1]
      {
        (object) GetOrdersRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetOrdersResponseType EndGetOrders(IAsyncResult asyncResult)
    {
      return (GetOrdersResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetPromotionalSaleDetailsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetPromotionalSaleDetailsResponseType GetPromotionalSaleDetails(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetPromotionalSaleDetailsRequestType GetPromotionalSaleDetailsRequest)
    {
      return (GetPromotionalSaleDetailsResponseType) this.Invoke(nameof (GetPromotionalSaleDetails), new object[1]
      {
        (object) GetPromotionalSaleDetailsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetPromotionalSaleDetails(
      GetPromotionalSaleDetailsRequestType GetPromotionalSaleDetailsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetPromotionalSaleDetails", new object[1]
      {
        (object) GetPromotionalSaleDetailsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetPromotionalSaleDetailsResponseType EndGetPromotionalSaleDetails(
      IAsyncResult asyncResult)
    {
      return (GetPromotionalSaleDetailsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellerDashboardResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellerDashboardResponseType GetSellerDashboard(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellerDashboardRequestType GetSellerDashboardRequest)
    {
      return (GetSellerDashboardResponseType) this.Invoke(nameof (GetSellerDashboard), new object[1]
      {
        (object) GetSellerDashboardRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellerDashboard(
      GetSellerDashboardRequestType GetSellerDashboardRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellerDashboard", new object[1]
      {
        (object) GetSellerDashboardRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellerDashboardResponseType EndGetSellerDashboard(IAsyncResult asyncResult)
    {
      return (GetSellerDashboardResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellerEventsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellerEventsResponseType GetSellerEvents(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellerEventsRequestType GetSellerEventsRequest)
    {
      return (GetSellerEventsResponseType) this.Invoke(nameof (GetSellerEvents), new object[1]
      {
        (object) GetSellerEventsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellerEvents(
      GetSellerEventsRequestType GetSellerEventsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellerEvents", new object[1]
      {
        (object) GetSellerEventsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellerEventsResponseType EndGetSellerEvents(IAsyncResult asyncResult)
    {
      return (GetSellerEventsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellerListResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellerListResponseType GetSellerList([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellerListRequestType GetSellerListRequest)
    {
      return (GetSellerListResponseType) this.Invoke(nameof (GetSellerList), new object[1]
      {
        (object) GetSellerListRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellerList(
      GetSellerListRequestType GetSellerListRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellerList", new object[1]
      {
        (object) GetSellerListRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellerListResponseType EndGetSellerList(IAsyncResult asyncResult)
    {
      return (GetSellerListResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellerTransactionsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellerTransactionsResponseType GetSellerTransactions(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellerTransactionsRequestType GetSellerTransactionsRequest)
    {
      return (GetSellerTransactionsResponseType) this.Invoke(nameof (GetSellerTransactions), new object[1]
      {
        (object) GetSellerTransactionsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellerTransactions(
      GetSellerTransactionsRequestType GetSellerTransactionsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellerTransactions", new object[1]
      {
        (object) GetSellerTransactionsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellerTransactionsResponseType EndGetSellerTransactions(IAsyncResult asyncResult)
    {
      return (GetSellerTransactionsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerAlertsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerAlertsResponseType GetSellingManagerAlerts(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerAlertsRequestType GetSellingManagerAlertsRequest)
    {
      return (GetSellingManagerAlertsResponseType) this.Invoke(nameof (GetSellingManagerAlerts), new object[1]
      {
        (object) GetSellingManagerAlertsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerAlerts(
      GetSellingManagerAlertsRequestType GetSellingManagerAlertsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerAlerts", new object[1]
      {
        (object) GetSellingManagerAlertsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerAlertsResponseType EndGetSellingManagerAlerts(IAsyncResult asyncResult)
    {
      return (GetSellingManagerAlertsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerEmailLogResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerEmailLogResponseType GetSellingManagerEmailLog(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerEmailLogRequestType GetSellingManagerEmailLogRequest)
    {
      return (GetSellingManagerEmailLogResponseType) this.Invoke(nameof (GetSellingManagerEmailLog), new object[1]
      {
        (object) GetSellingManagerEmailLogRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerEmailLog(
      GetSellingManagerEmailLogRequestType GetSellingManagerEmailLogRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerEmailLog", new object[1]
      {
        (object) GetSellingManagerEmailLogRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerEmailLogResponseType EndGetSellingManagerEmailLog(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerEmailLogResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerInventoryResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerInventoryResponseType GetSellingManagerInventory(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerInventoryRequestType GetSellingManagerInventoryRequest)
    {
      return (GetSellingManagerInventoryResponseType) this.Invoke(nameof (GetSellingManagerInventory), new object[1]
      {
        (object) GetSellingManagerInventoryRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerInventory(
      GetSellingManagerInventoryRequestType GetSellingManagerInventoryRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerInventory", new object[1]
      {
        (object) GetSellingManagerInventoryRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerInventoryResponseType EndGetSellingManagerInventory(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerInventoryResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerInventoryFolderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerInventoryFolderResponseType GetSellingManagerInventoryFolder(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerInventoryFolderRequestType GetSellingManagerInventoryFolderRequest)
    {
      return (GetSellingManagerInventoryFolderResponseType) this.Invoke(nameof (GetSellingManagerInventoryFolder), new object[1]
      {
        (object) GetSellingManagerInventoryFolderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerInventoryFolder(
      GetSellingManagerInventoryFolderRequestType GetSellingManagerInventoryFolderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerInventoryFolder", new object[1]
      {
        (object) GetSellingManagerInventoryFolderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerInventoryFolderResponseType EndGetSellingManagerInventoryFolder(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerInventoryFolderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerItemAutomationRuleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerItemAutomationRuleResponseType GetSellingManagerItemAutomationRule(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerItemAutomationRuleRequestType GetSellingManagerItemAutomationRuleRequest)
    {
      return (GetSellingManagerItemAutomationRuleResponseType) this.Invoke(nameof (GetSellingManagerItemAutomationRule), new object[1]
      {
        (object) GetSellingManagerItemAutomationRuleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerItemAutomationRule(
      GetSellingManagerItemAutomationRuleRequestType GetSellingManagerItemAutomationRuleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerItemAutomationRule", new object[1]
      {
        (object) GetSellingManagerItemAutomationRuleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerItemAutomationRuleResponseType EndGetSellingManagerItemAutomationRule(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerItemAutomationRuleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerSaleRecordResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerSaleRecordResponseType GetSellingManagerSaleRecord(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerSaleRecordRequestType GetSellingManagerSaleRecordRequest)
    {
      return (GetSellingManagerSaleRecordResponseType) this.Invoke(nameof (GetSellingManagerSaleRecord), new object[1]
      {
        (object) GetSellingManagerSaleRecordRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerSaleRecord(
      GetSellingManagerSaleRecordRequestType GetSellingManagerSaleRecordRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerSaleRecord", new object[1]
      {
        (object) GetSellingManagerSaleRecordRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerSaleRecordResponseType EndGetSellingManagerSaleRecord(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerSaleRecordResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerSoldListingsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerSoldListingsResponseType GetSellingManagerSoldListings(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerSoldListingsRequestType GetSellingManagerSoldListingsRequest)
    {
      return (GetSellingManagerSoldListingsResponseType) this.Invoke(nameof (GetSellingManagerSoldListings), new object[1]
      {
        (object) GetSellingManagerSoldListingsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerSoldListings(
      GetSellingManagerSoldListingsRequestType GetSellingManagerSoldListingsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerSoldListings", new object[1]
      {
        (object) GetSellingManagerSoldListingsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerSoldListingsResponseType EndGetSellingManagerSoldListings(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerSoldListingsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerTemplateAutomationRuleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerTemplateAutomationRuleResponseType GetSellingManagerTemplateAutomationRule(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerTemplateAutomationRuleRequestType GetSellingManagerTemplateAutomationRuleRequest)
    {
      return (GetSellingManagerTemplateAutomationRuleResponseType) this.Invoke(nameof (GetSellingManagerTemplateAutomationRule), new object[1]
      {
        (object) GetSellingManagerTemplateAutomationRuleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerTemplateAutomationRule(
      GetSellingManagerTemplateAutomationRuleRequestType GetSellingManagerTemplateAutomationRuleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerTemplateAutomationRule", new object[1]
      {
        (object) GetSellingManagerTemplateAutomationRuleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerTemplateAutomationRuleResponseType EndGetSellingManagerTemplateAutomationRule(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerTemplateAutomationRuleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSellingManagerTemplatesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSellingManagerTemplatesResponseType GetSellingManagerTemplates(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSellingManagerTemplatesRequestType GetSellingManagerTemplatesRequest)
    {
      return (GetSellingManagerTemplatesResponseType) this.Invoke(nameof (GetSellingManagerTemplates), new object[1]
      {
        (object) GetSellingManagerTemplatesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSellingManagerTemplates(
      GetSellingManagerTemplatesRequestType GetSellingManagerTemplatesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSellingManagerTemplates", new object[1]
      {
        (object) GetSellingManagerTemplatesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSellingManagerTemplatesResponseType EndGetSellingManagerTemplates(
      IAsyncResult asyncResult)
    {
      return (GetSellingManagerTemplatesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSessionIDResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSessionIDResponseType GetSessionID([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSessionIDRequestType GetSessionIDRequest)
    {
      return (GetSessionIDResponseType) this.Invoke(nameof (GetSessionID), new object[1]
      {
        (object) GetSessionIDRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSessionID(
      GetSessionIDRequestType GetSessionIDRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSessionID", new object[1]
      {
        (object) GetSessionIDRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSessionIDResponseType EndGetSessionID(IAsyncResult asyncResult)
    {
      return (GetSessionIDResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetShippingDiscountProfilesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetShippingDiscountProfilesResponseType GetShippingDiscountProfiles(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetShippingDiscountProfilesRequestType GetShippingDiscountProfilesRequest)
    {
      return (GetShippingDiscountProfilesResponseType) this.Invoke(nameof (GetShippingDiscountProfiles), new object[1]
      {
        (object) GetShippingDiscountProfilesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetShippingDiscountProfiles(
      GetShippingDiscountProfilesRequestType GetShippingDiscountProfilesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetShippingDiscountProfiles", new object[1]
      {
        (object) GetShippingDiscountProfilesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetShippingDiscountProfilesResponseType EndGetShippingDiscountProfiles(
      IAsyncResult asyncResult)
    {
      return (GetShippingDiscountProfilesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetStoreResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetStoreResponseType GetStore([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetStoreRequestType GetStoreRequest)
    {
      return (GetStoreResponseType) this.Invoke(nameof (GetStore), new object[1]
      {
        (object) GetStoreRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetStore(
      GetStoreRequestType GetStoreRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetStore", new object[1]
      {
        (object) GetStoreRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetStoreResponseType EndGetStore(IAsyncResult asyncResult)
    {
      return (GetStoreResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetStoreCategoryUpdateStatusResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetStoreCategoryUpdateStatusResponseType GetStoreCategoryUpdateStatus(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetStoreCategoryUpdateStatusRequestType GetStoreCategoryUpdateStatusRequest)
    {
      return (GetStoreCategoryUpdateStatusResponseType) this.Invoke(nameof (GetStoreCategoryUpdateStatus), new object[1]
      {
        (object) GetStoreCategoryUpdateStatusRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetStoreCategoryUpdateStatus(
      GetStoreCategoryUpdateStatusRequestType GetStoreCategoryUpdateStatusRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetStoreCategoryUpdateStatus", new object[1]
      {
        (object) GetStoreCategoryUpdateStatusRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetStoreCategoryUpdateStatusResponseType EndGetStoreCategoryUpdateStatus(
      IAsyncResult asyncResult)
    {
      return (GetStoreCategoryUpdateStatusResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetStoreCustomPageResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetStoreCustomPageResponseType GetStoreCustomPage(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetStoreCustomPageRequestType GetStoreCustomPageRequest)
    {
      return (GetStoreCustomPageResponseType) this.Invoke(nameof (GetStoreCustomPage), new object[1]
      {
        (object) GetStoreCustomPageRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetStoreCustomPage(
      GetStoreCustomPageRequestType GetStoreCustomPageRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetStoreCustomPage", new object[1]
      {
        (object) GetStoreCustomPageRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetStoreCustomPageResponseType EndGetStoreCustomPage(IAsyncResult asyncResult)
    {
      return (GetStoreCustomPageResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetStoreOptionsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetStoreOptionsResponseType GetStoreOptions(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetStoreOptionsRequestType GetStoreOptionsRequest)
    {
      return (GetStoreOptionsResponseType) this.Invoke(nameof (GetStoreOptions), new object[1]
      {
        (object) GetStoreOptionsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetStoreOptions(
      GetStoreOptionsRequestType GetStoreOptionsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetStoreOptions", new object[1]
      {
        (object) GetStoreOptionsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetStoreOptionsResponseType EndGetStoreOptions(IAsyncResult asyncResult)
    {
      return (GetStoreOptionsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetStorePreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetStorePreferencesResponseType GetStorePreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetStorePreferencesRequestType GetStorePreferencesRequest)
    {
      return (GetStorePreferencesResponseType) this.Invoke(nameof (GetStorePreferences), new object[1]
      {
        (object) GetStorePreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetStorePreferences(
      GetStorePreferencesRequestType GetStorePreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetStorePreferences", new object[1]
      {
        (object) GetStorePreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetStorePreferencesResponseType EndGetStorePreferences(IAsyncResult asyncResult)
    {
      return (GetStorePreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetSuggestedCategoriesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetSuggestedCategoriesResponseType GetSuggestedCategories(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetSuggestedCategoriesRequestType GetSuggestedCategoriesRequest)
    {
      return (GetSuggestedCategoriesResponseType) this.Invoke(nameof (GetSuggestedCategories), new object[1]
      {
        (object) GetSuggestedCategoriesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetSuggestedCategories(
      GetSuggestedCategoriesRequestType GetSuggestedCategoriesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetSuggestedCategories", new object[1]
      {
        (object) GetSuggestedCategoriesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetSuggestedCategoriesResponseType EndGetSuggestedCategories(IAsyncResult asyncResult)
    {
      return (GetSuggestedCategoriesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetTaxTableResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetTaxTableResponseType GetTaxTable([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetTaxTableRequestType GetTaxTableRequest)
    {
      return (GetTaxTableResponseType) this.Invoke(nameof (GetTaxTable), new object[1]
      {
        (object) GetTaxTableRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetTaxTable(
      GetTaxTableRequestType GetTaxTableRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetTaxTable", new object[1]
      {
        (object) GetTaxTableRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetTaxTableResponseType EndGetTaxTable(IAsyncResult asyncResult)
    {
      return (GetTaxTableResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetTokenStatusResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetTokenStatusResponseType GetTokenStatus([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetTokenStatusRequestType GetTokenStatusRequest)
    {
      return (GetTokenStatusResponseType) this.Invoke(nameof (GetTokenStatus), new object[1]
      {
        (object) GetTokenStatusRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetTokenStatus(
      GetTokenStatusRequestType GetTokenStatusRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetTokenStatus", new object[1]
      {
        (object) GetTokenStatusRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetTokenStatusResponseType EndGetTokenStatus(IAsyncResult asyncResult)
    {
      return (GetTokenStatusResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetUserResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetUserResponseType GetUser([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetUserRequestType GetUserRequest)
    {
      return (GetUserResponseType) this.Invoke(nameof (GetUser), new object[1]
      {
        (object) GetUserRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetUser(
      GetUserRequestType GetUserRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetUser", new object[1]
      {
        (object) GetUserRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetUserResponseType EndGetUser(IAsyncResult asyncResult)
    {
      return (GetUserResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetUserContactDetailsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetUserContactDetailsResponseType GetUserContactDetails(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetUserContactDetailsRequestType GetUserContactDetailsRequest)
    {
      return (GetUserContactDetailsResponseType) this.Invoke(nameof (GetUserContactDetails), new object[1]
      {
        (object) GetUserContactDetailsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetUserContactDetails(
      GetUserContactDetailsRequestType GetUserContactDetailsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetUserContactDetails", new object[1]
      {
        (object) GetUserContactDetailsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetUserContactDetailsResponseType EndGetUserContactDetails(IAsyncResult asyncResult)
    {
      return (GetUserContactDetailsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetUserDisputesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetUserDisputesResponseType GetUserDisputes(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetUserDisputesRequestType GetUserDisputesRequest)
    {
      return (GetUserDisputesResponseType) this.Invoke(nameof (GetUserDisputes), new object[1]
      {
        (object) GetUserDisputesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetUserDisputes(
      GetUserDisputesRequestType GetUserDisputesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetUserDisputes", new object[1]
      {
        (object) GetUserDisputesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetUserDisputesResponseType EndGetUserDisputes(IAsyncResult asyncResult)
    {
      return (GetUserDisputesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetUserPreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetUserPreferencesResponseType GetUserPreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetUserPreferencesRequestType GetUserPreferencesRequest)
    {
      return (GetUserPreferencesResponseType) this.Invoke(nameof (GetUserPreferences), new object[1]
      {
        (object) GetUserPreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetUserPreferences(
      GetUserPreferencesRequestType GetUserPreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetUserPreferences", new object[1]
      {
        (object) GetUserPreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetUserPreferencesResponseType EndGetUserPreferences(IAsyncResult asyncResult)
    {
      return (GetUserPreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetVeROReasonCodeDetailsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetVeROReasonCodeDetailsResponseType GetVeROReasonCodeDetails(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetVeROReasonCodeDetailsRequestType GetVeROReasonCodeDetailsRequest)
    {
      return (GetVeROReasonCodeDetailsResponseType) this.Invoke(nameof (GetVeROReasonCodeDetails), new object[1]
      {
        (object) GetVeROReasonCodeDetailsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetVeROReasonCodeDetails(
      GetVeROReasonCodeDetailsRequestType GetVeROReasonCodeDetailsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetVeROReasonCodeDetails", new object[1]
      {
        (object) GetVeROReasonCodeDetailsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetVeROReasonCodeDetailsResponseType EndGetVeROReasonCodeDetails(IAsyncResult asyncResult)
    {
      return (GetVeROReasonCodeDetailsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GetVeROReportStatusResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GetVeROReportStatusResponseType GetVeROReportStatus(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GetVeROReportStatusRequestType GetVeROReportStatusRequest)
    {
      return (GetVeROReportStatusResponseType) this.Invoke(nameof (GetVeROReportStatus), new object[1]
      {
        (object) GetVeROReportStatusRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGetVeROReportStatus(
      GetVeROReportStatusRequestType GetVeROReportStatusRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GetVeROReportStatus", new object[1]
      {
        (object) GetVeROReportStatusRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GetVeROReportStatusResponseType EndGetVeROReportStatus(IAsyncResult asyncResult)
    {
      return (GetVeROReportStatusResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GeteBayDetailsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GeteBayDetailsResponseType GeteBayDetails([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GeteBayDetailsRequestType GeteBayDetailsRequest)
    {
      return (GeteBayDetailsResponseType) this.Invoke(nameof (GeteBayDetails), new object[1]
      {
        (object) GeteBayDetailsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGeteBayDetails(
      GeteBayDetailsRequestType GeteBayDetailsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GeteBayDetails", new object[1]
      {
        (object) GeteBayDetailsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GeteBayDetailsResponseType EndGeteBayDetails(IAsyncResult asyncResult)
    {
      return (GeteBayDetailsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("GeteBayOfficialTimeResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public GeteBayOfficialTimeResponseType GeteBayOfficialTime(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] GeteBayOfficialTimeRequestType GeteBayOfficialTimeRequest)
    {
      return (GeteBayOfficialTimeResponseType) this.Invoke(nameof (GeteBayOfficialTime), new object[1]
      {
        (object) GeteBayOfficialTimeRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginGeteBayOfficialTime(
      GeteBayOfficialTimeRequestType GeteBayOfficialTimeRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("GeteBayOfficialTime", new object[1]
      {
        (object) GeteBayOfficialTimeRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public GeteBayOfficialTimeResponseType EndGeteBayOfficialTime(IAsyncResult asyncResult)
    {
      return (GeteBayOfficialTimeResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("LeaveFeedbackResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public LeaveFeedbackResponseType LeaveFeedback([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] LeaveFeedbackRequestType LeaveFeedbackRequest)
    {
      return (LeaveFeedbackResponseType) this.Invoke(nameof (LeaveFeedback), new object[1]
      {
        (object) LeaveFeedbackRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginLeaveFeedback(
      LeaveFeedbackRequestType LeaveFeedbackRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("LeaveFeedback", new object[1]
      {
        (object) LeaveFeedbackRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public LeaveFeedbackResponseType EndLeaveFeedback(IAsyncResult asyncResult)
    {
      return (LeaveFeedbackResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("MoveSellingManagerInventoryFolderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public MoveSellingManagerInventoryFolderResponseType MoveSellingManagerInventoryFolder(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] MoveSellingManagerInventoryFolderRequestType MoveSellingManagerInventoryFolderRequest)
    {
      return (MoveSellingManagerInventoryFolderResponseType) this.Invoke(nameof (MoveSellingManagerInventoryFolder), new object[1]
      {
        (object) MoveSellingManagerInventoryFolderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginMoveSellingManagerInventoryFolder(
      MoveSellingManagerInventoryFolderRequestType MoveSellingManagerInventoryFolderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("MoveSellingManagerInventoryFolder", new object[1]
      {
        (object) MoveSellingManagerInventoryFolderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public MoveSellingManagerInventoryFolderResponseType EndMoveSellingManagerInventoryFolder(
      IAsyncResult asyncResult)
    {
      return (MoveSellingManagerInventoryFolderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("PlaceOfferResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public PlaceOfferResponseType PlaceOffer([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] PlaceOfferRequestType PlaceOfferRequest)
    {
      return (PlaceOfferResponseType) this.Invoke(nameof (PlaceOffer), new object[1]
      {
        (object) PlaceOfferRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginPlaceOffer(
      PlaceOfferRequestType PlaceOfferRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("PlaceOffer", new object[1]
      {
        (object) PlaceOfferRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public PlaceOfferResponseType EndPlaceOffer(IAsyncResult asyncResult)
    {
      return (PlaceOfferResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("RelistFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public RelistFixedPriceItemResponseType RelistFixedPriceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] RelistFixedPriceItemRequestType RelistFixedPriceItemRequest)
    {
      return (RelistFixedPriceItemResponseType) this.Invoke(nameof (RelistFixedPriceItem), new object[1]
      {
        (object) RelistFixedPriceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginRelistFixedPriceItem(
      RelistFixedPriceItemRequestType RelistFixedPriceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("RelistFixedPriceItem", new object[1]
      {
        (object) RelistFixedPriceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public RelistFixedPriceItemResponseType EndRelistFixedPriceItem(IAsyncResult asyncResult)
    {
      return (RelistFixedPriceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("RelistItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public RelistItemResponseType RelistItem([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] RelistItemRequestType RelistItemRequest)
    {
      return (RelistItemResponseType) this.Invoke(nameof (RelistItem), new object[1]
      {
        (object) RelistItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginRelistItem(
      RelistItemRequestType RelistItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("RelistItem", new object[1]
      {
        (object) RelistItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public RelistItemResponseType EndRelistItem(IAsyncResult asyncResult)
    {
      return (RelistItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("RemoveFromWatchListResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public RemoveFromWatchListResponseType RemoveFromWatchList(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] RemoveFromWatchListRequestType RemoveFromWatchListRequest)
    {
      return (RemoveFromWatchListResponseType) this.Invoke(nameof (RemoveFromWatchList), new object[1]
      {
        (object) RemoveFromWatchListRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginRemoveFromWatchList(
      RemoveFromWatchListRequestType RemoveFromWatchListRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("RemoveFromWatchList", new object[1]
      {
        (object) RemoveFromWatchListRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public RemoveFromWatchListResponseType EndRemoveFromWatchList(IAsyncResult asyncResult)
    {
      return (RemoveFromWatchListResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("RespondToBestOfferResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public RespondToBestOfferResponseType RespondToBestOffer(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] RespondToBestOfferRequestType RespondToBestOfferRequest)
    {
      return (RespondToBestOfferResponseType) this.Invoke(nameof (RespondToBestOffer), new object[1]
      {
        (object) RespondToBestOfferRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginRespondToBestOffer(
      RespondToBestOfferRequestType RespondToBestOfferRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("RespondToBestOffer", new object[1]
      {
        (object) RespondToBestOfferRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public RespondToBestOfferResponseType EndRespondToBestOffer(IAsyncResult asyncResult)
    {
      return (RespondToBestOfferResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("RespondToFeedbackResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public RespondToFeedbackResponseType RespondToFeedback(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] RespondToFeedbackRequestType RespondToFeedbackRequest)
    {
      return (RespondToFeedbackResponseType) this.Invoke(nameof (RespondToFeedback), new object[1]
      {
        (object) RespondToFeedbackRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginRespondToFeedback(
      RespondToFeedbackRequestType RespondToFeedbackRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("RespondToFeedback", new object[1]
      {
        (object) RespondToFeedbackRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public RespondToFeedbackResponseType EndRespondToFeedback(IAsyncResult asyncResult)
    {
      return (RespondToFeedbackResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseCheckoutStatusResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseCheckoutStatusResponseType ReviseCheckoutStatus(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseCheckoutStatusRequestType ReviseCheckoutStatusRequest)
    {
      return (ReviseCheckoutStatusResponseType) this.Invoke(nameof (ReviseCheckoutStatus), new object[1]
      {
        (object) ReviseCheckoutStatusRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseCheckoutStatus(
      ReviseCheckoutStatusRequestType ReviseCheckoutStatusRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseCheckoutStatus", new object[1]
      {
        (object) ReviseCheckoutStatusRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseCheckoutStatusResponseType EndReviseCheckoutStatus(IAsyncResult asyncResult)
    {
      return (ReviseCheckoutStatusResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseFixedPriceItemResponseType ReviseFixedPriceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseFixedPriceItemRequestType ReviseFixedPriceItemRequest)
    {
      return (ReviseFixedPriceItemResponseType) this.Invoke(nameof (ReviseFixedPriceItem), new object[1]
      {
        (object) ReviseFixedPriceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseFixedPriceItem(
      ReviseFixedPriceItemRequestType ReviseFixedPriceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseFixedPriceItem", new object[1]
      {
        (object) ReviseFixedPriceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseFixedPriceItemResponseType EndReviseFixedPriceItem(IAsyncResult asyncResult)
    {
      return (ReviseFixedPriceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseInventoryStatusResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseInventoryStatusResponseType ReviseInventoryStatus(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseInventoryStatusRequestType ReviseInventoryStatusRequest)
    {
      return (ReviseInventoryStatusResponseType) this.Invoke(nameof (ReviseInventoryStatus), new object[1]
      {
        (object) ReviseInventoryStatusRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseInventoryStatus(
      ReviseInventoryStatusRequestType ReviseInventoryStatusRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseInventoryStatus", new object[1]
      {
        (object) ReviseInventoryStatusRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseInventoryStatusResponseType EndReviseInventoryStatus(IAsyncResult asyncResult)
    {
      return (ReviseInventoryStatusResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseItemResponseType ReviseItem([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseItemRequestType ReviseItemRequest)
    {
      return (ReviseItemResponseType) this.Invoke(nameof (ReviseItem), new object[1]
      {
        (object) ReviseItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseItem(
      ReviseItemRequestType ReviseItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseItem", new object[1]
      {
        (object) ReviseItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseItemResponseType EndReviseItem(IAsyncResult asyncResult)
    {
      return (ReviseItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseMyMessagesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseMyMessagesResponseType ReviseMyMessages(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseMyMessagesRequestType ReviseMyMessagesRequest)
    {
      return (ReviseMyMessagesResponseType) this.Invoke(nameof (ReviseMyMessages), new object[1]
      {
        (object) ReviseMyMessagesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseMyMessages(
      ReviseMyMessagesRequestType ReviseMyMessagesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseMyMessages", new object[1]
      {
        (object) ReviseMyMessagesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseMyMessagesResponseType EndReviseMyMessages(IAsyncResult asyncResult)
    {
      return (ReviseMyMessagesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseMyMessagesFoldersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseMyMessagesFoldersResponseType ReviseMyMessagesFolders(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseMyMessagesFoldersRequestType ReviseMyMessagesFoldersRequest)
    {
      return (ReviseMyMessagesFoldersResponseType) this.Invoke(nameof (ReviseMyMessagesFolders), new object[1]
      {
        (object) ReviseMyMessagesFoldersRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseMyMessagesFolders(
      ReviseMyMessagesFoldersRequestType ReviseMyMessagesFoldersRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseMyMessagesFolders", new object[1]
      {
        (object) ReviseMyMessagesFoldersRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseMyMessagesFoldersResponseType EndReviseMyMessagesFolders(IAsyncResult asyncResult)
    {
      return (ReviseMyMessagesFoldersResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseSellingManagerInventoryFolderResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseSellingManagerInventoryFolderResponseType ReviseSellingManagerInventoryFolder(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseSellingManagerInventoryFolderRequestType ReviseSellingManagerInventoryFolderRequest)
    {
      return (ReviseSellingManagerInventoryFolderResponseType) this.Invoke(nameof (ReviseSellingManagerInventoryFolder), new object[1]
      {
        (object) ReviseSellingManagerInventoryFolderRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseSellingManagerInventoryFolder(
      ReviseSellingManagerInventoryFolderRequestType ReviseSellingManagerInventoryFolderRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseSellingManagerInventoryFolder", new object[1]
      {
        (object) ReviseSellingManagerInventoryFolderRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseSellingManagerInventoryFolderResponseType EndReviseSellingManagerInventoryFolder(
      IAsyncResult asyncResult)
    {
      return (ReviseSellingManagerInventoryFolderResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseSellingManagerProductResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseSellingManagerProductResponseType ReviseSellingManagerProduct(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseSellingManagerProductRequestType ReviseSellingManagerProductRequest)
    {
      return (ReviseSellingManagerProductResponseType) this.Invoke(nameof (ReviseSellingManagerProduct), new object[1]
      {
        (object) ReviseSellingManagerProductRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseSellingManagerProduct(
      ReviseSellingManagerProductRequestType ReviseSellingManagerProductRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseSellingManagerProduct", new object[1]
      {
        (object) ReviseSellingManagerProductRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseSellingManagerProductResponseType EndReviseSellingManagerProduct(
      IAsyncResult asyncResult)
    {
      return (ReviseSellingManagerProductResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseSellingManagerSaleRecordResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseSellingManagerSaleRecordResponseType ReviseSellingManagerSaleRecord(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseSellingManagerSaleRecordRequestType ReviseSellingManagerSaleRecordRequest)
    {
      return (ReviseSellingManagerSaleRecordResponseType) this.Invoke(nameof (ReviseSellingManagerSaleRecord), new object[1]
      {
        (object) ReviseSellingManagerSaleRecordRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseSellingManagerSaleRecord(
      ReviseSellingManagerSaleRecordRequestType ReviseSellingManagerSaleRecordRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseSellingManagerSaleRecord", new object[1]
      {
        (object) ReviseSellingManagerSaleRecordRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseSellingManagerSaleRecordResponseType EndReviseSellingManagerSaleRecord(
      IAsyncResult asyncResult)
    {
      return (ReviseSellingManagerSaleRecordResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ReviseSellingManagerTemplateResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ReviseSellingManagerTemplateResponseType ReviseSellingManagerTemplate(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ReviseSellingManagerTemplateRequestType ReviseSellingManagerTemplateRequest)
    {
      return (ReviseSellingManagerTemplateResponseType) this.Invoke(nameof (ReviseSellingManagerTemplate), new object[1]
      {
        (object) ReviseSellingManagerTemplateRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginReviseSellingManagerTemplate(
      ReviseSellingManagerTemplateRequestType ReviseSellingManagerTemplateRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ReviseSellingManagerTemplate", new object[1]
      {
        (object) ReviseSellingManagerTemplateRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ReviseSellingManagerTemplateResponseType EndReviseSellingManagerTemplate(
      IAsyncResult asyncResult)
    {
      return (ReviseSellingManagerTemplateResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("RevokeTokenResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public RevokeTokenResponseType RevokeToken([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] RevokeTokenRequestType RevokeTokenRequest)
    {
      return (RevokeTokenResponseType) this.Invoke(nameof (RevokeToken), new object[1]
      {
        (object) RevokeTokenRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginRevokeToken(
      RevokeTokenRequestType RevokeTokenRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("RevokeToken", new object[1]
      {
        (object) RevokeTokenRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public RevokeTokenResponseType EndRevokeToken(IAsyncResult asyncResult)
    {
      return (RevokeTokenResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SaveItemToSellingManagerTemplateResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SaveItemToSellingManagerTemplateResponseType SaveItemToSellingManagerTemplate(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SaveItemToSellingManagerTemplateRequestType SaveItemToSellingManagerTemplateRequest)
    {
      return (SaveItemToSellingManagerTemplateResponseType) this.Invoke(nameof (SaveItemToSellingManagerTemplate), new object[1]
      {
        (object) SaveItemToSellingManagerTemplateRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSaveItemToSellingManagerTemplate(
      SaveItemToSellingManagerTemplateRequestType SaveItemToSellingManagerTemplateRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SaveItemToSellingManagerTemplate", new object[1]
      {
        (object) SaveItemToSellingManagerTemplateRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SaveItemToSellingManagerTemplateResponseType EndSaveItemToSellingManagerTemplate(
      IAsyncResult asyncResult)
    {
      return (SaveItemToSellingManagerTemplateResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SellerReverseDisputeResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SellerReverseDisputeResponseType SellerReverseDispute(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SellerReverseDisputeRequestType SellerReverseDisputeRequest)
    {
      return (SellerReverseDisputeResponseType) this.Invoke(nameof (SellerReverseDispute), new object[1]
      {
        (object) SellerReverseDisputeRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSellerReverseDispute(
      SellerReverseDisputeRequestType SellerReverseDisputeRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SellerReverseDispute", new object[1]
      {
        (object) SellerReverseDisputeRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SellerReverseDisputeResponseType EndSellerReverseDispute(IAsyncResult asyncResult)
    {
      return (SellerReverseDisputeResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SendInvoiceResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SendInvoiceResponseType SendInvoice([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SendInvoiceRequestType SendInvoiceRequest)
    {
      return (SendInvoiceResponseType) this.Invoke(nameof (SendInvoice), new object[1]
      {
        (object) SendInvoiceRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSendInvoice(
      SendInvoiceRequestType SendInvoiceRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SendInvoice", new object[1]
      {
        (object) SendInvoiceRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SendInvoiceResponseType EndSendInvoice(IAsyncResult asyncResult)
    {
      return (SendInvoiceResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetMessagePreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetMessagePreferencesResponseType SetMessagePreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetMessagePreferencesRequestType SetMessagePreferencesRequest)
    {
      return (SetMessagePreferencesResponseType) this.Invoke(nameof (SetMessagePreferences), new object[1]
      {
        (object) SetMessagePreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetMessagePreferences(
      SetMessagePreferencesRequestType SetMessagePreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetMessagePreferences", new object[1]
      {
        (object) SetMessagePreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetMessagePreferencesResponseType EndSetMessagePreferences(IAsyncResult asyncResult)
    {
      return (SetMessagePreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetNotificationPreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetNotificationPreferencesResponseType SetNotificationPreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetNotificationPreferencesRequestType SetNotificationPreferencesRequest)
    {
      return (SetNotificationPreferencesResponseType) this.Invoke(nameof (SetNotificationPreferences), new object[1]
      {
        (object) SetNotificationPreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetNotificationPreferences(
      SetNotificationPreferencesRequestType SetNotificationPreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetNotificationPreferences", new object[1]
      {
        (object) SetNotificationPreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetNotificationPreferencesResponseType EndSetNotificationPreferences(
      IAsyncResult asyncResult)
    {
      return (SetNotificationPreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetPromotionalSaleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetPromotionalSaleResponseType SetPromotionalSale(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetPromotionalSaleRequestType SetPromotionalSaleRequest)
    {
      return (SetPromotionalSaleResponseType) this.Invoke(nameof (SetPromotionalSale), new object[1]
      {
        (object) SetPromotionalSaleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetPromotionalSale(
      SetPromotionalSaleRequestType SetPromotionalSaleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetPromotionalSale", new object[1]
      {
        (object) SetPromotionalSaleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetPromotionalSaleResponseType EndSetPromotionalSale(IAsyncResult asyncResult)
    {
      return (SetPromotionalSaleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetPromotionalSaleListingsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetPromotionalSaleListingsResponseType SetPromotionalSaleListings(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetPromotionalSaleListingsRequestType SetPromotionalSaleListingsRequest)
    {
      return (SetPromotionalSaleListingsResponseType) this.Invoke(nameof (SetPromotionalSaleListings), new object[1]
      {
        (object) SetPromotionalSaleListingsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetPromotionalSaleListings(
      SetPromotionalSaleListingsRequestType SetPromotionalSaleListingsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetPromotionalSaleListings", new object[1]
      {
        (object) SetPromotionalSaleListingsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetPromotionalSaleListingsResponseType EndSetPromotionalSaleListings(
      IAsyncResult asyncResult)
    {
      return (SetPromotionalSaleListingsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetSellingManagerFeedbackOptionsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetSellingManagerFeedbackOptionsResponseType SetSellingManagerFeedbackOptions(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetSellingManagerFeedbackOptionsRequestType SetSellingManagerFeedbackOptionsRequest)
    {
      return (SetSellingManagerFeedbackOptionsResponseType) this.Invoke(nameof (SetSellingManagerFeedbackOptions), new object[1]
      {
        (object) SetSellingManagerFeedbackOptionsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetSellingManagerFeedbackOptions(
      SetSellingManagerFeedbackOptionsRequestType SetSellingManagerFeedbackOptionsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetSellingManagerFeedbackOptions", new object[1]
      {
        (object) SetSellingManagerFeedbackOptionsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetSellingManagerFeedbackOptionsResponseType EndSetSellingManagerFeedbackOptions(
      IAsyncResult asyncResult)
    {
      return (SetSellingManagerFeedbackOptionsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetSellingManagerItemAutomationRuleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetSellingManagerItemAutomationRuleResponseType SetSellingManagerItemAutomationRule(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetSellingManagerItemAutomationRuleRequestType SetSellingManagerItemAutomationRuleRequest)
    {
      return (SetSellingManagerItemAutomationRuleResponseType) this.Invoke(nameof (SetSellingManagerItemAutomationRule), new object[1]
      {
        (object) SetSellingManagerItemAutomationRuleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetSellingManagerItemAutomationRule(
      SetSellingManagerItemAutomationRuleRequestType SetSellingManagerItemAutomationRuleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetSellingManagerItemAutomationRule", new object[1]
      {
        (object) SetSellingManagerItemAutomationRuleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetSellingManagerItemAutomationRuleResponseType EndSetSellingManagerItemAutomationRule(
      IAsyncResult asyncResult)
    {
      return (SetSellingManagerItemAutomationRuleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetSellingManagerTemplateAutomationRuleResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetSellingManagerTemplateAutomationRuleResponseType SetSellingManagerTemplateAutomationRule(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetSellingManagerTemplateAutomationRuleRequestType SetSellingManagerTemplateAutomationRuleRequest)
    {
      return (SetSellingManagerTemplateAutomationRuleResponseType) this.Invoke(nameof (SetSellingManagerTemplateAutomationRule), new object[1]
      {
        (object) SetSellingManagerTemplateAutomationRuleRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetSellingManagerTemplateAutomationRule(
      SetSellingManagerTemplateAutomationRuleRequestType SetSellingManagerTemplateAutomationRuleRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetSellingManagerTemplateAutomationRule", new object[1]
      {
        (object) SetSellingManagerTemplateAutomationRuleRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetSellingManagerTemplateAutomationRuleResponseType EndSetSellingManagerTemplateAutomationRule(
      IAsyncResult asyncResult)
    {
      return (SetSellingManagerTemplateAutomationRuleResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetShippingDiscountProfilesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetShippingDiscountProfilesResponseType SetShippingDiscountProfiles(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetShippingDiscountProfilesRequestType SetShippingDiscountProfilesRequest)
    {
      return (SetShippingDiscountProfilesResponseType) this.Invoke(nameof (SetShippingDiscountProfiles), new object[1]
      {
        (object) SetShippingDiscountProfilesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetShippingDiscountProfiles(
      SetShippingDiscountProfilesRequestType SetShippingDiscountProfilesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetShippingDiscountProfiles", new object[1]
      {
        (object) SetShippingDiscountProfilesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetShippingDiscountProfilesResponseType EndSetShippingDiscountProfiles(
      IAsyncResult asyncResult)
    {
      return (SetShippingDiscountProfilesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetStoreResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetStoreResponseType SetStore([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetStoreRequestType SetStoreRequest)
    {
      return (SetStoreResponseType) this.Invoke(nameof (SetStore), new object[1]
      {
        (object) SetStoreRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetStore(
      SetStoreRequestType SetStoreRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetStore", new object[1]
      {
        (object) SetStoreRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetStoreResponseType EndSetStore(IAsyncResult asyncResult)
    {
      return (SetStoreResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetStoreCategoriesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetStoreCategoriesResponseType SetStoreCategories(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetStoreCategoriesRequestType SetStoreCategoriesRequest)
    {
      return (SetStoreCategoriesResponseType) this.Invoke(nameof (SetStoreCategories), new object[1]
      {
        (object) SetStoreCategoriesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetStoreCategories(
      SetStoreCategoriesRequestType SetStoreCategoriesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetStoreCategories", new object[1]
      {
        (object) SetStoreCategoriesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetStoreCategoriesResponseType EndSetStoreCategories(IAsyncResult asyncResult)
    {
      return (SetStoreCategoriesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetStoreCustomPageResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetStoreCustomPageResponseType SetStoreCustomPage(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetStoreCustomPageRequestType SetStoreCustomPageRequest)
    {
      return (SetStoreCustomPageResponseType) this.Invoke(nameof (SetStoreCustomPage), new object[1]
      {
        (object) SetStoreCustomPageRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetStoreCustomPage(
      SetStoreCustomPageRequestType SetStoreCustomPageRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetStoreCustomPage", new object[1]
      {
        (object) SetStoreCustomPageRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetStoreCustomPageResponseType EndSetStoreCustomPage(IAsyncResult asyncResult)
    {
      return (SetStoreCustomPageResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetStorePreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetStorePreferencesResponseType SetStorePreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetStorePreferencesRequestType SetStorePreferencesRequest)
    {
      return (SetStorePreferencesResponseType) this.Invoke(nameof (SetStorePreferences), new object[1]
      {
        (object) SetStorePreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetStorePreferences(
      SetStorePreferencesRequestType SetStorePreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetStorePreferences", new object[1]
      {
        (object) SetStorePreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetStorePreferencesResponseType EndSetStorePreferences(IAsyncResult asyncResult)
    {
      return (SetStorePreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetTaxTableResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetTaxTableResponseType SetTaxTable([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetTaxTableRequestType SetTaxTableRequest)
    {
      return (SetTaxTableResponseType) this.Invoke(nameof (SetTaxTable), new object[1]
      {
        (object) SetTaxTableRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetTaxTable(
      SetTaxTableRequestType SetTaxTableRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetTaxTable", new object[1]
      {
        (object) SetTaxTableRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetTaxTableResponseType EndSetTaxTable(IAsyncResult asyncResult)
    {
      return (SetTaxTableResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetUserNotesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetUserNotesResponseType SetUserNotes([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetUserNotesRequestType SetUserNotesRequest)
    {
      return (SetUserNotesResponseType) this.Invoke(nameof (SetUserNotes), new object[1]
      {
        (object) SetUserNotesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetUserNotes(
      SetUserNotesRequestType SetUserNotesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetUserNotes", new object[1]
      {
        (object) SetUserNotesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetUserNotesResponseType EndSetUserNotes(IAsyncResult asyncResult)
    {
      return (SetUserNotesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("SetUserPreferencesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public SetUserPreferencesResponseType SetUserPreferences(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] SetUserPreferencesRequestType SetUserPreferencesRequest)
    {
      return (SetUserPreferencesResponseType) this.Invoke(nameof (SetUserPreferences), new object[1]
      {
        (object) SetUserPreferencesRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginSetUserPreferences(
      SetUserPreferencesRequestType SetUserPreferencesRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("SetUserPreferences", new object[1]
      {
        (object) SetUserPreferencesRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public SetUserPreferencesResponseType EndSetUserPreferences(IAsyncResult asyncResult)
    {
      return (SetUserPreferencesResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ValidateChallengeInputResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ValidateChallengeInputResponseType ValidateChallengeInput(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ValidateChallengeInputRequestType ValidateChallengeInputRequest)
    {
      return (ValidateChallengeInputResponseType) this.Invoke(nameof (ValidateChallengeInput), new object[1]
      {
        (object) ValidateChallengeInputRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginValidateChallengeInput(
      ValidateChallengeInputRequestType ValidateChallengeInputRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ValidateChallengeInput", new object[1]
      {
        (object) ValidateChallengeInputRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ValidateChallengeInputResponseType EndValidateChallengeInput(IAsyncResult asyncResult)
    {
      return (ValidateChallengeInputResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("ValidateTestUserRegistrationResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public ValidateTestUserRegistrationResponseType ValidateTestUserRegistration(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] ValidateTestUserRegistrationRequestType ValidateTestUserRegistrationRequest)
    {
      return (ValidateTestUserRegistrationResponseType) this.Invoke(nameof (ValidateTestUserRegistration), new object[1]
      {
        (object) ValidateTestUserRegistrationRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginValidateTestUserRegistration(
      ValidateTestUserRegistrationRequestType ValidateTestUserRegistrationRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("ValidateTestUserRegistration", new object[1]
      {
        (object) ValidateTestUserRegistrationRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public ValidateTestUserRegistrationResponseType EndValidateTestUserRegistration(
      IAsyncResult asyncResult)
    {
      return (ValidateTestUserRegistrationResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("VeROReportItemsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public VeROReportItemsResponseType VeROReportItems(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] VeROReportItemsRequestType VeROReportItemsRequest)
    {
      return (VeROReportItemsResponseType) this.Invoke(nameof (VeROReportItems), new object[1]
      {
        (object) VeROReportItemsRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginVeROReportItems(
      VeROReportItemsRequestType VeROReportItemsRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("VeROReportItems", new object[1]
      {
        (object) VeROReportItemsRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public VeROReportItemsResponseType EndVeROReportItems(IAsyncResult asyncResult)
    {
      return (VeROReportItemsResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("VerifyAddFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public VerifyAddFixedPriceItemResponseType VerifyAddFixedPriceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] VerifyAddFixedPriceItemRequestType VerifyAddFixedPriceItemRequest)
    {
      return (VerifyAddFixedPriceItemResponseType) this.Invoke(nameof (VerifyAddFixedPriceItem), new object[1]
      {
        (object) VerifyAddFixedPriceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginVerifyAddFixedPriceItem(
      VerifyAddFixedPriceItemRequestType VerifyAddFixedPriceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("VerifyAddFixedPriceItem", new object[1]
      {
        (object) VerifyAddFixedPriceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public VerifyAddFixedPriceItemResponseType EndVerifyAddFixedPriceItem(IAsyncResult asyncResult)
    {
      return (VerifyAddFixedPriceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("VerifyAddItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public VerifyAddItemResponseType VerifyAddItem([XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] VerifyAddItemRequestType VerifyAddItemRequest)
    {
      return (VerifyAddItemResponseType) this.Invoke(nameof (VerifyAddItem), new object[1]
      {
        (object) VerifyAddItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginVerifyAddItem(
      VerifyAddItemRequestType VerifyAddItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("VerifyAddItem", new object[1]
      {
        (object) VerifyAddItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public VerifyAddItemResponseType EndVerifyAddItem(IAsyncResult asyncResult)
    {
      return (VerifyAddItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("VerifyAddSecondChanceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public VerifyAddSecondChanceItemResponseType VerifyAddSecondChanceItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] VerifyAddSecondChanceItemRequestType VerifyAddSecondChanceItemRequest)
    {
      return (VerifyAddSecondChanceItemResponseType) this.Invoke(nameof (VerifyAddSecondChanceItem), new object[1]
      {
        (object) VerifyAddSecondChanceItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginVerifyAddSecondChanceItem(
      VerifyAddSecondChanceItemRequestType VerifyAddSecondChanceItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("VerifyAddSecondChanceItem", new object[1]
      {
        (object) VerifyAddSecondChanceItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public VerifyAddSecondChanceItemResponseType EndVerifyAddSecondChanceItem(
      IAsyncResult asyncResult)
    {
      return (VerifyAddSecondChanceItemResponseType) this.EndInvoke(asyncResult)[0];
    }

    /// <remarks />
    [SoapHeader("RequesterCredentials", Direction = SoapHeaderDirection.InOut)]
    [SoapDocumentMethod("", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
    [SoapExtensionEx]
    [return: XmlElement("VerifyRelistItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public VerifyRelistItemResponseType VerifyRelistItem(
      [XmlElement(Namespace = "urn:ebay:apis:eBLBaseComponents")] VerifyRelistItemRequestType VerifyRelistItemRequest)
    {
      return (VerifyRelistItemResponseType) this.Invoke(nameof (VerifyRelistItem), new object[1]
      {
        (object) VerifyRelistItemRequest
      })[0];
    }

    /// <remarks />
    public IAsyncResult BeginVerifyRelistItem(
      VerifyRelistItemRequestType VerifyRelistItemRequest,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("VerifyRelistItem", new object[1]
      {
        (object) VerifyRelistItemRequest
      }, callback, asyncState);
    }

    /// <remarks />
    public VerifyRelistItemResponseType EndVerifyRelistItem(IAsyncResult asyncResult)
    {
      return (VerifyRelistItemResponseType) this.EndInvoke(asyncResult)[0];
    }
  }
}
