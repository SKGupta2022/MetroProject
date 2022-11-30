using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Framework
{
    public class Functions : AsyncDbRepository
    {
        private readonly IAppSettings _configuration;
        public Functions(IAppSettings configuration, IDbConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _configuration = configuration;
            if (connectionFactory == null) throw new ArgumentNullException(nameof(connectionFactory));
        }

        public static string PostHTTPData(string _URL, string Data, string Header = null, string Content_Type = "application/json")
        { //manual error save 
            try
            {
                string responseFromServer = ""; string postData = null;
                WebRequest request = WebRequest.Create(_URL);
                request.Method = "POST";
                if (Header != null)
                {
                    string[] valueArr = Header.Split(',');
                    foreach (var item in valueArr)
                    {
                        if (item.IndexOf(":") > 0)
                        {
                            string[] AddParameter = item.Split(':');
                            request.Headers.Add(AddParameter[0], AddParameter[1]);
                        }
                    }
                }
                if (Data != null)
                    postData = Data;
                else
                    postData = "";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                if (string.IsNullOrEmpty(Content_Type))
                    request.ContentType = "application/json";
                else
                    request.ContentType = Content_Type;
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                    Console.WriteLine(responseFromServer);
                }
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// The string fail.
        /// </summary>
        public static readonly int Fail = 0;

        /// <summary>
        /// The string success.
        /// </summary>
        public static readonly int Success = 1;

        /// <summary>
        /// The other
        /// </summary>
        public static readonly int Other = 2;

        /// <summary>
        /// The date time format
        /// </summary>
        public static readonly string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// The default date time
        /// </summary>
        public static readonly string DefaultDateTime = "1900-01-01 00:00:00.000";

        /// <summary>
        /// File Name Format
        /// </summary>
        public static readonly string FileNameFormat = "yyyyMMddHHmmssfff_";

        /// <summary>
        /// Removes the special characters.
        /// </summary>
        /// <param name="stringData">The string data.</param>
        /// <returns>System String.</returns>
        public static string RemoveSpecialCharacters(string stringData)
        {
            StringBuilder stringbuilder = new StringBuilder();
            foreach (char c in stringData)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    stringbuilder.Append(c);
                }
            }

            return stringbuilder.ToString();
        }
        public static int GetPaybleAmount(int numberOfPages)
        {
            int minAmount = 10; int baseAmount = 5; int paybleAmount = 0; int amountToAdd = 0;
            try
            {
                paybleAmount = baseAmount * numberOfPages;
                if (paybleAmount < minAmount)
                {
                    paybleAmount = minAmount;
                }
                else
                {
                    int remainder = paybleAmount % minAmount;
                    if (remainder != 0)
                    {
                        amountToAdd = 10 - remainder;
                    }
                    paybleAmount += amountToAdd;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return paybleAmount;
        }
        public static string ToBeEncrypt(string textToEncrypt, string EncryptionPassword)
        {
            try
            {
                RijndaelManaged rijndaelCipher = new RijndaelManaged();
                rijndaelCipher.Mode = CipherMode.CBC;
                rijndaelCipher.Padding = PaddingMode.PKCS7;
                rijndaelCipher.KeySize = 256;
                rijndaelCipher.BlockSize = 128;
                byte[] pwdBytes = Encoding.UTF8.GetBytes(EncryptionPassword);
                pwdBytes = SHA256.Create().ComputeHash(pwdBytes);
                byte[] keyBytes = new byte[16];
                int len = pwdBytes.Length;
                if (len > keyBytes.Length)
                {
                    len = keyBytes.Length;
                }
                Array.Copy(pwdBytes, keyBytes, len);
                rijndaelCipher.Key = keyBytes;
                rijndaelCipher.IV = keyBytes;
                ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
                byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
                return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
            }
            catch (Exception ex)
            {
                BackEndException backEndException = new BackEndException();
                backEndException.RequestURL = textToEncrypt;
                backEndException.Type = "ToBeEncrypt";
                backEndException.Result = ex.Message;
                //ManualErrorSave(backEndException);
                throw ex;
            }

        }
        public static string Remove_hazardous_Character(string myString)
        {
            if (!string.IsNullOrEmpty(myString))
            {
                myString = myString.Replace("/", "");
                myString = myString.Replace("<", "");
                myString = myString.Replace(">", "");
                myString = myString.Replace("'", "");
                myString = myString.Replace("%", "");
                myString = myString.Replace(";", "");
                myString = myString.Replace("&", "");
                myString = myString.Replace("*", "");
                myString = myString.Replace("(", "");
                myString = myString.Replace(")", "");
                myString = myString.Replace("@", "");
                myString = myString.Replace("#", "");
                myString = myString.Replace("+", "");
                myString = myString.Replace(".", "");

                return myString;
            }
            else
                return string.Empty;
        }
        //public async Task<ICollection<DataTable>> GetConfigValue(string Source_Name, string Source_Value)
        //{
        //    var queryParameters = new DynamicParameters();
        //    queryParameters.Add("@Source_Name", Source_Name);
        //    queryParameters.Add("@Source_Name", Source_Value);
        //    queryParameters.Add("@Action", CommonAction.GetStaticValue);
        //    var returnvalue = (await WithConnection(async c => await c.QueryAsync<DataTable>(StoredProcedures.Get_MSTCONFIG, queryParameters, commandType: CommandType.StoredProcedure))).ToList();
        //    return returnvalue;
        //}
        public static string ToBeDecrypt(string textToDecrypt, string EncryptionPassword)
        {
            try
            {
                RijndaelManaged rijndaelCipher = new RijndaelManaged();
                rijndaelCipher.Mode = CipherMode.CBC;
                rijndaelCipher.Padding = PaddingMode.PKCS7;
                rijndaelCipher.KeySize = 256;
                rijndaelCipher.BlockSize = 128;
                byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
                byte[] pwdBytes = Encoding.UTF8.GetBytes(EncryptionPassword);
                pwdBytes = SHA256.Create().ComputeHash(pwdBytes);
                byte[] keyBytes = new byte[16];
                int len = pwdBytes.Length;
                if (len > keyBytes.Length)
                {
                    len = keyBytes.Length;
                }
                Array.Copy(pwdBytes, keyBytes, len);
                rijndaelCipher.Key = keyBytes;
                rijndaelCipher.IV = keyBytes;
                byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                return Encoding.UTF8.GetString(plainText);
            }
            catch (Exception ex)
            {
                BackEndException backEndException = new BackEndException();
                backEndException.RequestURL = textToDecrypt;
                backEndException.Type = "ToBeDecrypt";
                backEndException.Result = ex.Message;
                // ManualErrorSave(backEndException);
                throw ex;
            }

        }
        //public static string CallGETAPI(string url)  //manual error save 
        //{
        //    try
        //    {
        //        var client = new RestClient(url);
        //        //var request = new RestRequest(Method.GET);

        //        //IRestResponse response = client.Execute(request);
        //        // Deserializing json data to object             
        //        return null; // response.Content;
        //    }
        //    catch (Exception ex)
        //    {
        //        BackEndException backEndException = new BackEndException();
        //        backEndException.RequestURL = url;
        //        backEndException.Type = "GET";
        //        backEndException.Result = ex.Message;
        //        ManualErrorSave(backEndException);
        //        throw ex;
        //    }
        //}

        public static string UnicodeToString(string unicodestring)
        {

            // Create two different encodings.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            //Encoding Utf8 = Encoding.UTF8;

            // // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(unicodestring);

            // // Perform the conversion from one encoding to the other.
            byte[] ascibytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(ascibytes, 0, ascibytes.Length)];
            ascii.GetChars(ascibytes, 0, ascibytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);
            return asciiString;
        }

        public static string postXMLData(string destinationUrl, string requestXml) // manual error save
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
                byte[] bytes;
                bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
                request.ContentType = "Application/xml";
                request.ContentLength = bytes.Length;
                request.Headers["appname"] = "Emitra+";//Test-By-DotNet
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = response.GetResponseStream();
                    string responseStr = new StreamReader(responseStream).ReadToEnd();
                    return responseStr;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public static string CreateSHA256Hash(string toBeHashString)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(toBeHashString));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }

    public class BackEndException
    {
        public string RequestURL { get; set; }
        public string jSON { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }
    }
}
