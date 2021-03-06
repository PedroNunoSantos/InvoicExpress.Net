﻿// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("items"), XmlType(AnonymousType=true)]
	public partial class ItemsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";

		[XmlElement("item")]
		public List<ItemDto> Items { get; set; } = new List<ItemDto>();
		
		#region Add Methods elpers
		
		public void Add(ItemDto item) => Items.Add(item);

		public void AddRange(IEnumerable<ItemDto> items) => Items.AddRange(items);
		
		#endregion

				
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ItemsDto>();
        }
		*/
	}
}
