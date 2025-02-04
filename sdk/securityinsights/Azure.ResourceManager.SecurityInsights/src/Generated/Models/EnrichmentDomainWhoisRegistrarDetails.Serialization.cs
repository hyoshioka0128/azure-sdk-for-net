// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EnrichmentDomainWhoisRegistrarDetails
    {
        internal static EnrichmentDomainWhoisRegistrarDetails DeserializeEnrichmentDomainWhoisRegistrarDetails(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> abuseContactEmail = default;
            Optional<string> abuseContactPhone = default;
            Optional<string> ianaId = default;
            Optional<Uri> url = default;
            Optional<string> whoisServer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("abuseContactEmail"))
                {
                    abuseContactEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("abuseContactPhone"))
                {
                    abuseContactPhone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ianaId"))
                {
                    ianaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("whoisServer"))
                {
                    whoisServer = property.Value.GetString();
                    continue;
                }
            }
            return new EnrichmentDomainWhoisRegistrarDetails(name.Value, abuseContactEmail.Value, abuseContactPhone.Value, ianaId.Value, url.Value, whoisServer.Value);
        }
    }
}
