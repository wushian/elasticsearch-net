using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net.Connection;
using Elasticsearch.Net.Connection.Configuration;
using static Elasticsearch.Net.HttpMethod;

///Generated File Please Do Not Edit Manually
	
namespace Elasticsearch.Net
{
	///<summary>
	///Raw operations with elasticsearch
	///</summary>
	public partial class ElasticsearchClient : IElasticsearchClient
	{
	
		///<summary>Represents a POST on /_bulk 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Bulk<T>(PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_bulk 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> BulkAsync<T>(PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_bulk 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Bulk<T>(string index, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_bulk 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> BulkAsync<T>(string index, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_bulk 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Bulk<T>(string index, string type, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_bulk 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> BulkAsync<T>(string index, string type, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_bulk 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> BulkPut<T>(PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_bulk 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> BulkPutAsync<T>(PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_bulk 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> BulkPut<T>(string index, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_bulk 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> BulkPutAsync<T>(string index, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/_bulk 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> BulkPut<T>(string index, string type, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/_bulk 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html</para>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> BulkPutAsync<T>(string index, string type, PostData<object> body, Func<BulkRequestParameters, BulkRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_bulk"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_cat/aliases 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatAliases<T>(Func<CatAliasesRequestParameters, CatAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/aliases"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/aliases 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatAliasesAsync<T>(Func<CatAliasesRequestParameters, CatAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/aliases"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/aliases/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatAliases<T>(string name, Func<CatAliasesRequestParameters, CatAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/aliases/{name.NotNull("name")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/aliases/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatAliasesAsync<T>(string name, Func<CatAliasesRequestParameters, CatAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/aliases/{name.NotNull("name")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/allocation 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-allocation.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatAllocation<T>(Func<CatAllocationRequestParameters, CatAllocationRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/allocation"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/allocation 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-allocation.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatAllocationAsync<T>(Func<CatAllocationRequestParameters, CatAllocationRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/allocation"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/allocation/{node_id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-allocation.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatAllocation<T>(string node_id, Func<CatAllocationRequestParameters, CatAllocationRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/allocation/{node_id.NotNull("node_id")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/allocation/{node_id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-allocation.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatAllocationAsync<T>(string node_id, Func<CatAllocationRequestParameters, CatAllocationRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/allocation/{node_id.NotNull("node_id")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatCount<T>(Func<CatCountRequestParameters, CatCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/count"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatCountAsync<T>(Func<CatCountRequestParameters, CatCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/count"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/count/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatCount<T>(string index, Func<CatCountRequestParameters, CatCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/count/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/count/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatCountAsync<T>(string index, Func<CatCountRequestParameters, CatCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/count/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/fielddata 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-fielddata.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatFielddata<T>(Func<CatFielddataRequestParameters, CatFielddataRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/fielddata"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/fielddata 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-fielddata.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatFielddataAsync<T>(Func<CatFielddataRequestParameters, CatFielddataRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/fielddata"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/fielddata/{fields} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-fielddata.html</para>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return the fielddata size</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatFielddata<T>(string fields, Func<CatFielddataRequestParameters, CatFielddataRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/fielddata/{fields.NotNull("fields")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/fielddata/{fields} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-fielddata.html</para>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return the fielddata size</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatFielddataAsync<T>(string fields, Func<CatFielddataRequestParameters, CatFielddataRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/fielddata/{fields.NotNull("fields")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/health 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-health.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatHealth<T>(Func<CatHealthRequestParameters, CatHealthRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/health"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/health 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-health.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatHealthAsync<T>(Func<CatHealthRequestParameters, CatHealthRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/health"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatHelp<T>(Func<CatHelpRequestParameters, CatHelpRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatHelpAsync<T>(Func<CatHelpRequestParameters, CatHelpRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/indices 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatIndices<T>(Func<CatIndicesRequestParameters, CatIndicesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/indices"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/indices 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatIndicesAsync<T>(Func<CatIndicesRequestParameters, CatIndicesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/indices"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/indices/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatIndices<T>(string index, Func<CatIndicesRequestParameters, CatIndicesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/indices/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/indices/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatIndicesAsync<T>(string index, Func<CatIndicesRequestParameters, CatIndicesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/indices/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/master 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-master.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatMaster<T>(Func<CatMasterRequestParameters, CatMasterRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/master"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/master 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-master.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatMasterAsync<T>(Func<CatMasterRequestParameters, CatMasterRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/master"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/nodeattrs 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodeattrs.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatNodeattrs<T>(Func<CatNodeattrsRequestParameters, CatNodeattrsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/nodeattrs"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/nodeattrs 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodeattrs.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatNodeattrsAsync<T>(Func<CatNodeattrsRequestParameters, CatNodeattrsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/nodeattrs"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/nodes 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatNodes<T>(Func<CatNodesRequestParameters, CatNodesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/nodes"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/nodes 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatNodesAsync<T>(Func<CatNodesRequestParameters, CatNodesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/nodes"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/pending_tasks 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-pending-tasks.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatPendingTasks<T>(Func<CatPendingTasksRequestParameters, CatPendingTasksRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/pending_tasks"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/pending_tasks 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-pending-tasks.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatPendingTasksAsync<T>(Func<CatPendingTasksRequestParameters, CatPendingTasksRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/pending_tasks"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/plugins 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-plugins.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatPlugins<T>(Func<CatPluginsRequestParameters, CatPluginsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/plugins"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/plugins 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-plugins.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatPluginsAsync<T>(Func<CatPluginsRequestParameters, CatPluginsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/plugins"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/recovery 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatRecovery<T>(Func<CatRecoveryRequestParameters, CatRecoveryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/recovery"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/recovery 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatRecoveryAsync<T>(Func<CatRecoveryRequestParameters, CatRecoveryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/recovery"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/recovery/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatRecovery<T>(string index, Func<CatRecoveryRequestParameters, CatRecoveryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/recovery/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/recovery/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatRecoveryAsync<T>(string index, Func<CatRecoveryRequestParameters, CatRecoveryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/recovery/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/segments 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-segments.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatSegments<T>(Func<CatSegmentsRequestParameters, CatSegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/segments"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/segments 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-segments.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatSegmentsAsync<T>(Func<CatSegmentsRequestParameters, CatSegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/segments"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/segments/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-segments.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatSegments<T>(string index, Func<CatSegmentsRequestParameters, CatSegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/segments/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/segments/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-segments.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatSegmentsAsync<T>(string index, Func<CatSegmentsRequestParameters, CatSegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/segments/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatShards<T>(Func<CatShardsRequestParameters, CatShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/shards"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatShardsAsync<T>(Func<CatShardsRequestParameters, CatShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/shards"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/shards/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatShards<T>(string index, Func<CatShardsRequestParameters, CatShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/shards/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/shards/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to limit the returned information</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatShardsAsync<T>(string index, Func<CatShardsRequestParameters, CatShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/shards/{index.NotNull("index")}"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/thread_pool 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-thread-pool.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CatThreadPool<T>(Func<CatThreadPoolRequestParameters, CatThreadPoolRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cat/thread_pool"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a GET on /_cat/thread_pool 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-thread-pool.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CatThreadPoolAsync<T>(Func<CatThreadPoolRequestParameters, CatThreadPoolRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cat/thread_pool"), null, _params(requestParameters, contentType: "text/plain"));
		
		///<summary>Represents a DELETE on /_search/scroll/{scroll_id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
		///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClearScroll<T>(string scroll_id, PostData<object> body, Func<ClearScrollRequestParameters, ClearScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_search/scroll/{scroll_id.NotNull("scroll_id")}"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_search/scroll/{scroll_id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
		///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClearScrollAsync<T>(string scroll_id, PostData<object> body, Func<ClearScrollRequestParameters, ClearScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_search/scroll/{scroll_id.NotNull("scroll_id")}"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_search/scroll 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClearScroll<T>(PostData<object> body, Func<ClearScrollRequestParameters, ClearScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_search/scroll"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_search/scroll 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClearScrollAsync<T>(PostData<object> body, Func<ClearScrollRequestParameters, ClearScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_search/scroll"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/settings 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-update-settings.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterGetSettings<T>(Func<ClusterGetSettingsRequestParameters, ClusterGetSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/settings"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/settings 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-update-settings.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterGetSettingsAsync<T>(Func<ClusterGetSettingsRequestParameters, ClusterGetSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/settings"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/health 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterHealth<T>(Func<ClusterHealthRequestParameters, ClusterHealthRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/health"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/health 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterHealthAsync<T>(Func<ClusterHealthRequestParameters, ClusterHealthRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/health"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/health/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html</para>	
	    ///</summary>
		///<param name="index">Limit the information returned to a specific index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterHealth<T>(string index, Func<ClusterHealthRequestParameters, ClusterHealthRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/health/{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/health/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html</para>	
	    ///</summary>
		///<param name="index">Limit the information returned to a specific index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterHealthAsync<T>(string index, Func<ClusterHealthRequestParameters, ClusterHealthRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/health/{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/pending_tasks 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-pending.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterPendingTasks<T>(Func<ClusterPendingTasksRequestParameters, ClusterPendingTasksRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/pending_tasks"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/pending_tasks 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-pending.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterPendingTasksAsync<T>(Func<ClusterPendingTasksRequestParameters, ClusterPendingTasksRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/pending_tasks"), null, _params(requestParameters));
		
		///<summary>Represents a PUT on /_cluster/settings 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-update-settings.html</para>	
	    ///</summary>
		///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterPutSettings<T>(PostData<object> body, Func<ClusterSettingsRequestParameters, ClusterSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_cluster/settings"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_cluster/settings 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-update-settings.html</para>	
	    ///</summary>
		///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterPutSettingsAsync<T>(PostData<object> body, Func<ClusterSettingsRequestParameters, ClusterSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_cluster/settings"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_cluster/reroute 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-reroute.html</para>	
	    ///</summary>
		///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterReroute<T>(PostData<object> body, Func<ClusterRerouteRequestParameters, ClusterRerouteRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_cluster/reroute"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_cluster/reroute 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-reroute.html</para>	
	    ///</summary>
		///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterRerouteAsync<T>(PostData<object> body, Func<ClusterRerouteRequestParameters, ClusterRerouteRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_cluster/reroute"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/state 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-state.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterState<T>(Func<ClusterStateRequestParameters, ClusterStateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/state"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/state 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-state.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterStateAsync<T>(Func<ClusterStateRequestParameters, ClusterStateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/state"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/state/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-state.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterState<T>(string metric, Func<ClusterStateRequestParameters, ClusterStateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/state/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/state/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-state.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterStateAsync<T>(string metric, Func<ClusterStateRequestParameters, ClusterStateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/state/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/state/{metric}/{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-state.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterState<T>(string metric, string index, Func<ClusterStateRequestParameters, ClusterStateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/state/{metric.NotNull("metric")}/{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/state/{metric}/{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-state.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterStateAsync<T>(string metric, string index, Func<ClusterStateRequestParameters, ClusterStateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/state/{metric.NotNull("metric")}/{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterStats<T>(Func<ClusterStatsRequestParameters, ClusterStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterStatsAsync<T>(Func<ClusterStatsRequestParameters, ClusterStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/stats/nodes/{node_id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ClusterStats<T>(string node_id, Func<ClusterStatsRequestParameters, ClusterStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/stats/nodes/{node_id.NotNull("node_id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/stats/nodes/{node_id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ClusterStatsAsync<T>(string node_id, Func<ClusterStatsRequestParameters, ClusterStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/stats/nodes/{node_id.NotNull("node_id")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Count<T>(PostData<object> body, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountAsync<T>(PostData<object> body, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Count<T>(string index, PostData<object> body, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountAsync<T>(string index, PostData<object> body, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Count<T>(string index, string type, PostData<object> body, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountAsync<T>(string index, string type, PostData<object> body, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_count"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountGet<T>(Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountGetAsync<T>(Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountGet<T>(string index, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountGetAsync<T>(string index, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountGet<T>(string index, string type, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-count.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountGetAsync<T>(string index, string type, Func<CountRequestParameters, CountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_percolate/count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountPercolateGet<T>(string index, string type, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate/count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_percolate/count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountPercolateGetAsync<T>(string index, string type, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate/count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_percolate/count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountPercolateGet<T>(string index, string type, string id, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate/count"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_percolate/count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountPercolateGetAsync<T>(string index, string type, string id, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate/count"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_percolate/count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="body">The count percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountPercolate<T>(string index, string type, PostData<object> body, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate/count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_percolate/count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="body">The count percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountPercolateAsync<T>(string index, string type, PostData<object> body, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate/count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_percolate/count 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="body">The count percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> CountPercolate<T>(string index, string type, string id, PostData<object> body, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate/count"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_percolate/count 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated.</param>
		///<param name="type">The type of the document being count percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="body">The count percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> CountPercolateAsync<T>(string index, string type, string id, PostData<object> body, Func<PercolateCountRequestParameters, PercolateCountRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate/count"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/{type}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-delete.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Delete<T>(string index, string type, string id, Func<DeleteRequestParameters, DeleteRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a DELETE on /{index}/{type}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-delete.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> DeleteAsync<T>(string index, string type, string id, Func<DeleteRequestParameters, DeleteRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a DELETE on /{index}/_query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: https://www.elastic.co/guide/en/elasticsearch/plugins/2.0/plugins-delete-by-query.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="body">A query to restrict the operation specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> DeleteByQuery<T>(string index, PostData<object> body, Func<DeleteByQueryRequestParameters, DeleteByQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"{index.NotNull("index")}/_query"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/_query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: https://www.elastic.co/guide/en/elasticsearch/plugins/2.0/plugins-delete-by-query.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="body">A query to restrict the operation specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> DeleteByQueryAsync<T>(string index, PostData<object> body, Func<DeleteByQueryRequestParameters, DeleteByQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"{index.NotNull("index")}/_query"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/{type}/_query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: https://www.elastic.co/guide/en/elasticsearch/plugins/2.0/plugins-delete-by-query.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of types to restrict the operation</param>
		///<param name="body">A query to restrict the operation specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> DeleteByQuery<T>(string index, string type, PostData<object> body, Func<DeleteByQueryRequestParameters, DeleteByQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_query"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/{type}/_query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: https://www.elastic.co/guide/en/elasticsearch/plugins/2.0/plugins-delete-by-query.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of types to restrict the operation</param>
		///<param name="body">A query to restrict the operation specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> DeleteByQueryAsync<T>(string index, string type, PostData<object> body, Func<DeleteByQueryRequestParameters, DeleteByQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_query"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_scripts/{lang}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> DeleteScript<T>(string lang, string id, Func<DeleteScriptRequestParameters, DeleteScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_scripts/{lang}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> DeleteScriptAsync<T>(string lang, string id, Func<DeleteScriptRequestParameters, DeleteScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_search/template/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> DeleteTemplate<T>(string id, Func<DeleteSearchTemplateRequestParameters, DeleteSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_search/template/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_search/template/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> DeleteTemplateAsync<T>(string id, Func<DeleteSearchTemplateRequestParameters, DeleteSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_search/template/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a HEAD on /{index}/{type}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Exists<T>(string index, string type, string id, Func<DocumentExistsRequestParameters, DocumentExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index}/{type}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ExistsAsync<T>(string index, string type, string id, Func<DocumentExistsRequestParameters, DocumentExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_explain 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ExplainGet<T>(string index, string type, string id, Func<ExplainRequestParameters, ExplainRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_explain"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_explain 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ExplainGetAsync<T>(string index, string type, string id, Func<ExplainRequestParameters, ExplainRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_explain"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_explain 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">The document ID</param>
		///<param name="body">The query definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Explain<T>(string index, string type, string id, PostData<object> body, Func<ExplainRequestParameters, ExplainRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_explain"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_explain 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">The document ID</param>
		///<param name="body">The query definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ExplainAsync<T>(string index, string type, string id, PostData<object> body, Func<ExplainRequestParameters, ExplainRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_explain"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_field_stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> FieldStatsGet<T>(Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_field_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_field_stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> FieldStatsGetAsync<T>(Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_field_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_field_stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> FieldStatsGet<T>(string index, Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_field_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_field_stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> FieldStatsGetAsync<T>(string index, Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_field_stats"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_field_stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> FieldStats<T>(PostData<object> body, Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_field_stats"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_field_stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> FieldStatsAsync<T>(PostData<object> body, Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_field_stats"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_field_stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> FieldStats<T>(string index, PostData<object> body, Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_field_stats"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_field_stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> FieldStatsAsync<T>(string index, PostData<object> body, Func<FieldStatsRequestParameters, FieldStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_field_stats"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Get<T>(string index, string type, string id, Func<GetRequestParameters, GetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /{index}/{type}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> GetAsync<T>(string index, string type, string id, Func<GetRequestParameters, GetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /_scripts/{lang}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> GetScript<T>(string lang, string id, Func<GetScriptRequestParameters, GetScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_scripts/{lang}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> GetScriptAsync<T>(string lang, string id, Func<GetScriptRequestParameters, GetScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_source 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document; use `_all` to fetch the first document matching the ID across all types</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> GetSource<T>(string index, string type, string id, Func<SourceRequestParameters, SourceRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_source"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_source 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document; use `_all` to fetch the first document matching the ID across all types</param>
		///<param name="id">The document ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> GetSourceAsync<T>(string index, string type, string id, Func<SourceRequestParameters, SourceRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_source"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/template/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> GetTemplate<T>(string id, Func<GetSearchTemplateRequestParameters, GetSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search/template/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/template/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> GetTemplateAsync<T>(string id, Func<GetSearchTemplateRequestParameters, GetSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search/template/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Index<T>(string index, string type, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndexAsync<T>(string index, string type, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">Document ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Index<T>(string index, string type, string id, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">Document ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndexAsync<T>(string index, string type, string id, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndexPut<T>(string index, string type, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndexPutAsync<T>(string index, string type, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">Document ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndexPut<T>(string index, string type, string id, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">Document ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndexPutAsync<T>(string index, string type, string id, PostData<object> body, Func<IndexRequestParameters, IndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_analyze 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesAnalyzeGetForAll<T>(Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_analyze"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_analyze 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesAnalyzeGetForAllAsync<T>(Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_analyze"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_analyze 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesAnalyzeGet<T>(string index, Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_analyze"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_analyze 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesAnalyzeGetAsync<T>(string index, Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_analyze"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_analyze 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="body">The text on which the analysis should be performed</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesAnalyzeForAll<T>(PostData<object> body, Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_analyze"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_analyze 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="body">The text on which the analysis should be performed</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesAnalyzeForAllAsync<T>(PostData<object> body, Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_analyze"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_analyze 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="body">The text on which the analysis should be performed</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesAnalyze<T>(string index, PostData<object> body, Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_analyze"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_analyze 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html</para>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="body">The text on which the analysis should be performed</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesAnalyzeAsync<T>(string index, PostData<object> body, Func<AnalyzeRequestParameters, AnalyzeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_analyze"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_cache/clear 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesClearCacheForAll<T>(Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_cache/clear 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesClearCacheForAllAsync<T>(Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_cache/clear 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesClearCache<T>(string index, Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_cache/clear 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesClearCacheAsync<T>(string index, Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cache/clear 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesClearCacheGetForAll<T>(Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cache/clear 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesClearCacheGetForAllAsync<T>(Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_cache/clear 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesClearCacheGet<T>(string index, Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_cache/clear 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesClearCacheGetAsync<T>(string index, Func<ClearCacheRequestParameters, ClearCacheRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_cache/clear"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_close 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-open-close.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesClose<T>(string index, Func<CloseIndexRequestParameters, CloseIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_close"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_close 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-open-close.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesCloseAsync<T>(string index, Func<CloseIndexRequestParameters, CloseIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_close"), null, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesCreate<T>(string index, PostData<object> body, Func<CreateIndexRequestParameters, CreateIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesCreateAsync<T>(string index, PostData<object> body, Func<CreateIndexRequestParameters, CreateIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesCreatePost<T>(string index, PostData<object> body, Func<CreateIndexRequestParameters, CreateIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesCreatePostAsync<T>(string index, PostData<object> body, Func<CreateIndexRequestParameters, CreateIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesDelete<T>(string index, Func<DeleteIndexRequestParameters, DeleteIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesDeleteAsync<T>(string index, Func<DeleteIndexRequestParameters, DeleteIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names (supports wildcards); use `_all` for all indices</param>
		///<param name="name">A comma-separated list of aliases to delete (supports wildcards); use `_all` to delete all aliases for the specified indices.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesDeleteAlias<T>(string index, string name, Func<DeleteAliasRequestParameters, DeleteAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names (supports wildcards); use `_all` for all indices</param>
		///<param name="name">A comma-separated list of aliases to delete (supports wildcards); use `_all` to delete all aliases for the specified indices.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesDeleteAliasAsync<T>(string index, string name, Func<DeleteAliasRequestParameters, DeleteAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_template/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesDeleteTemplateForAll<T>(string name, Func<DeleteIndexTemplateRequestParameters, DeleteIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_template/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_template/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesDeleteTemplateForAllAsync<T>(string name, Func<DeleteIndexTemplateRequestParameters, DeleteIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_template/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to delete warmers from (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name="name">A comma-separated list of warmer names to delete (supports wildcards); use `_all` to delete all warmers in the specified indices. You must specify a name either in the uri or in the parameters.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesDeleteWarmer<T>(string index, string name, Func<DeleteWarmerRequestParameters, DeleteWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /{index}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to delete warmers from (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name="name">A comma-separated list of warmer names to delete (supports wildcards); use `_all` to delete all warmers in the specified indices. You must specify a name either in the uri or in the parameters.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesDeleteWarmerAsync<T>(string index, string name, Func<DeleteWarmerRequestParameters, DeleteWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a HEAD on /{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to check</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesExists<T>(string index, Func<IndexExistsRequestParameters, IndexExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"{index.NotNull("index")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to check</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesExistsAsync<T>(string index, Func<IndexExistsRequestParameters, IndexExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"{index.NotNull("index")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesExistsAliasForAll<T>(string name, Func<AliasExistsRequestParameters, AliasExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"_alias/{name.NotNull("name")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesExistsAliasForAllAsync<T>(string name, Func<AliasExistsRequestParameters, AliasExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"_alias/{name.NotNull("name")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index}/_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesExistsAlias<T>(string index, string name, Func<AliasExistsRequestParameters, AliasExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index}/_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesExistsAliasAsync<T>(string index, string name, Func<AliasExistsRequestParameters, AliasExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index}/_alias 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesExistsAlias<T>(string index, Func<AliasExistsRequestParameters, AliasExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"{index.NotNull("index")}/_alias"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index}/_alias 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesExistsAliasAsync<T>(string index, Func<AliasExistsRequestParameters, AliasExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"{index.NotNull("index")}/_alias"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /_template/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesExistsTemplateForAll<T>(string name, Func<IndexTemplateExistsRequestParameters, IndexTemplateExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"_template/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a HEAD on /_template/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesExistsTemplateForAllAsync<T>(string name, Func<IndexTemplateExistsRequestParameters, IndexTemplateExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"_template/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a HEAD on /{index}/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-types-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
		///<param name="type">A comma-separated list of document types to check</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesExistsType<T>(string index, string type, Func<TypeExistsRequestParameters, TypeExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($"{index.NotNull("index")}/{type.NotNull("type")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a HEAD on /{index}/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-types-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
		///<param name="type">A comma-separated list of document types to check</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesExistsTypeAsync<T>(string index, string type, Func<TypeExistsRequestParameters, TypeExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($"{index.NotNull("index")}/{type.NotNull("type")}"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a POST on /_flush 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushForAll<T>(Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_flush"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_flush 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushForAllAsync<T>(Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_flush"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_flush 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlush<T>(string index, Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_flush"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_flush 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushAsync<T>(string index, Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_flush"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_flush 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushGetForAll<T>(Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_flush"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_flush 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushGetForAllAsync<T>(Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_flush"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_flush 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushGet<T>(string index, Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_flush"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_flush 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushGetAsync<T>(string index, Func<FlushRequestParameters, FlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_flush"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_flush/synced 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushSyncedForAll<T>(Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_flush/synced 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushSyncedForAllAsync<T>(Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_flush/synced 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushSynced<T>(string index, Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_flush/synced 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushSyncedAsync<T>(string index, Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_flush/synced 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushSyncedGetForAll<T>(Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_flush/synced 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushSyncedGetForAllAsync<T>(Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_flush/synced 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesFlushSyncedGet<T>(string index, Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_flush/synced 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-synced-flush.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesFlushSyncedGetAsync<T>(string index, Func<SyncedFlushRequestParameters, SyncedFlushRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_flush/synced"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGet<T>(string index, Func<GetIndexRequestParameters, GetIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAsync<T>(string index, Func<GetIndexRequestParameters, GetIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{feature} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="feature">A comma-separated list of features</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGet<T>(string index, string feature, Func<GetIndexRequestParameters, GetIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{feature.NotNull("feature")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{feature} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="feature">A comma-separated list of features</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAsync<T>(string index, string feature, Func<GetIndexRequestParameters, GetIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{feature.NotNull("feature")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_alias 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAliasForAll<T>(Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_alias"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_alias 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasForAllAsync<T>(Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_alias"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAliasForAll<T>(string name, Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_alias/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasForAllAsync<T>(string name, Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_alias/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAlias<T>(string index, string name, Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasAsync<T>(string index, string name, Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_alias 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAlias<T>(string index, Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_alias"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_alias 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasAsync<T>(string index, Func<GetAliasRequestParameters, GetAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_alias"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_aliases 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAliasesForAll<T>(Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_aliases"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_aliases 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasesForAllAsync<T>(Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_aliases"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_aliases 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAliases<T>(string index, Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_aliases"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_aliases 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasesAsync<T>(string index, Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_aliases"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_aliases/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to filter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAliases<T>(string index, string name, Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_aliases/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_aliases/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to filter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasesAsync<T>(string index, string name, Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_aliases/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_aliases/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to filter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetAliasesForAll<T>(string name, Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_aliases/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_aliases/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to filter</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetAliasesForAllAsync<T>(string name, Func<GetAliasesRequestParameters, GetAliasesRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_aliases/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping/field/{fields} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetFieldMappingForAll<T>(string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mapping/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping/field/{fields} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetFieldMappingForAllAsync<T>(string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mapping/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping/field/{fields} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetFieldMapping<T>(string index, string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mapping/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping/field/{fields} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetFieldMappingAsync<T>(string index, string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mapping/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping/{type}/field/{fields} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetFieldMappingForAll<T>(string type, string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mapping/{type.NotNull("type")}/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping/{type}/field/{fields} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetFieldMappingForAllAsync<T>(string type, string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mapping/{type.NotNull("type")}/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping/{type}/field/{fields} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetFieldMapping<T>(string index, string type, string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mapping/{type.NotNull("type")}/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping/{type}/field/{fields} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="fields">A comma-separated list of fields</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetFieldMappingAsync<T>(string index, string type, string fields, Func<GetFieldMappingRequestParameters, GetFieldMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mapping/{type.NotNull("type")}/field/{fields.NotNull("fields")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetMappingForAll<T>(Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mapping"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetMappingForAllAsync<T>(Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mapping"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetMapping<T>(string index, Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mapping"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetMappingAsync<T>(string index, Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mapping"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetMappingForAll<T>(string type, Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mapping/{type.NotNull("type")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mapping/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetMappingForAllAsync<T>(string type, Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mapping/{type.NotNull("type")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetMapping<T>(string index, string type, Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mapping/{type.NotNull("type")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mapping/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetMappingAsync<T>(string index, string type, Func<GetMappingRequestParameters, GetMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mapping/{type.NotNull("type")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_settings 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetSettingsForAll<T>(Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_settings"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_settings 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetSettingsForAllAsync<T>(Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_settings"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_settings 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetSettings<T>(string index, Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_settings"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_settings 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetSettingsAsync<T>(string index, Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_settings"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_settings/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the settings that should be included</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetSettings<T>(string index, string name, Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_settings/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_settings/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the settings that should be included</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetSettingsAsync<T>(string index, string name, Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_settings/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_settings/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="name">The name of the settings that should be included</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetSettingsForAll<T>(string name, Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_settings/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_settings/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html</para>	
	    ///</summary>
		///<param name="name">The name of the settings that should be included</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetSettingsForAllAsync<T>(string name, Func<GetIndexSettingsRequestParameters, GetIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_settings/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetTemplateForAll<T>(Func<GetIndexTemplateRequestParameters, GetIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetTemplateForAllAsync<T>(Func<GetIndexTemplateRequestParameters, GetIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_template/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetTemplateForAll<T>(string name, Func<GetIndexTemplateRequestParameters, GetIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_template/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_template/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetTemplateForAllAsync<T>(string name, Func<GetIndexTemplateRequestParameters, GetIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_template/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_upgrade 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetUpgradeForAll<T>(Func<UpgradeStatusRequestParameters, UpgradeStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_upgrade 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetUpgradeForAllAsync<T>(Func<UpgradeStatusRequestParameters, UpgradeStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_upgrade 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetUpgrade<T>(string index, Func<UpgradeStatusRequestParameters, UpgradeStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_upgrade 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetUpgradeAsync<T>(string index, Func<UpgradeStatusRequestParameters, UpgradeStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_warmer 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetWarmerForAll<T>(Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_warmer"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_warmer 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetWarmerForAllAsync<T>(Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_warmer"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_warmer 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetWarmer<T>(string index, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_warmer"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_warmer 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetWarmerAsync<T>(string index, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_warmer"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetWarmer<T>(string index, string name, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetWarmerAsync<T>(string index, string name, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetWarmerForAll<T>(string name, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetWarmerForAllAsync<T>(string name, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesGetWarmer<T>(string index, string type, string name, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesGetWarmerAsync<T>(string index, string type, string name, Func<GetWarmerRequestParameters, GetWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_warmer/{name.NotNull("name")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_open 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-open-close.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesOpen<T>(string index, Func<OpenIndexRequestParameters, OpenIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_open"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_open 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-open-close.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesOpenAsync<T>(string index, Func<OpenIndexRequestParameters, OpenIndexRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_open"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_optimize 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesOptimizeForAll<T>(Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_optimize 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesOptimizeForAllAsync<T>(Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_optimize 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesOptimize<T>(string index, Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_optimize 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesOptimizeAsync<T>(string index, Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_optimize 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesOptimizeGetForAll<T>(Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_optimize 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesOptimizeGetForAllAsync<T>(Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_optimize 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesOptimizeGet<T>(string index, Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_optimize 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesOptimizeGetAsync<T>(string index, Func<OptimizeRequestParameters, OptimizeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_optimize"), null, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutAlias<T>(string index, string name, PostData<object> body, Func<PutAliasRequestParameters, PutAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutAliasAsync<T>(string index, string name, PostData<object> body, Func<PutAliasRequestParameters, PutAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_alias/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutAliasPost<T>(string index, string name, PostData<object> body, Func<PutAliasRequestParameters, PutAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_alias/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutAliasPostAsync<T>(string index, string name, PostData<object> body, Func<PutAliasRequestParameters, PutAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_alias/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/_mapping 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutMapping<T>(string index, string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mapping"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/_mapping 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutMappingAsync<T>(string index, string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mapping"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_mapping/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutMappingForAll<T>(string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_mapping/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_mapping/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutMappingForAllAsync<T>(string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_mapping/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mapping 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutMappingPost<T>(string index, string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mapping"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mapping 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutMappingPostAsync<T>(string index, string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mapping"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_mapping/{type} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutMappingPostForAll<T>(string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_mapping/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_mapping/{type} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html</para>	
	    ///</summary>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutMappingPostForAllAsync<T>(string type, PostData<object> body, Func<PutMappingRequestParameters, PutMappingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_mapping/{type.NotNull("type")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_settings 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html</para>	
	    ///</summary>
		///<param name="body">The index settings to be updated</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutSettingsForAll<T>(PostData<object> body, Func<UpdateIndexSettingsRequestParameters, UpdateIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_settings"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_settings 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html</para>	
	    ///</summary>
		///<param name="body">The index settings to be updated</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutSettingsForAllAsync<T>(PostData<object> body, Func<UpdateIndexSettingsRequestParameters, UpdateIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_settings"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_settings 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The index settings to be updated</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutSettings<T>(string index, PostData<object> body, Func<UpdateIndexSettingsRequestParameters, UpdateIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/_settings"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_settings 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The index settings to be updated</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutSettingsAsync<T>(string index, PostData<object> body, Func<UpdateIndexSettingsRequestParameters, UpdateIndexSettingsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/_settings"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_template/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutTemplateForAll<T>(string name, PostData<object> body, Func<PutIndexTemplateRequestParameters, PutIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_template/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_template/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutTemplateForAllAsync<T>(string name, PostData<object> body, Func<PutIndexTemplateRequestParameters, PutIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_template/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_template/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutTemplatePostForAll<T>(string name, PostData<object> body, Func<PutIndexTemplateRequestParameters, PutIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_template/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_template/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html</para>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutTemplatePostForAllAsync<T>(string name, PostData<object> body, Func<PutIndexTemplateRequestParameters, PutIndexTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_template/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutWarmerForAll<T>(string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutWarmerForAllAsync<T>(string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutWarmer<T>(string index, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutWarmerAsync<T>(string index, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutWarmer<T>(string index, string type, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /{index}/{type}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutWarmerAsync<T>(string index, string type, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutWarmerPostForAll<T>(string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutWarmerPostForAllAsync<T>(string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutWarmerPost<T>(string index, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutWarmerPostAsync<T>(string index, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_warmer/{name} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesPutWarmerPost<T>(string index, string type, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_warmer/{name} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesPutWarmerPostAsync<T>(string index, string type, string name, PostData<object> body, Func<PutWarmerRequestParameters, PutWarmerRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_warmer/{name.NotNull("name")}"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_recovery 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesRecoveryForAll<T>(Func<RecoveryStatusRequestParameters, RecoveryStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_recovery"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_recovery 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesRecoveryForAllAsync<T>(Func<RecoveryStatusRequestParameters, RecoveryStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_recovery"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_recovery 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesRecovery<T>(string index, Func<RecoveryStatusRequestParameters, RecoveryStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_recovery"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_recovery 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesRecoveryAsync<T>(string index, Func<RecoveryStatusRequestParameters, RecoveryStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_recovery"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_refresh 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesRefreshForAll<T>(Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_refresh 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesRefreshForAllAsync<T>(Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_refresh 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesRefresh<T>(string index, Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_refresh 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesRefreshAsync<T>(string index, Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_refresh 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesRefreshGetForAll<T>(Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_refresh 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesRefreshGetForAllAsync<T>(Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_refresh 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesRefreshGet<T>(string index, Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_refresh 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesRefreshGetAsync<T>(string index, Func<RefreshRequestParameters, RefreshRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_refresh"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_segments 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesSegmentsForAll<T>(Func<SegmentsRequestParameters, SegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_segments"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_segments 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesSegmentsForAllAsync<T>(Func<SegmentsRequestParameters, SegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_segments"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_segments 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesSegments<T>(string index, Func<SegmentsRequestParameters, SegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_segments"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_segments 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesSegmentsAsync<T>(string index, Func<SegmentsRequestParameters, SegmentsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_segments"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_shard_stores 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesShardStoresForAll<T>(Func<IndicesShardStoresRequestParameters, IndicesShardStoresRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_shard_stores"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_shard_stores 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesShardStoresForAllAsync<T>(Func<IndicesShardStoresRequestParameters, IndicesShardStoresRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_shard_stores"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_shard_stores 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesShardStores<T>(string index, Func<IndicesShardStoresRequestParameters, IndicesShardStoresRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_shard_stores"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_shard_stores 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesShardStoresAsync<T>(string index, Func<IndicesShardStoresRequestParameters, IndicesShardStoresRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_shard_stores"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesStatsForAll<T>(Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesStatsForAllAsync<T>(Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_stats/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned the specific metrics.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesStatsForAll<T>(string metric, Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_stats/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned the specific metrics.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesStatsForAllAsync<T>(string metric, Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesStats<T>(string index, Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesStatsAsync<T>(string index, Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_stats/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="metric">Limit the information returned the specific metrics.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesStats<T>(string index, string metric, Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_stats/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="metric">Limit the information returned the specific metrics.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesStatsAsync<T>(string index, string metric, Func<IndicesStatsRequestParameters, IndicesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_aliases 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="body">The definition of `actions` to perform</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesUpdateAliasesForAll<T>(PostData<object> body, Func<BulkAliasRequestParameters, BulkAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_aliases"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_aliases 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html</para>	
	    ///</summary>
		///<param name="body">The definition of `actions` to perform</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesUpdateAliasesForAllAsync<T>(PostData<object> body, Func<BulkAliasRequestParameters, BulkAliasRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_aliases"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_upgrade 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesUpgradeForAll<T>(Func<UpgradeRequestParameters, UpgradeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_upgrade 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesUpgradeForAllAsync<T>(Func<UpgradeRequestParameters, UpgradeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_upgrade 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesUpgrade<T>(string index, Func<UpgradeRequestParameters, UpgradeRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_upgrade 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesUpgradeAsync<T>(string index, Func<UpgradeRequestParameters, UpgradeRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_upgrade"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_validate/query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesValidateQueryGetForAll<T>(Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_validate/query"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_validate/query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesValidateQueryGetForAllAsync<T>(Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_validate/query"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_validate/query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesValidateQueryGet<T>(string index, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_validate/query"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_validate/query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesValidateQueryGetAsync<T>(string index, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_validate/query"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_validate/query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesValidateQueryGet<T>(string index, string type, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_validate/query"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_validate/query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesValidateQueryGetAsync<T>(string index, string type, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_validate/query"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_validate/query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="body">The query definition specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesValidateQueryForAll<T>(PostData<object> body, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_validate/query"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_validate/query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="body">The query definition specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesValidateQueryForAllAsync<T>(PostData<object> body, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_validate/query"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_validate/query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The query definition specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesValidateQuery<T>(string index, PostData<object> body, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_validate/query"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_validate/query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The query definition specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesValidateQueryAsync<T>(string index, PostData<object> body, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_validate/query"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_validate/query 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="body">The query definition specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> IndicesValidateQuery<T>(string index, string type, PostData<object> body, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_validate/query"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_validate/query 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="body">The query definition specified with the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> IndicesValidateQueryAsync<T>(string index, string type, PostData<object> body, Func<ValidateQueryRequestParameters, ValidateQueryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_validate/query"), body, _params(requestParameters));
		
		///<summary>Represents a GET on / 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Info<T>(Func<InfoRequestParameters, InfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($""), null, _params(requestParameters));
		
		///<summary>Represents a GET on / 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> InfoAsync<T>(Func<InfoRequestParameters, InfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($""), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mget 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MgetGet<T>(Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mget"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mget 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MgetGetAsync<T>(Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mget"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mget 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MgetGet<T>(string index, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mget"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mget 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MgetGetAsync<T>(string index, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mget"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_mget 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MgetGet<T>(string index, string type, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mget"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_mget 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MgetGetAsync<T>(string index, string type, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mget"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_mget 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mget<T>(PostData<object> body, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_mget"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_mget 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MgetAsync<T>(PostData<object> body, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_mget"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_mget 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mget<T>(string index, PostData<object> body, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_mget"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_mget 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MgetAsync<T>(string index, PostData<object> body, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_mget"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mget 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mget<T>(string index, string type, PostData<object> body, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mget"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mget 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MgetAsync<T>(string index, string type, PostData<object> body, Func<MultiGetRequestParameters, MultiGetRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mget"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_mpercolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MpercolateGet<T>(Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mpercolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mpercolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MpercolateGetAsync<T>(Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mpercolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mpercolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MpercolateGet<T>(string index, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mpercolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mpercolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MpercolateGetAsync<T>(string index, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mpercolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_mpercolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="type">The type of the document being percolated to use as default.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MpercolateGet<T>(string index, string type, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mpercolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_mpercolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="type">The type of the document being percolated to use as default.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MpercolateGetAsync<T>(string index, string type, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mpercolate"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_mpercolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="body">The percolate request definitions (header &amp; body pair), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mpercolate<T>(PostData<object> body, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_mpercolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_mpercolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="body">The percolate request definitions (header &amp; body pair), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MpercolateAsync<T>(PostData<object> body, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_mpercolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_mpercolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="body">The percolate request definitions (header &amp; body pair), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mpercolate<T>(string index, PostData<object> body, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_mpercolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_mpercolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="body">The percolate request definitions (header &amp; body pair), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MpercolateAsync<T>(string index, PostData<object> body, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_mpercolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mpercolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="type">The type of the document being percolated to use as default.</param>
		///<param name="body">The percolate request definitions (header &amp; body pair), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mpercolate<T>(string index, string type, PostData<object> body, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mpercolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mpercolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being count percolated to use as default</param>
		///<param name="type">The type of the document being percolated to use as default.</param>
		///<param name="body">The percolate request definitions (header &amp; body pair), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MpercolateAsync<T>(string index, string type, PostData<object> body, Func<MultiPercolateRequestParameters, MultiPercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mpercolate"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_msearch 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MsearchGet<T>(Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_msearch"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_msearch 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MsearchGetAsync<T>(Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_msearch"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_msearch 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MsearchGet<T>(string index, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_msearch"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_msearch 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MsearchGetAsync<T>(string index, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_msearch"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_msearch 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MsearchGet<T>(string index, string type, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_msearch"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_msearch 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MsearchGetAsync<T>(string index, string type, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_msearch"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_msearch 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Msearch<T>(PostData<object> body, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_msearch"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_msearch 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MsearchAsync<T>(PostData<object> body, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_msearch"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_msearch 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Msearch<T>(string index, PostData<object> body, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_msearch"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_msearch 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MsearchAsync<T>(string index, PostData<object> body, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_msearch"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_msearch 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Msearch<T>(string index, string type, PostData<object> body, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_msearch"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_msearch 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MsearchAsync<T>(string index, string type, PostData<object> body, Func<MultiSearchRequestParameters, MultiSearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_msearch"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_mtermvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MtermvectorsGet<T>(Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_mtermvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_mtermvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MtermvectorsGetAsync<T>(Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_mtermvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mtermvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MtermvectorsGet<T>(string index, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_mtermvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_mtermvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MtermvectorsGetAsync<T>(string index, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_mtermvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_mtermvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> MtermvectorsGet<T>(string index, string type, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mtermvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_mtermvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MtermvectorsGetAsync<T>(string index, string type, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mtermvectors"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_mtermvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mtermvectors<T>(PostData<object> body, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_mtermvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_mtermvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MtermvectorsAsync<T>(PostData<object> body, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_mtermvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_mtermvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mtermvectors<T>(string index, PostData<object> body, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_mtermvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_mtermvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MtermvectorsAsync<T>(string index, PostData<object> body, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_mtermvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mtermvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Mtermvectors<T>(string index, string type, PostData<object> body, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mtermvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_mtermvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> MtermvectorsAsync<T>(string index, string type, PostData<object> body, Func<MultiTermVectorsRequestParameters, MultiTermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_mtermvectors"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/nodes/hotthreads 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesHotThreadsForAll<T>(Func<NodesHotThreadsRequestParameters, NodesHotThreadsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/nodes/hotthreads"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/nodes/hotthreads 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesHotThreadsForAllAsync<T>(Func<NodesHotThreadsRequestParameters, NodesHotThreadsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/nodes/hotthreads"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/nodes/{node_id}/hotthreads 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesHotThreads<T>(string node_id, Func<NodesHotThreadsRequestParameters, NodesHotThreadsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_cluster/nodes/{node_id.NotNull("node_id")}/hotthreads"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_cluster/nodes/{node_id}/hotthreads 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesHotThreadsAsync<T>(string node_id, Func<NodesHotThreadsRequestParameters, NodesHotThreadsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_cluster/nodes/{node_id.NotNull("node_id")}/hotthreads"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesInfoForAll<T>(Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesInfoForAllAsync<T>(Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesInfo<T>(string node_id, Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesInfoAsync<T>(string node_id, Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="metric">A comma-separated list of metrics you wish returned. Leave empty to return all.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesInfoForAll<T>(string metric, Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="metric">A comma-separated list of metrics you wish returned. Leave empty to return all.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesInfoForAllAsync<T>(string metric, Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="metric">A comma-separated list of metrics you wish returned. Leave empty to return all.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesInfo<T>(string node_id, string metric, Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="metric">A comma-separated list of metrics you wish returned. Leave empty to return all.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesInfoAsync<T>(string node_id, string metric, Func<NodesInfoRequestParameters, NodesInfoRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesStatsForAll<T>(Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesStatsForAllAsync<T>(Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/stats 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesStats<T>(string node_id, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/stats 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesStatsAsync<T>(string node_id, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/stats"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/stats/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesStatsForAll<T>(string metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/stats/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesStatsForAllAsync<T>(string metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/stats/{metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesStats<T>(string node_id, string metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/stats/{metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesStatsAsync<T>(string node_id, string metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/stats/{metric.NotNull("metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/stats/{metric}/{index_metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="index_metric">Limit the information returned for `indices` metric to the specific index metrics. Isn&#39;t used if `indices` (or `all`) metric isn&#39;t specified.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesStatsForAll<T>(string metric, string index_metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/stats/{metric.NotNull("metric")}/{index_metric.NotNull("index_metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/stats/{metric}/{index_metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="index_metric">Limit the information returned for `indices` metric to the specific index metrics. Isn&#39;t used if `indices` (or `all`) metric isn&#39;t specified.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesStatsForAllAsync<T>(string metric, string index_metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/stats/{metric.NotNull("metric")}/{index_metric.NotNull("index_metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/stats/{metric}/{index_metric} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="index_metric">Limit the information returned for `indices` metric to the specific index metrics. Isn&#39;t used if `indices` (or `all`) metric isn&#39;t specified.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> NodesStats<T>(string node_id, string metric, string index_metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/stats/{metric.NotNull("metric")}/{index_metric.NotNull("index_metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_nodes/{node_id}/stats/{metric}/{index_metric} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</para>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		///<param name="metric">Limit the information returned to the specified metrics</param>
		///<param name="index_metric">Limit the information returned for `indices` metric to the specific index metrics. Isn&#39;t used if `indices` (or `all`) metric isn&#39;t specified.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> NodesStatsAsync<T>(string node_id, string metric, string index_metric, Func<NodesStatsRequestParameters, NodesStatsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_nodes/{node_id.NotNull("node_id")}/stats/{metric.NotNull("metric")}/{index_metric.NotNull("index_metric")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_percolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> PercolateGet<T>(string index, string type, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_percolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PercolateGetAsync<T>(string index, string type, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_percolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> PercolateGet<T>(string index, string type, string id, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_percolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PercolateGetAsync<T>(string index, string type, string id, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_percolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="body">The percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Percolate<T>(string index, string type, PostData<object> body, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_percolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="body">The percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PercolateAsync<T>(string index, string type, PostData<object> body, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_percolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_percolate 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="body">The percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Percolate<T>(string index, string type, string id, PostData<object> body, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_percolate 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html</para>	
	    ///</summary>
		///<param name="index">The index of the document being percolated.</param>
		///<param name="type">The type of the document being percolated.</param>
		///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
		///<param name="body">The percolator request definition using the percolate DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PercolateAsync<T>(string index, string type, string id, PostData<object> body, Func<PercolateRequestParameters, PercolateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_percolate"), body, _params(requestParameters));
		
		///<summary>Represents a HEAD on / 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Ping<T>(Func<PingRequestParameters, PingRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(HEAD, Url($""), null, _params(requestParameters));
		
		///<summary>Represents a HEAD on / 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PingAsync<T>(Func<PingRequestParameters, PingRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(HEAD, Url($""), null, _params(requestParameters));
		
		///<summary>Represents a PUT on /_scripts/{lang}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> PutScript<T>(string lang, string id, PostData<object> body, Func<PutScriptRequestParameters, PutScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_scripts/{lang}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PutScriptAsync<T>(string lang, string id, PostData<object> body, Func<PutScriptRequestParameters, PutScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_scripts/{lang}/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> PutScriptPost<T>(string lang, string id, PostData<object> body, Func<PutScriptRequestParameters, PutScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_scripts/{lang}/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html</para>	
	    ///</summary>
		///<param name="lang">Script language</param>
		///<param name="id">Script ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PutScriptPostAsync<T>(string lang, string id, PostData<object> body, Func<PutScriptRequestParameters, PutScriptRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_scripts/{lang.NotNull("lang")}/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_search/template/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> PutTemplate<T>(string id, PostData<object> body, Func<PutSearchTemplateRequestParameters, PutSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_search/template/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_search/template/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PutTemplateAsync<T>(string id, PostData<object> body, Func<PutSearchTemplateRequestParameters, PutSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_search/template/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/template/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> PutTemplatePost<T>(string id, PostData<object> body, Func<PutSearchTemplateRequestParameters, PutSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search/template/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/template/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">Template ID</param>
		///<param name="body">The document</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> PutTemplatePostAsync<T>(string id, PostData<object> body, Func<PutSearchTemplateRequestParameters, PutSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search/template/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_render/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> RenderSearchTemplateGet<T>(Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_render/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_render/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> RenderSearchTemplateGetAsync<T>(Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_render/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_render/template/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">The id of the stored search template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> RenderSearchTemplateGet<T>(string id, Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_render/template/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_render/template/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">The id of the stored search template</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> RenderSearchTemplateGetAsync<T>(string id, Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_render/template/{id.NotNull("id")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_render/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> RenderSearchTemplate<T>(PostData<object> body, Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_render/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_render/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> RenderSearchTemplateAsync<T>(PostData<object> body, Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_render/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_render/template/{id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">The id of the stored search template</param>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> RenderSearchTemplate<T>(string id, PostData<object> body, Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_render/template/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_render/template/{id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html</para>	
	    ///</summary>
		///<param name="id">The id of the stored search template</param>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> RenderSearchTemplateAsync<T>(string id, PostData<object> body, Func<RenderSearchTemplateRequestParameters, RenderSearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_render/template/{id.NotNull("id")}"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/scroll 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ScrollGet<T>(Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search/scroll"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/scroll 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ScrollGetAsync<T>(Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search/scroll"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/scroll/{scroll_id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> ScrollGet<T>(string scroll_id, Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search/scroll/{scroll_id.NotNull("scroll_id")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/scroll/{scroll_id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ScrollGetAsync<T>(string scroll_id, Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search/scroll/{scroll_id.NotNull("scroll_id")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/scroll 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Scroll<T>(PostData<object> body, Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search/scroll"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/scroll 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ScrollAsync<T>(PostData<object> body, Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search/scroll"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/scroll/{scroll_id} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Scroll<T>(string scroll_id, PostData<object> body, Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search/scroll/{scroll_id.NotNull("scroll_id")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/scroll/{scroll_id} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html</para>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> ScrollAsync<T>(string scroll_id, PostData<object> body, Func<ScrollRequestParameters, ScrollRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search/scroll/{scroll_id.NotNull("scroll_id")}"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_search 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchGet<T>(Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchGetAsync<T>(Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_search 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchGet<T>(string index, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_search"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_search 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchGetAsync<T>(string index, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_search"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_search 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchGet<T>(string index, string type, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_search 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchGetAsync<T>(string index, string type, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_search 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="body">The search definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Search<T>(PostData<object> body, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="body">The search definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchAsync<T>(PostData<object> body, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_search 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Search<T>(string index, PostData<object> body, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_search"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_search 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchAsync<T>(string index, PostData<object> body, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_search"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_search 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Search<T>(string index, string type, PostData<object> body, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_search 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition using the Query DSL</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchAsync<T>(string index, string type, PostData<object> body, Func<SearchRequestParameters, SearchRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/exists 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchExists<T>(PostData<object> body, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search/exists"), body, _params(requestParameters, allow404: true));
		
		///<summary>Represents a POST on /_search/exists 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchExistsAsync<T>(PostData<object> body, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search/exists"), body, _params(requestParameters, allow404: true));
		
		///<summary>Represents a POST on /{index}/_search/exists 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchExists<T>(string index, PostData<object> body, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_search/exists"), body, _params(requestParameters, allow404: true));
		
		///<summary>Represents a POST on /{index}/_search/exists 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchExistsAsync<T>(string index, PostData<object> body, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_search/exists"), body, _params(requestParameters, allow404: true));
		
		///<summary>Represents a POST on /{index}/{type}/_search/exists 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchExists<T>(string index, string type, PostData<object> body, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/exists"), body, _params(requestParameters, allow404: true));
		
		///<summary>Represents a POST on /{index}/{type}/_search/exists 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchExistsAsync<T>(string index, string type, PostData<object> body, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/exists"), body, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /_search/exists 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchExistsGet<T>(Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search/exists"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /_search/exists 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchExistsGetAsync<T>(Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search/exists"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /{index}/_search/exists 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchExistsGet<T>(string index, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_search/exists"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /{index}/_search/exists 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchExistsGetAsync<T>(string index, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_search/exists"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /{index}/{type}/_search/exists 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchExistsGet<T>(string index, string type, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/exists"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /{index}/{type}/_search/exists 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-exists.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchExistsGetAsync<T>(string index, string type, Func<SearchExistsRequestParameters, SearchExistsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/exists"), null, _params(requestParameters, allow404: true));
		
		///<summary>Represents a GET on /_search_shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchShardsGet<T>(Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search_shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchShardsGetAsync<T>(Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_search_shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchShardsGet<T>(string index, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_search_shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchShardsGetAsync<T>(string index, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_search_shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchShardsGet<T>(string index, string type, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_search_shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchShardsGetAsync<T>(string index, string type, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_search_shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchShards<T>(Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_search_shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchShardsAsync<T>(Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_search_shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchShards<T>(string index, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_search_shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchShardsAsync<T>(string index, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_search_shards 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchShards<T>(string index, string type, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_search_shards 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchShardsAsync<T>(string index, string type, Func<SearchShardsRequestParameters, SearchShardsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search_shards"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchTemplateGet<T>(Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_search/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_search/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchTemplateGetAsync<T>(Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_search/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_search/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchTemplateGet<T>(string index, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_search/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_search/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchTemplateGetAsync<T>(string index, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_search/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_search/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchTemplateGet<T>(string index, string type, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/template"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_search/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchTemplateGetAsync<T>(string index, string type, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/template"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchTemplate<T>(PostData<object> body, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_search/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_search/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchTemplateAsync<T>(PostData<object> body, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_search/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_search/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchTemplate<T>(string index, PostData<object> body, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_search/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_search/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchTemplateAsync<T>(string index, PostData<object> body, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_search/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_search/template 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SearchTemplate<T>(string index, string type, PostData<object> body, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/template"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_search/template 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition template and its params</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SearchTemplateAsync<T>(string index, string type, PostData<object> body, Func<SearchTemplateRequestParameters, SearchTemplateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_search/template"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="body">The snapshot definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotCreate<T>(string repository, string snapshot, PostData<object> body, Func<SnapshotRequestParameters, SnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="body">The snapshot definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotCreateAsync<T>(string repository, string snapshot, PostData<object> body, Func<SnapshotRequestParameters, SnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="body">The snapshot definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotCreatePost<T>(string repository, string snapshot, PostData<object> body, Func<SnapshotRequestParameters, SnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="body">The snapshot definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotCreatePostAsync<T>(string repository, string snapshot, PostData<object> body, Func<SnapshotRequestParameters, SnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_snapshot/{repository} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="body">The repository definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotCreateRepository<T>(string repository, PostData<object> body, Func<CreateRepositoryRequestParameters, CreateRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(PUT, Url($"_snapshot/{repository.NotNull("repository")}"), body, _params(requestParameters));
		
		///<summary>Represents a PUT on /_snapshot/{repository} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="body">The repository definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotCreateRepositoryAsync<T>(string repository, PostData<object> body, Func<CreateRepositoryRequestParameters, CreateRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(PUT, Url($"_snapshot/{repository.NotNull("repository")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="body">The repository definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotCreateRepositoryPost<T>(string repository, PostData<object> body, Func<CreateRepositoryRequestParameters, CreateRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="body">The repository definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotCreateRepositoryPostAsync<T>(string repository, PostData<object> body, Func<CreateRepositoryRequestParameters, CreateRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}"), body, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotDelete<T>(string repository, string snapshot, Func<DeleteSnapshotRequestParameters, DeleteSnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotDeleteAsync<T>(string repository, string snapshot, Func<DeleteSnapshotRequestParameters, DeleteSnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_snapshot/{repository} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A comma-separated list of repository names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotDeleteRepository<T>(string repository, Func<DeleteRepositoryRequestParameters, DeleteRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(DELETE, Url($"_snapshot/{repository.NotNull("repository")}"), null, _params(requestParameters));
		
		///<summary>Represents a DELETE on /_snapshot/{repository} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A comma-separated list of repository names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotDeleteRepositoryAsync<T>(string repository, Func<DeleteRepositoryRequestParameters, DeleteRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(DELETE, Url($"_snapshot/{repository.NotNull("repository")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A comma-separated list of snapshot names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotGet<T>(string repository, string snapshot, Func<GetSnapshotRequestParameters, GetSnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository}/{snapshot} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A comma-separated list of snapshot names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotGetAsync<T>(string repository, string snapshot, Func<GetSnapshotRequestParameters, GetSnapshotRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotGetRepository<T>(Func<GetRepositoryRequestParameters, GetRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_snapshot"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotGetRepositoryAsync<T>(Func<GetRepositoryRequestParameters, GetRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_snapshot"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository} 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A comma-separated list of repository names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotGetRepository<T>(string repository, Func<GetRepositoryRequestParameters, GetRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository} 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A comma-separated list of repository names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotGetRepositoryAsync<T>(string repository, Func<GetRepositoryRequestParameters, GetRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository}/{snapshot}/_restore 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="body">Details of what to restore</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotRestore<T>(string repository, string snapshot, PostData<object> body, Func<RestoreRequestParameters, RestoreRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}/_restore"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository}/{snapshot}/_restore 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A snapshot name</param>
		///<param name="body">Details of what to restore</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotRestoreAsync<T>(string repository, string snapshot, PostData<object> body, Func<RestoreRequestParameters, RestoreRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}/_restore"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/_status 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotStatus<T>(Func<SnapshotStatusRequestParameters, SnapshotStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_snapshot/_status"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/_status 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotStatusAsync<T>(Func<SnapshotStatusRequestParameters, SnapshotStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_snapshot/_status"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository}/_status 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotStatus<T>(string repository, Func<SnapshotStatusRequestParameters, SnapshotStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}/_status"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository}/_status 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotStatusAsync<T>(string repository, Func<SnapshotStatusRequestParameters, SnapshotStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}/_status"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository}/{snapshot}/_status 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A comma-separated list of snapshot names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotStatus<T>(string repository, string snapshot, Func<SnapshotStatusRequestParameters, SnapshotStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}/_status"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_snapshot/{repository}/{snapshot}/_status 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="snapshot">A comma-separated list of snapshot names</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotStatusAsync<T>(string repository, string snapshot, Func<SnapshotStatusRequestParameters, SnapshotStatusRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_snapshot/{repository.NotNull("repository")}/{snapshot.NotNull("snapshot")}/_status"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository}/_verify 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SnapshotVerifyRepository<T>(string repository, Func<VerifyRepositoryRequestParameters, VerifyRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}/_verify"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_snapshot/{repository}/_verify 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para>	
	    ///</summary>
		///<param name="repository">A repository name</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SnapshotVerifyRepositoryAsync<T>(string repository, Func<VerifyRepositoryRequestParameters, VerifyRepositoryRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_snapshot/{repository.NotNull("repository")}/_verify"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /_suggest 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="body">The request definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Suggest<T>(PostData<object> body, Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"_suggest"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /_suggest 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="body">The request definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SuggestAsync<T>(PostData<object> body, Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"_suggest"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_suggest 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The request definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Suggest<T>(string index, PostData<object> body, Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/_suggest"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/_suggest 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The request definition</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SuggestAsync<T>(string index, PostData<object> body, Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/_suggest"), body, _params(requestParameters));
		
		///<summary>Represents a GET on /_suggest 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SuggestGet<T>(Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"_suggest"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /_suggest 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SuggestGetAsync<T>(Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"_suggest"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_suggest 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> SuggestGet<T>(string index, Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/_suggest"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/_suggest 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/search-suggesters.html</para>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> SuggestGetAsync<T>(string index, Func<SuggestRequestParameters, SuggestRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/_suggest"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_termvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> TermvectorsGet<T>(string index, string type, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_termvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/_termvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> TermvectorsGetAsync<T>(string index, string type, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_termvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_termvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> TermvectorsGet<T>(string index, string type, string id, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_termvectors"), null, _params(requestParameters));
		
		///<summary>Represents a GET on /{index}/{type}/{id}/_termvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> TermvectorsGetAsync<T>(string index, string type, string id, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(GET, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_termvectors"), null, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_termvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Termvectors<T>(string index, string type, PostData<object> body, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_termvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/_termvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> TermvectorsAsync<T>(string index, string type, PostData<object> body, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/_termvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_termvectors 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
		///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Termvectors<T>(string index, string type, string id, PostData<object> body, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_termvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_termvectors 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html</para>	
	    ///</summary>
		///<param name="index">The index in which the document resides.</param>
		///<param name="type">The type of the document.</param>
		///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
		///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> TermvectorsAsync<T>(string index, string type, string id, PostData<object> body, Func<TermVectorsRequestParameters, TermVectorsRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_termvectors"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_update 
		///<para></para>Returns: ElasticsearchResponse&lt;T&gt; where the behavior depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">Document ID</param>
		///<param name="body">The request definition using either `script` or partial `doc`</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public ElasticsearchResponse<T> Update<T>(string index, string type, string id, PostData<object> body, Func<UpdateRequestParameters, UpdateRequestParameters> requestParameters = null)
			where T : class => this.DoRequest<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_update"), body, _params(requestParameters));
		
		///<summary>Represents a POST on /{index}/{type}/{id}/_update 
		///<para></para>Returns: A task of ElasticsearchResponse&lt;T&gt; where the behaviour depends on the type of T:
		///<para> - T, an object you own that the elasticsearch response will be deserialized to /para>
		///<para> - byte[], no deserialization, but the response stream will be closed</para>
		///<para> - Stream, no deserialization, response stream is your responsibility</para>
		///<para> - VoidResponse, no deserialization, response stream never read and closed</para>
		///<para> - DynamicDictionary, a dynamic aware dictionary that can be safely traversed to any depth 
	    ///<para>See also: http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html</para>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="id">Document ID</param>
		///<param name="body">The request definition using either `script` or partial `doc`</param>
		///<param name="requestParameters">A func that allows you to describe the querystring parameters &amp; request specific connection settings.</param>
		public Task<ElasticsearchResponse<T>> UpdateAsync<T>(string index, string type, string id, PostData<object> body, Func<UpdateRequestParameters, UpdateRequestParameters> requestParameters = null)
			where T : class => this.DoRequestAsync<T>(POST, Url($"{index.NotNull("index")}/{type.NotNull("type")}/{id.NotNull("id")}/_update"), body, _params(requestParameters));
		
	
	  }
	  }
	
