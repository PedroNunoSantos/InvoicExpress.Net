using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("invoice"), XmlType(AnonymousType=true)]
	public partial class InvoiceDto
	{
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("status")]
		public string Status { get; set; }
		
		[XmlElement("archived")]
		public string Archived { get; set; }
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlElement("sequence_number")]
		public string SequenceNumber { get; set; }
		
		[XmlIgnore]
		public DateTime? Date { get; set; }
		
		[XmlElement("date"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _DateDto
	    {	    
			get { return Date.ToXml<DateTime?>(); }
            set { Date = value.FromXml<DateTime?>(); }
	    }
		
		[XmlIgnore]
		public DateTime? DueDate { get; set; }
		
		[XmlElement("due_date"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _DueDateDto
	    {	    
			get { return DueDate.ToXml<DateTime?>(); }
            set { DueDate = value.FromXml<DateTime?>(); }
	    }
		
		[XmlElement("reference")]
		public string Reference { get; set; }
		
		[XmlElement("observations")]
		public string Observations { get; set; }
		
		[XmlIgnore]
		public float? Retention { get; set; }
		
		[XmlElement("retention"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _RetentionDto
	    {	    
			get { return Retention.ToXml<float?>(); }
            set { Retention = value.FromXml<float?>(); }
	    }
		
		[XmlElement("tax_exemption")]
		public string TaxExemption { get; set; }
		
		[XmlElement("permalink")]
		public string Permalink { get; set; }
		
		[XmlElement("sequence_id")]
		public string SequenceId { get; set; }
		
		[XmlElement("manual_sequence_number")]
		public string ManualSequenceNumber { get; set; }
		
		[XmlElement("client")]
		public ClientDto Client { get; set; }
		
		[XmlElement("currency")]
		public string Currency { get; set; }
		
		[XmlElement("items")]
		public ItemsDto ItemsArray { get; set; }
		
		[XmlIgnore]
		public float? Sum { get; set; }
		
		[XmlElement("sum"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _SumDto
	    {	    
			get { return Sum.ToXml<float?>(); }
            set { Sum = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Discount { get; set; }
		
		[XmlElement("discount"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _DiscountDto
	    {	    
			get { return Discount.ToXml<float?>(); }
            set { Discount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? BeforeTaxes { get; set; }
		
		[XmlElement("before_taxes"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _BeforeTaxesDto
	    {	    
			get { return BeforeTaxes.ToXml<float?>(); }
            set { BeforeTaxes = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Taxes { get; set; }
		
		[XmlElement("taxes"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _TaxesDto
	    {	    
			get { return Taxes.ToXml<float?>(); }
            set { Taxes = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Total { get; set; }
		
		[XmlElement("total"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _TotalDto
	    {	    
			get { return Total.ToXml<float?>(); }
            set { Total = value.FromXml<float?>(); }
	    }
		
		[XmlElement("mb_reference")]
		public string MbReference { get; set; }
	}
}