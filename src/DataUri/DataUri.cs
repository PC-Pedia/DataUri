﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System.Net
{
	public sealed partial class DataUri
	{

		/// <summary>
		/// Construct a new DataUri instance
		/// </summary>
		/// <param name="bytes"></param>
		public DataUri(byte[] bytes)
		{
			this.Bytes = bytes;
		}

		/// <summary>
		/// Construct a new DataUri instance
		/// </summary>
		/// <param name="mediaType"></param>
		/// <param name="bytes"></param>
		public DataUri(string mediaType, byte[] bytes)
		{
			this.MediaType = mediaType;
			this.Bytes = bytes;
		}

		/// <summary>
		/// Gets the bytes for this data-uri instance.
		/// </summary>
		public byte[] Bytes { get; private set; }

		/// <summary>
		/// Gets the Media type for this data-uri instance.
		/// </summary>
		public string MediaType { get; set; }
	}
}
