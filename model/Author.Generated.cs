// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace KenticoKontentModels
{
    public partial class Author
    {
        public const string Codename = "author";
        public const string AvatarImageCodename = "avatar_image";
        public const string BioCodename = "bio";
        public const string EmailCodename = "email";
        public const string GithubCodename = "github";
        public const string NameCodename = "name";
        public const string RssCodename = "rss";
        public const string TelegramCodename = "telegram";
        public const string TwitterCodename = "twitter";
        public const string VkCodename = "vk";

        public IEnumerable<IAsset> AvatarImage { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Github { get; set; }
        public string Name { get; set; }
        public string Rss { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public string Telegram { get; set; }
        public string Twitter { get; set; }
        public string Vk { get; set; }
    }
}