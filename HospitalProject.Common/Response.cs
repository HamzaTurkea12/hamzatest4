﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Common
{
	
	public class Response : IResponse
	{
		public Response(ResponseType responseType)
		{
				ResponseType = responseType;
		}
		public Response(ResponseType responseType, string message)
		{
				ResponseType = responseType;
				Message = message;
		}
		public string Message { get; set; }
		public ResponseType ResponseType { get; set; }

	}


	public enum ResponseType
	{
		Success,
		ValidationError,
		NotFound,
		//Error //kayıt varsa bakacağı, eğer varsa hata döneceğim
	}

}
