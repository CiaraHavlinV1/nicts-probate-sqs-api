using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text;


namespace nicts_probate_sqs_api.Models
{

	public class ProbateApplicationModel
	{

		[XmlRoot(ElementName = "Applicant")]
		public class Applicant
		{


			[XmlElement(ElementName = "Forenames")]
			public string Forenames { get; set; }

			[XmlElement(ElementName = "Surname")]
			public string Surname { get; set; }

			[XmlElement(ElementName = "AddressLine1")]
			public string AddressLine1 { get; set; }

			[XmlElement(ElementName = "AddressLine2")]
			public string AddressLine2 { get; set; }

			[XmlElement(ElementName = "AddressLine3")]
			public string AddressLine3 { get; set; }

			[XmlElement(ElementName = "AddressLine4")]
			public string AddressLine4 { get; set; }

			[XmlElement(ElementName = "AddressLine5")]
			public string AddressLine5 { get; set; }

			[XmlElement(ElementName = "Postcode")]
			public string Postcode { get; set; }

			[XmlElement(ElementName = "EmailAddress")]
			public string EmailAddress { get; set; }

			[XmlElement(ElementName = "MobileNum")]
			public string MobileNum { get; set; }

			[XmlElement(ElementName = "Representation")]
			public string Representation { get; set; }

			[XmlElement(ElementName = "RepresentationReference")]
			public string RepresentationReference { get; set; }
		}

		[XmlRoot(ElementName = "AdditionalTitle")]
		public class AdditionalTitle
		{

			[XmlElement(ElementName = "AdditionalForenames")]
			public string AdditionalForenames { get; set; }

			[XmlElement(ElementName = "AdditionalSurname")]
			public string AdditionalSurname { get; set; }
		}

		[XmlRoot(ElementName = "Deceased")]
		public class Deceased
		{

			[XmlElement(ElementName = "Forenames")]
			public string Forenames { get; set; }

			[XmlElement(ElementName = "Surname")]
			public string Surname { get; set; }

			[XmlElement(ElementName = "AddressLine1")]
			public string AddressLine1 { get; set; }

			[XmlElement(ElementName = "AddressLine2")]
			public string AddressLine2 { get; set; }

			[XmlElement(ElementName = "AddressLine3")]
			public string AddressLine3 { get; set; }

			[XmlElement(ElementName = "AddressLine4")]
			public string AddressLine4 { get; set; }

			[XmlElement(ElementName = "AddressLine5")]
			public string AddressLine5 { get; set; }

			[XmlElement(ElementName = "Postcode")]
			public string Postcode { get; set; }

			[XmlElement(ElementName = "DeceasedDoB")]
			public string DeceasedDoB { get; set; }

			[XmlElement(ElementName = "DeceasedDoD")]
			public string DeceasedDoD { get; set; }

			[XmlElement(ElementName = "Occupation")]
			public string Occupation { get; set; }

			[XmlElement(ElementName = "PlaceOfDeath")]
			public string PlaceOfDeath { get; set; }

			[XmlElement(ElementName = "AdditionalTitle")]
			public AdditionalTitle AdditionalTitle { get; set; }
		}

		[XmlRoot(ElementName = "Participant")]
		public class Participant
		{

			[XmlElement(ElementName = "Applicant")]
			public List<Applicant> Applicant { get; set; }

			[XmlElement(ElementName = "Deceased")]
			public Deceased Deceased { get; set; }
		}

		[XmlRoot(ElementName = "Document")]
		public class Document
		{

			[XmlElement(ElementName = "DocumentURL")]
			public string DocumentURL { get; set; }

			[XmlElement(ElementName = "DocumentCode")]
			public string DocumentCode { get; set; }
		}

		[XmlRoot(ElementName = "ProbateCase")]
		public class ProbateCase
		{

			[XmlElement(ElementName = "ProbatePortalReference")]
			public string ProbatePortalReference { get; set; }

			[XmlElement(ElementName = "CaseType")]
			public string CaseType { get; set; }

			[XmlElement(ElementName = "GrossAssets")]
			public string GrossAssets { get; set; }

			[XmlElement(ElementName = "NetAssets")]
			public string NetAssets { get; set; }

			[XmlElement(ElementName = "Limitations")]
			public string Limitations { get; set; }

			[XmlElement(ElementName = "EntitlementCode")]
			public string EntitlementCode { get; set; }

			[XmlElement(ElementName = "CodicilNumPages")]
			public string CodicilNumPages { get; set; }

			[XmlElement(ElementName = "CodicilNum")]
			public string CodicilNum { get; set; }

			[XmlElement(ElementName = "PortalStampFee")]
			public string PortalStampFee { get; set; }

			[XmlElement(ElementName = "PortalCopyFee")]
			public string PortalCopyFee { get; set; }

			[XmlElement(ElementName = "PortalPersonalApplicationFee")]
			public string PortalPersonalApplicationFee { get; set; }

			[XmlElement(ElementName = "OtherAttachments")]
			public string OtherAttachments { get; set; }

			[XmlElement(ElementName = "Participant")]
			public Participant Participant { get; set; }

			[XmlElement(ElementName = "Document")]
			public List<Document> Document { get; set; }
		}

		[XmlRoot(ElementName = "ProbateCreateCase")]
		public class ProbateCreateCase
		{

			[XmlElement(ElementName = "ProbateCase")]
			public ProbateCase ProbateCase { get; set; }

			[XmlAttribute(AttributeName = "xmlns")]
			public String Xmlns { get; set; }
		}

	}
}
