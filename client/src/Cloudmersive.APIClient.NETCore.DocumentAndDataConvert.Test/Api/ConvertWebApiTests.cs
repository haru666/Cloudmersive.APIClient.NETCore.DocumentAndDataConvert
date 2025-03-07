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
    ///  Class for testing ConvertWebApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConvertWebApiTests
    {
        private ConvertWebApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConvertWebApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConvertWebApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConvertWebApi
            //Assert.IsInstanceOfType(typeof(ConvertWebApi), instance, "instance is a ConvertWebApi");
        }

        
        /// <summary>
        /// Test ConvertWebHtmlToDocx
        /// </summary>
        [Test]
        public void ConvertWebHtmlToDocxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HtmlToOfficeRequest inputRequest = null;
            //var response = instance.ConvertWebHtmlToDocx(inputRequest);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertWebHtmlToPdf
        /// </summary>
        [Test]
        public void ConvertWebHtmlToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HtmlToPdfRequest input = null;
            //var response = instance.ConvertWebHtmlToPdf(input);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertWebMdToHtml
        /// </summary>
        [Test]
        public void ConvertWebMdToHtmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertWebMdToHtml(inputFile);
            //Assert.IsInstanceOf<HtmlMdResult> (response, "response is HtmlMdResult");
        }
        
        /// <summary>
        /// Test ConvertWebUrlToPdf
        /// </summary>
        [Test]
        public void ConvertWebUrlToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ScreenshotRequest input = null;
            //var response = instance.ConvertWebUrlToPdf(input);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertWebUrlToScreenshot
        /// </summary>
        [Test]
        public void ConvertWebUrlToScreenshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ScreenshotRequest input = null;
            //var response = instance.ConvertWebUrlToScreenshot(input);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
