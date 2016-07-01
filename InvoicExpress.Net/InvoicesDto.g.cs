using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("invoices"), XmlType(AnonymousType=true)]
	public partial class InvoicesDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("invoice")]
		public InvoiceDto[] InvoicesArray { get; set; }
	}
}
