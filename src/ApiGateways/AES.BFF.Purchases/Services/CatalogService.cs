﻿using AES.BFF.Purchases.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

namespace AES.BFF.Purchases.Services
{
    public interface ICatalogService { }

    public class CatalogService : Service, ICatalogService
    {
        private readonly HttpClient _httpClient;

        public CatalogService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.CatalogUrl);
        }
    }
}