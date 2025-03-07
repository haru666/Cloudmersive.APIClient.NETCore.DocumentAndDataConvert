/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Test
{
    /// <summary>
    ///  Class for testing ConvertImageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConvertImageApiTests
    {
        private ConvertImageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConvertImageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConvertImageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConvertImageApi
            //Assert.IsInstanceOfType(typeof(ConvertImageApi), instance, "instance is a ConvertImageApi");
        }

        
        /// <summary>
        /// Test ConvertImageGetImageInfo
        /// </summary>
        [Test]
        public void ConvertImageGetImageInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertImageGetImageInfo(inputFile);
            //Assert.IsInstanceOf<GetImageInfoResult> (response, "response is GetImageInfoResult");
        }
        
        /// <summary>
        /// Test ConvertImageImageFormatConvert
        /// </summary>
        [Test]
        public void ConvertImageImageFormatConvertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string format1 = null;
            //string format2 = null;
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertImageImageFormatConvert(format1, format2, inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertImageImageSetDPI
        /// </summary>
        [Test]
        public void ConvertImageImageSetDPITest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? dpi = null;
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertImageImageSetDPI(dpi, inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertImageMultipageImageFormatConvert
        /// </summary>
        [Test]
        public void ConvertImageMultipageImageFormatConvertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string format1 = null;
            //string format2 = null;
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertImageMultipageImageFormatConvert(format1, format2, inputFile);
            //Assert.IsInstanceOf<MultipageImageFormatConversionResult> (response, "response is MultipageImageFormatConversionResult");
        }
        
    }

}
