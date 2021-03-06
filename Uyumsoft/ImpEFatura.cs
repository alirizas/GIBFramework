﻿using GIBInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Uyumsoft.ServiceUyumsoft;

namespace Uyumsoft
{
    public partial class EFatura : IEFatura
    {
        public string ProviderId()
        {
            return "Uyumsoft";
        }
        public SendResult SendInvoice(SendParameters SendParameters)
        {
            SendResult r = new SendResult();
            ServiceUyumsoft.InvoiceInfo[] InvoiceInfo = new ServiceUyumsoft.InvoiceInfo[SendParameters.InvoicesInfo.Count];

            int i = 0;
            foreach (var item in SendParameters.InvoicesInfo)
            {
                var xml = item.Invoices.CreateXml();
                InvoiceInfo[i] = new ServiceUyumsoft.InvoiceInfo();
                InvoiceInfo[i].Invoice = UyumsoftInvoiceDeserialize(xml);
                InvoiceInfo[i].LocalDocumentId = item.LocalDocumentId;
                InvoiceInfo[i].Scenario = InvoiceScenarioChoosen.eInvoice;
                InvoiceInfo[i].TargetCustomer = new ServiceUyumsoft.CustomerInfo()
                {
                    VknTckn = item.Customer.VknTckn,
                    Alias = item.Customer.Alias,
                    Title = item.Customer.Title
                };



                i++;
            }
            var response = service.SendInvoice(InvoiceInfo);
            r.Message = response.Message;
            r.IsSucceded = response.IsSucceded;
            if (response.IsSucceded)
            {
                r.ResultInvoices = new List<ResultInvoice>();
                foreach (var item in response.Value)
                {
                    ResultInvoice ri = new ResultInvoice();
                    ri.FaturaNo = item.Number;
                    ri.ETN = item.Id;
                    r.ResultInvoices.Add(ri);
                }
            }
            else
            {
                //throw new Exception("hata testi");
            }

            return r;
        }

        public static ServiceUyumsoft.InvoiceType UyumsoftInvoiceDeserialize(string xml)
        {
            xml = xml.Replace("<Invoice ", "<InvoiceType ");
            xml = xml.Replace("</Invoice>", "</InvoiceType>");

            var lines = xml.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            StringBuilder sb = new StringBuilder();
            {
                string s = "<InvoiceType xmlns:ubltr=\"urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents\" xmlns:cctc=\"urn:un:unece:uncefact:documentation:2\" xmlns:cbc=\"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2\" xmlns:cac=\"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2\" xmlns:qdt=\"urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2\" xmlns:ds=\"http://www.w3.org/2000/09/xmldsig#\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:ext=\"urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2\" xmlns:xades=\"http://uri.etsi.org/01903/v1.3.2#\" xmlns:udt=\"urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2\">";
                int i = 0;
                foreach (var item in lines)
                {
                    i++;
                    if (i == 2)
                    {
                        sb.Append(s);
                    }
                    else if (i > 7)
                    {
                        sb.Append(item);
                    }
                }
                xml = sb.ToString();
            }
            XmlSerializer serialize = new XmlSerializer(typeof(ServiceUyumsoft.InvoiceType));
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                stream.Seek(0, SeekOrigin.Begin);
                return serialize.Deserialize(stream) as ServiceUyumsoft.InvoiceType;
            }
        }



    }
}
