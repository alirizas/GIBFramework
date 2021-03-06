﻿using GIBInterface;
using System.Collections.Generic;


namespace UyumsoftDotNetStandart
{
    public partial class EFatura : ISettings
    {
        Dictionary<string, string> _Settings;
        public Dictionary<string, string> Settings
        {
            get
            {
                if (_Settings == null)
                    return DefaultSettings();
                else
                    return _Settings;
            }
            set
            {
                _Settings = value;
            }
        }

        public Dictionary<string, string> DefaultSettings()
        {
            return new Dictionary<string, string>()
            {
                {"UserName","Kullanıcı Adını Buraya Giriniz"},
                {"Password","Şifreyi Buraya Giriniz"},
                {"Uri","https://efatura-test.uyumsoft.com.tr/services/Integration" },

                {"VergiNumarasi","Buraya Gönderimi yapan firmanın Vergi numarasını yazınız"},


            };
        }
    }
}
