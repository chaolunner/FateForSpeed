//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityEngine; 
using System;
using System.Collections;
using System.Collections.Generic;
using LitJson;
namespace cn.sharesdk.unity3d
{
	/// <summary>
	/// Content type.
	/// </summary>
	public class ShareContent
	{	      		
		Hashtable shareParams = new Hashtable();
		Hashtable customizeShareParams = new Hashtable();

		/*Android Only- 隐藏九宫格的平台（平台id数组,例如：(int)PlatformType.Facebook）*/
		public void SetHidePlatforms(String[] hidePlatformList) {
			shareParams["hidePlatformList"] = String.Join (",", hidePlatformList);
		}

		/*iOS/Android*/
		public void SetTitle(String title) {
			shareParams["title"] = title;
		}

		/*iOS/Android*/
		public void SetText(String text) {
			shareParams["text"] = text;
		}

		/*iOS/Android*/
		public void SetUrl(String url) {
			shareParams["url"] = url;
		}

		/*iOS/Android - 本地图片路径*/
		public void SetImagePath(String imagePath) {
			#if UNITY_ANDROID
			shareParams["imagePath"] = imagePath;
			#elif UNITY_IPHONE
			shareParams["imageUrl"] = imagePath;
			#endif
		}

		/*iOS/Android - 网络图片路径*/
		public void SetImageUrl(String imageUrl) {
			shareParams["imageUrl"] = imageUrl;
		}

		/*Android Only- 图片string数组（多图分享）*/
		public void SetImageArray(String[] imageArray) {
			shareParams["imageArray"] = String.Join(",", imageArray);
		}

		/*iOS/Android - 分享类型*/
		public void SetShareType(int shareType) {
			#if UNITY_ANDROID
			if (shareType == 0) {
				shareType = 1;
			} else if(shareType == 10){
				shareType = 11;
			} 
			#endif
			shareParams["shareType"] = shareType;
		}

		/*Android Only*/
		public void SetTitleUrl(String titleUrl) {
			shareParams["titleUrl"] = titleUrl;
		}

		/*iOS/Android*/
		public void SetComment(String comment) {
			shareParams["comment"] = comment;
		}

		/*Android Only*/
		public void SetSite(String site) {
			shareParams["site"] = site;
		}

		/*Android Only*/
		public void SetSiteUrl(String siteUrl) {
			shareParams["siteUrl"] = siteUrl;
		}

		/*Android Only*/
		public void SetAddress(String address) {
			shareParams["address"] = address;
		}

		/*iOS/Android*/
		public void SetFilePath(String filePath) {
			shareParams["filePath"] = filePath;
		}

		/*iOS/Android*/
		public void SetMusicUrl(String musicUrl) {
			shareParams["musicUrl"] = musicUrl;
		}

		/*iOS/Android - Sina/Tencent/Twitter/VKontakte*/
		public void SetLatitude(String latitude) {
			shareParams["latitude"] = latitude;
		}

		/*iOS/Android - Sina/Tencent/Twitter/VKontakte*/
		public void SetLongitude(String longitude) {
			shareParams["longitude"] = longitude;
		}
		
		/*iOS/Android - YouDaoNote*/
		public void SetSource(String source){
			#if UNITY_ANDROID
			shareParams["url"] = source;
			#elif UNITY_IPHONE
			shareParams ["source"] = source;
			#endif
		}
		
		/*iOS/Android - YouDaoNote*/
		public void SetAuthor(String author){
			#if UNITY_ANDROID
			shareParams["address"] = author;
			#elif UNITY_IPHONE
			shareParams ["author"] = author;
			#endif
		}
		
		/*iOS/Android - Flickr*/
		public void SetSafetyLevel(int safetyLevel){
			shareParams ["safetyLevel"] = safetyLevel;
		}
		
		/*iOS/Android - Flickr*/
		public void SetContentType(int contentType){
			shareParams ["contentType"] = contentType;
		}
		
		/*iOS/Android - Flickr*/
		public void SetHidden(int hidden){
			shareParams ["hidden"] = hidden;
		}
		
		/*iOS/Android - Flickr*/
		public void SetIsPublic(bool isPublic){
			shareParams ["isPublic"] = isPublic;
		}
		
		/*iOS/Android - Flickr*/
		public void SetIsFriend(bool isFriend){
			shareParams ["isFriend"] = isFriend;
		}
		
		/*iOS/Android - Flickr*/
		public void SetIsFamily(bool isFamily){
			shareParams ["isFamily"] = isFamily;
		}
		
		/*iOS/Android - VKontakte*/
		public void SetFriendsOnly(bool friendsOnly){
			#if UNITY_ANDROID
			shareParams["isFriend"] = friendsOnly;
			#elif UNITY_IPHONE
			shareParams ["friendsOnly"] = friendsOnly;
			#endif
		}
		
		/*iOS/Android - VKontakte*/
		public void SetGroupID(String groupID){
			shareParams ["groupID"] = groupID;
		}
		
		/*iOS/Android - WhatsApp*/
		public void SetAudioPath(String audioPath){
			#if UNITY_ANDROID
			shareParams["filePath"] = audioPath;
			#elif UNITY_IPHONE
			shareParams ["audioPath"] = audioPath;
			#endif
		}
		
		/*iOS/Android - WhatsApp/Youtube/ MeiPai/Sina(the path must be an assetUrl path in iOS)*/
		public void SetVideoPath(String videoPath){
			#if UNITY_ANDROID
			shareParams["filePath"] = videoPath;
			#elif UNITY_IPHONE
			shareParams ["videoPath"] = videoPath;
			#endif
		}
		
		/*iOS/Android - YouDaoNote/YinXiang/Evernote*/
		public void SetNotebook(String notebook){
			shareParams ["notebook"] = notebook;
		}
		
		/*iOS/Android - Pocket/Flickr/YinXiang/Evernote/Youtube*/
		public void SetTags(String tags){
			shareParams ["tags"] = tags;
		}

		/*iOS - Youtube(0-public;1-private;2-unlisted)*/
		public void SetPrivateStatus(int status)
		{
			shareParams ["privateStatus"] = status;
		}
			
		/*iOS Only - Sina*/
		public void SetObjectID(String objectId) {
			shareParams["objectID"] = objectId;
		}

		/*iOS Only - Renren*/
		public void SetAlbumID(String albumId) {
			shareParams["AlbumID"] = albumId;
		}

		/*iOS Only - Wechat*/
		public void SetEmotionPath(String emotionPath){
			shareParams["emotionPath"] = emotionPath;
		}

		/*iOS Only - Wechat/Yixin*/
		public void SetExtInfoPath(String extInfoPath){
			shareParams["extInfoPath"] = extInfoPath;
		}

		/*iOS Only - Wechat*/ 
		public void SetSourceFileExtension(String sourceFileExtension){
			shareParams["sourceFileExtension"] = sourceFileExtension;
		}

		/*iOS Only - Wechat*/
		public void SetSourceFilePath(String sourceFilePath){
			shareParams["sourceFilePath"] = sourceFilePath;
		}

		/*iOS Only - QQ/Wechat/Yixin*/
		public void SetThumbImageUrl(String thumbImageUrl){
			shareParams["thumbImageUrl"] = thumbImageUrl;
		}

		/*iOS Only - Douban/LinkedIn/Faceobook*/
		public void SetUrlDescription(String urlDescription){
			shareParams["urlDescription"] = urlDescription;
		}

		/*iOS Only - Pinterest*/
		public void SetBoard(String SetBoard){
			shareParams["board"] = SetBoard;
		}

		/*iOS Only - WhatsApp/Instagram*/
		public void SetMenuX(float menuX){
			shareParams ["menuX"] = menuX;
		}

		/*iOS Only - WhatsApp/Instagram*/
		public void SetMenuY(float menuY){
			shareParams ["menuY"] = menuY;
		}

		/*iOS Only - LinkedIn*/
		public void SetVisibility(String visibility){
			shareParams ["visibility"] = visibility;
		}

		/*iOS Only - Tumblr*/
		public void SetBlogName(String blogName){
			shareParams ["blogName"] = blogName;
		}

		/*iOS Only - SMS/Mail*/
		public void SetRecipients(String recipients){
			shareParams ["recipients"] = recipients;
		}

		/*iOS Only - Mail*/
		public void SetCCRecipients(String ccRecipients){
			shareParams ["ccRecipients"] = ccRecipients;
		}

		/*iOS Only - Mail*/
		public void SetBCCRecipients(String bccRecipients){
			shareParams ["bccRecipients"] = bccRecipients;
		}

		/*iOS Only - Dropbox/Mail/SMS*/
		public void SetAttachmentPath(String attachmentPath){
			shareParams ["attachmentPath"] = attachmentPath;
		}

		/*iOS Only - Instapaper/Pinterest/Youtube*/
		public void SetDesc(String desc){
			shareParams ["desc"] = desc;
		}

		/*iOS Only - Instapaper*/
		public void SetIsPrivateFromSource(bool isPrivateFromSource){
			shareParams ["isPrivateFromSource"] = isPrivateFromSource;
		}

		/*iOS Only - Instapaper*/
		public void SetResolveFinalUrl(bool resolveFinalUrl){
			shareParams ["resolveFinalUrl"] = resolveFinalUrl;
		}

		/*iOS Only - - Instapaper*/
		public void SetFolderId(int folderId){
			shareParams ["folderId"] = folderId;
		}

		/*iOS Only - Pocket*/
		public void SetTweetID(String tweetID){
			shareParams ["tweetID"] = tweetID;
		}

		/*iOS Only - Yixin*/
		public void SetToUserID(String toUserID){
			shareParams ["toUserID"] = toUserID;
		}

		/*iOS Only - Kakao*/
		public void SetPermission(String permission){
			shareParams ["permission"] = permission;
		}

		/*iOS Only - Kakao*/
		public void SetEnableShare(bool enableShare){
			shareParams ["enableShare"] = enableShare;
		}

		/*iOS Only - Kakao*/
		public void SetImageWidth(float imageWidth){
			shareParams ["imageWidth"] = imageWidth;
		}

		/*iOS Only - Kakao*/
		public void SetImageHeight(float imageHeight){
			shareParams ["imageHeight"] = imageHeight;
		}

		/*iOS Only - Kakao*/
		public void SetAppButtonTitle(String appButtonTitle){
			shareParams ["appButtonTitle"] = appButtonTitle;
		}

		/*iOS Only - Kakao*/
		public void SetAndroidExecParam(Hashtable androidExecParam){
			shareParams ["androidExecParam"] = androidExecParam;
		}

		/*iOS Only - Kakao*/
		public void SetAndroidMarkParam(String androidMarkParam){
			shareParams ["androidMarkParam"] = androidMarkParam;
		}

		/*iOS Only - Kakao*/
		public void SetIphoneExecParam(Hashtable iphoneExecParam){
			shareParams ["iphoneExecParam"] = iphoneExecParam;
		}

		/*iOS Only - Kakao*/
		public void SetIphoneMarkParam(String iphoneMarkParam){
			shareParams ["iphoneMarkParam"] = iphoneMarkParam;
		}

		/*iOS Only - Kakao*/
		public void SetIpadExecParam(Hashtable ipadExecParam){
			shareParams ["ipadExecParam"] = ipadExecParam;
		}

		/*iOS Only - Kakao*/
		public void SetIpadMarkParam(String ipadMarkParam){
			shareParams ["ipadMarkParam"] = ipadMarkParam;
		}

		/*iOS Only - Kakao*/
		public void SetTemplateArgs(Hashtable templateArgs){
			shareParams ["templateArgs"] = templateArgs;
		}

		/*iOS Only - Kakao*/
		public void SetTemplateId(String templateId){
			shareParams ["templateId"] = templateId;
		}

		/*iOS/android - facebook*/
		public void SetFacebookHashtag(String hashtag){
            #if UNITY_ANDROID
                shareParams ["HASHTAG"] = hashtag;
            #elif UNITY_IPHONE
			    shareParams ["hashtag"] = hashtag;
            #endif
        }

        /*iOS/android - facebook*/
        public void SetFacebookQuote(String quote){
            #if UNITY_ANDROID
                shareParams ["QUOTE"] = quote;
            #elif UNITY_IPHONE
			    shareParams ["quote"] = quote;
            #endif
        }

        /*iOS Only - facebookMessenger*/
        public void SetMessengerGif(String gif){
			shareParams ["gif"] = gif;
		}

		public void SetEnableClientShare(bool enalble){
			shareParams ["clientShare"] = enalble;
		}

		//iOS Only 用于启用新浪微博的api分享
		public void SetEnableSinaWeiboAPIShare(bool enalble){
			shareParams ["apiShare"] = enalble;
		}

		//iOS Only 应用内分享时使用微博高级接口 v3.6.3  v4.0.1 弃用
		public void SetEnableAdvancedInterfaceShare(bool enalble){
			shareParams ["advancedShare"] = enalble;
		}

		// iOS v4.0.8 新浪微博 分享到Story开关
		public void SetSinaShareEnableShareToStory(bool enalble){
			shareParams ["isShareToStory"] = enalble;
		}

		// iOS/Android 分享微信小程序的ID
		public void SetMiniProgramUserName(String userName){
			shareParams ["wxUserName"] = userName;
		}

        // iOS/Android 分享QQ小程序的应用id
        public void SetMiniProgramAppID(string appID){
            #if UNITY_ANDROID
                shareParams["mini_program_appid"] = appID;
            #elif UNITY_IPHONE
                shareParams["qqMiniProgramAppID"] = appID;
            #endif
        }

        // iOS/Android 微信、QQ小程序的页面路径
        public void SetMiniProgramPath(String path){
			shareParams ["wxPath"] = path;

            #if UNITY_ANDROID
                shareParams["mini_program_path"] = path;
            #elif UNITY_IPHONE
                shareParams["qqMiniProgramPath"] = path;
            #endif

        }

        // iOS/Android 微信小程序 withTicket开关
        public void SetMiniProgramWithShareTicket(bool enalble){
			shareParams ["wxWithShareTicket"] = enalble;
		}

        // iOS/Android 分享微信小程序的版本（0-正式，1-开发，2-体验），IOS 分享QQ小程序(3-正式版,1-测试版,4-预览版)
        public void SetMiniProgramType(int type){
			shareParams ["wxMiniProgramType"] = type;
            shareParams["qqMiniprogramType"] = type;  
        }


        //Android分享QQ小程序的版本 默认传入一个空的字符串就好
        public void SetQQMiniProgramType(String type) {
            shareParams["mini_program_type"] = type;
        }


        // iOS only 高清缩略图，建议长宽比是 5:4 ,6.5.9及以上版本微信客户端小程序类型分享使用 要求图片数据小于128k,QQ小程序
        public void SetMiniProgramHdThumbImage(string hdThumbImage){
			shareParams ["wxMiniProgramHdThumbImage"] = hdThumbImage;
            
            #if UNITY_ANDROID
            #elif UNITY_IPHONE
                shareParams["qqMiniProgramHdThumbImage"] = hdThumbImage;
            #endif
        }

        //IOS only
        public void SetMiniProgramWebpageUrl(string webpageUrl) {
            shareParams["qqMiniProgramWebpageUrl"] = webpageUrl;
        }

        //android only    Reddit平台板块参数
        public void SetSubreddit(string subreddit)
		{
			shareParams["sr"] = subreddit;
		}

        // 新浪微博LinkCard 分享效果参数
        public void SetSinaLinkCard(bool enable)
        {
            shareParams["sina_linkCard"] = enable;
        }
        public void SetSinaCardTitle(String title)
        {
            shareParams["sina_cardTitle"] = title;
        }
        public void SetSinaCardSummary(String summary)
        {
#if UNITY_ANDROID
			    shareParams["lc_summary"] = summary;
#elif UNITY_IPHONE
			    shareParams["sina_cardSummary"] = summary;
#endif
        }

        public void SetSinaCardImageAndroid(JsonData jsonobject)
        {
            shareParams["lc_image"] = jsonobject;
            Debug.Log("jsonobject  ==================>>> " + jsonobject);
        }
        public void SetSinaCardTypeAndroid(String type)
        {
            shareParams["lc_object_type"] = type;
        }
        public void SetSinaCardDisplayNameAndroid(String displayname)
        {
            shareParams["lc_display_name"] = displayname;
        }
        public void SetSinaCardCreateAtAndroid(String createtime)
        {
            shareParams["lc_create_at"] = createtime;
        }
        public void SetSinaCardURLAndroid(String url)
        {
            shareParams["lc_url"] = url;
        }

        /** 抖音视频9.0及其以上版本系统需要传的activity **/
        public void SetActivity(AndroidJavaObject activity) {
            shareParams["activity"] = activity;
            Debug.Log("QQQ activity  ==================>>> " + activity);
        }


        //不同平台分享不同内容
        public void SetShareContentCustomize(PlatformType platform, ShareContent content) {
			customizeShareParams [(int)platform] = content.GetShareParamsStr();
		}

		public String GetShareParamsStr() {
			if (customizeShareParams.Count > 0) {
				shareParams["customizeShareParams"] = customizeShareParams;
			}
			String jsonStr = MiniJSON.jsonEncode (shareParams);
			Debug.Log("ParseShareParams  ===>>> " + jsonStr );
			return jsonStr;
		}

		public Hashtable GetShareParams() {
			if (customizeShareParams.Count > 0) {
				shareParams["customizeShareParams"] = customizeShareParams;
			}
			String jsonStr = MiniJSON.jsonEncode (shareParams);
			Debug.Log("ParseShareParams  ===>>> " + jsonStr );
			return shareParams;
		}
	}

}

