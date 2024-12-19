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

    public class TypesType
    {
        private string mType = "EUResponsiblePerson";
        private XmlElementCollection mAny;

        public string Type
        {
            get => this.mType;
            set => this.mType = value;
        }

        [XmlAnyElement]
        public XmlElementCollection Any
        {
            get => this.mAny;
            set => this.mAny = value;
        }
    }
}
