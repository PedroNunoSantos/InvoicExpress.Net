// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
using System.ComponentModel;

namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices">SimplifiedInvoices</a> module
		/// </summary>
		public static class SimplifiedInvoices
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			public static SimplifiedInvoiceDto Create(string apiKey, string accountName, SimplifiedInvoiceDto inputData)
			{
				string xmlResult = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return xmlResult.DeserializeXml<SimplifiedInvoiceDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Get(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			public static SimplifiedInvoiceDto Get(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string xmlResult = Rest_Get(apiKey, accountName, simplifiedInvoiceId);
			    return xmlResult.DeserializeXml<SimplifiedInvoiceDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Update(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, string simplifiedInvoiceId, SimplifiedInvoiceDto inputData)
			{
				Rest_Update(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_List(string apiKey, string accountName, int? page, int? perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			public static SimplifiedInvoicesDto List(string apiKey, string accountName, int? page, int? perPage)
			{
				string xmlResult = Rest_List(apiKey, accountName, page, perPage);
			    return xmlResult.DeserializeXml<SimplifiedInvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_ChangeState(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/change-state.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			public static void ChangeState(string apiKey, string accountName, string simplifiedInvoiceId, SimplifiedInvoiceChangeStateDto inputData)
			{
				Rest_ChangeState(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_EmailInvoice(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/email-document.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoice(string apiKey, string accountName, string simplifiedInvoiceId, EmailMessageDto inputData)
			{
				Rest_EmailInvoice(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
			/// </summary>
			public static PdfOutputDto Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string xmlResult = Rest_Pdf(apiKey, accountName, simplifiedInvoiceId);
			    return xmlResult.DeserializeXml<PdfOutputDto>();
			}

	}
}
}