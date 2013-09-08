 
using System.Runtime.Serialization;
using System;
using RestAPICore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace SinaWeiboTest
{





	public partial class JDCBClient:JsonClientBase
	{
		public JDCBClient()
		{
			//TODO: Set BaseUri property Here 在这里指定服务基础地址
			BaseUri = new Uri("http://api.weibo.com/");
					
			_executeEmotionsMethod= new JsonMethod<EmotionsRequest, EmotionsResponse>(this, new Uri("emotions.json", UriKind.Relative));
						
			_executeFavoritesMethod= new JsonMethod<FavoritesRequest, FavoritesResponse>(this, new Uri("favorites.json", UriKind.Relative));
						
			_executeAccountGetPrivacyMethod= new JsonMethod<Account.GetPrivacyRequest, Account.GetPrivacyResponse>(this, new Uri("account/get_privacy.json", UriKind.Relative));
						
			_executeAccountRateLimitStatusMethod= new JsonMethod<Account.RateLimitStatusRequest, Account.RateLimitStatusResponse>(this, new Uri("account/rate_limit_status.json", UriKind.Relative));
						
			_executeAccountMethod= new JsonMethod<AccountRequest, AccountResponse>(this, new Uri("account/end_session.json", UriKind.Relative));
						
			_executeAccountUpdateProfileMethod= new JsonMethod<Account.UpdateProfileRequest, Account.UpdateProfileResponse>(this, new Uri("account/update_profile.json", UriKind.Relative));
						
			_executeAccountUpdateProfileImageMethod= new JsonMethod<Account.UpdateProfileImageRequest, Account.UpdateProfileImageResponse>(this, new Uri("account/update_profile_image.json", UriKind.Relative));
						
			_executeAccountVerifyCredentialsMethod= new JsonMethod<Account.VerifyCredentialsRequest, Account.VerifyCredentialsResponse>(this, new Uri("account/verify_credentials.json", UriKind.Relative));
						
			_executeBlocksBlockingMethod= new JsonMethod<Blocks.BlockingRequest, Blocks.BlockingResponse>(this, new Uri("blocks/blocking.json", UriKind.Relative));
						
			_executeBlocksCreateMethod= new JsonMethod<Blocks.CreateRequest, Blocks.CreateResponse>(this, new Uri("blocks/create.json", UriKind.Relative));
						
			_executeBlocksDestroyMethod= new JsonMethod<Blocks.DestroyRequest, Blocks.DestroyResponse>(this, new Uri("blocks/destroy.json", UriKind.Relative));
						
			_executeBlocksExistsMethod= new JsonMethod<Blocks.ExistsRequest, Blocks.ExistsResponse>(this, new Uri("blocks/exists.json", UriKind.Relative));
						
			_executeFavoritesCreateMethod= new JsonMethod<Favorites.CreateRequest, Favorites.CreateResponse>(this, new Uri("favorites/create.json", UriKind.Relative));
						
			_executeFavoritesDestroyMethod= new JsonMethod<Favorites.DestroyRequest, Favorites.DestroyResponse>(this, new Uri("favorites/destroy/{id}.json", UriKind.Relative));
						
			_executeFavoritesDestroyBatchMethod= new JsonMethod<Favorites.DestroyBatchRequest, Favorites.DestroyBatchResponse>(this, new Uri("favorites/destroy_batch.json", UriKind.Relative));
						
			_executeFriendshipsCreateMethod= new JsonMethod<Friendships.CreateRequest, Friendships.CreateResponse>(this, new Uri("friendships/create/{id}.json", UriKind.Relative));
						
			_executeFriendshipsDestroyMethod= new JsonMethod<Friendships.DestroyRequest, Friendships.DestroyResponse>(this, new Uri("friendships/destroy/{id}.json", UriKind.Relative));
						
			_executeFriendshipsExistsMethod= new JsonMethod<Friendships.ExistsRequest, Friendships.ExistsResponse>(this, new Uri("friendships/exists.json", UriKind.Relative));
						
			_executeFriendshipsShowMethod= new JsonMethod<Friendships.ShowRequest, Friendships.ShowResponse>(this, new Uri("friendships/show.json", UriKind.Relative));
						
			_executeShortUrlExpandMethod= new JsonMethod<ShortUrl.ExpandRequest, ShortUrl.ExpandResponse>(this, new Uri("short_url/expand.json", UriKind.Relative));
						
			_executeShortUrlShortenMethod= new JsonMethod<ShortUrl.ShortenRequest, ShortUrl.ShortenResponse>(this, new Uri("short_url/shorten.json", UriKind.Relative));
						
			_executeShortUrlCommentCommentsMethod= new JsonMethod<ShortUrl.Comment.CommentsRequest, ShortUrl.Comment.CommentsResponse>(this, new Uri("short_url/comment/comments.json", UriKind.Relative));
						
			_executeShortUrlCommentCountsMethod= new JsonMethod<ShortUrl.Comment.CountsRequest, ShortUrl.Comment.CountsResponse>(this, new Uri("short_url/comment/counts.json", UriKind.Relative));
						
			_executeShortUrlShareCountsMethod= new JsonMethod<ShortUrl.Share.CountsRequest, ShortUrl.Share.CountsResponse>(this, new Uri("short_url/share/counts.json", UriKind.Relative));
						
			_executeShortUrlShareStatusesMethod= new JsonMethod<ShortUrl.Share.StatusesRequest, ShortUrl.Share.StatusesResponse>(this, new Uri("short_url/share/statuses.json", UriKind.Relative));
						
			_executeStatusesCommentMethod= new JsonMethod<Statuses.CommentRequest, Statuses.CommentResponse>(this, new Uri("statuses/comment.json", UriKind.Relative));
						
			_executeStatusesCommentsByMeMethod= new JsonMethod<Statuses.CommentsByMeRequest, Statuses.CommentsByMeResponse>(this, new Uri("statuses/comments_by_me.json", UriKind.Relative));
						
			_executeStatusesCommentsTimelineMethod= new JsonMethod<Statuses.CommentsTimelineRequest, Statuses.CommentsTimelineResponse>(this, new Uri("statuses/comments_timeline.json", UriKind.Relative));
						
			_executeStatusesCommentsToMeMethod= new JsonMethod<Statuses.CommentsToMeRequest, Statuses.CommentsToMeResponse>(this, new Uri("statuses/comments_to_me.json", UriKind.Relative));
						
			_executeStatusesCommentDestroyMethod= new JsonMethod<Statuses.CommentDestroyRequest, Statuses.CommentDestroyResponse>(this, new Uri("statuses/comment_destroy/{id}.json", UriKind.Relative));
						
			_executeStatusesCommentDestroyBatchMethod= new JsonMethod<Statuses.CommentDestroyBatchRequest, Statuses.CommentDestroyBatchResponse>(this, new Uri("statuses/comment/destroy_batch.json", UriKind.Relative));
						
			_executeStatusesCountsMethod= new JsonMethod<Statuses.CountsRequest, Statuses.CountsResponse>(this, new Uri("statuses/counts.json", UriKind.Relative));
						
			_executeStatusesFollowersMethod= new JsonMethod<Statuses.FollowersRequest, Statuses.FollowersResponse>(this, new Uri("statuses/followers.json", UriKind.Relative));
						
			_executeStatusesFriendsMethod= new JsonMethod<Statuses.FriendsRequest, Statuses.FriendsResponse>(this, new Uri("statuses/friends.json", UriKind.Relative));
						
			_executeStatusesFriendsTimelineMethod= new JsonMethod<Statuses.FriendsTimelineRequest, Statuses.FriendsTimelineResponse>(this, new Uri("statuses/friends_timeline.json", UriKind.Relative));
						
			_executeStatusesPublicTimelineMethod= new JsonMethod<Statuses.PublicTimelineRequest, Statuses.PublicTimelineResponse>(this, new Uri("statuses/public_timeline.json", UriKind.Relative));
						
			_executeStatusesReplyMethod= new JsonMethod<Statuses.ReplyRequest, Statuses.ReplyResponse>(this, new Uri("statuses/reply.json", UriKind.Relative));
						
			_executeStatusesRepostMethod= new JsonMethod<Statuses.RepostRequest, Statuses.RepostResponse>(this, new Uri("statuses/repost.json", UriKind.Relative));
						
			_executeStatusesRepostByMeMethod= new JsonMethod<Statuses.RepostByMeRequest, Statuses.RepostByMeResponse>(this, new Uri("statuses/repost_by_me.json", UriKind.Relative));
						
			_executeStatusesResetCountMethod= new JsonMethod<Statuses.ResetCountRequest, Statuses.ResetCountResponse>(this, new Uri("statuses/reset_count.json", UriKind.Relative));
						
			_executeStatusesShowMethod= new JsonMethod<Statuses.ShowRequest, Statuses.ShowResponse>(this, new Uri("statuses/show/{id}.json", UriKind.Relative));
						
			_executeStatusesUnreadMethod= new JsonMethod<Statuses.UnreadRequest, Statuses.UnreadResponse>(this, new Uri("statuses/unread.json", UriKind.Relative));
						
			_executeStatusesUpdateMethod= new JsonMethod<Statuses.UpdateRequest, Statuses.UpdateResponse>(this, new Uri("statuses/update.json", UriKind.Relative));
						
			_executeStatusesUploadMethod= new JsonMethod<Statuses.UploadRequest, Statuses.UploadResponse>(this, new Uri("statuses/upload.json", UriKind.Relative));
						
			_executeStatusesUserTimelineMethod= new JsonMethod<Statuses.UserTimelineRequest, Statuses.UserTimelineResponse>(this, new Uri("statuses/user_timeline/{id}.json", UriKind.Relative));
						
			_executeTagsCreateMethod= new JsonMethod<Tags.CreateRequest, Tags.CreateResponse>(this, new Uri("tags/create.json", UriKind.Relative));
						
			_executeTagsSuggestionsMethod= new JsonMethod<Tags.SuggestionsRequest, Tags.SuggestionsResponse>(this, new Uri("tags/suggestions.json", UriKind.Relative));
						
			_executeTrendsFollowMethod= new JsonMethod<Trends.FollowRequest, Trends.FollowResponse>(this, new Uri("trends/follow.json", UriKind.Relative));
						
			_executeTrendsStatusesMethod= new JsonMethod<Trends.StatusesRequest, Trends.StatusesResponse>(this, new Uri("trends/statuses.json", UriKind.Relative));
						
			_executeTrendsTrendsMethod= new JsonMethod<Trends.TrendsRequest, Trends.TrendsResponse>(this, new Uri("trends.json", UriKind.Relative));
						
			_executeUserFriendsUpdateRemarkMethod= new JsonMethod<User.Friends.UpdateRemarkRequest, User.Friends.UpdateRemarkResponse>(this, new Uri("user/friends/update_remark.json", UriKind.Relative));
						
			_executeUsersHotMethod= new JsonMethod<Users.HotRequest, Users.HotResponse>(this, new Uri("users/hot.json", UriKind.Relative));
						
			_executeUsersShowMethod= new JsonMethod<Users.ShowRequest, Users.ShowResponse>(this, new Uri("users/show/{id}.json", UriKind.Relative));
						
					
			_requestEmotionsMethod= new JsonMethod<EmotionsRequest, Stream>(this, new Uri("emotions.json", UriKind.Relative));
						
			_requestFavoritesMethod= new JsonMethod<FavoritesRequest, Stream>(this, new Uri("favorites.json", UriKind.Relative));
						
			_requestAccountGetPrivacyMethod= new JsonMethod<Account.GetPrivacyRequest, Stream>(this, new Uri("account/get_privacy.json", UriKind.Relative));
						
			_requestAccountRateLimitStatusMethod= new JsonMethod<Account.RateLimitStatusRequest, Stream>(this, new Uri("account/rate_limit_status.json", UriKind.Relative));
						
			_requestAccountMethod= new JsonMethod<AccountRequest, Stream>(this, new Uri("account/end_session.json", UriKind.Relative));
						
			_requestAccountUpdatePrivacyMethod= new JsonMethod<Account.UpdatePrivacyRequest, Stream>(this, new Uri("account/update_privacy.json", UriKind.Relative));
						
			_requestAccountUpdateProfileMethod= new JsonMethod<Account.UpdateProfileRequest, Stream>(this, new Uri("account/update_profile.json", UriKind.Relative));
						
			_requestAccountUpdateProfileImageMethod= new JsonMethod<Account.UpdateProfileImageRequest, Stream>(this, new Uri("account/update_profile_image.json", UriKind.Relative));
						
			_requestAccountVerifyCredentialsMethod= new JsonMethod<Account.VerifyCredentialsRequest, Stream>(this, new Uri("account/verify_credentials.json", UriKind.Relative));
						
			_requestBlocksBlockingMethod= new JsonMethod<Blocks.BlockingRequest, Stream>(this, new Uri("blocks/blocking.json", UriKind.Relative));
						
			_requestBlocksBlockingIdsMethod= new JsonMethod<Blocks.BlockingIdsRequest, Stream>(this, new Uri("blocks/blocking/ids.json", UriKind.Relative));
						
			_requestBlocksCreateMethod= new JsonMethod<Blocks.CreateRequest, Stream>(this, new Uri("blocks/create.json", UriKind.Relative));
						
			_requestBlocksDestroyMethod= new JsonMethod<Blocks.DestroyRequest, Stream>(this, new Uri("blocks/destroy.json", UriKind.Relative));
						
			_requestBlocksExistsMethod= new JsonMethod<Blocks.ExistsRequest, Stream>(this, new Uri("blocks/exists.json", UriKind.Relative));
						
			_requestFavoritesCreateMethod= new JsonMethod<Favorites.CreateRequest, Stream>(this, new Uri("favorites/create.json", UriKind.Relative));
						
			_requestFavoritesDestroyMethod= new JsonMethod<Favorites.DestroyRequest, Stream>(this, new Uri("favorites/destroy/{id}.json", UriKind.Relative));
						
			_requestFavoritesDestroyBatchMethod= new JsonMethod<Favorites.DestroyBatchRequest, Stream>(this, new Uri("favorites/destroy_batch.json", UriKind.Relative));
						
			_requestFriendshipsCreateMethod= new JsonMethod<Friendships.CreateRequest, Stream>(this, new Uri("friendships/create/{id}.json", UriKind.Relative));
						
			_requestFriendshipsDestroyMethod= new JsonMethod<Friendships.DestroyRequest, Stream>(this, new Uri("friendships/destroy/{id}.json", UriKind.Relative));
						
			_requestFriendshipsExistsMethod= new JsonMethod<Friendships.ExistsRequest, Stream>(this, new Uri("friendships/exists.json", UriKind.Relative));
						
			_requestFriendshipsShowMethod= new JsonMethod<Friendships.ShowRequest, Stream>(this, new Uri("friendships/show.json", UriKind.Relative));
						
			_requestShortUrlExpandMethod= new JsonMethod<ShortUrl.ExpandRequest, Stream>(this, new Uri("short_url/expand.json", UriKind.Relative));
						
			_requestShortUrlShortenMethod= new JsonMethod<ShortUrl.ShortenRequest, Stream>(this, new Uri("short_url/shorten.json", UriKind.Relative));
						
			_requestShortUrlCommentCommentsMethod= new JsonMethod<ShortUrl.Comment.CommentsRequest, Stream>(this, new Uri("short_url/comment/comments.json", UriKind.Relative));
						
			_requestShortUrlCommentCountsMethod= new JsonMethod<ShortUrl.Comment.CountsRequest, Stream>(this, new Uri("short_url/comment/counts.json", UriKind.Relative));
						
			_requestShortUrlShareCountsMethod= new JsonMethod<ShortUrl.Share.CountsRequest, Stream>(this, new Uri("short_url/share/counts.json", UriKind.Relative));
						
			_requestShortUrlShareStatusesMethod= new JsonMethod<ShortUrl.Share.StatusesRequest, Stream>(this, new Uri("short_url/share/statuses.json", UriKind.Relative));
						
			_requestSocialgraphFollowsIdsMethod= new JsonMethod<Socialgraph.FollowsIdsRequest, Stream>(this, new Uri("followers/ids/{id}.json", UriKind.Relative));
						
			_requestSocialgraphFriendsIdsMethod= new JsonMethod<Socialgraph.FriendsIdsRequest, Stream>(this, new Uri("friends/ids/{id}.json", UriKind.Relative));
						
			_requestStatusesCommentMethod= new JsonMethod<Statuses.CommentRequest, Stream>(this, new Uri("statuses/comment.json", UriKind.Relative));
						
			_requestStatusesCommentsMethod= new JsonMethod<Statuses.CommentsRequest, Stream>(this, new Uri("statuses/comments.json", UriKind.Relative));
						
			_requestStatusesCommentsByMeMethod= new JsonMethod<Statuses.CommentsByMeRequest, Stream>(this, new Uri("statuses/comments_by_me.json", UriKind.Relative));
						
			_requestStatusesCommentsTimelineMethod= new JsonMethod<Statuses.CommentsTimelineRequest, Stream>(this, new Uri("statuses/comments_timeline.json", UriKind.Relative));
						
			_requestStatusesCommentsToMeMethod= new JsonMethod<Statuses.CommentsToMeRequest, Stream>(this, new Uri("statuses/comments_to_me.json", UriKind.Relative));
						
			_requestStatusesCommentDestroyMethod= new JsonMethod<Statuses.CommentDestroyRequest, Stream>(this, new Uri("statuses/comment_destroy/{id}.json", UriKind.Relative));
						
			_requestStatusesCommentDestroyBatchMethod= new JsonMethod<Statuses.CommentDestroyBatchRequest, Stream>(this, new Uri("statuses/comment/destroy_batch.json", UriKind.Relative));
						
			_requestStatusesCountsMethod= new JsonMethod<Statuses.CountsRequest, Stream>(this, new Uri("statuses/counts.json", UriKind.Relative));
						
			_requestStatusesDestroyMethod= new JsonMethod<Statuses.DestroyRequest, Stream>(this, new Uri("statuses/destroy/{id}.json", UriKind.Relative));
						
			_requestStatusesFollowersMethod= new JsonMethod<Statuses.FollowersRequest, Stream>(this, new Uri("statuses/followers.json", UriKind.Relative));
						
			_requestStatusesFriendsMethod= new JsonMethod<Statuses.FriendsRequest, Stream>(this, new Uri("statuses/friends.json", UriKind.Relative));
						
			_requestStatusesFriendsTimelineMethod= new JsonMethod<Statuses.FriendsTimelineRequest, Stream>(this, new Uri("statuses/friends_timeline.json", UriKind.Relative));
						
			_requestStatusesMentionsMethod= new JsonMethod<Statuses.MentionsRequest, Stream>(this, new Uri("statuses/mentions.json", UriKind.Relative));
						
			_requestStatusesPublicTimelineMethod= new JsonMethod<Statuses.PublicTimelineRequest, Stream>(this, new Uri("statuses/public_timeline.json", UriKind.Relative));
						
			_requestStatusesReplyMethod= new JsonMethod<Statuses.ReplyRequest, Stream>(this, new Uri("statuses/reply.json", UriKind.Relative));
						
			_requestStatusesRepostMethod= new JsonMethod<Statuses.RepostRequest, Stream>(this, new Uri("statuses/repost.json", UriKind.Relative));
						
			_requestStatusesRepostByMeMethod= new JsonMethod<Statuses.RepostByMeRequest, Stream>(this, new Uri("statuses/repost_by_me.json", UriKind.Relative));
						
			_requestStatusesRepostTimelineMethod= new JsonMethod<Statuses.RepostTimelineRequest, Stream>(this, new Uri("statuses/repost_timeline.json", UriKind.Relative));
						
			_requestStatusesResetCountMethod= new JsonMethod<Statuses.ResetCountRequest, Stream>(this, new Uri("statuses/reset_count.json", UriKind.Relative));
						
			_requestStatusesShowMethod= new JsonMethod<Statuses.ShowRequest, Stream>(this, new Uri("statuses/show/{id}.json", UriKind.Relative));
						
			_requestStatusesUnreadMethod= new JsonMethod<Statuses.UnreadRequest, Stream>(this, new Uri("statuses/unread.json", UriKind.Relative));
						
			_requestStatusesUpdateMethod= new JsonMethod<Statuses.UpdateRequest, Stream>(this, new Uri("statuses/update.json", UriKind.Relative));
						
			_requestStatusesUploadMethod= new JsonMethod<Statuses.UploadRequest, Stream>(this, new Uri("statuses/upload.json", UriKind.Relative));
						
			_requestStatusesUserTimelineMethod= new JsonMethod<Statuses.UserTimelineRequest, Stream>(this, new Uri("statuses/user_timeline/{id}.json", UriKind.Relative));
						
			_requestTagsCreateMethod= new JsonMethod<Tags.CreateRequest, Stream>(this, new Uri("tags/create.json", UriKind.Relative));
						
			_requestTagsDestroyMethod= new JsonMethod<Tags.DestroyRequest, Stream>(this, new Uri("tags/destroy.json", UriKind.Relative));
						
			_requestTagsDestroyBatchMethod= new JsonMethod<Tags.DestroyBatchRequest, Stream>(this, new Uri("tags/destroy_batch.json", UriKind.Relative));
						
			_requestTagsSuggestionsMethod= new JsonMethod<Tags.SuggestionsRequest, Stream>(this, new Uri("tags/suggestions.json", UriKind.Relative));
						
			_requestTagsTagsMethod= new JsonMethod<Tags.TagsRequest, Stream>(this, new Uri("tags.json", UriKind.Relative));
						
			_requestTrendsDailyMethod= new JsonMethod<Trends.DailyRequest, Stream>(this, new Uri("trends/daily.json", UriKind.Relative));
						
			_requestTrendsDestroyMethod= new JsonMethod<Trends.DestroyRequest, Stream>(this, new Uri("trends/destroy.json", UriKind.Relative));
						
			_requestTrendsFollowMethod= new JsonMethod<Trends.FollowRequest, Stream>(this, new Uri("trends/follow.json", UriKind.Relative));
						
			_requestTrendsHourlyMethod= new JsonMethod<Trends.HourlyRequest, Stream>(this, new Uri("trends/hourly.json", UriKind.Relative));
						
			_requestTrendsStatusesMethod= new JsonMethod<Trends.StatusesRequest, Stream>(this, new Uri("trends/statuses.json", UriKind.Relative));
						
			_requestTrendsTrendsMethod= new JsonMethod<Trends.TrendsRequest, Stream>(this, new Uri("trends.json", UriKind.Relative));
						
			_requestTrendsWeeklyMethod= new JsonMethod<Trends.WeeklyRequest, Stream>(this, new Uri("trends/weekly.json", UriKind.Relative));
						
			_requestUserFriendsUpdateRemarkMethod= new JsonMethod<User.Friends.UpdateRemarkRequest, Stream>(this, new Uri("user/friends/update_remark.json", UriKind.Relative));
						
			_requestUsersHotMethod= new JsonMethod<Users.HotRequest, Stream>(this, new Uri("users/hot.json", UriKind.Relative));
						
			_requestUsersShowMethod= new JsonMethod<Users.ShowRequest, Stream>(this, new Uri("users/show/{id}.json", UriKind.Relative));
						
			_requestUsersSuggestionsMethod= new JsonMethod<Users.SuggestionsRequest, Stream>(this, new Uri("users/suggestions.json", UriKind.Relative));
					}
		
				
		/// <summary>
		/// Path\emotions
		/// </summary>
		JsonMethod<EmotionsRequest, EmotionsResponse> _executeEmotionsMethod;
		
		/// <summary>
		/// This is a async execution of \emotions rest call. 
		/// It returns JsonResponse&lt;EmotionsResponse&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<EmotionsResponse>> ExecuteEmotionsAsync (
			EmotionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeEmotionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \emotions rest call. 
		/// It returns JsonResponse&lt;EmotionsResponse&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<EmotionsResponse> ExecuteEmotions(EmotionsRequest request)
		{
			return ExecuteEmotionsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\favorites
		/// </summary>
		JsonMethod<FavoritesRequest, FavoritesResponse> _executeFavoritesMethod;
		
		/// <summary>
		/// This is a async execution of \favorites rest call. 
		/// It returns JsonResponse&lt;FavoritesResponse&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FavoritesResponse>> ExecuteFavoritesAsync (
			FavoritesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites rest call. 
		/// It returns JsonResponse&lt;FavoritesResponse&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FavoritesResponse> ExecuteFavorites(FavoritesRequest request)
		{
			return ExecuteFavoritesAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\account\get_privacy
		/// </summary>
		JsonMethod<Account.GetPrivacyRequest, Account.GetPrivacyResponse> _executeAccountGetPrivacyMethod;
		
		/// <summary>
		/// This is a async execution of \account\get_privacy rest call. 
		/// It returns JsonResponse&lt;Account.GetPrivacyResponse&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Account.GetPrivacyResponse>> ExecuteAccountGetPrivacyAsync (
			Account.GetPrivacyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountGetPrivacyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\get_privacy rest call. 
		/// It returns JsonResponse&lt;Account.GetPrivacyResponse&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Account.GetPrivacyResponse> ExecuteAccountGetPrivacy(Account.GetPrivacyRequest request)
		{
			return ExecuteAccountGetPrivacyAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\account\rate_limit_status
		/// </summary>
		JsonMethod<Account.RateLimitStatusRequest, Account.RateLimitStatusResponse> _executeAccountRateLimitStatusMethod;
		
		/// <summary>
		/// This is a async execution of \account\rate_limit_status rest call. 
		/// It returns JsonResponse&lt;Account.RateLimitStatusResponse&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Account.RateLimitStatusResponse>> ExecuteAccountRateLimitStatusAsync (
			Account.RateLimitStatusRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountRateLimitStatusMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\rate_limit_status rest call. 
		/// It returns JsonResponse&lt;Account.RateLimitStatusResponse&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Account.RateLimitStatusResponse> ExecuteAccountRateLimitStatus(Account.RateLimitStatusRequest request)
		{
			return ExecuteAccountRateLimitStatusAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\account
		/// </summary>
		JsonMethod<AccountRequest, AccountResponse> _executeAccountMethod;
		
		/// <summary>
		/// This is a async execution of \account rest call. 
		/// It returns JsonResponse&lt;AccountResponse&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public async Task<JsonResponse<AccountResponse>> ExecuteAccountAsync (
			AccountRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account rest call. 
		/// It returns JsonResponse&lt;AccountResponse&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public JsonResponse<AccountResponse> ExecuteAccount(AccountRequest request)
		{
			return ExecuteAccountAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\account\update_profile
		/// </summary>
		JsonMethod<Account.UpdateProfileRequest, Account.UpdateProfileResponse> _executeAccountUpdateProfileMethod;
		
		/// <summary>
		/// This is a async execution of \account\update_profile rest call. 
		/// It returns JsonResponse&lt;Account.UpdateProfileResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Account.UpdateProfileResponse>> ExecuteAccountUpdateProfileAsync (
			Account.UpdateProfileRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountUpdateProfileMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\update_profile rest call. 
		/// It returns JsonResponse&lt;Account.UpdateProfileResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Account.UpdateProfileResponse> ExecuteAccountUpdateProfile(Account.UpdateProfileRequest request)
		{
			return ExecuteAccountUpdateProfileAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\account\update_profile_image
		/// </summary>
		JsonMethod<Account.UpdateProfileImageRequest, Account.UpdateProfileImageResponse> _executeAccountUpdateProfileImageMethod;
		
		/// <summary>
		/// This is a async execution of \account\update_profile_image rest call. 
		/// It returns JsonResponse&lt;Account.UpdateProfileImageResponse&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Account.UpdateProfileImageResponse>> ExecuteAccountUpdateProfileImageAsync (
			Account.UpdateProfileImageRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountUpdateProfileImageMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\update_profile_image rest call. 
		/// It returns JsonResponse&lt;Account.UpdateProfileImageResponse&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Account.UpdateProfileImageResponse> ExecuteAccountUpdateProfileImage(Account.UpdateProfileImageRequest request)
		{
			return ExecuteAccountUpdateProfileImageAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\account\verify_credentials
		/// </summary>
		JsonMethod<Account.VerifyCredentialsRequest, Account.VerifyCredentialsResponse> _executeAccountVerifyCredentialsMethod;
		
		/// <summary>
		/// This is a async execution of \account\verify_credentials rest call. 
		/// It returns JsonResponse&lt;Account.VerifyCredentialsResponse&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Account.VerifyCredentialsResponse>> ExecuteAccountVerifyCredentialsAsync (
			Account.VerifyCredentialsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountVerifyCredentialsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\verify_credentials rest call. 
		/// It returns JsonResponse&lt;Account.VerifyCredentialsResponse&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Account.VerifyCredentialsResponse> ExecuteAccountVerifyCredentials(Account.VerifyCredentialsRequest request)
		{
			return ExecuteAccountVerifyCredentialsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\blocks\blocking
		/// </summary>
		JsonMethod<Blocks.BlockingRequest, Blocks.BlockingResponse> _executeBlocksBlockingMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\blocking rest call. 
		/// It returns JsonResponse&lt;Blocks.BlockingResponse&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Blocks.BlockingResponse>> ExecuteBlocksBlockingAsync (
			Blocks.BlockingRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksBlockingMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\blocking rest call. 
		/// It returns JsonResponse&lt;Blocks.BlockingResponse&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Blocks.BlockingResponse> ExecuteBlocksBlocking(Blocks.BlockingRequest request)
		{
			return ExecuteBlocksBlockingAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\blocks\create
		/// </summary>
		JsonMethod<Blocks.CreateRequest, Blocks.CreateResponse> _executeBlocksCreateMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\create rest call. 
		/// It returns JsonResponse&lt;Blocks.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Blocks.CreateResponse>> ExecuteBlocksCreateAsync (
			Blocks.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\create rest call. 
		/// It returns JsonResponse&lt;Blocks.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Blocks.CreateResponse> ExecuteBlocksCreate(Blocks.CreateRequest request)
		{
			return ExecuteBlocksCreateAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\blocks\destroy
		/// </summary>
		JsonMethod<Blocks.DestroyRequest, Blocks.DestroyResponse> _executeBlocksDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\destroy rest call. 
		/// It returns JsonResponse&lt;Blocks.DestroyResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Blocks.DestroyResponse>> ExecuteBlocksDestroyAsync (
			Blocks.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\destroy rest call. 
		/// It returns JsonResponse&lt;Blocks.DestroyResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Blocks.DestroyResponse> ExecuteBlocksDestroy(Blocks.DestroyRequest request)
		{
			return ExecuteBlocksDestroyAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\blocks\exists
		/// </summary>
		JsonMethod<Blocks.ExistsRequest, Blocks.ExistsResponse> _executeBlocksExistsMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\exists rest call. 
		/// It returns JsonResponse&lt;Blocks.ExistsResponse&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Blocks.ExistsResponse>> ExecuteBlocksExistsAsync (
			Blocks.ExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\exists rest call. 
		/// It returns JsonResponse&lt;Blocks.ExistsResponse&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Blocks.ExistsResponse> ExecuteBlocksExists(Blocks.ExistsRequest request)
		{
			return ExecuteBlocksExistsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\favorites\create
		/// </summary>
		JsonMethod<Favorites.CreateRequest, Favorites.CreateResponse> _executeFavoritesCreateMethod;
		
		/// <summary>
		/// This is a async execution of \favorites\create rest call. 
		/// It returns JsonResponse&lt;Favorites.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Favorites.CreateResponse>> ExecuteFavoritesCreateAsync (
			Favorites.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites\create rest call. 
		/// It returns JsonResponse&lt;Favorites.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Favorites.CreateResponse> ExecuteFavoritesCreate(Favorites.CreateRequest request)
		{
			return ExecuteFavoritesCreateAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\favorites\destroy
		/// </summary>
		JsonMethod<Favorites.DestroyRequest, Favorites.DestroyResponse> _executeFavoritesDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \favorites\destroy rest call. 
		/// It returns JsonResponse&lt;Favorites.DestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Favorites.DestroyResponse>> ExecuteFavoritesDestroyAsync (
			Favorites.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites\destroy rest call. 
		/// It returns JsonResponse&lt;Favorites.DestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Favorites.DestroyResponse> ExecuteFavoritesDestroy(Favorites.DestroyRequest request)
		{
			return ExecuteFavoritesDestroyAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\favorites\destroy_batch
		/// </summary>
		JsonMethod<Favorites.DestroyBatchRequest, Favorites.DestroyBatchResponse> _executeFavoritesDestroyBatchMethod;
		
		/// <summary>
		/// This is a async execution of \favorites\destroy_batch rest call. 
		/// It returns JsonResponse&lt;Favorites.DestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Favorites.DestroyBatchResponse>> ExecuteFavoritesDestroyBatchAsync (
			Favorites.DestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites\destroy_batch rest call. 
		/// It returns JsonResponse&lt;Favorites.DestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Favorites.DestroyBatchResponse> ExecuteFavoritesDestroyBatch(Favorites.DestroyBatchRequest request)
		{
			return ExecuteFavoritesDestroyBatchAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\friendships\create
		/// </summary>
		JsonMethod<Friendships.CreateRequest, Friendships.CreateResponse> _executeFriendshipsCreateMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\create rest call. 
		/// It returns JsonResponse&lt;Friendships.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Friendships.CreateResponse>> ExecuteFriendshipsCreateAsync (
			Friendships.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\create rest call. 
		/// It returns JsonResponse&lt;Friendships.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Friendships.CreateResponse> ExecuteFriendshipsCreate(Friendships.CreateRequest request)
		{
			return ExecuteFriendshipsCreateAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\friendships\destroy
		/// </summary>
		JsonMethod<Friendships.DestroyRequest, Friendships.DestroyResponse> _executeFriendshipsDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\destroy rest call. 
		/// It returns JsonResponse&lt;Friendships.DestroyResponse&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Friendships.DestroyResponse>> ExecuteFriendshipsDestroyAsync (
			Friendships.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\destroy rest call. 
		/// It returns JsonResponse&lt;Friendships.DestroyResponse&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Friendships.DestroyResponse> ExecuteFriendshipsDestroy(Friendships.DestroyRequest request)
		{
			return ExecuteFriendshipsDestroyAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\friendships\exists
		/// </summary>
		JsonMethod<Friendships.ExistsRequest, Friendships.ExistsResponse> _executeFriendshipsExistsMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\exists rest call. 
		/// It returns JsonResponse&lt;Friendships.ExistsResponse&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Friendships.ExistsResponse>> ExecuteFriendshipsExistsAsync (
			Friendships.ExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\exists rest call. 
		/// It returns JsonResponse&lt;Friendships.ExistsResponse&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Friendships.ExistsResponse> ExecuteFriendshipsExists(Friendships.ExistsRequest request)
		{
			return ExecuteFriendshipsExistsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\friendships\show
		/// </summary>
		JsonMethod<Friendships.ShowRequest, Friendships.ShowResponse> _executeFriendshipsShowMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\show rest call. 
		/// It returns JsonResponse&lt;Friendships.ShowResponse&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Friendships.ShowResponse>> ExecuteFriendshipsShowAsync (
			Friendships.ShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\show rest call. 
		/// It returns JsonResponse&lt;Friendships.ShowResponse&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Friendships.ShowResponse> ExecuteFriendshipsShow(Friendships.ShowRequest request)
		{
			return ExecuteFriendshipsShowAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\short_url\expand
		/// </summary>
		JsonMethod<ShortUrl.ExpandRequest, ShortUrl.ExpandResponse> _executeShortUrlExpandMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\expand rest call. 
		/// It returns JsonResponse&lt;ShortUrl.ExpandResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrl.ExpandResponse>> ExecuteShortUrlExpandAsync (
			ShortUrl.ExpandRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlExpandMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\expand rest call. 
		/// It returns JsonResponse&lt;ShortUrl.ExpandResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrl.ExpandResponse> ExecuteShortUrlExpand(ShortUrl.ExpandRequest request)
		{
			return ExecuteShortUrlExpandAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\short_url\shorten
		/// </summary>
		JsonMethod<ShortUrl.ShortenRequest, ShortUrl.ShortenResponse> _executeShortUrlShortenMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\shorten rest call. 
		/// It returns JsonResponse&lt;ShortUrl.ShortenResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrl.ShortenResponse>> ExecuteShortUrlShortenAsync (
			ShortUrl.ShortenRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlShortenMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\shorten rest call. 
		/// It returns JsonResponse&lt;ShortUrl.ShortenResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrl.ShortenResponse> ExecuteShortUrlShorten(ShortUrl.ShortenRequest request)
		{
			return ExecuteShortUrlShortenAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\short_url\comment\comments
		/// </summary>
		JsonMethod<ShortUrl.Comment.CommentsRequest, ShortUrl.Comment.CommentsResponse> _executeShortUrlCommentCommentsMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\comment\comments rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Comment.CommentsResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrl.Comment.CommentsResponse>> ExecuteShortUrlCommentCommentsAsync (
			ShortUrl.Comment.CommentsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlCommentCommentsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\comment\comments rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Comment.CommentsResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrl.Comment.CommentsResponse> ExecuteShortUrlCommentComments(ShortUrl.Comment.CommentsRequest request)
		{
			return ExecuteShortUrlCommentCommentsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\short_url\comment\counts
		/// </summary>
		JsonMethod<ShortUrl.Comment.CountsRequest, ShortUrl.Comment.CountsResponse> _executeShortUrlCommentCountsMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\comment\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Comment.CountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrl.Comment.CountsResponse>> ExecuteShortUrlCommentCountsAsync (
			ShortUrl.Comment.CountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlCommentCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\comment\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Comment.CountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrl.Comment.CountsResponse> ExecuteShortUrlCommentCounts(ShortUrl.Comment.CountsRequest request)
		{
			return ExecuteShortUrlCommentCountsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\short_url\share\counts
		/// </summary>
		JsonMethod<ShortUrl.Share.CountsRequest, ShortUrl.Share.CountsResponse> _executeShortUrlShareCountsMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\share\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Share.CountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrl.Share.CountsResponse>> ExecuteShortUrlShareCountsAsync (
			ShortUrl.Share.CountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlShareCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\share\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Share.CountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrl.Share.CountsResponse> ExecuteShortUrlShareCounts(ShortUrl.Share.CountsRequest request)
		{
			return ExecuteShortUrlShareCountsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\short_url\share\statuses
		/// </summary>
		JsonMethod<ShortUrl.Share.StatusesRequest, ShortUrl.Share.StatusesResponse> _executeShortUrlShareStatusesMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\share\statuses rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Share.StatusesResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrl.Share.StatusesResponse>> ExecuteShortUrlShareStatusesAsync (
			ShortUrl.Share.StatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlShareStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\share\statuses rest call. 
		/// It returns JsonResponse&lt;ShortUrl.Share.StatusesResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrl.Share.StatusesResponse> ExecuteShortUrlShareStatuses(ShortUrl.Share.StatusesRequest request)
		{
			return ExecuteShortUrlShareStatusesAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\comment
		/// </summary>
		JsonMethod<Statuses.CommentRequest, Statuses.CommentResponse> _executeStatusesCommentMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comment rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentResponse&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CommentResponse>> ExecuteStatusesCommentAsync (
			Statuses.CommentRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comment rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentResponse&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CommentResponse> ExecuteStatusesComment(Statuses.CommentRequest request)
		{
			return ExecuteStatusesCommentAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\comments_by_me
		/// </summary>
		JsonMethod<Statuses.CommentsByMeRequest, Statuses.CommentsByMeResponse> _executeStatusesCommentsByMeMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comments_by_me rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentsByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CommentsByMeResponse>> ExecuteStatusesCommentsByMeAsync (
			Statuses.CommentsByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentsByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comments_by_me rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentsByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CommentsByMeResponse> ExecuteStatusesCommentsByMe(Statuses.CommentsByMeRequest request)
		{
			return ExecuteStatusesCommentsByMeAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\comments_timeline
		/// </summary>
		JsonMethod<Statuses.CommentsTimelineRequest, Statuses.CommentsTimelineResponse> _executeStatusesCommentsTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comments_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CommentsTimelineResponse>> ExecuteStatusesCommentsTimelineAsync (
			Statuses.CommentsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comments_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CommentsTimelineResponse> ExecuteStatusesCommentsTimeline(Statuses.CommentsTimelineRequest request)
		{
			return ExecuteStatusesCommentsTimelineAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\comments_to_me
		/// </summary>
		JsonMethod<Statuses.CommentsToMeRequest, Statuses.CommentsToMeResponse> _executeStatusesCommentsToMeMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comments_to_me rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentsToMeResponse&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CommentsToMeResponse>> ExecuteStatusesCommentsToMeAsync (
			Statuses.CommentsToMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentsToMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comments_to_me rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentsToMeResponse&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CommentsToMeResponse> ExecuteStatusesCommentsToMe(Statuses.CommentsToMeRequest request)
		{
			return ExecuteStatusesCommentsToMeAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\comment_destroy
		/// </summary>
		JsonMethod<Statuses.CommentDestroyRequest, Statuses.CommentDestroyResponse> _executeStatusesCommentDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comment_destroy rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CommentDestroyResponse>> ExecuteStatusesCommentDestroyAsync (
			Statuses.CommentDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comment_destroy rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CommentDestroyResponse> ExecuteStatusesCommentDestroy(Statuses.CommentDestroyRequest request)
		{
			return ExecuteStatusesCommentDestroyAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\comment_destroy_batch
		/// </summary>
		JsonMethod<Statuses.CommentDestroyBatchRequest, Statuses.CommentDestroyBatchResponse> _executeStatusesCommentDestroyBatchMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comment_destroy_batch rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentDestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CommentDestroyBatchResponse>> ExecuteStatusesCommentDestroyBatchAsync (
			Statuses.CommentDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comment_destroy_batch rest call. 
		/// It returns JsonResponse&lt;Statuses.CommentDestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CommentDestroyBatchResponse> ExecuteStatusesCommentDestroyBatch(Statuses.CommentDestroyBatchRequest request)
		{
			return ExecuteStatusesCommentDestroyBatchAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\counts
		/// </summary>
		JsonMethod<Statuses.CountsRequest, Statuses.CountsResponse> _executeStatusesCountsMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\counts rest call. 
		/// It returns JsonResponse&lt;Statuses.CountsResponse&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.CountsResponse>> ExecuteStatusesCountsAsync (
			Statuses.CountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\counts rest call. 
		/// It returns JsonResponse&lt;Statuses.CountsResponse&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.CountsResponse> ExecuteStatusesCounts(Statuses.CountsRequest request)
		{
			return ExecuteStatusesCountsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\followers
		/// </summary>
		JsonMethod<Statuses.FollowersRequest, Statuses.FollowersResponse> _executeStatusesFollowersMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\followers rest call. 
		/// It returns JsonResponse&lt;Statuses.FollowersResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.FollowersResponse>> ExecuteStatusesFollowersAsync (
			Statuses.FollowersRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\followers rest call. 
		/// It returns JsonResponse&lt;Statuses.FollowersResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.FollowersResponse> ExecuteStatusesFollowers(Statuses.FollowersRequest request)
		{
			return ExecuteStatusesFollowersAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\friends
		/// </summary>
		JsonMethod<Statuses.FriendsRequest, Statuses.FriendsResponse> _executeStatusesFriendsMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\friends rest call. 
		/// It returns JsonResponse&lt;Statuses.FriendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.FriendsResponse>> ExecuteStatusesFriendsAsync (
			Statuses.FriendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesFriendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\friends rest call. 
		/// It returns JsonResponse&lt;Statuses.FriendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.FriendsResponse> ExecuteStatusesFriends(Statuses.FriendsRequest request)
		{
			return ExecuteStatusesFriendsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\friends_timeline
		/// </summary>
		JsonMethod<Statuses.FriendsTimelineRequest, Statuses.FriendsTimelineResponse> _executeStatusesFriendsTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\friends_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.FriendsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.FriendsTimelineResponse>> ExecuteStatusesFriendsTimelineAsync (
			Statuses.FriendsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesFriendsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\friends_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.FriendsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.FriendsTimelineResponse> ExecuteStatusesFriendsTimeline(Statuses.FriendsTimelineRequest request)
		{
			return ExecuteStatusesFriendsTimelineAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\public_timeline
		/// </summary>
		JsonMethod<Statuses.PublicTimelineRequest, Statuses.PublicTimelineResponse> _executeStatusesPublicTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\public_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.PublicTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.PublicTimelineResponse>> ExecuteStatusesPublicTimelineAsync (
			Statuses.PublicTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesPublicTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\public_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.PublicTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.PublicTimelineResponse> ExecuteStatusesPublicTimeline(Statuses.PublicTimelineRequest request)
		{
			return ExecuteStatusesPublicTimelineAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\reply
		/// </summary>
		JsonMethod<Statuses.ReplyRequest, Statuses.ReplyResponse> _executeStatusesReplyMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\reply rest call. 
		/// It returns JsonResponse&lt;Statuses.ReplyResponse&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.ReplyResponse>> ExecuteStatusesReplyAsync (
			Statuses.ReplyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesReplyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\reply rest call. 
		/// It returns JsonResponse&lt;Statuses.ReplyResponse&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.ReplyResponse> ExecuteStatusesReply(Statuses.ReplyRequest request)
		{
			return ExecuteStatusesReplyAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\repost
		/// </summary>
		JsonMethod<Statuses.RepostRequest, Statuses.RepostResponse> _executeStatusesRepostMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\repost rest call. 
		/// It returns JsonResponse&lt;Statuses.RepostResponse&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.RepostResponse>> ExecuteStatusesRepostAsync (
			Statuses.RepostRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesRepostMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\repost rest call. 
		/// It returns JsonResponse&lt;Statuses.RepostResponse&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.RepostResponse> ExecuteStatusesRepost(Statuses.RepostRequest request)
		{
			return ExecuteStatusesRepostAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\repost_by_me
		/// </summary>
		JsonMethod<Statuses.RepostByMeRequest, Statuses.RepostByMeResponse> _executeStatusesRepostByMeMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\repost_by_me rest call. 
		/// It returns JsonResponse&lt;Statuses.RepostByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.RepostByMeResponse>> ExecuteStatusesRepostByMeAsync (
			Statuses.RepostByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesRepostByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\repost_by_me rest call. 
		/// It returns JsonResponse&lt;Statuses.RepostByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.RepostByMeResponse> ExecuteStatusesRepostByMe(Statuses.RepostByMeRequest request)
		{
			return ExecuteStatusesRepostByMeAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\reset_count
		/// </summary>
		JsonMethod<Statuses.ResetCountRequest, Statuses.ResetCountResponse> _executeStatusesResetCountMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\reset_count rest call. 
		/// It returns JsonResponse&lt;Statuses.ResetCountResponse&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.ResetCountResponse>> ExecuteStatusesResetCountAsync (
			Statuses.ResetCountRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesResetCountMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\reset_count rest call. 
		/// It returns JsonResponse&lt;Statuses.ResetCountResponse&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.ResetCountResponse> ExecuteStatusesResetCount(Statuses.ResetCountRequest request)
		{
			return ExecuteStatusesResetCountAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\show
		/// </summary>
		JsonMethod<Statuses.ShowRequest, Statuses.ShowResponse> _executeStatusesShowMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\show rest call. 
		/// It returns JsonResponse&lt;Statuses.ShowResponse&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.ShowResponse>> ExecuteStatusesShowAsync (
			Statuses.ShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\show rest call. 
		/// It returns JsonResponse&lt;Statuses.ShowResponse&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.ShowResponse> ExecuteStatusesShow(Statuses.ShowRequest request)
		{
			return ExecuteStatusesShowAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\unread
		/// </summary>
		JsonMethod<Statuses.UnreadRequest, Statuses.UnreadResponse> _executeStatusesUnreadMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\unread rest call. 
		/// It returns JsonResponse&lt;Statuses.UnreadResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.UnreadResponse>> ExecuteStatusesUnreadAsync (
			Statuses.UnreadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUnreadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\unread rest call. 
		/// It returns JsonResponse&lt;Statuses.UnreadResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.UnreadResponse> ExecuteStatusesUnread(Statuses.UnreadRequest request)
		{
			return ExecuteStatusesUnreadAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\update
		/// </summary>
		JsonMethod<Statuses.UpdateRequest, Statuses.UpdateResponse> _executeStatusesUpdateMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\update rest call. 
		/// It returns JsonResponse&lt;Statuses.UpdateResponse&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.UpdateResponse>> ExecuteStatusesUpdateAsync (
			Statuses.UpdateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\update rest call. 
		/// It returns JsonResponse&lt;Statuses.UpdateResponse&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.UpdateResponse> ExecuteStatusesUpdate(Statuses.UpdateRequest request)
		{
			return ExecuteStatusesUpdateAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\upload
		/// </summary>
		JsonMethod<Statuses.UploadRequest, Statuses.UploadResponse> _executeStatusesUploadMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\upload rest call. 
		/// It returns JsonResponse&lt;Statuses.UploadResponse&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.UploadResponse>> ExecuteStatusesUploadAsync (
			Statuses.UploadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUploadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\upload rest call. 
		/// It returns JsonResponse&lt;Statuses.UploadResponse&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.UploadResponse> ExecuteStatusesUpload(Statuses.UploadRequest request)
		{
			return ExecuteStatusesUploadAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\statuses\user_timeline
		/// </summary>
		JsonMethod<Statuses.UserTimelineRequest, Statuses.UserTimelineResponse> _executeStatusesUserTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\user_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.UserTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Statuses.UserTimelineResponse>> ExecuteStatusesUserTimelineAsync (
			Statuses.UserTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUserTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\user_timeline rest call. 
		/// It returns JsonResponse&lt;Statuses.UserTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Statuses.UserTimelineResponse> ExecuteStatusesUserTimeline(Statuses.UserTimelineRequest request)
		{
			return ExecuteStatusesUserTimelineAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\tags\create
		/// </summary>
		JsonMethod<Tags.CreateRequest, Tags.CreateResponse> _executeTagsCreateMethod;
		
		/// <summary>
		/// This is a async execution of \tags\create rest call. 
		/// It returns JsonResponse&lt;Tags.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Tags.CreateResponse>> ExecuteTagsCreateAsync (
			Tags.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTagsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \tags\create rest call. 
		/// It returns JsonResponse&lt;Tags.CreateResponse&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Tags.CreateResponse> ExecuteTagsCreate(Tags.CreateRequest request)
		{
			return ExecuteTagsCreateAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\tags\suggestions
		/// </summary>
		JsonMethod<Tags.SuggestionsRequest, Tags.SuggestionsResponse> _executeTagsSuggestionsMethod;
		
		/// <summary>
		/// This is a async execution of \tags\suggestions rest call. 
		/// It returns JsonResponse&lt;Tags.SuggestionsResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Tags.SuggestionsResponse>> ExecuteTagsSuggestionsAsync (
			Tags.SuggestionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTagsSuggestionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \tags\suggestions rest call. 
		/// It returns JsonResponse&lt;Tags.SuggestionsResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Tags.SuggestionsResponse> ExecuteTagsSuggestions(Tags.SuggestionsRequest request)
		{
			return ExecuteTagsSuggestionsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\trends\follow
		/// </summary>
		JsonMethod<Trends.FollowRequest, Trends.FollowResponse> _executeTrendsFollowMethod;
		
		/// <summary>
		/// This is a async execution of \trends\follow rest call. 
		/// It returns JsonResponse&lt;Trends.FollowResponse&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Trends.FollowResponse>> ExecuteTrendsFollowAsync (
			Trends.FollowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTrendsFollowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \trends\follow rest call. 
		/// It returns JsonResponse&lt;Trends.FollowResponse&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Trends.FollowResponse> ExecuteTrendsFollow(Trends.FollowRequest request)
		{
			return ExecuteTrendsFollowAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\trends\statuses
		/// </summary>
		JsonMethod<Trends.StatusesRequest, Trends.StatusesResponse> _executeTrendsStatusesMethod;
		
		/// <summary>
		/// This is a async execution of \trends\statuses rest call. 
		/// It returns JsonResponse&lt;Trends.StatusesResponse&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Trends.StatusesResponse>> ExecuteTrendsStatusesAsync (
			Trends.StatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTrendsStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \trends\statuses rest call. 
		/// It returns JsonResponse&lt;Trends.StatusesResponse&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Trends.StatusesResponse> ExecuteTrendsStatuses(Trends.StatusesRequest request)
		{
			return ExecuteTrendsStatusesAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\trends\trends
		/// </summary>
		JsonMethod<Trends.TrendsRequest, Trends.TrendsResponse> _executeTrendsTrendsMethod;
		
		/// <summary>
		/// This is a async execution of \trends\trends rest call. 
		/// It returns JsonResponse&lt;Trends.TrendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Trends.TrendsResponse>> ExecuteTrendsTrendsAsync (
			Trends.TrendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTrendsTrendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \trends\trends rest call. 
		/// It returns JsonResponse&lt;Trends.TrendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Trends.TrendsResponse> ExecuteTrendsTrends(Trends.TrendsRequest request)
		{
			return ExecuteTrendsTrendsAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\user\friends\update_remark
		/// </summary>
		JsonMethod<User.Friends.UpdateRemarkRequest, User.Friends.UpdateRemarkResponse> _executeUserFriendsUpdateRemarkMethod;
		
		/// <summary>
		/// This is a async execution of \user\friends\update_remark rest call. 
		/// It returns JsonResponse&lt;User.Friends.UpdateRemarkResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<User.Friends.UpdateRemarkResponse>> ExecuteUserFriendsUpdateRemarkAsync (
			User.Friends.UpdateRemarkRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeUserFriendsUpdateRemarkMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \user\friends\update_remark rest call. 
		/// It returns JsonResponse&lt;User.Friends.UpdateRemarkResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<User.Friends.UpdateRemarkResponse> ExecuteUserFriendsUpdateRemark(User.Friends.UpdateRemarkRequest request)
		{
			return ExecuteUserFriendsUpdateRemarkAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\users\hot
		/// </summary>
		JsonMethod<Users.HotRequest, Users.HotResponse> _executeUsersHotMethod;
		
		/// <summary>
		/// This is a async execution of \users\hot rest call. 
		/// It returns JsonResponse&lt;Users.HotResponse&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Users.HotResponse>> ExecuteUsersHotAsync (
			Users.HotRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeUsersHotMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \users\hot rest call. 
		/// It returns JsonResponse&lt;Users.HotResponse&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Users.HotResponse> ExecuteUsersHot(Users.HotRequest request)
		{
			return ExecuteUsersHotAsync(request).Result;
		}
		
		
				
		/// <summary>
		/// Path\users\show
		/// </summary>
		JsonMethod<Users.ShowRequest, Users.ShowResponse> _executeUsersShowMethod;
		
		/// <summary>
		/// This is a async execution of \users\show rest call. 
		/// It returns JsonResponse&lt;Users.ShowResponse&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Users.ShowResponse>> ExecuteUsersShowAsync (
			Users.ShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeUsersShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \users\show rest call. 
		/// It returns JsonResponse&lt;Users.ShowResponse&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Users.ShowResponse> ExecuteUsersShow(Users.ShowRequest request)
		{
			return ExecuteUsersShowAsync(request).Result;
		}
		
		
						
		JsonMethod<EmotionsRequest, Stream> _requestEmotionsMethod;
		/// <summary>
		/// This is a async request of \emotions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestEmotionsAsync (
			EmotionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestEmotionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \emotions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestEmotions(EmotionsRequest request)
		{
			return RequestEmotionsAsync(request).Result;
		}
		
				
		JsonMethod<FavoritesRequest, Stream> _requestFavoritesMethod;
		/// <summary>
		/// This is a async request of \favorites rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesAsync (
			FavoritesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavorites(FavoritesRequest request)
		{
			return RequestFavoritesAsync(request).Result;
		}
		
				
		JsonMethod<Account.GetPrivacyRequest, Stream> _requestAccountGetPrivacyMethod;
		/// <summary>
		/// This is a async request of \account\get_privacy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountGetPrivacyAsync (
			Account.GetPrivacyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountGetPrivacyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\get_privacy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountGetPrivacy(Account.GetPrivacyRequest request)
		{
			return RequestAccountGetPrivacyAsync(request).Result;
		}
		
				
		JsonMethod<Account.RateLimitStatusRequest, Stream> _requestAccountRateLimitStatusMethod;
		/// <summary>
		/// This is a async request of \account\rate_limit_status rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountRateLimitStatusAsync (
			Account.RateLimitStatusRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountRateLimitStatusMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\rate_limit_status rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountRateLimitStatus(Account.RateLimitStatusRequest request)
		{
			return RequestAccountRateLimitStatusAsync(request).Result;
		}
		
				
		JsonMethod<AccountRequest, Stream> _requestAccountMethod;
		/// <summary>
		/// This is a async request of \account rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountAsync (
			AccountRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public JsonResponse<Stream> RequestAccount(AccountRequest request)
		{
			return RequestAccountAsync(request).Result;
		}
		
				
		JsonMethod<Account.UpdatePrivacyRequest, Stream> _requestAccountUpdatePrivacyMethod;
		/// <summary>
		/// This is a async request of \account\update_privacy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>设置隐私信息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountUpdatePrivacyAsync (
			Account.UpdatePrivacyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountUpdatePrivacyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\update_privacy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>设置隐私信息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountUpdatePrivacy(Account.UpdatePrivacyRequest request)
		{
			return RequestAccountUpdatePrivacyAsync(request).Result;
		}
		
				
		JsonMethod<Account.UpdateProfileRequest, Stream> _requestAccountUpdateProfileMethod;
		/// <summary>
		/// This is a async request of \account\update_profile rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountUpdateProfileAsync (
			Account.UpdateProfileRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountUpdateProfileMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\update_profile rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountUpdateProfile(Account.UpdateProfileRequest request)
		{
			return RequestAccountUpdateProfileAsync(request).Result;
		}
		
				
		JsonMethod<Account.UpdateProfileImageRequest, Stream> _requestAccountUpdateProfileImageMethod;
		/// <summary>
		/// This is a async request of \account\update_profile_image rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountUpdateProfileImageAsync (
			Account.UpdateProfileImageRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountUpdateProfileImageMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\update_profile_image rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountUpdateProfileImage(Account.UpdateProfileImageRequest request)
		{
			return RequestAccountUpdateProfileImageAsync(request).Result;
		}
		
				
		JsonMethod<Account.VerifyCredentialsRequest, Stream> _requestAccountVerifyCredentialsMethod;
		/// <summary>
		/// This is a async request of \account\verify_credentials rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountVerifyCredentialsAsync (
			Account.VerifyCredentialsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountVerifyCredentialsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\verify_credentials rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountVerifyCredentials(Account.VerifyCredentialsRequest request)
		{
			return RequestAccountVerifyCredentialsAsync(request).Result;
		}
		
				
		JsonMethod<Blocks.BlockingRequest, Stream> _requestBlocksBlockingMethod;
		/// <summary>
		/// This is a async request of \blocks\blocking rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksBlockingAsync (
			Blocks.BlockingRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksBlockingMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\blocking rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksBlocking(Blocks.BlockingRequest request)
		{
			return RequestBlocksBlockingAsync(request).Result;
		}
		
				
		JsonMethod<Blocks.BlockingIdsRequest, Stream> _requestBlocksBlockingIdsMethod;
		/// <summary>
		/// This is a async request of \blocks\blockingIds rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户黑名单中的用户ID列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksBlockingIdsAsync (
			Blocks.BlockingIdsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksBlockingIdsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\blockingIds rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户黑名单中的用户ID列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksBlockingIds(Blocks.BlockingIdsRequest request)
		{
			return RequestBlocksBlockingIdsAsync(request).Result;
		}
		
				
		JsonMethod<Blocks.CreateRequest, Stream> _requestBlocksCreateMethod;
		/// <summary>
		/// This is a async request of \blocks\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksCreateAsync (
			Blocks.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksCreate(Blocks.CreateRequest request)
		{
			return RequestBlocksCreateAsync(request).Result;
		}
		
				
		JsonMethod<Blocks.DestroyRequest, Stream> _requestBlocksDestroyMethod;
		/// <summary>
		/// This is a async request of \blocks\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksDestroyAsync (
			Blocks.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksDestroy(Blocks.DestroyRequest request)
		{
			return RequestBlocksDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Blocks.ExistsRequest, Stream> _requestBlocksExistsMethod;
		/// <summary>
		/// This is a async request of \blocks\exists rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksExistsAsync (
			Blocks.ExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\exists rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksExists(Blocks.ExistsRequest request)
		{
			return RequestBlocksExistsAsync(request).Result;
		}
		
				
		JsonMethod<Favorites.CreateRequest, Stream> _requestFavoritesCreateMethod;
		/// <summary>
		/// This is a async request of \favorites\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesCreateAsync (
			Favorites.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavoritesCreate(Favorites.CreateRequest request)
		{
			return RequestFavoritesCreateAsync(request).Result;
		}
		
				
		JsonMethod<Favorites.DestroyRequest, Stream> _requestFavoritesDestroyMethod;
		/// <summary>
		/// This is a async request of \favorites\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesDestroyAsync (
			Favorites.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavoritesDestroy(Favorites.DestroyRequest request)
		{
			return RequestFavoritesDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Favorites.DestroyBatchRequest, Stream> _requestFavoritesDestroyBatchMethod;
		/// <summary>
		/// This is a async request of \favorites\destroy_batch rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesDestroyBatchAsync (
			Favorites.DestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites\destroy_batch rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavoritesDestroyBatch(Favorites.DestroyBatchRequest request)
		{
			return RequestFavoritesDestroyBatchAsync(request).Result;
		}
		
				
		JsonMethod<Friendships.CreateRequest, Stream> _requestFriendshipsCreateMethod;
		/// <summary>
		/// This is a async request of \friendships\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsCreateAsync (
			Friendships.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsCreate(Friendships.CreateRequest request)
		{
			return RequestFriendshipsCreateAsync(request).Result;
		}
		
				
		JsonMethod<Friendships.DestroyRequest, Stream> _requestFriendshipsDestroyMethod;
		/// <summary>
		/// This is a async request of \friendships\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsDestroyAsync (
			Friendships.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsDestroy(Friendships.DestroyRequest request)
		{
			return RequestFriendshipsDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Friendships.ExistsRequest, Stream> _requestFriendshipsExistsMethod;
		/// <summary>
		/// This is a async request of \friendships\exists rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsExistsAsync (
			Friendships.ExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\exists rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsExists(Friendships.ExistsRequest request)
		{
			return RequestFriendshipsExistsAsync(request).Result;
		}
		
				
		JsonMethod<Friendships.ShowRequest, Stream> _requestFriendshipsShowMethod;
		/// <summary>
		/// This is a async request of \friendships\show rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsShowAsync (
			Friendships.ShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\show rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsShow(Friendships.ShowRequest request)
		{
			return RequestFriendshipsShowAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrl.ExpandRequest, Stream> _requestShortUrlExpandMethod;
		/// <summary>
		/// This is a async request of \short_url\expand rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlExpandAsync (
			ShortUrl.ExpandRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlExpandMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\expand rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlExpand(ShortUrl.ExpandRequest request)
		{
			return RequestShortUrlExpandAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrl.ShortenRequest, Stream> _requestShortUrlShortenMethod;
		/// <summary>
		/// This is a async request of \short_url\shorten rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlShortenAsync (
			ShortUrl.ShortenRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlShortenMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\shorten rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlShorten(ShortUrl.ShortenRequest request)
		{
			return RequestShortUrlShortenAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrl.Comment.CommentsRequest, Stream> _requestShortUrlCommentCommentsMethod;
		/// <summary>
		/// This is a async request of \short_url\comment\comments rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlCommentCommentsAsync (
			ShortUrl.Comment.CommentsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlCommentCommentsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\comment\comments rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlCommentComments(ShortUrl.Comment.CommentsRequest request)
		{
			return RequestShortUrlCommentCommentsAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrl.Comment.CountsRequest, Stream> _requestShortUrlCommentCountsMethod;
		/// <summary>
		/// This is a async request of \short_url\comment\counts rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlCommentCountsAsync (
			ShortUrl.Comment.CountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlCommentCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\comment\counts rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlCommentCounts(ShortUrl.Comment.CountsRequest request)
		{
			return RequestShortUrlCommentCountsAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrl.Share.CountsRequest, Stream> _requestShortUrlShareCountsMethod;
		/// <summary>
		/// This is a async request of \short_url\share\counts rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlShareCountsAsync (
			ShortUrl.Share.CountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlShareCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\share\counts rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlShareCounts(ShortUrl.Share.CountsRequest request)
		{
			return RequestShortUrlShareCountsAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrl.Share.StatusesRequest, Stream> _requestShortUrlShareStatusesMethod;
		/// <summary>
		/// This is a async request of \short_url\share\statuses rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlShareStatusesAsync (
			ShortUrl.Share.StatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlShareStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\share\statuses rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlShareStatuses(ShortUrl.Share.StatusesRequest request)
		{
			return RequestShortUrlShareStatusesAsync(request).Result;
		}
		
				
		JsonMethod<Socialgraph.FollowsIdsRequest, Stream> _requestSocialgraphFollowsIdsMethod;
		/// <summary>
		/// This is a async request of \socialgraph\followsIds rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户的粉丝用户ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/followers/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestSocialgraphFollowsIdsAsync (
			Socialgraph.FollowsIdsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestSocialgraphFollowsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \socialgraph\followsIds rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户的粉丝用户ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/followers/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestSocialgraphFollowsIds(Socialgraph.FollowsIdsRequest request)
		{
			return RequestSocialgraphFollowsIdsAsync(request).Result;
		}
		
				
		JsonMethod<Socialgraph.FriendsIdsRequest, Stream> _requestSocialgraphFriendsIdsMethod;
		/// <summary>
		/// This is a async request of \socialgraph\friendsIds rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户关注的一组用户的ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friends/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestSocialgraphFriendsIdsAsync (
			Socialgraph.FriendsIdsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestSocialgraphFriendsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \socialgraph\friendsIds rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户关注的一组用户的ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friends/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestSocialgraphFriendsIds(Socialgraph.FriendsIdsRequest request)
		{
			return RequestSocialgraphFriendsIdsAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentRequest, Stream> _requestStatusesCommentMethod;
		/// <summary>
		/// This is a async request of \statuses\comment rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentAsync (
			Statuses.CommentRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comment rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesComment(Statuses.CommentRequest request)
		{
			return RequestStatusesCommentAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentsRequest, Stream> _requestStatusesCommentsMethod;
		/// <summary>
		/// This is a async request of \statuses\comments rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博消息ID返回某条微博消息的评论列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsAsync (
			Statuses.CommentsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博消息ID返回某条微博消息的评论列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesComments(Statuses.CommentsRequest request)
		{
			return RequestStatusesCommentsAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentsByMeRequest, Stream> _requestStatusesCommentsByMeMethod;
		/// <summary>
		/// This is a async request of \statuses\comments_by_me rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsByMeAsync (
			Statuses.CommentsByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments_by_me rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentsByMe(Statuses.CommentsByMeRequest request)
		{
			return RequestStatusesCommentsByMeAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentsTimelineRequest, Stream> _requestStatusesCommentsTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\comments_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsTimelineAsync (
			Statuses.CommentsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentsTimeline(Statuses.CommentsTimelineRequest request)
		{
			return RequestStatusesCommentsTimelineAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentsToMeRequest, Stream> _requestStatusesCommentsToMeMethod;
		/// <summary>
		/// This is a async request of \statuses\comments_to_me rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsToMeAsync (
			Statuses.CommentsToMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsToMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments_to_me rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentsToMe(Statuses.CommentsToMeRequest request)
		{
			return RequestStatusesCommentsToMeAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentDestroyRequest, Stream> _requestStatusesCommentDestroyMethod;
		/// <summary>
		/// This is a async request of \statuses\comment_destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentDestroyAsync (
			Statuses.CommentDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comment_destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentDestroy(Statuses.CommentDestroyRequest request)
		{
			return RequestStatusesCommentDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CommentDestroyBatchRequest, Stream> _requestStatusesCommentDestroyBatchMethod;
		/// <summary>
		/// This is a async request of \statuses\comment_destroy_batch rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentDestroyBatchAsync (
			Statuses.CommentDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comment_destroy_batch rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentDestroyBatch(Statuses.CommentDestroyBatchRequest request)
		{
			return RequestStatusesCommentDestroyBatchAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.CountsRequest, Stream> _requestStatusesCountsMethod;
		/// <summary>
		/// This is a async request of \statuses\counts rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCountsAsync (
			Statuses.CountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\counts rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCounts(Statuses.CountsRequest request)
		{
			return RequestStatusesCountsAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.DestroyRequest, Stream> _requestStatusesDestroyMethod;
		/// <summary>
		/// This is a async request of \statuses\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID删除微博消息。注意：只能删除自己发布的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesDestroyAsync (
			Statuses.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID删除微博消息。注意：只能删除自己发布的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesDestroy(Statuses.DestroyRequest request)
		{
			return RequestStatusesDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.FollowersRequest, Stream> _requestStatusesFollowersMethod;
		/// <summary>
		/// This is a async request of \statuses\followers rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesFollowersAsync (
			Statuses.FollowersRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\followers rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesFollowers(Statuses.FollowersRequest request)
		{
			return RequestStatusesFollowersAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.FriendsRequest, Stream> _requestStatusesFriendsMethod;
		/// <summary>
		/// This is a async request of \statuses\friends rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesFriendsAsync (
			Statuses.FriendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesFriendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\friends rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesFriends(Statuses.FriendsRequest request)
		{
			return RequestStatusesFriendsAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.FriendsTimelineRequest, Stream> _requestStatusesFriendsTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\friends_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesFriendsTimelineAsync (
			Statuses.FriendsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesFriendsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\friends_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesFriendsTimeline(Statuses.FriendsTimelineRequest request)
		{
			return RequestStatusesFriendsTimelineAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.MentionsRequest, Stream> _requestStatusesMentionsMethod;
		/// <summary>
		/// This is a async request of \statuses\mentions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条提到登录用户的微博消息（即包含@username的微博消息） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/mentions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesMentionsAsync (
			Statuses.MentionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesMentionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\mentions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条提到登录用户的微博消息（即包含@username的微博消息） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/mentions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesMentions(Statuses.MentionsRequest request)
		{
			return RequestStatusesMentionsAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.PublicTimelineRequest, Stream> _requestStatusesPublicTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\public_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesPublicTimelineAsync (
			Statuses.PublicTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesPublicTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\public_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesPublicTimeline(Statuses.PublicTimelineRequest request)
		{
			return RequestStatusesPublicTimelineAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.ReplyRequest, Stream> _requestStatusesReplyMethod;
		/// <summary>
		/// This is a async request of \statuses\reply rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesReplyAsync (
			Statuses.ReplyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesReplyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\reply rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesReply(Statuses.ReplyRequest request)
		{
			return RequestStatusesReplyAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.RepostRequest, Stream> _requestStatusesRepostMethod;
		/// <summary>
		/// This is a async request of \statuses\repost rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesRepostAsync (
			Statuses.RepostRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesRepostMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\repost rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesRepost(Statuses.RepostRequest request)
		{
			return RequestStatusesRepostAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.RepostByMeRequest, Stream> _requestStatusesRepostByMeMethod;
		/// <summary>
		/// This is a async request of \statuses\repost_by_me rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesRepostByMeAsync (
			Statuses.RepostByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesRepostByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\repost_by_me rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesRepostByMe(Statuses.RepostByMeRequest request)
		{
			return RequestStatusesRepostByMeAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.RepostTimelineRequest, Stream> _requestStatusesRepostTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\repost_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回一条原创微博消息的最新n条转发微博消息。本接口无法对非原创微博进行查询。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesRepostTimelineAsync (
			Statuses.RepostTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesRepostTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\repost_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回一条原创微博消息的最新n条转发微博消息。本接口无法对非原创微博进行查询。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesRepostTimeline(Statuses.RepostTimelineRequest request)
		{
			return RequestStatusesRepostTimelineAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.ResetCountRequest, Stream> _requestStatusesResetCountMethod;
		/// <summary>
		/// This is a async request of \statuses\reset_count rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesResetCountAsync (
			Statuses.ResetCountRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesResetCountMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\reset_count rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesResetCount(Statuses.ResetCountRequest request)
		{
			return RequestStatusesResetCountAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.ShowRequest, Stream> _requestStatusesShowMethod;
		/// <summary>
		/// This is a async request of \statuses\show rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesShowAsync (
			Statuses.ShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\show rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesShow(Statuses.ShowRequest request)
		{
			return RequestStatusesShowAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.UnreadRequest, Stream> _requestStatusesUnreadMethod;
		/// <summary>
		/// This is a async request of \statuses\unread rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUnreadAsync (
			Statuses.UnreadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUnreadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\unread rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUnread(Statuses.UnreadRequest request)
		{
			return RequestStatusesUnreadAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.UpdateRequest, Stream> _requestStatusesUpdateMethod;
		/// <summary>
		/// This is a async request of \statuses\update rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUpdateAsync (
			Statuses.UpdateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\update rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUpdate(Statuses.UpdateRequest request)
		{
			return RequestStatusesUpdateAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.UploadRequest, Stream> _requestStatusesUploadMethod;
		/// <summary>
		/// This is a async request of \statuses\upload rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUploadAsync (
			Statuses.UploadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUploadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\upload rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUpload(Statuses.UploadRequest request)
		{
			return RequestStatusesUploadAsync(request).Result;
		}
		
				
		JsonMethod<Statuses.UserTimelineRequest, Stream> _requestStatusesUserTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\user_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUserTimelineAsync (
			Statuses.UserTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUserTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\user_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUserTimeline(Statuses.UserTimelineRequest request)
		{
			return RequestStatusesUserTimelineAsync(request).Result;
		}
		
				
		JsonMethod<Tags.CreateRequest, Stream> _requestTagsCreateMethod;
		/// <summary>
		/// This is a async request of \tags\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsCreateAsync (
			Tags.CreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsCreate(Tags.CreateRequest request)
		{
			return RequestTagsCreateAsync(request).Result;
		}
		
				
		JsonMethod<Tags.DestroyRequest, Stream> _requestTagsDestroyMethod;
		/// <summary>
		/// This is a async request of \tags\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsDestroyAsync (
			Tags.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsDestroy(Tags.DestroyRequest request)
		{
			return RequestTagsDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Tags.DestroyBatchRequest, Stream> _requestTagsDestroyBatchMethod;
		/// <summary>
		/// This is a async request of \tags\destroy_batch rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除一组标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsDestroyBatchAsync (
			Tags.DestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\destroy_batch rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除一组标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsDestroyBatch(Tags.DestroyBatchRequest request)
		{
			return RequestTagsDestroyBatchAsync(request).Result;
		}
		
				
		JsonMethod<Tags.SuggestionsRequest, Stream> _requestTagsSuggestionsMethod;
		/// <summary>
		/// This is a async request of \tags\suggestions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsSuggestionsAsync (
			Tags.SuggestionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsSuggestionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\suggestions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsSuggestions(Tags.SuggestionsRequest request)
		{
			return RequestTagsSuggestionsAsync(request).Result;
		}
		
				
		JsonMethod<Tags.TagsRequest, Stream> _requestTagsTagsMethod;
		/// <summary>
		/// This is a async request of \tags\tags rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回指定用户的标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsTagsAsync (
			Tags.TagsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsTagsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\tags rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回指定用户的标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsTags(Tags.TagsRequest request)
		{
			return RequestTagsTagsAsync(request).Result;
		}
		
				
		JsonMethod<Trends.DailyRequest, Stream> _requestTrendsDailyMethod;
		/// <summary>
		/// This is a async request of \trends\daily rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一天内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/daily.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsDailyAsync (
			Trends.DailyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsDailyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\daily rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一天内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/daily.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsDaily(Trends.DailyRequest request)
		{
			return RequestTrendsDailyAsync(request).Result;
		}
		
				
		JsonMethod<Trends.DestroyRequest, Stream> _requestTrendsDestroyMethod;
		/// <summary>
		/// This is a async request of \trends\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某话题的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsDestroyAsync (
			Trends.DestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某话题的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsDestroy(Trends.DestroyRequest request)
		{
			return RequestTrendsDestroyAsync(request).Result;
		}
		
				
		JsonMethod<Trends.FollowRequest, Stream> _requestTrendsFollowMethod;
		/// <summary>
		/// This is a async request of \trends\follow rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsFollowAsync (
			Trends.FollowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsFollowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\follow rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsFollow(Trends.FollowRequest request)
		{
			return RequestTrendsFollowAsync(request).Result;
		}
		
				
		JsonMethod<Trends.HourlyRequest, Stream> _requestTrendsHourlyMethod;
		/// <summary>
		/// This is a async request of \trends\hourly rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一小时内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/hourly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsHourlyAsync (
			Trends.HourlyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsHourlyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\hourly rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一小时内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/hourly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsHourly(Trends.HourlyRequest request)
		{
			return RequestTrendsHourlyAsync(request).Result;
		}
		
				
		JsonMethod<Trends.StatusesRequest, Stream> _requestTrendsStatusesMethod;
		/// <summary>
		/// This is a async request of \trends\statuses rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsStatusesAsync (
			Trends.StatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\statuses rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsStatuses(Trends.StatusesRequest request)
		{
			return RequestTrendsStatusesAsync(request).Result;
		}
		
				
		JsonMethod<Trends.TrendsRequest, Stream> _requestTrendsTrendsMethod;
		/// <summary>
		/// This is a async request of \trends\trends rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsTrendsAsync (
			Trends.TrendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsTrendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\trends rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsTrends(Trends.TrendsRequest request)
		{
			return RequestTrendsTrendsAsync(request).Result;
		}
		
				
		JsonMethod<Trends.WeeklyRequest, Stream> _requestTrendsWeeklyMethod;
		/// <summary>
		/// This is a async request of \trends\weekly rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一周内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/weekly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsWeeklyAsync (
			Trends.WeeklyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsWeeklyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\weekly rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一周内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/weekly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsWeekly(Trends.WeeklyRequest request)
		{
			return RequestTrendsWeeklyAsync(request).Result;
		}
		
				
		JsonMethod<User.Friends.UpdateRemarkRequest, Stream> _requestUserFriendsUpdateRemarkMethod;
		/// <summary>
		/// This is a async request of \user\friends\update_remark rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUserFriendsUpdateRemarkAsync (
			User.Friends.UpdateRemarkRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUserFriendsUpdateRemarkMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \user\friends\update_remark rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUserFriendsUpdateRemark(User.Friends.UpdateRemarkRequest request)
		{
			return RequestUserFriendsUpdateRemarkAsync(request).Result;
		}
		
				
		JsonMethod<Users.HotRequest, Stream> _requestUsersHotMethod;
		/// <summary>
		/// This is a async request of \users\hot rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUsersHotAsync (
			Users.HotRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUsersHotMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \users\hot rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUsersHot(Users.HotRequest request)
		{
			return RequestUsersHotAsync(request).Result;
		}
		
				
		JsonMethod<Users.ShowRequest, Stream> _requestUsersShowMethod;
		/// <summary>
		/// This is a async request of \users\show rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUsersShowAsync (
			Users.ShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUsersShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \users\show rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUsersShow(Users.ShowRequest request)
		{
			return RequestUsersShowAsync(request).Result;
		}
		
				
		JsonMethod<Users.SuggestionsRequest, Stream> _requestUsersSuggestionsMethod;
		/// <summary>
		/// This is a async request of \users\suggestions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前用户可能感兴趣的用户。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUsersSuggestionsAsync (
			Users.SuggestionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUsersSuggestionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \users\suggestions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前用户可能感兴趣的用户。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUsersSuggestions(Users.SuggestionsRequest request)
		{
			return RequestUsersSuggestionsAsync(request).Result;
		}
		
				
	}

}

 





















