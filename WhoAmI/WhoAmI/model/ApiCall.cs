﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WhoAmI
{
	public class ApiCall
	{
		static readonly string ApiUrl = "http://tools.fifaguide.com/api/{0}/{1}";
		static readonly string ApiUrlMy = "http://192.168.0.102:8080/howamirs/howamirs/{0}/{1}";
		static readonly string ApiUrl2="http://192.168.0.102:8080/howamirs/howamirs/registrosDiaModulo/1";
		//http://192.168.0.106:8080/howamirs/howamirs/registrosDiaModulo/1


		public async Task<T> GetResponse<T>(string method, string param) where T : class
		{

			var client = new System.Net.Http.HttpClient();
			var client2 = new System.Net.Http.HttpClient();


			//Definide o Header de resultado para JSON, para evitar que seja retornado um HTML ou XML
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client2.MaxResponseContentBufferSize = 1024*1024*8;

			//Formata a Url com o metodo e o parametro enviado e inicia o acesso a Api. Como o acesso será por meio
			//da Internet, pode demorar muito, para que o aplicativo não trave usamos um método assincrono
			//e colocamos a keyword AWAIT, para que a Thread principal - UI - continuo sendo executada
			//e o método so volte a ser executado quando o download das informações for finalizado
			var response = await client.GetAsync(string.Format(ApiUrlMy, method, param));
			var JsonResult = response.Content.ReadAsStringAsync().Result;
			//string method2 = "registrosDiaModulo";
			//string param2 = "1";
			//var response2 = await client2.GetAsync(string.Format(ApiUrl2, method2, param2));
			var response2 = await client2.GetAsync(new Uri(ApiUrl2));
			var JsonResult2 = response2.Content.ReadAsStringAsync().Result;
			//Lê a string retornada
			if (typeof(T) == typeof(string))
				return null;

			//Converte o resultado Json para uma Classe utilizando as Libs do Newtonsoft.Json
			var rootobject = JsonConvert.DeserializeObject<T>(JsonResult);

			return rootobject;
		}




	}
}

