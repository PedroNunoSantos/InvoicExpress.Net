// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/invoices/list
namespace InvoicExpress.Net.R.Invoices.List
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoices {
	    private invoicesInvoice invoiceField;
	    private string typeField;
	    /// <remarks/>
	    public invoicesInvoice invoice {
	        get {
	            return this.invoiceField;
	        }
	        set {
	            this.invoiceField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoice {
	    private string idField;
	    private string statusField;
	    private bool archivedField;
	    private string typeField;
	    private string sequence_numberField;
	    private string dateField;
	    private string due_dateField;
	    private string referenceField;
	    private string observationsField;
	    private decimal retentionField;
	    private string permalinkField;
	    private invoicesInvoiceClient clientField;
	    private string currencyField;
	    private invoicesInvoiceItems itemsField;
	    private decimal sumField;
	    private decimal discountField;
	    private decimal before_taxesField;
	    private decimal taxesField;
	    private decimal totalField;
	    /// <remarks/>
	    public string id {
	        get {
	            return this.idField;
	        }
	        set {
	            this.idField = value;
	        }
	    }
	    /// <remarks/>
	    public string status {
	        get {
	            return this.statusField;
	        }
	        set {
	            this.statusField = value;
	        }
	    }
	    /// <remarks/>
	    public bool archived {
	        get {
	            return this.archivedField;
	        }
	        set {
	            this.archivedField = value;
	        }
	    }
	    /// <remarks/>
	    public string type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    public string sequence_number {
	        get {
	            return this.sequence_numberField;
	        }
	        set {
	            this.sequence_numberField = value;
	        }
	    }
	    /// <remarks/>
	    public string date {
	        get {
	            return this.dateField;
	        }
	        set {
	            this.dateField = value;
	        }
	    }
	    /// <remarks/>
	    public string due_date {
	        get {
	            return this.due_dateField;
	        }
	        set {
	            this.due_dateField = value;
	        }
	    }
	    /// <remarks/>
	    public string reference {
	        get {
	            return this.referenceField;
	        }
	        set {
	            this.referenceField = value;
	        }
	    }
	    /// <remarks/>
	    public string observations {
	        get {
	            return this.observationsField;
	        }
	        set {
	            this.observationsField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal retention {
	        get {
	            return this.retentionField;
	        }
	        set {
	            this.retentionField = value;
	        }
	    }
	    /// <remarks/>
	    public string permalink {
	        get {
	            return this.permalinkField;
	        }
	        set {
	            this.permalinkField = value;
	        }
	    }
	    /// <remarks/>
	    public invoicesInvoiceClient client {
	        get {
	            return this.clientField;
	        }
	        set {
	            this.clientField = value;
	        }
	    }
	    /// <remarks/>
	    public string currency {
	        get {
	            return this.currencyField;
	        }
	        set {
	            this.currencyField = value;
	        }
	    }
	    /// <remarks/>
	    public invoicesInvoiceItems items {
	        get {
	            return this.itemsField;
	        }
	        set {
	            this.itemsField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal sum {
	        get {
	            return this.sumField;
	        }
	        set {
	            this.sumField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal discount {
	        get {
	            return this.discountField;
	        }
	        set {
	            this.discountField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal before_taxes {
	        get {
	            return this.before_taxesField;
	        }
	        set {
	            this.before_taxesField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal taxes {
	        get {
	            return this.taxesField;
	        }
	        set {
	            this.taxesField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal total {
	        get {
	            return this.totalField;
	        }
	        set {
	            this.totalField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceClient {
	    private string idField;
	    private string nameField;
	    private string emailField;
	    private string addressField;
	    private string cityField;
	    private string postal_codeField;
	    private string countryField;
	    private uint fiscal_idField;
	    private string websiteField;
	    private long phoneField;
	    private long faxField;
	    /// <remarks/>
	    public string id {
	        get {
	            return this.idField;
	        }
	        set {
	            this.idField = value;
	        }
	    }
	    /// <remarks/>
	    public string name {
	        get {
	            return this.nameField;
	        }
	        set {
	            this.nameField = value;
	        }
	    }
	    /// <remarks/>
	    public string email {
	        get {
	            return this.emailField;
	        }
	        set {
	            this.emailField = value;
	        }
	    }
	    /// <remarks/>
	    public string address {
	        get {
	            return this.addressField;
	        }
	        set {
	            this.addressField = value;
	        }
	    }
	    /// <remarks/>
	    public string city {
	        get {
	            return this.cityField;
	        }
	        set {
	            this.cityField = value;
	        }
	    }
	    /// <remarks/>
	    public string postal_code {
	        get {
	            return this.postal_codeField;
	        }
	        set {
	            this.postal_codeField = value;
	        }
	    }
	    /// <remarks/>
	    public string country {
	        get {
	            return this.countryField;
	        }
	        set {
	            this.countryField = value;
	        }
	    }
	    /// <remarks/>
	    public uint fiscal_id {
	        get {
	            return this.fiscal_idField;
	        }
	        set {
	            this.fiscal_idField = value;
	        }
	    }
	    /// <remarks/>
	    public string website {
	        get {
	            return this.websiteField;
	        }
	        set {
	            this.websiteField = value;
	        }
	    }
	    /// <remarks/>
	    public long phone {
	        get {
	            return this.phoneField;
	        }
	        set {
	            this.phoneField = value;
	        }
	    }
	    /// <remarks/>
	    public long fax {
	        get {
	            return this.faxField;
	        }
	        set {
	            this.faxField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceItems {
	    private invoicesInvoiceItemsItem itemField;
	    private string typeField;
	    /// <remarks/>
	    public invoicesInvoiceItemsItem item {
	        get {
	            return this.itemField;
	        }
	        set {
	            this.itemField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceItemsItem {
	    private string nameField;
	    private string descriptionField;
	    private decimal unit_priceField;
	    private string unitField;
	    private decimal quantityField;
	    private invoicesInvoiceItemsItemTax taxField;
	    private decimal discountField;
	    private decimal subtotalField;
	    private decimal tax_amountField;
	    private decimal discount_amountField;
	    private decimal totalField;
	    /// <remarks/>
	    public string name {
	        get {
	            return this.nameField;
	        }
	        set {
	            this.nameField = value;
	        }
	    }
	    /// <remarks/>
	    public string description {
	        get {
	            return this.descriptionField;
	        }
	        set {
	            this.descriptionField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal unit_price {
	        get {
	            return this.unit_priceField;
	        }
	        set {
	            this.unit_priceField = value;
	        }
	    }
	    /// <remarks/>
	    public string unit {
	        get {
	            return this.unitField;
	        }
	        set {
	            this.unitField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal quantity {
	        get {
	            return this.quantityField;
	        }
	        set {
	            this.quantityField = value;
	        }
	    }
	    /// <remarks/>
	    public invoicesInvoiceItemsItemTax tax {
	        get {
	            return this.taxField;
	        }
	        set {
	            this.taxField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal discount {
	        get {
	            return this.discountField;
	        }
	        set {
	            this.discountField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal subtotal {
	        get {
	            return this.subtotalField;
	        }
	        set {
	            this.subtotalField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal tax_amount {
	        get {
	            return this.tax_amountField;
	        }
	        set {
	            this.tax_amountField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal discount_amount {
	        get {
	            return this.discount_amountField;
	        }
	        set {
	            this.discount_amountField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal total {
	        get {
	            return this.totalField;
	        }
	        set {
	            this.totalField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceItemsItemTax {
	    private string nameField;
	    private decimal valueField;
	    /// <remarks/>
	    public string name {
	        get {
	            return this.nameField;
	        }
	        set {
	            this.nameField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal value {
	        get {
	            return this.valueField;
	        }
	        set {
	            this.valueField = value;
	        }
	    }
	}
}