using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace eBay.Service.Core.Soap
{
    [GeneratedCode("CodeGen05", "1.0.7142.28876")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
    [Serializable]
    public class ResponsiblePersonType
    {
        private string mCompanyName;
        private string mStreet1;
        private string mStreet2;
        private string mCityName;
        private string mStateOrProvince;
        private string mPostalCode;
        private string mCountry;
        private string mPhone;
        private string mEmail;  
        private TypesType mTypes;
        private XmlElementCollection mAny;

        public TypesType Types
        {
            get => this.mTypes;
            set => this.mTypes = value;

        }
        public string CompanyName
        {
            get => this.mCompanyName;
            set => this.mCompanyName = value;
        }

        public string Street1
        {
            get => this.mStreet1;
            set => this.mStreet1 = value;
        }

        public string Street2
        {
            get => this.mStreet2;
            set => this.mStreet2 = value;
        }

        public string CityName
        {
            get => this.mCityName;
            set => this.mCityName = value;
        }

        public string StateOrProvince
        {
            get => this.mStateOrProvince;
            set => this.mStateOrProvince = value;
        }


        public string PostalCode
        {
            get => this.mPostalCode;
            set => this.mPostalCode = value;
        }

        public string Country
        {
            get => this.mCountry;
            set => this.mCountry = value;
        }

        public string Phone
        {
            get => this.mPhone;
            set => this.mPhone = value;
        }

        public string Email
        {
            get => this.mEmail;
            set => this.mEmail = value;
        }

        [XmlAnyElement]
        public XmlElementCollection Any
        {
            get => this.mAny;
            set => this.mAny = value;
        }
    }
}
