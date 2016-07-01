using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("client"), XmlType(AnonymousType=true)]
	public partial class EmailClientDto
	{
		
		[XmlElement("email")]
		public string Email { get; set; }
		
		[XmlElement("save")]
		public string Save { get; set; }
	}
}
