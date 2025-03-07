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
    ///  Class for testing ViewerToolsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ViewerToolsApiTests
    {
        private ViewerToolsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewerToolsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewerToolsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ViewerToolsApi
            //Assert.IsInstanceOfType(typeof(ViewerToolsApi), instance, "instance is a ViewerToolsApi");
        }

        
        /// <summary>
        /// Test ViewerToolsCreateSimple
        /// </summary>
        [Test]
        public void ViewerToolsCreateSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ViewerToolsCreateSimple(inputFile);
            //Assert.IsInstanceOf<ViewerResponse> (response, "response is ViewerResponse");
        }
        
    }

}
