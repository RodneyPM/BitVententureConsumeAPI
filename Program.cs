using ConsumeEndPoints.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsumeEndPoints
{


    class Program
    {

        static async Task Main(string[] args)
        {
            //filenames
            string _basicEndPoints = @"Data\basic_endpoints.json";
            string _bonusEndPoints = @"Data\bonus_endpoints.json";
            //
            string _filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), _basicEndPoints);
            try
            {
                Data fileResponse = new Data();
                using (StreamReader r = new StreamReader(_filePath))
                {
                    string endpoints = r.ReadToEnd();
                    if (!string.IsNullOrEmpty(endpoints))
                    {
                        fileResponse = JsonConvert.DeserializeObject<Data>(endpoints);
                    }
                    await Services(fileResponse);

                }
            }
            catch (Exception e)
            {
                // log exception
                // alert
            }


            Console.ReadLine();
        }
        /// <summary>
        /// main method to connect to services
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        static async Task<ServicesDTO[]> Services(Data data)
        {

            ServicesDTO[] info = data.Services;
            if (info != null && info.Length > 0)
            {
                foreach (var item in info)
                {
                    if (!string.IsNullOrEmpty(item.BaseURL) && item.Endpoints.Length > 0)
                    {
                        string url = item.BaseURL;

                        foreach (var endpoint in item.Endpoints)
                        {
                            if (!string.IsNullOrEmpty(endpoint.Resource))
                            {
                                url += endpoint.Resource;
                                if (endpoint.Enabled)
                                {
                                    HttpClient endpointsClient = new HttpClient();
                                    HttpResponseMessage endpointResponse = await endpointsClient.GetAsync(url);

                                    System.Net.HttpStatusCode statusCode = endpointResponse.StatusCode;

                                    if (statusCode == System.Net.HttpStatusCode.OK)
                                    {
                                        string dataType = "JSON";
                                        if (!string.IsNullOrEmpty(item.Datatype))
                                        {
                                            dataType = item.Datatype;
                                        }

                                        string content = await endpointResponse.Content.ReadAsStringAsync();
                                        if (!string.IsNullOrEmpty(content))
                                        {
                                            if (dataType == "JSON")
                                            {
                                                ResponseAPIDTO response = JsonConvert.DeserializeObject<ResponseAPIDTO>(content);
                                                if (response.Name == "Luke Skywalker")
                                                {
                                                    Console.WriteLine($"found {response.Name}");
                                                }
                                            }
                                            if (dataType == "XML")
                                            {
                                                XDocument xDocument = XDocument.Parse(content);
                                                if(xDocument != null)
                                                {
                                                    XmlSerializer serializer = new XmlSerializer(typeof(XMLDataDTO));
                                                    XMLDataDTO documentData = (XMLDataDTO)serializer.Deserialize(xDocument.CreateReader());
                                                    //send somewhere
                                                }
                                                
                                            }

                                        }
                                        if (item.Identifiers != null && item.Identifiers.Length > 0)
                                        {
                                            foreach (var identifier in item.Identifiers)
                                            {
                                                if (identifier.Value == "Luke Skywalker")
                                                {
                                                    Console.WriteLine($"found  {identifier.Value} from identifiers array");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //log issue
                                        //alert not found
                                    }
                                }



                            }
                        }

                    }

                }
            }
            return info;
        }
    }
}
