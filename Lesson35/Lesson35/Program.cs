using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson35
{
    class Program
    {
        static void Main(string[] args)
        {

            string uri = "http://mycsharp.ru/post/51/2016_07_28_protokol_http_metod_post_i_kuki_v_si-sharp.html";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            // данные для отправки, здесь я изменил значение тектового поля на "http_post"
            string postData = "__EVENTTARGET=&__EVENTARGUMENT=&__VIEWSTATE=%2FwEPDwUJNzg3OTE4NTEzZBgCBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WAwUjY3RsMDAkTG9naW5WaWV3MSRMb2dpblN0YXR1czIkY3RsMDEFI2N0bDAwJExvZ2luVmlldzEkTG9naW5TdGF0dXMyJGN0bDAzBSljdGwwMCRDb250ZW50UGxhY2VIb2xkZXIxJEltYWdlQnV0dG9uQ29kZQUQY3RsMDAkTG9naW5WaWV3MQ8PZAIBZPjV5VmdGl6Oqjup%2BvGFwKu6%2B3Ei&__VIEWSTATEGENERATOR=AD7AD114&__EVENTVALIDATION=%2FwEdAAb7D4Qtida%2BZGvmbQrru2fIg8CfUEZ4x6JEFru5nuWdjDAT7Txw9yG0b5PssXmG9uPZ%2BZJwSnD0h6b%2FvE2D3PPKxiJES0DEX6bfdLMW9tej7mlHPn5cMzWaJidgY%2FaB5w%2BN1FVC3grjFI9WCbFx2WZGaqkwFg%3D%3D&ctl00%24ContentPlaceHolder1%24TextBoxMessage=I+Did+It+(Twice)&ctl00%24ContentPlaceHolder1%24ButtonAddMessage=%D0%94%D0%BE%D0%B1%D0%B0%D0%B2%D0%B8%D1%82%D1%8C";
            //Cookies
            //_ym_uid=1491156420429156159; _ga=GA1.2.2008888109.1491156419; _gid=GA1.2.330448953.1495970183; ASP.NET_SessionId=5zchhpdtxzuczegxpulhgoqc; _rbu=14959595443644416969; _ym_isad=2; _ym_visorc_21378790=w; subscriber=True; mycsharp=81527CDA769F7C02627F22E794A945FA92314C37D852F458F9FB3845864E5CB86C680DF92F73B97CBB78CC3FB0DF53F9D4EE80DC392DE6042EBFF9F1D0B38E42B137A08C7DADB69873AB3B676B0AC8CC6B355D336C5625F73440C29AB05D1A839809A8A32D2B4FA6425939C80BB72B6EAED6A863
            // конвертируем строку в массив байтов
            byte[] data = Encoding.UTF8.GetBytes(postData);
            // указываем метод запроса POST
            request.Method = "POST";
            // для POST запроса необходимо указать тип передаваемых данных и размер
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            //request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0";
            //request.Referer = "http://mycsharp.ru/post/51/2016_07_28_protokol_http_metod_post_i_kuki_v_si-sharp.html";
            request.Headers.Add("Cookie: _ym_uid=1491156420429156159; _ga=GA1.2.2008888109.1491156419; _gid=GA1.2.1496792490.1495971217; ASP.NET_SessionId=5zchhpdtxzuczegxpulhgoqc; _rbu=14959595443644416969; _ym_isad=2; _ym_visorc_21378790=w; subscriber=True; mycsharp=81527CDA769F7C02627F22E794A945FA92314C37D852F458F9FB3845864E5CB86C680DF92F73B97CBB78CC3FB0DF53F9D4EE80DC392DE6042EBFF9F1D0B38E42B137A08C7DADB69873AB3B676B0AC8CC6B355D336C5625F73440C29AB05D1A839809A8A32D2B4FA6425939C80BB72B6EAED6A863; _rbs=14959705740220224168; _gat=1");
            // записываем в поток запроса данные
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            Console.WriteLine(reader.ReadToEnd()); // получаем ответ от сервера - страничка с текстом "HTTP_POST"
            reader.Close();
            Console.ReadLine();
        }
    }
}




//POST http://mycsharp.ru/post/51/2016_07_28_protokol_http_metod_post_i_kuki_v_si-sharp.html HTTP/1.1
//Host: mycsharp.ru
// + User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0
// + Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8
// - Accept-Language: en-US,en;q=0.5
// - Accept-Encoding: gzip, deflate
//Content-Type: application/x-www-form-urlencoded
//Content-Length: 715
// - Referer: http://mycsharp.ru/post/51/2016_07_28_protokol_http_metod_post_i_kuki_v_si-sharp.html
//Cookie: _ym_uid=1491156420429156159; _ga=GA1.2.2008888109.1491156419; _gid=GA1.2.1496792490.1495971217; ASP.NET_SessionId=5zchhpdtxzuczegxpulhgoqc; _rbu=14959595443644416969; _ym_isad=2; _ym_visorc_21378790=w; subscriber=True; mycsharp=81527CDA769F7C02627F22E794A945FA92314C37D852F458F9FB3845864E5CB86C680DF92F73B97CBB78CC3FB0DF53F9D4EE80DC392DE6042EBFF9F1D0B38E42B137A08C7DADB69873AB3B676B0AC8CC6B355D336C5625F73440C29AB05D1A839809A8A32D2B4FA6425939C80BB72B6EAED6A863; _rbs=14959705740220224168; _gat=1
//Connection: keep-alive
//Upgrade-Insecure-Requests: 1

//POST http://mycsharp.ru/post/51/2016_07_28_protokol_http_metod_post_i_kuki_v_si-sharp.html HTTP/1.1
//Content-Type: application/x-www-form-urlencoded
//Cookie: _ym_uid=1491156420429156159; _ga=GA1.2.2008888109.1491156419; _gid=GA1.2.330448953.1495970183; ASP.NET_SessionId=5zchhpdtxzuczegxpulhgoqc; _rbu=14959595443644416969; _ym_isad=2; _ym_visorc_21378790=w; subscriber=True; mycsharp=81527CDA769F7C02627F22E794A945FA92314C37D852F458F9FB3845864E5CB86C680DF92F73B97CBB78CC3FB0DF53F9D4EE80DC392DE6042EBFF9F1D0B38E42B137A08C7DADB69873AB3B676B0AC8CC6B355D336C5625F73440C29AB05D1A839809A8A32D2B4FA6425939C80BB72B6EAED6A863
//Host: mycsharp.ru
//Content-Length: 806
//Expect: 100-continue
//Connection: Keep-Alive
