﻿using System;
using NUnit.Framework;

using DataUri = System.Net.DataUri;

namespace DataUriTests
{
	[TestFixture]
	public class DataUriTests
	{
		
		[Test]
		[TestCase("data:base64,QUJDREVGR0hJSktMTU5PUFFSU1RVVldYWVo=", "4142434445464748494A4B4C4D4E4F505152535455565758595A")]
		[TestCase("data:base64,TG9yZW0gaXBzdW0gZG9sYXIgc2l0IGFtb3Q=", "4c6f72656d20697073756d20646f6c61722073697420616d6f74")]
		public void Parse_Base64_NoMediaType(string input, string expectedBytesStr)
		{
			//arrange
			byte[] expectedBytes = HexStringToByteArray(expectedBytesStr);

			//act
			var datauri = DataUri.Parse(input);

			//assert
			Assert.That(datauri, Is.Not.Null);
			Assert.That(datauri.Bytes, Is.EqualTo(expectedBytes));
			Assert.That(datauri.MediaType, Is.EqualTo((string)null));
		}

		#region test helpers
		public static byte[] HexStringToByteArray(string hexString) //http://stackoverflow.com/a/8235530/323456
		{
			if (hexString.Length % 2 != 0)
			{
				throw new ArgumentException("The hex values string cannot have an odd number of digits.");
			}

			byte[] HexAsBytes = new byte[hexString.Length / 2];
			for (int index = 0; index < HexAsBytes.Length; index++)
			{
				string byteValue = hexString.Substring(index * 2, 2);
				HexAsBytes[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
			}

			return HexAsBytes;
		}
		#endregion

	}
}