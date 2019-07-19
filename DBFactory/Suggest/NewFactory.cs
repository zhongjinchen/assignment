﻿using Servise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory.Suggest
{
    internal class NewFactory
    {
        private static SuggestService _suggestService;
        static NewFactory()
        {
            _suggestService = new SuggestService();
        }
        internal static void Create()
        {
            _suggestService.Publish("标题","",RegisterFactory.ZhangSan.Id);
        }
    }
}