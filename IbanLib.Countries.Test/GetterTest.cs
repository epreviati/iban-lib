﻿using NUnit.Framework;

namespace IbanLib.Countries.Test
{
    [TestFixture]
    public class GetterTest
    {
        [Test]
        [TestCase("AD")]
        [TestCase("AL")]
        [TestCase("AT")]
        [TestCase("BE")]
        [TestCase("DE")]
        [TestCase("ES")]
        [TestCase("FR")]
        [TestCase("GB")]
        [TestCase("IE")]
        [TestCase("IT")]
        [TestCase("MC")]
        [TestCase("MD")]
        [TestCase("MR")]
        [TestCase("RO")]
        [TestCase("SA")]
        [TestCase("SM")]
        [TestCase("TR")]
        [TestCase("VG")]
        public void Getter_Found_Country(string countryCode)
        {
            var country = Getter.GetCountry(countryCode);
            Assert.AreNotEqual(null, country);
            Assert.AreEqual(countryCode, country.Iso3166);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("  ")]
        [TestCase("-")]
        [TestCase("AA")]
        [TestCase("A0")]
        [TestCase("0A")]
        [TestCase("IT0")]
        [TestCase("0IT")]
        [TestCase("0IT0")]
        [TestCase("ITIT")]
        [TestCase("DE0")]
        [TestCase("0DE")]
        [TestCase("0DE0")]
        [TestCase("DEDE")]
        [TestCase("GB0")]
        [TestCase("0GB")]
        [TestCase("0GB0")]
        [TestCase("GBGB")]
        [TestCase("AE")]
        [TestCase("AF")]
        [TestCase("AG")]
        [TestCase("AI")]
        [TestCase("AM")]
        [TestCase("AN")]
        [TestCase("AO")]
        [TestCase("AQ")]
        [TestCase("AR")]
        [TestCase("AS")]
        [TestCase("AU")]
        [TestCase("AW")]
        [TestCase("AZ")]
        [TestCase("BA")]
        [TestCase("BB")]
        [TestCase("BD")]
        [TestCase("BF")]
        [TestCase("BG")]
        [TestCase("BH")]
        [TestCase("BI")]
        [TestCase("BJ")]
        [TestCase("BM")]
        [TestCase("BN")]
        [TestCase("BO")]
        [TestCase("BR")]
        [TestCase("BS")]
        [TestCase("BT")]
        [TestCase("BV")]
        [TestCase("BW")]
        [TestCase("BY")]
        [TestCase("BZ")]
        [TestCase("CA")]
        [TestCase("CM")]
        [TestCase("CV")]
        [TestCase("CF")]
        [TestCase("CL")]
        [TestCase("CN")]
        [TestCase("CX")]
        [TestCase("CC")]
        [TestCase("CO")]
        [TestCase("CG")]
        [TestCase("CD")]
        [TestCase("CK")]
        [TestCase("CR")]
        [TestCase("CI")]
        [TestCase("CU")]
        [TestCase("CY")]
        [TestCase("CZ")]
        [TestCase("CS")]
        [TestCase("CH")]
        [TestCase("DZ")]
        [TestCase("DK")]
        [TestCase("DJ")]
        [TestCase("DM")]
        [TestCase("DO")]
        [TestCase("EC")]
        [TestCase("EG")]
        [TestCase("ER")]
        [TestCase("EE")]
        [TestCase("ET")]
        [TestCase("EH")]
        [TestCase("FK")]
        [TestCase("FO")]
        [TestCase("FJ")]
        [TestCase("FI")]
        [TestCase("FM")]
        [TestCase("GQ")]
        [TestCase("GF")]
        [TestCase("GA")]
        [TestCase("GM")]
        [TestCase("GE")]
        [TestCase("GH")]
        [TestCase("GI")]
        [TestCase("GR")]
        [TestCase("GL")]
        [TestCase("GD")]
        [TestCase("GP")]
        [TestCase("GU")]
        [TestCase("GT")]
        [TestCase("GN")]
        [TestCase("GW")]
        [TestCase("GY")]
        [TestCase("GS")]
        [TestCase("HR")]
        [TestCase("HT")]
        [TestCase("HM")]
        [TestCase("HN")]
        [TestCase("HK")]
        [TestCase("HU")]
        [TestCase("IO")]
        [TestCase("IS")]
        [TestCase("IN")]
        [TestCase("ID")]
        [TestCase("IR")]
        [TestCase("IQ")]
        [TestCase("IL")]
        [TestCase("JM")]
        [TestCase("JO")]
        [TestCase("JP")]
        [TestCase("KH")]
        [TestCase("KY")]
        [TestCase("KM")]
        [TestCase("KZ")]
        [TestCase("KE")]
        [TestCase("KI")]
        [TestCase("KP")]
        [TestCase("KR")]
        [TestCase("KW")]
        [TestCase("KG")]
        [TestCase("KN")]
        [TestCase("LA")]
        [TestCase("LV")]
        [TestCase("LB")]
        [TestCase("LS")]
        [TestCase("LR")]
        [TestCase("LY")]
        [TestCase("LI")]
        [TestCase("LT")]
        [TestCase("LU")]
        [TestCase("LC")]
        [TestCase("LK")]
        [TestCase("MO")]
        [TestCase("MK")]
        [TestCase("MG")]
        [TestCase("MW")]
        [TestCase("MY")]
        [TestCase("MV")]
        [TestCase("ML")]
        [TestCase("MT")]
        [TestCase("MH")]
        [TestCase("MQ")]
        [TestCase("MU")]
        [TestCase("MX")]
        [TestCase("MN")]
        [TestCase("MS")]
        [TestCase("MA")]
        [TestCase("MZ")]
        [TestCase("MM")]
        [TestCase("MP")]
        [TestCase("NA")]
        [TestCase("NR")]
        [TestCase("NP")]
        [TestCase("NL")]
        [TestCase("NC")]
        [TestCase("NZ")]
        [TestCase("NI")]
        [TestCase("NE")]
        [TestCase("NG")]
        [TestCase("NU")]
        [TestCase("NF")]
        [TestCase("NO")]
        [TestCase("OM")]
        [TestCase("PF")]
        [TestCase("PK")]
        [TestCase("PW")]
        [TestCase("PS")]
        [TestCase("PA")]
        [TestCase("PG")]
        [TestCase("PY")]
        [TestCase("PE")]
        [TestCase("PH")]
        [TestCase("PN")]
        [TestCase("PL")]
        [TestCase("PT")]
        [TestCase("PR")]
        [TestCase("PM")]
        [TestCase("QA")]
        [TestCase("RE")]
        [TestCase("RU")]
        [TestCase("RW")]
        [TestCase("SV")]
        [TestCase("SH")]
        [TestCase("ST")]
        [TestCase("SN")]
        [TestCase("SC")]
        [TestCase("SL")]
        [TestCase("SG")]
        [TestCase("SK")]
        [TestCase("SI")]
        [TestCase("SB")]
        [TestCase("SO")]
        [TestCase("SD")]
        [TestCase("SR")]
        [TestCase("SJ")]
        [TestCase("SZ")]
        [TestCase("SE")]
        [TestCase("SY")]
        [TestCase("TD")]
        [TestCase("TF")]
        [TestCase("TW")]
        [TestCase("TJ")]
        [TestCase("TZ")]
        [TestCase("TH")]
        [TestCase("TL")]
        [TestCase("TG")]
        [TestCase("TK")]
        [TestCase("TO")]
        [TestCase("TT")]
        [TestCase("TN")]
        [TestCase("TM")]
        [TestCase("TC")]
        [TestCase("TV")]
        [TestCase("UG")]
        [TestCase("UA")]
        [TestCase("US")]
        [TestCase("UM")]
        [TestCase("UY")]
        [TestCase("UZ")]
        [TestCase("VA")]
        [TestCase("VC")]
        [TestCase("VU")]
        [TestCase("VE")]
        [TestCase("VN")]
        [TestCase("VI")]
        [TestCase("WS")]
        [TestCase("WF")]
        [TestCase("YE")]
        [TestCase("YT")]
        [TestCase("ZA")]
        [TestCase("ZM")]
        [TestCase("ZW")]
        public void Getter_Not_Found_Country(string countryCode)
        {
            Assert.AreEqual(null, Getter.GetCountry(countryCode));
        }
    }
}