// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GroupDocs.Signature.Cloud.Sdk.Api;
using GroupDocs.Signature.Cloud.Sdk.Client;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Storage
{
    using NUnit.Framework;

    public class TestStorageAuthentication
    {
        /// <summary>
        /// Test storage authentication with wrong Sid and Key.
        /// </summary>
        [Test]
        public void StorageAuthenticationWrongSidKey()
        {
            var appSid = "test";
            var appKey = "test";

            var config = new Configuration(appSid, appKey)
            {
                ApiBaseUrl = Config.ApiBaseUrl
            };

            var api = new InfoApi(config);

            var ex = Assert.Throws<System.AggregateException>(() =>
            {
                api.GetSupportedFileFormats();
            });

            Assert.IsTrue(ex.Message.Contains("invalid_client"));
        }

        /// <summary>
        /// Test storage authentication with wrong Key.
        /// </summary>
        [Test]
        public void StorageAuthenticationWrongKey()
        {
            var appSid = Config.AppSid;
            var appKey = "test";

            var config = new Configuration(appSid, appKey)
            {
                ApiBaseUrl = Config.ApiBaseUrl
            };

            var api = new InfoApi(config);

            var ex = Assert.Throws<System.AggregateException>(() =>
            {
                api.GetSupportedFileFormats();
            });

            Assert.IsTrue(ex.Message.Contains("invalid_client"));
        }
    }
}