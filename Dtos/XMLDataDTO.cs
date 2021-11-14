﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsumeEndPoints.Dtos
{
    [XmlRoot("geoPlugin")]
    public class XMLDataDTO
    {
		[XmlElement(ElementName = "geoplugin_request")]
		public string Geoplugin_request { get; set; }
		[XmlElement(ElementName = "geoplugin_status")]
		public string Geoplugin_status { get; set; }
		[XmlElement(ElementName = "geoplugin_delay")]
		public string Geoplugin_delay { get; set; }
		[XmlElement(ElementName = "geoplugin_credit")]
		public string Geoplugin_credit { get; set; }
		[XmlElement(ElementName = "geoplugin_city")]
		public string Geoplugin_city { get; set; }
		[XmlElement(ElementName = "geoplugin_region")]
		public string Geoplugin_region { get; set; }
		[XmlElement(ElementName = "geoplugin_regionCode")]
		public string Geoplugin_regionCode { get; set; }
		[XmlElement(ElementName = "geoplugin_regionName")]
		public string Geoplugin_regionName { get; set; }
		[XmlElement(ElementName = "geoplugin_areaCode")]
		public string Geoplugin_areaCode { get; set; }
		[XmlElement(ElementName = "geoplugin_dmaCode")]
		public string Geoplugin_dmaCode { get; set; }
		[XmlElement(ElementName = "geoplugin_countryCode")]
		public string Geoplugin_countryCode { get; set; }
		[XmlElement(ElementName = "geoplugin_countryName")]
		public string Geoplugin_countryName { get; set; }
		[XmlElement(ElementName = "geoplugin_inEU")]
		public string Geoplugin_inEU { get; set; }
		[XmlElement(ElementName = "geoplugin_euVATrate")]
		public string Geoplugin_euVATrate { get; set; }
		[XmlElement(ElementName = "geoplugin_continentCode")]
		public string Geoplugin_continentCode { get; set; }
		[XmlElement(ElementName = "geoplugin_continentName")]
		public string Geoplugin_continentName { get; set; }
		[XmlElement(ElementName = "geoplugin_latitude")]
		public string Geoplugin_latitude { get; set; }
		[XmlElement(ElementName = "geoplugin_longitude")]
		public string Geoplugin_longitude { get; set; }
		[XmlElement(ElementName = "geoplugin_locationAccuracyRadius")]
		public string Geoplugin_locationAccuracyRadius { get; set; }
		[XmlElement(ElementName = "geoplugin_timezone")]
		public string Geoplugin_timezone { get; set; }
		[XmlElement(ElementName = "geoplugin_currencyCode")]
		public string Geoplugin_currencyCode { get; set; }
		[XmlElement(ElementName = "geoplugin_currencySymbol")]
		public string Geoplugin_currencySymbol { get; set; }
		[XmlElement(ElementName = "geoplugin_currencySymbol_UTF8")]
		public string Geoplugin_currencySymbol_UTF8 { get; set; }
		[XmlElement(ElementName = "geoplugin_currencyConverter")]
		public string Geoplugin_currencyConverter { get; set; }
	}
}
