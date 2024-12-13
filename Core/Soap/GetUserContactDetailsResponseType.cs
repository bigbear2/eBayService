// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetUserContactDetailsResponseType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class GetUserContactDetailsResponseType : AbstractResponseType
  {
    private string mUserID;
    private AddressType mContactAddress;
    private DateTime mRegistrationDate;
    private bool mRegistrationDateSpecified;

    /// <summary>
    /// 
    /// </summary>
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType ContactAddress
    {
      get => this.mContactAddress;
      set => this.mContactAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime RegistrationDate
    {
      get => this.mRegistrationDate;
      set
      {
        this.mRegistrationDate = value;
        this.mRegistrationDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RegistrationDateSpecified
    {
      get => this.mRegistrationDateSpecified;
      set => this.mRegistrationDateSpecified = value;
    }
  }
}
