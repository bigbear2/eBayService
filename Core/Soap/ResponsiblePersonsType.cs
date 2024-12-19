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

    public class ResponsiblePersonsType
    {
        private ResponsiblePersonType mResponsiblePerson;
        private XmlElementCollection mAny;

        public ResponsiblePersonType ResponsiblePerson
        {
            get => this.mResponsiblePerson;
            set => this.mResponsiblePerson = value;
        }

        [XmlAnyElement]
        public XmlElementCollection Any
        {
            get => this.mAny;
            set => this.mAny = value;
        }
    }
}
