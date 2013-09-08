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



	
				//ns
	[DataContract]
	public partial class EmotionsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _phrase;
		[DataMember(Name = "phrase")]
		public string Phrase
		{ 
			get { return _phrase;} 
			set 
			{ 
				_phrase = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Phrase"));
			}
		}

		string _type;
		[DataMember(Name = "type")]
		public string Type
		{ 
			get { return _type;} 
			set 
			{ 
				_type = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Type"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		bool _is_hot;
		[DataMember(Name = "is_hot")]
		public bool IsHot
		{ 
			get { return _is_hot;} 
			set 
			{ 
				_is_hot = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("IsHot"));
			}
		}

		bool _is_common;
		[DataMember(Name = "is_common")]
		public bool IsCommon
		{ 
			get { return _is_common;} 
			set 
			{ 
				_is_common = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("IsCommon"));
			}
		}

		double _order_number;
		[DataMember(Name = "order_number")]
		public double OrderNumber
		{ 
			get { return _order_number;} 
			set 
			{ 
				_order_number = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("OrderNumber"));
			}
		}

		string _category;
		[DataMember(Name = "category")]
		public string Category
		{ 
			get { return _category;} 
			set 
			{ 
				_category = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Category"));
			}
		}

	}
	[CollectionDataContract]
	public partial class EmotionsResponse : ObservableCollection<EmotionsResponseArrayItem>
	{
	}

				
				//ns
	[DataContract]
	public partial class FavoritesResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

		UserType _user;
		[DataMember(Name = "user")]
		public UserType User
		{ 
			get { return _user;} 
			set 
			{ 
				_user = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
			}
		}

		RetweetedStatusType _retweeted_status;
		[DataMember(Name = "retweeted_status")]
		public RetweetedStatusType RetweetedStatus
		{ 
			get { return _retweeted_status;} 
			set 
			{ 
				_retweeted_status = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
			}
		}

		Object[] _annotations;
		[DataMember(Name = "annotations")]
		public Object[] Annotations
		{ 
			get { return _annotations;} 
			set 
			{ 
				_annotations = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
			}
		}

		[DataContract]
		public partial class UserType: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

		}
		[DataContract]
		public partial class RetweetedStatusType: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
	}
	[CollectionDataContract]
	public partial class FavoritesResponse : ObservableCollection<FavoritesResponseArrayItem>
	{
	}

				
				//nsAccount
	namespace Account
	{

		[DataContract]
		public partial class GetPrivacyResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _comment;
			[DataMember(Name = "comment")]
			public string Comment
			{ 
				get { return _comment;} 
				set 
				{ 
					_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Comment"));
				}
			}

			string _dm;
			[DataMember(Name = "dm")]
			public string Dm
			{ 
				get { return _dm;} 
				set 
				{ 
					_dm = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Dm"));
				}
			}

			string _real_name;
			[DataMember(Name = "real_name")]
			public string RealName
			{ 
				get { return _real_name;} 
				set 
				{ 
					_real_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RealName"));
				}
			}

			string _geo;
			[DataMember(Name = "geo")]
			public string Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _badge;
			[DataMember(Name = "badge")]
			public string Badge
			{ 
				get { return _badge;} 
				set 
				{ 
					_badge = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Badge"));
				}
			}

		}
	}


				
				//nsAccount
	namespace Account
	{

		[DataContract]
		public partial class RateLimitStatusResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _hourly_limit;
			[DataMember(Name = "hourly_limit")]
			public double HourlyLimit
			{ 
				get { return _hourly_limit;} 
				set 
				{ 
					_hourly_limit = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("HourlyLimit"));
				}
			}

			double _reset_time_in_seconds;
			[DataMember(Name = "reset_time_in_seconds")]
			public double ResetTimeInSeconds
			{ 
				get { return _reset_time_in_seconds;} 
				set 
				{ 
					_reset_time_in_seconds = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ResetTimeInSeconds"));
				}
			}

			string _reset_time;
			[DataMember(Name = "reset_time")]
			public string ResetTime
			{ 
				get { return _reset_time;} 
				set 
				{ 
					_reset_time = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ResetTime"));
				}
			}

			double _remaining_hits;
			[DataMember(Name = "remaining_hits")]
			public double RemainingHits
			{ 
				get { return _remaining_hits;} 
				set 
				{ 
					_remaining_hits = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RemainingHits"));
				}
			}

		}
	}


				
				//ns
	[DataContract]
	public partial class AccountResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

		StatusType _status;
		[DataMember(Name = "status")]
		public StatusType Status
		{ 
			get { return _status;} 
			set 
			{ 
				_status = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
			}
		}

		[DataContract]
		public partial class StatusType: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

		}
	}

				
				//nsAccount
	namespace Account
	{

		[DataContract]
		public partial class UpdateProfileResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

			}
		}
	}


				
				//nsAccount
	namespace Account
	{

		[DataContract]
		public partial class UpdateProfileImageResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

			}
		}
	}


				
				//nsAccount
	namespace Account
	{

		[DataContract]
		public partial class VerifyCredentialsResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

			}
		}
	}


				
				//nsBlocks
	namespace Blocks
	{

		[DataContract]
		public partial class BlockingResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				string _thumbnail_pic;
				[DataMember(Name = "thumbnail_pic")]
				public string ThumbnailPic
				{ 
					get { return _thumbnail_pic;} 
					set 
					{ 
						_thumbnail_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
					}
				}

				string _bmiddle_pic;
				[DataMember(Name = "bmiddle_pic")]
				public string BmiddlePic
				{ 
					get { return _bmiddle_pic;} 
					set 
					{ 
						_bmiddle_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
					}
				}

				string _original_pic;
				[DataMember(Name = "original_pic")]
				public string OriginalPic
				{ 
					get { return _original_pic;} 
					set 
					{ 
						_original_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

			}
		}
		[CollectionDataContract]
		public partial class BlockingResponse : ObservableCollection<BlockingResponseArrayItem>
		{
		}
	}


				
				//nsBlocks
	namespace Blocks
	{

		[DataContract]
		public partial class CreateResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				RetweetedStatusType _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatusType RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
					}
				}

				[DataContract]
				public partial class RetweetedStatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					string _thumbnail_pic;
					[DataMember(Name = "thumbnail_pic")]
					public string ThumbnailPic
					{ 
						get { return _thumbnail_pic;} 
						set 
						{ 
							_thumbnail_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
						}
					}

					string _bmiddle_pic;
					[DataMember(Name = "bmiddle_pic")]
					public string BmiddlePic
					{ 
						get { return _bmiddle_pic;} 
						set 
						{ 
							_bmiddle_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
						}
					}

					string _original_pic;
					[DataMember(Name = "original_pic")]
					public string OriginalPic
					{ 
						get { return _original_pic;} 
						set 
						{ 
							_original_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					AnnotationsArrayItem[] _annotations;
					[DataMember(Name = "annotations")]
					public AnnotationsArrayItem[] Annotations
					{ 
						get { return _annotations;} 
						set 
						{ 
							_annotations = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

					}
					[DataContract]
					public partial class AnnotationsArrayItem: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						string _server_ip;
						[DataMember(Name = "server_ip")]
						public string ServerIp
						{ 
							get { return _server_ip;} 
							set 
							{ 
								_server_ip = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ServerIp"));
							}
						}

					}
				}
			}
		}
	}


				
				//nsBlocks
	namespace Blocks
	{

		[DataContract]
		public partial class DestroyResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				RetweetedStatusType _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatusType RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
					}
				}

				[DataContract]
				public partial class RetweetedStatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					string _thumbnail_pic;
					[DataMember(Name = "thumbnail_pic")]
					public string ThumbnailPic
					{ 
						get { return _thumbnail_pic;} 
						set 
						{ 
							_thumbnail_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
						}
					}

					string _bmiddle_pic;
					[DataMember(Name = "bmiddle_pic")]
					public string BmiddlePic
					{ 
						get { return _bmiddle_pic;} 
						set 
						{ 
							_bmiddle_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
						}
					}

					string _original_pic;
					[DataMember(Name = "original_pic")]
					public string OriginalPic
					{ 
						get { return _original_pic;} 
						set 
						{ 
							_original_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					AnnotationsArrayItem[] _annotations;
					[DataMember(Name = "annotations")]
					public AnnotationsArrayItem[] Annotations
					{ 
						get { return _annotations;} 
						set 
						{ 
							_annotations = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

					}
					[DataContract]
					public partial class AnnotationsArrayItem: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						string _server_ip;
						[DataMember(Name = "server_ip")]
						public string ServerIp
						{ 
							get { return _server_ip;} 
							set 
							{ 
								_server_ip = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ServerIp"));
							}
						}

					}
				}
			}
		}
	}


				
				//nsBlocks
	namespace Blocks
	{

		[DataContract]
		public partial class ExistsResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			bool _result;
			[DataMember(Name = "result")]
			public bool Result
			{ 
				get { return _result;} 
				set 
				{ 
					_result = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Result"));
				}
			}

		}
	}


				
				//nsFavorites
	namespace Favorites
	{

		[DataContract]
		public partial class CreateResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			RetweetedStatusType _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatusType RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
				}
			}

			Object[] _annotations;
			[DataMember(Name = "annotations")]
			public Object[] Annotations
			{ 
				get { return _annotations;} 
				set 
				{ 
					_annotations = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class RetweetedStatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
	}


				
				//nsFavorites
	namespace Favorites
	{

		[DataContract]
		public partial class DestroyResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			RetweetedStatusType _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatusType RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
				}
			}

			Object[] _annotations;
			[DataMember(Name = "annotations")]
			public Object[] Annotations
			{ 
				get { return _annotations;} 
				set 
				{ 
					_annotations = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class RetweetedStatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
	}


				
				//nsFavorites
	namespace Favorites
	{

		[DataContract]
		public partial class DestroyBatchResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

			}
		}
		[CollectionDataContract]
		public partial class DestroyBatchResponse : ObservableCollection<DestroyBatchResponseArrayItem>
		{
		}
	}


				
				//nsFriendships
	namespace Friendships
	{

		[DataContract]
		public partial class CreateResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

			}
		}
	}


				
				//nsFriendships
	namespace Friendships
	{

		[DataContract]
		public partial class DestoryResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

			}
		}
	}


				
				//nsFriendships
	namespace Friendships
	{

		[DataContract]
		public partial class DestroyResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _bmiddle_pic;
				[DataMember(Name = "bmiddle_pic")]
				public string BmiddlePic
				{ 
					get { return _bmiddle_pic;} 
					set 
					{ 
						_bmiddle_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
					}
				}

				string _original_pic;
				[DataMember(Name = "original_pic")]
				public string OriginalPic
				{ 
					get { return _original_pic;} 
					set 
					{ 
						_original_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				string _thumbnail_pic;
				[DataMember(Name = "thumbnail_pic")]
				public string ThumbnailPic
				{ 
					get { return _thumbnail_pic;} 
					set 
					{ 
						_thumbnail_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

			}
		}
	}


				
				//nsFriendships
	namespace Friendships
	{

		[DataContract]
		public partial class ExistsResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			bool _friends;
			[DataMember(Name = "friends")]
			public bool Friends
			{ 
				get { return _friends;} 
				set 
				{ 
					_friends = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Friends"));
				}
			}

		}
	}


				
				//nsFriendships
	namespace Friendships
	{

		[DataContract]
		public partial class ShowResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			SourceType _source;
			[DataMember(Name = "source")]
			public SourceType Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			TargetType _target;
			[DataMember(Name = "target")]
			public TargetType Target
			{ 
				get { return _target;} 
				set 
				{ 
					_target = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Target"));
				}
			}

			[DataContract]
			public partial class SourceType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _followed_by;
				[DataMember(Name = "followed_by")]
				public bool FollowedBy
				{ 
					get { return _followed_by;} 
					set 
					{ 
						_followed_by = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowedBy"));
					}
				}

				bool _notifications_enabled;
				[DataMember(Name = "notifications_enabled")]
				public bool NotificationsEnabled
				{ 
					get { return _notifications_enabled;} 
					set 
					{ 
						_notifications_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("NotificationsEnabled"));
					}
				}

			}
			[DataContract]
			public partial class TargetType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _followed_by;
				[DataMember(Name = "followed_by")]
				public bool FollowedBy
				{ 
					get { return _followed_by;} 
					set 
					{ 
						_followed_by = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowedBy"));
					}
				}

				bool _notifications_enabled;
				[DataMember(Name = "notifications_enabled")]
				public bool NotificationsEnabled
				{ 
					get { return _notifications_enabled;} 
					set 
					{ 
						_notifications_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("NotificationsEnabled"));
					}
				}

			}
		}
	}


				
				//nsShortUrl
	namespace ShortUrl
	{

		[DataContract]
		public partial class ExpandResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _url_short;
			[DataMember(Name = "url_short")]
			public string UrlShort
			{ 
				get { return _url_short;} 
				set 
				{ 
					_url_short = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
				}
			}

			string _url_long;
			[DataMember(Name = "url_long")]
			public string UrlLong
			{ 
				get { return _url_long;} 
				set 
				{ 
					_url_long = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlLong"));
				}
			}

			double _type;
			[DataMember(Name = "type")]
			public double Type
			{ 
				get { return _type;} 
				set 
				{ 
					_type = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Type"));
				}
			}

		}
		[CollectionDataContract]
		public partial class ExpandResponse : ObservableCollection<ExpandResponseArrayItem>
		{
		}
	}


				
				//nsShortUrl
	namespace ShortUrl
	{

		[DataContract]
		public partial class ShortenResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _url_short;
			[DataMember(Name = "url_short")]
			public string UrlShort
			{ 
				get { return _url_short;} 
				set 
				{ 
					_url_short = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
				}
			}

			string _url_long;
			[DataMember(Name = "url_long")]
			public string UrlLong
			{ 
				get { return _url_long;} 
				set 
				{ 
					_url_long = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlLong"));
				}
			}

			double _type;
			[DataMember(Name = "type")]
			public double Type
			{ 
				get { return _type;} 
				set 
				{ 
					_type = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Type"));
				}
			}

		}
		[CollectionDataContract]
		public partial class ShortenResponse : ObservableCollection<ShortenResponseArrayItem>
		{
		}
	}


				
				//nsShortUrl.Comment
	namespace ShortUrl.Comment
	{

		[DataContract]
		public partial class CommentsResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _url_short;
			[DataMember(Name = "url_short")]
			public string UrlShort
			{ 
				get { return _url_short;} 
				set 
				{ 
					_url_short = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
				}
			}

			ShareCommentsArrayItem[] _share_comments;
			[DataMember(Name = "share_comments")]
			public ShareCommentsArrayItem[] ShareComments
			{ 
				get { return _share_comments;} 
				set 
				{ 
					_share_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ShareComments"));
				}
			}

			[DataContract]
			public partial class ShareCommentsArrayItem: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				StatusType _status;
				[DataMember(Name = "status")]
				public StatusType Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

					StatusType _status;
					[DataMember(Name = "status")]
					public StatusType Status
					{ 
						get { return _status;} 
						set 
						{ 
							_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					[DataContract]
					public partial class StatusType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						string _text;
						[DataMember(Name = "text")]
						public string Text
						{ 
							get { return _text;} 
							set 
							{ 
								_text = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
							}
						}

						bool _truncated;
						[DataMember(Name = "truncated")]
						public bool Truncated
						{ 
							get { return _truncated;} 
							set 
							{ 
								_truncated = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
							}
						}

						RetweetedStatusType _retweeted_status;
						[DataMember(Name = "retweeted_status")]
						public RetweetedStatusType RetweetedStatus
						{ 
							get { return _retweeted_status;} 
							set 
							{ 
								_retweeted_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
							}
						}

						string _in_reply_to_status_id;
						[DataMember(Name = "in_reply_to_status_id")]
						public string InReplyToStatusId
						{ 
							get { return _in_reply_to_status_id;} 
							set 
							{ 
								_in_reply_to_status_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
							}
						}

						string _in_reply_to_screen_name;
						[DataMember(Name = "in_reply_to_screen_name")]
						public string InReplyToScreenName
						{ 
							get { return _in_reply_to_screen_name;} 
							set 
							{ 
								_in_reply_to_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
							}
						}

						Object _geo;
						[DataMember(Name = "geo")]
						public Object Geo
						{ 
							get { return _geo;} 
							set 
							{ 
								_geo = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
							}
						}

						bool _favorited;
						[DataMember(Name = "favorited")]
						public bool Favorited
						{ 
							get { return _favorited;} 
							set 
							{ 
								_favorited = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
							}
						}

						string _in_reply_to_user_id;
						[DataMember(Name = "in_reply_to_user_id")]
						public string InReplyToUserId
						{ 
							get { return _in_reply_to_user_id;} 
							set 
							{ 
								_in_reply_to_user_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
							}
						}

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _source;
						[DataMember(Name = "source")]
						public string Source
						{ 
							get { return _source;} 
							set 
							{ 
								_source = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
							}
						}

						[DataContract]
						public partial class RetweetedStatusType: INotifyPropertyChanged
						{
							public event PropertyChangedEventHandler  PropertyChanged ;

							string _created_at;
							[DataMember(Name = "created_at")]
							public string CreatedAt
							{ 
								get { return _created_at;} 
								set 
								{ 
									_created_at = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
								}
							}

							string _text;
							[DataMember(Name = "text")]
							public string Text
							{ 
								get { return _text;} 
								set 
								{ 
									_text = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
								}
							}

							bool _truncated;
							[DataMember(Name = "truncated")]
							public bool Truncated
							{ 
								get { return _truncated;} 
								set 
								{ 
									_truncated = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
								}
							}

							string _in_reply_to_status_id;
							[DataMember(Name = "in_reply_to_status_id")]
							public string InReplyToStatusId
							{ 
								get { return _in_reply_to_status_id;} 
								set 
								{ 
									_in_reply_to_status_id = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
								}
							}

							string _in_reply_to_screen_name;
							[DataMember(Name = "in_reply_to_screen_name")]
							public string InReplyToScreenName
							{ 
								get { return _in_reply_to_screen_name;} 
								set 
								{ 
									_in_reply_to_screen_name = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
								}
							}

							Object _geo;
							[DataMember(Name = "geo")]
							public Object Geo
							{ 
								get { return _geo;} 
								set 
								{ 
									_geo = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
								}
							}

							UserType _user;
							[DataMember(Name = "user")]
							public UserType User
							{ 
								get { return _user;} 
								set 
								{ 
									_user = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
								}
							}

							bool _favorited;
							[DataMember(Name = "favorited")]
							public bool Favorited
							{ 
								get { return _favorited;} 
								set 
								{ 
									_favorited = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
								}
							}

							string _in_reply_to_user_id;
							[DataMember(Name = "in_reply_to_user_id")]
							public string InReplyToUserId
							{ 
								get { return _in_reply_to_user_id;} 
								set 
								{ 
									_in_reply_to_user_id = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
								}
							}

							double _id;
							[DataMember(Name = "id")]
							public double Id
							{ 
								get { return _id;} 
								set 
								{ 
									_id = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
								}
							}

							string _source;
							[DataMember(Name = "source")]
							public string Source
							{ 
								get { return _source;} 
								set 
								{ 
									_source = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
								}
							}

							[DataContract]
							public partial class UserType: INotifyPropertyChanged
							{
								public event PropertyChangedEventHandler  PropertyChanged ;

								string _name;
								[DataMember(Name = "name")]
								public string Name
								{ 
									get { return _name;} 
									set 
									{ 
										_name = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
									}
								}

								string _domain;
								[DataMember(Name = "domain")]
								public string Domain
								{ 
									get { return _domain;} 
									set 
									{ 
										_domain = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
									}
								}

								bool _geo_enabled;
								[DataMember(Name = "geo_enabled")]
								public bool GeoEnabled
								{ 
									get { return _geo_enabled;} 
									set 
									{ 
										_geo_enabled = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
									}
								}

								double _followers_count;
								[DataMember(Name = "followers_count")]
								public double FollowersCount
								{ 
									get { return _followers_count;} 
									set 
									{ 
										_followers_count = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
									}
								}

								double _statuses_count;
								[DataMember(Name = "statuses_count")]
								public double StatusesCount
								{ 
									get { return _statuses_count;} 
									set 
									{ 
										_statuses_count = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
									}
								}

								double _favourites_count;
								[DataMember(Name = "favourites_count")]
								public double FavouritesCount
								{ 
									get { return _favourites_count;} 
									set 
									{ 
										_favourites_count = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
									}
								}

								string _city;
								[DataMember(Name = "city")]
								public string City
								{ 
									get { return _city;} 
									set 
									{ 
										_city = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
									}
								}

								string _description;
								[DataMember(Name = "description")]
								public string Description
								{ 
									get { return _description;} 
									set 
									{ 
										_description = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
									}
								}

								bool _verified;
								[DataMember(Name = "verified")]
								public bool Verified
								{ 
									get { return _verified;} 
									set 
									{ 
										_verified = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
									}
								}

								double _id;
								[DataMember(Name = "id")]
								public double Id
								{ 
									get { return _id;} 
									set 
									{ 
										_id = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
									}
								}

								string _gender;
								[DataMember(Name = "gender")]
								public string Gender
								{ 
									get { return _gender;} 
									set 
									{ 
										_gender = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
									}
								}

								double _friends_count;
								[DataMember(Name = "friends_count")]
								public double FriendsCount
								{ 
									get { return _friends_count;} 
									set 
									{ 
										_friends_count = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
									}
								}

								string _screen_name;
								[DataMember(Name = "screen_name")]
								public string ScreenName
								{ 
									get { return _screen_name;} 
									set 
									{ 
										_screen_name = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
									}
								}

								bool _allow_all_act_msg;
								[DataMember(Name = "allow_all_act_msg")]
								public bool AllowAllActMsg
								{ 
									get { return _allow_all_act_msg;} 
									set 
									{ 
										_allow_all_act_msg = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
									}
								}

								bool _following;
								[DataMember(Name = "following")]
								public bool Following
								{ 
									get { return _following;} 
									set 
									{ 
										_following = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
									}
								}

								string _url;
								[DataMember(Name = "url")]
								public string Url
								{ 
									get { return _url;} 
									set 
									{ 
										_url = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
									}
								}

								string _profile_image_url;
								[DataMember(Name = "profile_image_url")]
								public string ProfileImageUrl
								{ 
									get { return _profile_image_url;} 
									set 
									{ 
										_profile_image_url = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
									}
								}

								string _created_at;
								[DataMember(Name = "created_at")]
								public string CreatedAt
								{ 
									get { return _created_at;} 
									set 
									{ 
										_created_at = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
									}
								}

								string _province;
								[DataMember(Name = "province")]
								public string Province
								{ 
									get { return _province;} 
									set 
									{ 
										_province = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
									}
								}

								string _location;
								[DataMember(Name = "location")]
								public string Location
								{ 
									get { return _location;} 
									set 
									{ 
										_location = value;
										if ( this.PropertyChanged != null )
											this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
									}
								}

							}
						}
					}
				}
				[DataContract]
				public partial class StatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

					}
				}
			}
		}
	}


				
				//nsShortUrl.Comment
	namespace ShortUrl.Comment
	{

		[DataContract]
		public partial class CountsResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _url_short;
			[DataMember(Name = "url_short")]
			public string UrlShort
			{ 
				get { return _url_short;} 
				set 
				{ 
					_url_short = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
				}
			}

			string _comment_counts;
			[DataMember(Name = "comment_counts")]
			public string CommentCounts
			{ 
				get { return _comment_counts;} 
				set 
				{ 
					_comment_counts = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CommentCounts"));
				}
			}

		}
		[CollectionDataContract]
		public partial class CountsResponse : ObservableCollection<CountsResponseArrayItem>
		{
		}
	}


				
				//nsShortUrl.Share
	namespace ShortUrl.Share
	{

		[DataContract]
		public partial class CountsResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _url_short;
			[DataMember(Name = "url_short")]
			public string UrlShort
			{ 
				get { return _url_short;} 
				set 
				{ 
					_url_short = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
				}
			}

			string _share_counts;
			[DataMember(Name = "share_counts")]
			public string ShareCounts
			{ 
				get { return _share_counts;} 
				set 
				{ 
					_share_counts = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ShareCounts"));
				}
			}

		}
		[CollectionDataContract]
		public partial class CountsResponse : ObservableCollection<CountsResponseArrayItem>
		{
		}
	}


				
				//nsShortUrl.Share
	namespace ShortUrl.Share
	{

		[DataContract]
		public partial class StatusesResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			ShareStatusesArrayItem[] _share_statuses;
			[DataMember(Name = "share_statuses")]
			public ShareStatusesArrayItem[] ShareStatuses
			{ 
				get { return _share_statuses;} 
				set 
				{ 
					_share_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ShareStatuses"));
				}
			}

			string _url_short;
			[DataMember(Name = "url_short")]
			public string UrlShort
			{ 
				get { return _url_short;} 
				set 
				{ 
					_url_short = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
				}
			}

			[DataContract]
			public partial class ShareStatusesArrayItem: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CommentResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

				StatusType _status;
				[DataMember(Name = "status")]
				public StatusType Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
					}
				}

				[DataContract]
				public partial class StatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

				}
			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				AnnotationsArrayItem[] _annotations;
				[DataMember(Name = "annotations")]
				public AnnotationsArrayItem[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
				[DataContract]
				public partial class AnnotationsArrayItem: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _server_ip;
					[DataMember(Name = "server_ip")]
					public string ServerIp
					{ 
						get { return _server_ip;} 
						set 
						{ 
							_server_ip = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ServerIp"));
						}
					}

				}
			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CommentsByMeResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class CommentsByMeResponse : ObservableCollection<CommentsByMeResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CommentsTimelineResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class CommentsTimelineResponse : ObservableCollection<CommentsTimelineResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CommentsToMeResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class CommentsToMeResponse : ObservableCollection<CommentsToMeResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CommentDestroyResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CommentDestroyBatchResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class CommentDestroyBatchResponse : ObservableCollection<CommentDestroyBatchResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class CountsResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			double _comments;
			[DataMember(Name = "comments")]
			public double Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Comments"));
				}
			}

			double _rt;
			[DataMember(Name = "rt")]
			public double Rt
			{ 
				get { return _rt;} 
				set 
				{ 
					_rt = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Rt"));
				}
			}

		}
		[CollectionDataContract]
		public partial class CountsResponse : ObservableCollection<CountsResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class DestoryResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class FollowersResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				RetweetedStatusType _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatusType RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
					}
				}

				[DataContract]
				public partial class RetweetedStatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

					}
				}
			}
		}
		[CollectionDataContract]
		public partial class FollowersResponse : ObservableCollection<FollowersResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class FriendsResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			string _remark;
			[DataMember(Name = "remark")]
			public string Remark
			{ 
				get { return _remark;} 
				set 
				{ 
					_remark = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Remark"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				RetweetedStatusType _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatusType RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
					}
				}

				[DataContract]
				public partial class RetweetedStatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

					}
				}
			}
		}
		[CollectionDataContract]
		public partial class FriendsResponse : ObservableCollection<FriendsResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class FriendsTimelineResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			string _thumbnail_pic;
			[DataMember(Name = "thumbnail_pic")]
			public string ThumbnailPic
			{ 
				get { return _thumbnail_pic;} 
				set 
				{ 
					_thumbnail_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
				}
			}

			string _bmiddle_pic;
			[DataMember(Name = "bmiddle_pic")]
			public string BmiddlePic
			{ 
				get { return _bmiddle_pic;} 
				set 
				{ 
					_bmiddle_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
				}
			}

			string _original_pic;
			[DataMember(Name = "original_pic")]
			public string OriginalPic
			{ 
				get { return _original_pic;} 
				set 
				{ 
					_original_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			double _reposts_count;
			[DataMember(Name = "reposts_count")]
			public double RepostsCount
			{ 
				get { return _reposts_count;} 
				set 
				{ 
					_reposts_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RepostsCount"));
				}
			}

			double _comments_count;
			[DataMember(Name = "comments_count")]
			public double CommentsCount
			{ 
				get { return _comments_count;} 
				set 
				{ 
					_comments_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CommentsCount"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			RetweetedStatusType _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatusType RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class RetweetedStatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				string _thumbnail_pic;
				[DataMember(Name = "thumbnail_pic")]
				public string ThumbnailPic
				{ 
					get { return _thumbnail_pic;} 
					set 
					{ 
						_thumbnail_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
					}
				}

				string _bmiddle_pic;
				[DataMember(Name = "bmiddle_pic")]
				public string BmiddlePic
				{ 
					get { return _bmiddle_pic;} 
					set 
					{ 
						_bmiddle_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
					}
				}

				string _original_pic;
				[DataMember(Name = "original_pic")]
				public string OriginalPic
				{ 
					get { return _original_pic;} 
					set 
					{ 
						_original_pic = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class FriendsTimelineResponse : ObservableCollection<FriendsTimelineResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class PublicTimelineResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
		[CollectionDataContract]
		public partial class PublicTimelineResponse : ObservableCollection<PublicTimelineResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class ReplyResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			ReplyCommentType _reply_comment;
			[DataMember(Name = "reply_comment")]
			public ReplyCommentType ReplyComment
			{ 
				get { return _reply_comment;} 
				set 
				{ 
					_reply_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ReplyComment"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

				StatusType _status;
				[DataMember(Name = "status")]
				public StatusType Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
					}
				}

				[DataContract]
				public partial class StatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

				}
			}
			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
			[DataContract]
			public partial class ReplyCommentType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class RepostResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			RetweetedStatusType _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatusType RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class RetweetedStatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class RepostByMeResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			RetweetedStatusType _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatusType RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class RetweetedStatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class RepostByMeResponse : ObservableCollection<RepostByMeResponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class RepostTimelineReponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			RetweetedStatusType _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatusType RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
			[DataContract]
			public partial class RetweetedStatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				UserType _user;
				[DataMember(Name = "user")]
				public UserType User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
					}
				}

				[DataContract]
				public partial class UserType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _screen_name;
					[DataMember(Name = "screen_name")]
					public string ScreenName
					{ 
						get { return _screen_name;} 
						set 
						{ 
							_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
						}
					}

					string _name;
					[DataMember(Name = "name")]
					public string Name
					{ 
						get { return _name;} 
						set 
						{ 
							_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
						}
					}

					string _province;
					[DataMember(Name = "province")]
					public string Province
					{ 
						get { return _province;} 
						set 
						{ 
							_province = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
						}
					}

					string _city;
					[DataMember(Name = "city")]
					public string City
					{ 
						get { return _city;} 
						set 
						{ 
							_city = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
						}
					}

					string _location;
					[DataMember(Name = "location")]
					public string Location
					{ 
						get { return _location;} 
						set 
						{ 
							_location = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
						}
					}

					string _description;
					[DataMember(Name = "description")]
					public string Description
					{ 
						get { return _description;} 
						set 
						{ 
							_description = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
						}
					}

					string _url;
					[DataMember(Name = "url")]
					public string Url
					{ 
						get { return _url;} 
						set 
						{ 
							_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
						}
					}

					string _profile_image_url;
					[DataMember(Name = "profile_image_url")]
					public string ProfileImageUrl
					{ 
						get { return _profile_image_url;} 
						set 
						{ 
							_profile_image_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
						}
					}

					string _domain;
					[DataMember(Name = "domain")]
					public string Domain
					{ 
						get { return _domain;} 
						set 
						{ 
							_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
						}
					}

					string _gender;
					[DataMember(Name = "gender")]
					public string Gender
					{ 
						get { return _gender;} 
						set 
						{ 
							_gender = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
						}
					}

					double _followers_count;
					[DataMember(Name = "followers_count")]
					public double FollowersCount
					{ 
						get { return _followers_count;} 
						set 
						{ 
							_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
						}
					}

					double _friends_count;
					[DataMember(Name = "friends_count")]
					public double FriendsCount
					{ 
						get { return _friends_count;} 
						set 
						{ 
							_friends_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
						}
					}

					double _statuses_count;
					[DataMember(Name = "statuses_count")]
					public double StatusesCount
					{ 
						get { return _statuses_count;} 
						set 
						{ 
							_statuses_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
						}
					}

					double _favourites_count;
					[DataMember(Name = "favourites_count")]
					public double FavouritesCount
					{ 
						get { return _favourites_count;} 
						set 
						{ 
							_favourites_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
						}
					}

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					bool _following;
					[DataMember(Name = "following")]
					public bool Following
					{ 
						get { return _following;} 
						set 
						{ 
							_following = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
						}
					}

					bool _allow_all_act_msg;
					[DataMember(Name = "allow_all_act_msg")]
					public bool AllowAllActMsg
					{ 
						get { return _allow_all_act_msg;} 
						set 
						{ 
							_allow_all_act_msg = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
						}
					}

					bool _geo_enabled;
					[DataMember(Name = "geo_enabled")]
					public bool GeoEnabled
					{ 
						get { return _geo_enabled;} 
						set 
						{ 
							_geo_enabled = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
						}
					}

					bool _verified;
					[DataMember(Name = "verified")]
					public bool Verified
					{ 
						get { return _verified;} 
						set 
						{ 
							_verified = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
						}
					}

				}
			}
		}
		[CollectionDataContract]
		public partial class RepostTimelineReponse : ObservableCollection<RepostTimelineReponseArrayItem>
		{
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class ResetCountResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			bool _result;
			[DataMember(Name = "result")]
			public bool Result
			{ 
				get { return _result;} 
				set 
				{ 
					_result = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Result"));
				}
			}

		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class ShowResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class UnreadResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _new_status;
			[DataMember(Name = "new_status")]
			public double NewStatus
			{ 
				get { return _new_status;} 
				set 
				{ 
					_new_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("NewStatus"));
				}
			}

			double _followers;
			[DataMember(Name = "followers")]
			public double Followers
			{ 
				get { return _followers;} 
				set 
				{ 
					_followers = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Followers"));
				}
			}

			double _status;
			[DataMember(Name = "status")]
			public double Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			double _dm;
			[DataMember(Name = "dm")]
			public double Dm
			{ 
				get { return _dm;} 
				set 
				{ 
					_dm = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Dm"));
				}
			}

			double _mentions;
			[DataMember(Name = "mentions")]
			public double Mentions
			{ 
				get { return _mentions;} 
				set 
				{ 
					_mentions = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mentions"));
				}
			}

			double _comments;
			[DataMember(Name = "comments")]
			public double Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Comments"));
				}
			}

		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class UpdateResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class UploadResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			string _thumbnail_pic;
			[DataMember(Name = "thumbnail_pic")]
			public string ThumbnailPic
			{ 
				get { return _thumbnail_pic;} 
				set 
				{ 
					_thumbnail_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
				}
			}

			string _bmiddle_pic;
			[DataMember(Name = "bmiddle_pic")]
			public string BmiddlePic
			{ 
				get { return _bmiddle_pic;} 
				set 
				{ 
					_bmiddle_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
				}
			}

			string _original_pic;
			[DataMember(Name = "original_pic")]
			public string OriginalPic
			{ 
				get { return _original_pic;} 
				set 
				{ 
					_original_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
	}


				
				//nsStatuses
	namespace Statuses
	{

		[DataContract]
		public partial class UserTimelineResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
		[CollectionDataContract]
		public partial class UserTimelineResponse : ObservableCollection<UserTimelineResponseArrayItem>
		{
		}
	}


				
				//nsTags
	namespace Tags
	{

		[DataContract]
		public partial class CreateResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _tagid;
			[DataMember(Name = "tagid")]
			public string Tagid
			{ 
				get { return _tagid;} 
				set 
				{ 
					_tagid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Tagid"));
				}
			}

		}
		[CollectionDataContract]
		public partial class CreateResponse : ObservableCollection<CreateResponseArrayItem>
		{
		}
	}


				
				//nsTags
	namespace Tags
	{

		[DataContract]
		public partial class DestoryBatchResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _tagid;
			[DataMember(Name = "tagid")]
			public string Tagid
			{ 
				get { return _tagid;} 
				set 
				{ 
					_tagid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Tagid"));
				}
			}

		}
		[CollectionDataContract]
		public partial class DestoryBatchResponse : ObservableCollection<DestoryBatchResponseArrayItem>
		{
		}
	}


				
				//nsTags
	namespace Tags
	{

		[DataContract]
		public partial class SuggestionsResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _id;
			[DataMember(Name = "id")]
			public string Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _value;
			[DataMember(Name = "value")]
			public string Value
			{ 
				get { return _value;} 
				set 
				{ 
					_value = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Value"));
				}
			}

		}
		[CollectionDataContract]
		public partial class SuggestionsResponse : ObservableCollection<SuggestionsResponseArrayItem>
		{
		}
	}


				
				//nsTrends
	namespace Trends
	{

		[DataContract]
		public partial class DestoryResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			bool _result;
			[DataMember(Name = "result")]
			public bool Result
			{ 
				get { return _result;} 
				set 
				{ 
					_result = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Result"));
				}
			}

		}
	}


				
				//nsTrends
	namespace Trends
	{

		[DataContract]
		public partial class FollowResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _topicid;
			[DataMember(Name = "topicid")]
			public string Topicid
			{ 
				get { return _topicid;} 
				set 
				{ 
					_topicid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Topicid"));
				}
			}

		}
	}


				
				//nsTrends
	namespace Trends
	{

		[DataContract]
		public partial class StatusesResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _text;
			[DataMember(Name = "text")]
			public string Text
			{ 
				get { return _text;} 
				set 
				{ 
					_text = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
				}
			}

			string _source;
			[DataMember(Name = "source")]
			public string Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
				}
			}

			bool _favorited;
			[DataMember(Name = "favorited")]
			public bool Favorited
			{ 
				get { return _favorited;} 
				set 
				{ 
					_favorited = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
				}
			}

			bool _truncated;
			[DataMember(Name = "truncated")]
			public bool Truncated
			{ 
				get { return _truncated;} 
				set 
				{ 
					_truncated = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
				}
			}

			string _in_reply_to_status_id;
			[DataMember(Name = "in_reply_to_status_id")]
			public string InReplyToStatusId
			{ 
				get { return _in_reply_to_status_id;} 
				set 
				{ 
					_in_reply_to_status_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
				}
			}

			string _in_reply_to_user_id;
			[DataMember(Name = "in_reply_to_user_id")]
			public string InReplyToUserId
			{ 
				get { return _in_reply_to_user_id;} 
				set 
				{ 
					_in_reply_to_user_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
				}
			}

			string _in_reply_to_screen_name;
			[DataMember(Name = "in_reply_to_screen_name")]
			public string InReplyToScreenName
			{ 
				get { return _in_reply_to_screen_name;} 
				set 
				{ 
					_in_reply_to_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
				}
			}

			string _thumbnail_pic;
			[DataMember(Name = "thumbnail_pic")]
			public string ThumbnailPic
			{ 
				get { return _thumbnail_pic;} 
				set 
				{ 
					_thumbnail_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
				}
			}

			string _bmiddle_pic;
			[DataMember(Name = "bmiddle_pic")]
			public string BmiddlePic
			{ 
				get { return _bmiddle_pic;} 
				set 
				{ 
					_bmiddle_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
				}
			}

			string _original_pic;
			[DataMember(Name = "original_pic")]
			public string OriginalPic
			{ 
				get { return _original_pic;} 
				set 
				{ 
					_original_pic = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
				}
			}

			Object _geo;
			[DataMember(Name = "geo")]
			public Object Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
				}
			}

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
				}
			}

			UserType _user;
			[DataMember(Name = "user")]
			public UserType User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
				}
			}

			[DataContract]
			public partial class UserType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _screen_name;
				[DataMember(Name = "screen_name")]
				public string ScreenName
				{ 
					get { return _screen_name;} 
					set 
					{ 
						_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
					}
				}

				string _name;
				[DataMember(Name = "name")]
				public string Name
				{ 
					get { return _name;} 
					set 
					{ 
						_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
					}
				}

				string _province;
				[DataMember(Name = "province")]
				public string Province
				{ 
					get { return _province;} 
					set 
					{ 
						_province = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
					}
				}

				string _city;
				[DataMember(Name = "city")]
				public string City
				{ 
					get { return _city;} 
					set 
					{ 
						_city = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
					}
				}

				string _location;
				[DataMember(Name = "location")]
				public string Location
				{ 
					get { return _location;} 
					set 
					{ 
						_location = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
					}
				}

				string _description;
				[DataMember(Name = "description")]
				public string Description
				{ 
					get { return _description;} 
					set 
					{ 
						_description = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
					}
				}

				string _url;
				[DataMember(Name = "url")]
				public string Url
				{ 
					get { return _url;} 
					set 
					{ 
						_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
					}
				}

				string _profile_image_url;
				[DataMember(Name = "profile_image_url")]
				public string ProfileImageUrl
				{ 
					get { return _profile_image_url;} 
					set 
					{ 
						_profile_image_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
					}
				}

				string _domain;
				[DataMember(Name = "domain")]
				public string Domain
				{ 
					get { return _domain;} 
					set 
					{ 
						_domain = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
					}
				}

				string _gender;
				[DataMember(Name = "gender")]
				public string Gender
				{ 
					get { return _gender;} 
					set 
					{ 
						_gender = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
					}
				}

				double _followers_count;
				[DataMember(Name = "followers_count")]
				public double FollowersCount
				{ 
					get { return _followers_count;} 
					set 
					{ 
						_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
					}
				}

				double _friends_count;
				[DataMember(Name = "friends_count")]
				public double FriendsCount
				{ 
					get { return _friends_count;} 
					set 
					{ 
						_friends_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
					}
				}

				double _statuses_count;
				[DataMember(Name = "statuses_count")]
				public double StatusesCount
				{ 
					get { return _statuses_count;} 
					set 
					{ 
						_statuses_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
					}
				}

				double _favourites_count;
				[DataMember(Name = "favourites_count")]
				public double FavouritesCount
				{ 
					get { return _favourites_count;} 
					set 
					{ 
						_favourites_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
					}
				}

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				bool _following;
				[DataMember(Name = "following")]
				public bool Following
				{ 
					get { return _following;} 
					set 
					{ 
						_following = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
					}
				}

				bool _allow_all_act_msg;
				[DataMember(Name = "allow_all_act_msg")]
				public bool AllowAllActMsg
				{ 
					get { return _allow_all_act_msg;} 
					set 
					{ 
						_allow_all_act_msg = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
					}
				}

				bool _geo_enabled;
				[DataMember(Name = "geo_enabled")]
				public bool GeoEnabled
				{ 
					get { return _geo_enabled;} 
					set 
					{ 
						_geo_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
					}
				}

				bool _verified;
				[DataMember(Name = "verified")]
				public bool Verified
				{ 
					get { return _verified;} 
					set 
					{ 
						_verified = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
					}
				}

			}
		}
		[CollectionDataContract]
		public partial class StatusesResponse : ObservableCollection<StatusesResponseArrayItem>
		{
		}
	}


				
				//nsTrends
	namespace Trends
	{

		[DataContract]
		public partial class TrendsResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _num;
			[DataMember(Name = "num")]
			public string Num
			{ 
				get { return _num;} 
				set 
				{ 
					_num = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Num"));
				}
			}

			string _trend_id;
			[DataMember(Name = "trend_id")]
			public string TrendId
			{ 
				get { return _trend_id;} 
				set 
				{ 
					_trend_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("TrendId"));
				}
			}

			string _hotword;
			[DataMember(Name = "hotword")]
			public string Hotword
			{ 
				get { return _hotword;} 
				set 
				{ 
					_hotword = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Hotword"));
				}
			}

		}
		[CollectionDataContract]
		public partial class TrendsResponse : ObservableCollection<TrendsResponseArrayItem>
		{
		}
	}


				
				//nsUser.Friends
	namespace User.Friends
	{

		[DataContract]
		public partial class UpdateRemarkResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				RetweetedStatusType _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatusType RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				[DataContract]
				public partial class RetweetedStatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _bmiddle_pic;
					[DataMember(Name = "bmiddle_pic")]
					public string BmiddlePic
					{ 
						get { return _bmiddle_pic;} 
						set 
						{ 
							_bmiddle_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
						}
					}

					string _original_pic;
					[DataMember(Name = "original_pic")]
					public string OriginalPic
					{ 
						get { return _original_pic;} 
						set 
						{ 
							_original_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					Object[] _annotations;
					[DataMember(Name = "annotations")]
					public Object[] Annotations
					{ 
						get { return _annotations;} 
						set 
						{ 
							_annotations = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Annotations"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					string _thumbnail_pic;
					[DataMember(Name = "thumbnail_pic")]
					public string ThumbnailPic
					{ 
						get { return _thumbnail_pic;} 
						set 
						{ 
							_thumbnail_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

					}
				}
			}
		}
	}


				
				//nsUsers
	namespace Users
	{

		[DataContract]
		public partial class HotResponseArrayItem: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

				RetweetedStatusType _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatusType RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("RetweetedStatus"));
					}
				}

				[DataContract]
				public partial class RetweetedStatusType: INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler  PropertyChanged ;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
						}
					}

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
						}
					}

					string _text;
					[DataMember(Name = "text")]
					public string Text
					{ 
						get { return _text;} 
						set 
						{ 
							_text = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
						}
					}

					string _source;
					[DataMember(Name = "source")]
					public string Source
					{ 
						get { return _source;} 
						set 
						{ 
							_source = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
						}
					}

					bool _favorited;
					[DataMember(Name = "favorited")]
					public bool Favorited
					{ 
						get { return _favorited;} 
						set 
						{ 
							_favorited = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
						}
					}

					bool _truncated;
					[DataMember(Name = "truncated")]
					public bool Truncated
					{ 
						get { return _truncated;} 
						set 
						{ 
							_truncated = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
						}
					}

					string _in_reply_to_status_id;
					[DataMember(Name = "in_reply_to_status_id")]
					public string InReplyToStatusId
					{ 
						get { return _in_reply_to_status_id;} 
						set 
						{ 
							_in_reply_to_status_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
						}
					}

					string _in_reply_to_user_id;
					[DataMember(Name = "in_reply_to_user_id")]
					public string InReplyToUserId
					{ 
						get { return _in_reply_to_user_id;} 
						set 
						{ 
							_in_reply_to_user_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
						}
					}

					string _in_reply_to_screen_name;
					[DataMember(Name = "in_reply_to_screen_name")]
					public string InReplyToScreenName
					{ 
						get { return _in_reply_to_screen_name;} 
						set 
						{ 
							_in_reply_to_screen_name = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
						}
					}

					string _thumbnail_pic;
					[DataMember(Name = "thumbnail_pic")]
					public string ThumbnailPic
					{ 
						get { return _thumbnail_pic;} 
						set 
						{ 
							_thumbnail_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
						}
					}

					string _bmiddle_pic;
					[DataMember(Name = "bmiddle_pic")]
					public string BmiddlePic
					{ 
						get { return _bmiddle_pic;} 
						set 
						{ 
							_bmiddle_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
						}
					}

					string _original_pic;
					[DataMember(Name = "original_pic")]
					public string OriginalPic
					{ 
						get { return _original_pic;} 
						set 
						{ 
							_original_pic = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
						}
					}

					Object _geo;
					[DataMember(Name = "geo")]
					public Object Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
						}
					}

					string _mid;
					[DataMember(Name = "mid")]
					public string Mid
					{ 
						get { return _mid;} 
						set 
						{ 
							_mid = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
						}
					}

					UserType _user;
					[DataMember(Name = "user")]
					public UserType User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged (this,new PropertyChangedEventArgs ("User"));
						}
					}

					[DataContract]
					public partial class UserType: INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler  PropertyChanged ;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
							}
						}

						string _screen_name;
						[DataMember(Name = "screen_name")]
						public string ScreenName
						{ 
							get { return _screen_name;} 
							set 
							{ 
								_screen_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
							}
						}

						string _name;
						[DataMember(Name = "name")]
						public string Name
						{ 
							get { return _name;} 
							set 
							{ 
								_name = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
							}
						}

						string _province;
						[DataMember(Name = "province")]
						public string Province
						{ 
							get { return _province;} 
							set 
							{ 
								_province = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
							}
						}

						string _city;
						[DataMember(Name = "city")]
						public string City
						{ 
							get { return _city;} 
							set 
							{ 
								_city = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
							}
						}

						string _location;
						[DataMember(Name = "location")]
						public string Location
						{ 
							get { return _location;} 
							set 
							{ 
								_location = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
							}
						}

						string _description;
						[DataMember(Name = "description")]
						public string Description
						{ 
							get { return _description;} 
							set 
							{ 
								_description = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
							}
						}

						string _url;
						[DataMember(Name = "url")]
						public string Url
						{ 
							get { return _url;} 
							set 
							{ 
								_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
							}
						}

						string _profile_image_url;
						[DataMember(Name = "profile_image_url")]
						public string ProfileImageUrl
						{ 
							get { return _profile_image_url;} 
							set 
							{ 
								_profile_image_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
							}
						}

						string _domain;
						[DataMember(Name = "domain")]
						public string Domain
						{ 
							get { return _domain;} 
							set 
							{ 
								_domain = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
							}
						}

						string _gender;
						[DataMember(Name = "gender")]
						public string Gender
						{ 
							get { return _gender;} 
							set 
							{ 
								_gender = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
							}
						}

						double _followers_count;
						[DataMember(Name = "followers_count")]
						public double FollowersCount
						{ 
							get { return _followers_count;} 
							set 
							{ 
								_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
							}
						}

						double _friends_count;
						[DataMember(Name = "friends_count")]
						public double FriendsCount
						{ 
							get { return _friends_count;} 
							set 
							{ 
								_friends_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
							}
						}

						double _statuses_count;
						[DataMember(Name = "statuses_count")]
						public double StatusesCount
						{ 
							get { return _statuses_count;} 
							set 
							{ 
								_statuses_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
							}
						}

						double _favourites_count;
						[DataMember(Name = "favourites_count")]
						public double FavouritesCount
						{ 
							get { return _favourites_count;} 
							set 
							{ 
								_favourites_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
							}
						}

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
							}
						}

						bool _following;
						[DataMember(Name = "following")]
						public bool Following
						{ 
							get { return _following;} 
							set 
							{ 
								_following = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
							}
						}

						bool _allow_all_act_msg;
						[DataMember(Name = "allow_all_act_msg")]
						public bool AllowAllActMsg
						{ 
							get { return _allow_all_act_msg;} 
							set 
							{ 
								_allow_all_act_msg = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
							}
						}

						bool _geo_enabled;
						[DataMember(Name = "geo_enabled")]
						public bool GeoEnabled
						{ 
							get { return _geo_enabled;} 
							set 
							{ 
								_geo_enabled = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
							}
						}

						bool _verified;
						[DataMember(Name = "verified")]
						public bool Verified
						{ 
							get { return _verified;} 
							set 
							{ 
								_verified = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
							}
						}

					}
				}
			}
		}
		[CollectionDataContract]
		public partial class HotResponse : ObservableCollection<HotResponseArrayItem>
		{
		}
	}


				
				//nsUsers
	namespace Users
	{

		[DataContract]
		public partial class ShowResponse: INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler  PropertyChanged ;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
				}
			}

			string _screen_name;
			[DataMember(Name = "screen_name")]
			public string ScreenName
			{ 
				get { return _screen_name;} 
				set 
				{ 
					_screen_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
				}
			}

			string _name;
			[DataMember(Name = "name")]
			public string Name
			{ 
				get { return _name;} 
				set 
				{ 
					_name = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
				}
			}

			string _province;
			[DataMember(Name = "province")]
			public string Province
			{ 
				get { return _province;} 
				set 
				{ 
					_province = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
				}
			}

			string _city;
			[DataMember(Name = "city")]
			public string City
			{ 
				get { return _city;} 
				set 
				{ 
					_city = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
				}
			}

			string _location;
			[DataMember(Name = "location")]
			public string Location
			{ 
				get { return _location;} 
				set 
				{ 
					_location = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
				}
			}

			string _description;
			[DataMember(Name = "description")]
			public string Description
			{ 
				get { return _description;} 
				set 
				{ 
					_description = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
				}
			}

			string _url;
			[DataMember(Name = "url")]
			public string Url
			{ 
				get { return _url;} 
				set 
				{ 
					_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
				}
			}

			string _profile_image_url;
			[DataMember(Name = "profile_image_url")]
			public string ProfileImageUrl
			{ 
				get { return _profile_image_url;} 
				set 
				{ 
					_profile_image_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
				}
			}

			string _domain;
			[DataMember(Name = "domain")]
			public string Domain
			{ 
				get { return _domain;} 
				set 
				{ 
					_domain = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
				}
			}

			string _gender;
			[DataMember(Name = "gender")]
			public string Gender
			{ 
				get { return _gender;} 
				set 
				{ 
					_gender = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
				}
			}

			double _followers_count;
			[DataMember(Name = "followers_count")]
			public double FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
				}
			}

			double _friends_count;
			[DataMember(Name = "friends_count")]
			public double FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
				}
			}

			double _statuses_count;
			[DataMember(Name = "statuses_count")]
			public double StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
				}
			}

			double _favourites_count;
			[DataMember(Name = "favourites_count")]
			public double FavouritesCount
			{ 
				get { return _favourites_count;} 
				set 
				{ 
					_favourites_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
				}
			}

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
				}
			}

			bool _following;
			[DataMember(Name = "following")]
			public bool Following
			{ 
				get { return _following;} 
				set 
				{ 
					_following = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
				}
			}

			bool _allow_all_act_msg;
			[DataMember(Name = "allow_all_act_msg")]
			public bool AllowAllActMsg
			{ 
				get { return _allow_all_act_msg;} 
				set 
				{ 
					_allow_all_act_msg = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
				}
			}

			bool _geo_enabled;
			[DataMember(Name = "geo_enabled")]
			public bool GeoEnabled
			{ 
				get { return _geo_enabled;} 
				set 
				{ 
					_geo_enabled = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
				}
			}

			bool _verified;
			[DataMember(Name = "verified")]
			public bool Verified
			{ 
				get { return _verified;} 
				set 
				{ 
					_verified = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
				}
			}

			StatusType _status;
			[DataMember(Name = "status")]
			public StatusType Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
				}
			}

			[DataContract]
			public partial class StatusType: INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler  PropertyChanged ;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
					}
				}

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
					}
				}

				string _text;
				[DataMember(Name = "text")]
				public string Text
				{ 
					get { return _text;} 
					set 
					{ 
						_text = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
					}
				}

				string _source;
				[DataMember(Name = "source")]
				public string Source
				{ 
					get { return _source;} 
					set 
					{ 
						_source = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
					}
				}

				bool _favorited;
				[DataMember(Name = "favorited")]
				public bool Favorited
				{ 
					get { return _favorited;} 
					set 
					{ 
						_favorited = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
					}
				}

				bool _truncated;
				[DataMember(Name = "truncated")]
				public bool Truncated
				{ 
					get { return _truncated;} 
					set 
					{ 
						_truncated = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
					}
				}

				string _in_reply_to_status_id;
				[DataMember(Name = "in_reply_to_status_id")]
				public string InReplyToStatusId
				{ 
					get { return _in_reply_to_status_id;} 
					set 
					{ 
						_in_reply_to_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
					}
				}

				string _in_reply_to_user_id;
				[DataMember(Name = "in_reply_to_user_id")]
				public string InReplyToUserId
				{ 
					get { return _in_reply_to_user_id;} 
					set 
					{ 
						_in_reply_to_user_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
					}
				}

				string _in_reply_to_screen_name;
				[DataMember(Name = "in_reply_to_screen_name")]
				public string InReplyToScreenName
				{ 
					get { return _in_reply_to_screen_name;} 
					set 
					{ 
						_in_reply_to_screen_name = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
					}
				}

				Object _geo;
				[DataMember(Name = "geo")]
				public Object Geo
				{ 
					get { return _geo;} 
					set 
					{ 
						_geo = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
					}
				}

				string _mid;
				[DataMember(Name = "mid")]
				public string Mid
				{ 
					get { return _mid;} 
					set 
					{ 
						_mid = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
					}
				}

			}
		}
	}


				
}
