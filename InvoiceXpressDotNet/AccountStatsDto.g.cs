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
	[XmlRoot("account_stats"), XmlType(AnonymousType=true)]
	public partial class AccountStatsDto : Dto
	{		

		[XmlElement("plan")]
		public string Plan { get; set; }

		[XmlElement("expires_at")]
		public string ExpiresAt { get; set; }

		[XmlElement("documents")]
		public DocumentsStatsDto Documents { get; set; }

		[XmlElement("users")]
		public UsersStatsDto Users { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<AccountStatsDto>();
        }
		*/
	}
}
