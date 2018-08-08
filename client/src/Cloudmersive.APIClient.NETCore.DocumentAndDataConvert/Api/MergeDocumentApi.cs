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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMergeDocumentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Merge Multple Word DOCX Together
        /// </summary>
        /// <remarks>
        /// Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>byte[]</returns>
        byte[] MergeDocumentDocx (System.IO.Stream inputFile1, System.IO.Stream inputFile2);

        /// <summary>
        /// Merge Multple Word DOCX Together
        /// </summary>
        /// <remarks>
        /// Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> MergeDocumentDocxWithHttpInfo (System.IO.Stream inputFile1, System.IO.Stream inputFile2);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Merge Multple Word DOCX Together
        /// </summary>
        /// <remarks>
        /// Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> MergeDocumentDocxAsync (System.IO.Stream inputFile1, System.IO.Stream inputFile2);

        /// <summary>
        /// Merge Multple Word DOCX Together
        /// </summary>
        /// <remarks>
        /// Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> MergeDocumentDocxAsyncWithHttpInfo (System.IO.Stream inputFile1, System.IO.Stream inputFile2);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MergeDocumentApi : IMergeDocumentApi
    {
        private Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MergeDocumentApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MergeDocumentApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Merge Multple Word DOCX Together Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>byte[]</returns>
        public byte[] MergeDocumentDocx (System.IO.Stream inputFile1, System.IO.Stream inputFile2)
        {
             ApiResponse<byte[]> localVarResponse = MergeDocumentDocxWithHttpInfo(inputFile1, inputFile2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Merge Multple Word DOCX Together Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > MergeDocumentDocxWithHttpInfo (System.IO.Stream inputFile1, System.IO.Stream inputFile2)
        {
            // verify the required parameter 'inputFile1' is set
            if (inputFile1 == null)
                throw new ApiException(400, "Missing required parameter 'inputFile1' when calling MergeDocumentApi->MergeDocumentDocx");
            // verify the required parameter 'inputFile2' is set
            if (inputFile2 == null)
                throw new ApiException(400, "Missing required parameter 'inputFile2' when calling MergeDocumentApi->MergeDocumentDocx");

            var localVarPath = "/convert/merge/docx";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile1 != null) localVarFileParams.Add("inputFile1", Configuration.ApiClient.ParameterToFile("inputFile1", inputFile1));
            if (inputFile2 != null) localVarFileParams.Add("inputFile2", Configuration.ApiClient.ParameterToFile("inputFile2", inputFile2));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MergeDocumentDocx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }

        /// <summary>
        /// Merge Multple Word DOCX Together Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> MergeDocumentDocxAsync (System.IO.Stream inputFile1, System.IO.Stream inputFile2)
        {
             ApiResponse<byte[]> localVarResponse = await MergeDocumentDocxAsyncWithHttpInfo(inputFile1, inputFile2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Merge Multple Word DOCX Together Combine multiple Office Word Documents (docx) into one single Office Word documents
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile1">First input file to perform the operation on.</param>
        /// <param name="inputFile2">Second input file to perform the operation on (more than 2 can be supplied).</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> MergeDocumentDocxAsyncWithHttpInfo (System.IO.Stream inputFile1, System.IO.Stream inputFile2)
        {
            // verify the required parameter 'inputFile1' is set
            if (inputFile1 == null)
                throw new ApiException(400, "Missing required parameter 'inputFile1' when calling MergeDocumentApi->MergeDocumentDocx");
            // verify the required parameter 'inputFile2' is set
            if (inputFile2 == null)
                throw new ApiException(400, "Missing required parameter 'inputFile2' when calling MergeDocumentApi->MergeDocumentDocx");

            var localVarPath = "/convert/merge/docx";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile1 != null) localVarFileParams.Add("inputFile1", Configuration.ApiClient.ParameterToFile("inputFile1", inputFile1));
            if (inputFile2 != null) localVarFileParams.Add("inputFile2", Configuration.ApiClient.ParameterToFile("inputFile2", inputFile2));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MergeDocumentDocx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }

    }
}
