using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WhoAmI
{
	public class RegistroPonto
    {	
        [JsonProperty ("data")]
        public int data {get;set;}

        [JsonProperty ("hora")]
        public int hora {get;set;}

        [JsonProperty ("empNO")]
        public int empNO {get;set;}

        [JsonProperty ("tipoPonto")]
        public char tipoPonto {get;set;}
		
		public RegistroPonto ()
		{

		}
	}
}

